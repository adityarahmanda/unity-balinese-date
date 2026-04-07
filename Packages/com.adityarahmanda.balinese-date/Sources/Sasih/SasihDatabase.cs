using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace BalineseCalendar
{
    // [CreateAssetMenu(fileName = "SasihDatabase", menuName = "Balinese Calendar/Sasih Database")]
    public class SasihDatabase : ScriptableObject
    {
        public const string SasihDatabasePath = "BalineseDate/SasihDatabase";
        private const string SasihJsonPath = "BalineseDate/Sasih";
        
        [SerializeField] private List<SasihData> sasihDataList =  new List<SasihData>();

        private Dictionary<int, SasihData> _sasihDataDictionary;
        
        public void ReadDataFromJson()
        {
            string jsonText;
            try
            {
                var dewasaJsonAsset = Resources.Load<TextAsset>(SasihJsonPath);
                jsonText = dewasaJsonAsset.text;
            }
            catch (Exception e)
            {
                Debug.LogError("Failed to load Dewasa JSON: " + e.Message);
                return;
            }
            
            RawSasihData[] rawDataList;
            try
            {
                rawDataList = JsonConvert.DeserializeObject<RawSasihData[]>(jsonText);
            }
            catch (Exception e)
            {
                Debug.LogError("Failed to parse Dewasa JSON: " + e.Message);
                return;
            }
            
            sasihDataList = new List<SasihData>();
            foreach (var rawData in rawDataList)
            {
                var data = new SasihData()
                {
                    SasihId = rawData.SasihId,
                    SuitableActivityList = Utils.SplitOutsideQuotes(rawData.SuitableActivityList),
                    UnsuitableActivityList = Utils.SplitOutsideQuotes(rawData.UnsuitableActivityList),
                };
                sasihDataList.Add(data);
            }
        }
        
        public SasihData GetSasihData(Sasih sasih)
        {
            if (_sasihDataDictionary == null)
            {
                _sasihDataDictionary = new Dictionary<int, SasihData>();
                foreach (var sasihData in sasihDataList)
                {
                    if (_sasihDataDictionary.ContainsKey(sasihData.SasihId))
                    {
                        Debug.LogWarning($"Duplicate DewasaData for DewasaId {sasihData.SasihId} found. Skipping.");
                        continue;
                    }
                    
                    _sasihDataDictionary.Add(sasihData.SasihId, sasihData);
                }
            }

            return _sasihDataDictionary.GetValueOrDefault(sasih.Id);
        }
    }
}