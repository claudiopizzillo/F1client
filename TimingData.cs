using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Client_net
{
    class TimingData
    {

        public class Steering
        {
            public List<int> pRAI { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pKUB { get; set; }
            public List<int> pGIO { get; set; }
        }

        public class GforceLat
        {
            public List<int> pRAI { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pKUB { get; set; }
            public List<int> pGIO { get; set; }
        }

        public class GforceLong
        {
            public List<int> pRAI { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pKUB { get; set; }
            public List<int> pGIO { get; set; }
        }

        public class Brake
        {
            public List<int> pRAI { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pGIO { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pKUB { get; set; }
        }

        public class Performance
        {
            public List<int> pRAI { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pSTR { get; set; }
            public List<int?> pMAG { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pKUB { get; set; }
            public List<int> pGIO { get; set; }
        }

        public class Throttle
        {
            public List<int> pRAI { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pKUB { get; set; }
            public List<int> pGIO { get; set; }
        }

        public class Graph
        {
            public Steering Steering { get; set; }
            public GforceLat GforceLat { get; set; }
            public GforceLong GforceLong { get; set; }
            public Brake Brake { get; set; }
            public Performance Performance { get; set; }
            public Throttle Throttle { get; set; }
            public List<string> TrackStatus { get; set; }
            public string xtitle { get; set; }
            public string ytitle { get; set; }
            public string ztitle { get; set; }
        }

        public class Scores
        {
            public Graph graph { get; set; }
        }

        public class Data
        {
            public List<int> pVER { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pRAI { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pGIO { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pKUB { get; set; }
            public List<int> pSAI { get; set; }
        }

        public class Graph2
        {
            public Data data { get; set; }
            public List<string> TrackStatus { get; set; }
            public string xtitle { get; set; }
            public string ytitle { get; set; }
            public string ztitle { get; set; }
        }

        public class LapPos
        {
            public Graph2 graph { get; set; }
        }

        public class Driver
        {
            public string Name { get; set; }
            public string Initials { get; set; }
            public string FullName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Color { get; set; }
            public string Team { get; set; }
            public string Num { get; set; }
        }

        public class Data2
        {
            public List<Driver> Drivers { get; set; }
        }

        public class Init
        {
            public Data2 data { get; set; }
            public int seq { get; set; }
            public long T { get; set; }
            public string TY { get; set; }
        }

        public class DR
        {
            public List<object> B { get; set; }
            public List<int?> STOP { get; set; }
        }

        public class Data3
        {
            public string F { get; set; }
            public List<DR> DR { get; set; }
        }

        public class Best
        {
            public Data3 data { get; set; }
            public int seq { get; set; }
            public long T { get; set; }
            public string TY { get; set; }
        }

        public class DR2
        {
            public List<object> O { get; set; }
            public List<string> OC { get; set; }
            public List<int?> UC { get; set; }
        }

        public class Data4
        {
            public List<DR2> DR { get; set; }
        }

        public class Opt
        {
            public Data4 data { get; set; }
            public int seq { get; set; }
            public long T { get; set; }
            public string TY { get; set; }
        }

        public class DR3
        {
            public List<object> G { get; set; }
        }

        public class Data5
        {
            public List<int> SQ { get; set; }
            public List<int> GR { get; set; }
            public int RT { get; set; }
            public List<DR3> DR { get; set; }
            public List<double> W { get; set; }
            public bool E { get; set; }
        }

        public class Sq
        {
            public Data5 data { get; set; }
            public int seq { get; set; }
            public long T { get; set; }
            public string TY { get; set; }
        }

        public class DR4
        {
            public List<object> F { get; set; }
        }

        public class Data6
        {
            public int L { get; set; }
            public int TL { get; set; }
            public string FL { get; set; }
            public string S { get; set; }
            public string R { get; set; }
            public string RL { get; set; }
            public string RC { get; set; }
            public string CL { get; set; }
            public int SL { get; set; }
            public List<DR4> DR { get; set; }
        }

        public class Free
        {
            public Data6 data { get; set; }
            public int seq { get; set; }
            public long T { get; set; }
            public string TY { get; set; }
        }

        public class Data7
        {
            public int TL { get; set; }
        }

        public class Commentary
        {
            public Data7 data { get; set; }
            public int seq { get; set; }
            public long T { get; set; }
            public string TY { get; set; }
        }

        public class DR5
        {
            public List<string> X { get; set; }
            public List<int> TI { get; set; }
        }

        public class Data8
        {
            public List<DR5> DR { get; set; }
        }

        public class Xtra
        {
            public Data8 data { get; set; }
            public int seq { get; set; }
            public long T { get; set; }
            public string TY { get; set; }
        }

        public class Data9
        {
            public List<double> pTrack { get; set; }
            public List<double> pAir { get; set; }
            public List<double> pRaining { get; set; }
            public List<double> Speed { get; set; }
            public List<double> pHumidity { get; set; }
            public List<double> pPressure { get; set; }
            public List<double> Dir { get; set; }
        }

        public class Graph3
        {
            public int norm { get; set; }
            public Data9 data { get; set; }
            public string xtitle { get; set; }
            public string ytitle { get; set; }
            public string ztitle { get; set; }
        }

       public class Weather
        {
            public Graph3 graph { get; set; }
        }

        public class SPFeed
        {
            public Scores Scores { get; set; }
            public LapPos LapPos { get; set; }
            public Init init { get; set; }
            public Best best { get; set; }
            public Opt opt { get; set; }
            public Sq sq { get; set; }
            public Free free { get; set; }
            public string prefix { get; set; }
            public string path { get; set; }
            public int timezoneOffset { get; set; }
            public bool _kf { get; set; }
            public Commentary commentary { get; set; }
            public Xtra xtra { get; set; }
            public Weather Weather { get; set; }
        }

        public class ExtrapolatedClock
        {
            public DateTime Utc { get; set; }
            public string Remaining { get; set; }
            public bool Extrapolating { get; set; }
            public bool _kf { get; set; }
        }

        public class StreamingStatus
        {
            public string Status { get; set; }
            public bool _kf { get; set; }
        }

        public class RootObject
        {
            public SPFeed SPFeed { get; set; }
            public ExtrapolatedClock ExtrapolatedClock { get; set; }
            public StreamingStatus StreamingStatus { get; set; }
        }

    }
}
