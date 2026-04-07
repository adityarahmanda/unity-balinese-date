using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;

namespace BalineseCalendar
{
    // [CreateAssetMenu(fileName = "DewasaDatabase", menuName = "Balinese Calendar/Dewasa Database")]
    public class DewasaDatabase : ScriptableObject
    {
        [SerializeField] private List<DewasaData> dewasaDataList =  new List<DewasaData>();
        [SerializeField] private List<DewasaRule> dewasaRuleList = new List<DewasaRule>();

        private Dictionary<int, DewasaData> _dewasaDataDictionary;
        private Dictionary<string, DewasaRule> _dewasaRuleDictionary;

        public const string DewasaDatabasePath = "BalineseDate/DewasaDatabase";
        private const string DewasaJsonPath = "BalineseDate/Dewasa";
        private const string PangelongEqualsSasihName = "Pangelong Equals Sasih";
        private const string PenanggalEqualsSasihName = "Penanggal Equals Sasih";
        
        public void ReadDataFromJson()
        {
            string jsonText;
            try
            {
                var dewasaJsonAsset = Resources.Load<TextAsset>(DewasaJsonPath);
                jsonText = dewasaJsonAsset.text;
            }
            catch (Exception e)
            {
                Debug.LogError("Failed to load Dewasa JSON: " + e.Message);
                return;
            }
            
            RawDewasaData[] rawDataList;
            try
            {
                rawDataList = JsonConvert.DeserializeObject<RawDewasaData[]>(jsonText);
            }
            catch (Exception e)
            {
                Debug.LogError("Failed to parse Dewasa JSON: " + e.Message);
                return;
            }
            
            dewasaDataList = new List<DewasaData>();
            dewasaRuleList = new List<DewasaRule>();
            foreach (var rawData in rawDataList)
            {
                var data = new DewasaData()
                {
                    DewasaId = rawData.DewasaId,
                    SuitableActivityList = Utils.SplitOutsideQuotes(rawData.SuitableActivityList),
                    UnsuitableActivityList = Utils.SplitOutsideQuotes(rawData.UnsuitableActivityList),
                    RuleNameList = Utils.SplitOutsideQuotes(rawData.RuleNameList)
                };
                dewasaDataList.Add(data);
                
                foreach (var ruleName in data.RuleNameList)
                {
                    var alreadyExist = dewasaRuleList.Any(r => r.Name == ruleName);
                    if (alreadyExist) continue;
                    
                    if (ruleName == PenanggalEqualsSasihName || ruleName == PangelongEqualsSasihName)
                    {
                        dewasaRuleList.Add(new DewasaRule() { Name = ruleName });
                        continue;
                    }

                    dewasaRuleList.Add(new DewasaRule()
                    {
                        Name = ruleName,
                        Filter = ParseDewasaRuleFilterFromName(ruleName)
                    });
                }
            }
        }
        
        private Filter ParseDewasaRuleFilterFromName(string ruleName)
        {
            var filter = new Filter();
            var filterStringList = ruleName.Split(" ");
            foreach (var filterString in filterStringList)
            {
                // Check EkaWara
                foreach (var ekaWara in EkaWara.Values)
                {
                    if (ekaWara.ToString() == filterString)
                        filter.ekaWaraId = ekaWara.Id;
                }
                    
                // Check Dwiwara
                foreach (var dwiWara in DwiWara.Values)
                {
                    if (dwiWara.ToString() == filterString)
                        filter.dwikaraId = dwiWara.Id;
                }
                    
                // Check Triwara
                foreach (var triWara in TriWara.Values)
                {
                    if (triWara.ToString() == filterString)
                        filter.triWaraId = triWara.Id;
                }
                    
                // Check Caturwara
                foreach (var caturWara in CaturWara.Values)
                {
                    if (caturWara.ToString() == filterString)
                        filter.caturWaraId = caturWara.Id;
                }
                    
                // Check Pancawara
                foreach (var pancaWara in PancaWara.Values)
                {
                    if (pancaWara.ToString() == filterString)
                        filter.pancaWaraId = pancaWara.Id;
                }
                    
                // Check Sadwara
                foreach (var sadWara in SadWara.Values)
                {
                    if (sadWara.ToString() == filterString)
                        filter.sadWaraId = sadWara.Id;
                }
                    
                // Check Saptawara
                foreach (var saptaWara in SaptaWara.Values)
                {
                    if (saptaWara.ToString() == filterString)
                        filter.saptaWaraId = saptaWara.Id;
                }
                    
                // Check AstaWara
                foreach (var astaWara in AstaWara.Values)
                {
                    if (astaWara.ToString() == filterString)
                        filter.astaWaraId = astaWara.Id;
                }
                    
                // Check SangaWara
                foreach (var sangaWara in SangaWara.Values)
                {
                    if (sangaWara.ToString() == filterString)
                        filter.sangaWaraId = sangaWara.Id;
                }
                    
                // Check DasaWara
                foreach (var dasaWara in DasaWara.Values)
                {
                    if (dasaWara.ToString() == filterString) 
                        filter.dasaId = dasaWara.Id;
                }
                
                // Check Wuku
                foreach (var wuku in Wuku.Values)
                {
                    if (wuku.ToString() == filterString) 
                        filter.wukuId = wuku.Id;
                }

                // Check SasihDayInfo
                foreach (var sasihDayInfo in SasihDayInfo.Values)
                {
                    if (sasihDayInfo.ToString() == filterString) 
                        filter.sasihDayInfoId = sasihDayInfo.Id;
                }

                // Check SasihDay
                if (int.TryParse(filterString, out var sasihDay))
                {
                    filter.sasihDay = new[] { sasihDay };
                }
            }

            return filter;
        }
        
        public List<Dewasa> GetDewasa(BalineseDate balineseDate)
        {
            var result = new HashSet<Dewasa>();
            foreach (var dewasa in Dewasa.Values)
            {
                var dewasaData = GetDewasaData(dewasa);
                if (dewasaData == null) continue;

                var dewasaList = new HashSet<Dewasa>();
                foreach (var ruleName in dewasaData.RuleNameList)
                {
                    if (FilterCheckByDewasaRule(balineseDate, ruleName))
                        dewasaList.Add(dewasa);
                }

                foreach (var item in dewasaList)
                    result.Add(item);
            }
            return result.ToList();
        }

        public bool FilterCheckByDewasaRule(BalineseDate balineseDate, string ruleName)
        {
            var rule = GetDewasaRule(ruleName);
            if (rule == null) return false;

            if (rule.Name == PenanggalEqualsSasihName)
            {
                if (IsPenanggalEqualsSasih(balineseDate))
                    return true;
            } 
            else if (rule.Name == PangelongEqualsSasihName)
            {
                if (IsPangelongEqualsSasih(balineseDate))
                    return true;
            } 
            else if (Utils.FilterByDateItem(balineseDate, rule.Filter))
            {
                return true;
            }

            return false;
        }

        private bool IsPenanggalEqualsSasih(BalineseDate balineseDate)
        {
            if (balineseDate.sasihDayInfo != SasihDayInfo.PENANGGAL) return false;
            return IsSasihDayEqualsSasih(balineseDate);
        }
        
        private bool IsPangelongEqualsSasih(BalineseDate balineseDate)
        {
            if (balineseDate.sasihDayInfo != SasihDayInfo.PANGELONG) return false;
            var sasihOrder = balineseDate.sasih.RefId + 1;
            foreach (var sasihDay in balineseDate.sasihDay)
            { 
                if (sasihDay == sasihOrder)
                    return true;
            }
            return false;
        }

        private bool IsSasihDayEqualsSasih(BalineseDate balineseDate)
        {
            var sasihOrder = balineseDate.sasih.RefId + 1;
            foreach (var sasihDay in balineseDate.sasihDay)
            { 
                if (sasihDay == sasihOrder)
                    return true;
            }
            return false;
        }

        public DewasaData GetDewasaData(Dewasa dewasa)
        {
            if (_dewasaDataDictionary == null)
            {
                _dewasaDataDictionary = new Dictionary<int, DewasaData>();
                foreach (var dewasaData in dewasaDataList)
                {
                    if (_dewasaDataDictionary.ContainsKey(dewasaData.DewasaId))
                    {
                        Debug.LogWarning($"Duplicate DewasaData for DewasaId {dewasaData.DewasaId} found. Skipping.");
                        continue;
                    }
                    
                    _dewasaDataDictionary.Add(dewasaData.DewasaId, dewasaData);
                }
            }

            return _dewasaDataDictionary.GetValueOrDefault(dewasa.Id);
        }
        
        public DewasaRule GetDewasaRule(string dewasaRuleName)
        {
            if (_dewasaRuleDictionary == null)
            {
                _dewasaRuleDictionary = new Dictionary<string, DewasaRule>();
                foreach (var dewasaRule in dewasaRuleList)
                {
                    if (_dewasaRuleDictionary.ContainsKey(dewasaRule.Name))
                    {
                        Debug.LogWarning($"Duplicate DewasaData for DewasaId {dewasaRule.Name} found. Skipping.");
                        continue;
                    }
                    
                    _dewasaRuleDictionary.Add(dewasaRule.Name, dewasaRule);
                }
            }

            return _dewasaRuleDictionary.GetValueOrDefault(dewasaRuleName);
        }
    }
}
