using System;

namespace BalineseCalendar
{
    [Serializable]
    public class DewasaData
    {
        public int DewasaId;
        public string[] SuitableActivityList;
        public string[] UnsuitableActivityList;
        public string[] RuleNameList;
    }

    [Serializable]
    public class RawDewasaData
    {
        public int DewasaId;
        public string SuitableActivityList;
        public string UnsuitableActivityList;
        public string RuleNameList;
    }
}