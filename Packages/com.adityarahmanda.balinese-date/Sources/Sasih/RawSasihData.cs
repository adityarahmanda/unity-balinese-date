using System;

namespace BalineseCalendar
{
    [Serializable]
    public class SasihData
    {
        public int SasihId;
        public string[] SuitableActivityList;
        public string[] UnsuitableActivityList;
    }
    
    [Serializable]
    public class RawSasihData
    {
        public int SasihId;
        public string SuitableActivityList;
        public string UnsuitableActivityList;
    }
}