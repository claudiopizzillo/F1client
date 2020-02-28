using Newtonsoft.Json;
using System;
using System.Collections;
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
            public List<int> pKUB { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pRAI { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pGIO { get; set; }
        }

        public class GforceLat
        {
            public List<int> pKUB { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pRAI { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pGIO { get; set; }
        }

        public class GforceLong
        {
            public List<int> pKUB { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pRAI { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pGIO { get; set; }
        }

        public class Brake
        {
            public List<int> pKUB { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pRAI { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pGIO { get; set; }
        }

        public class Performance
        {
            public List<int> pKUB { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pRAI { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pGIO { get; set; }
        }

        public class Throttle
        {
            public List<int> pKUB { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pRAI { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pHAM { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pBOT { get; set; }
            public List<int> pGIO { get; set; }
        }

        public class Graph
        {
            [JsonProperty("Steering")]
            public Steering Steering { get; set; }
            [JsonProperty("GforceLat")]
            public GforceLat GforceLat { get; set; }
            [JsonProperty("GforceLong")]
            public GforceLong GforceLong { get; set; }
            [JsonProperty("Brake")]
            public Brake Brake { get; set; }
            [JsonProperty("Performance")]
            public Performance Performance { get; set; }
            [JsonProperty("Throttle")]
            public Throttle Throttle { get; set; }
            [JsonProperty("TrackStatus")]
            public List<string> TrackStatus { get; set; }
            [JsonProperty("xtitle")]
            public string xtitle { get; set; }
            [JsonProperty("ytitle")]
            public string ytitle { get; set; }
            [JsonProperty("ztitle")]
            public string ztitle { get; set; }
        }

        public class Scores
        {
            [JsonProperty("graph")]
            public Graph graph { get; set; }
        }

        public class Data
        {
            public List<int> pHAM { get; set; }
            public List<int> pVER { get; set; }
            public List<int> pLEC { get; set; }
            public List<int> pVET { get; set; }
            public List<int> pALB { get; set; }
            public List<int> pNOR { get; set; }
            public List<int> pRIC { get; set; }
            public List<int> pSAI { get; set; }
            public List<int> pHUL { get; set; }
            public List<int> pPER { get; set; }
            public List<int> pGAS { get; set; }
            public List<int> pSTR { get; set; }
            public List<int> pKVY { get; set; }
            public List<int> pMAG { get; set; }
            public List<int> pGRO { get; set; }
            public List<int> pGIO { get; set; }
            public List<int> pRAI { get; set; }
            public List<int> pRUS { get; set; }
            public List<int> pKUB { get; set; }
            public List<int> pBOT { get; set; }
        }

        public class Graph2
        {
            [JsonProperty("data")]
            public Data data { get; set; }
            [JsonProperty("TrackStatus")]
            public List<string> TrackStatus { get; set; }
            [JsonProperty("xtitle")]
            public string xtitle { get; set; }
            [JsonProperty("ytitle")]
            public string ytitle { get; set; }
            [JsonProperty("ztitle")]
            public string ztitle { get; set; }
        }

        public class LapPos
        {
            [JsonProperty("graph")]
            public Graph2 graph { get; set; }
        }

        public class Driver
        {
            [JsonProperty("Name")]
            public string Name { get; set; }
            [JsonProperty("Initials")]
            public string Initials { get; set; }
            [JsonProperty("FullName")]
            public string FullName { get; set; }
            [JsonProperty("FirstName")]
            public string FirstName { get; set; }
            [JsonProperty("LastName")]
            public string LastName { get; set; }
            [JsonProperty("Color")]
            public string Color { get; set; }
            [JsonProperty("Team")]
            public string Team { get; set; }
            [JsonProperty("Num")]
            public string Num { get; set; }
        }

        public class Data2
        {
            [JsonProperty("Drivers")]
            public List<Driver> Drivers { get; set; }
        }

        public class Init
        {
            [JsonProperty("data")]
            public Data2 data { get; set; }
            [JsonProperty("seq")]
            public int seq { get; set; }
            [JsonProperty("T")]
            public long T { get; set; }
            [JsonProperty("TY")]
            public string TY { get; set; }
        }

        public class DR
        {
            [JsonProperty("B")]
            public List<object> B { get; set; }
        }

        public class Data3
        {
            [JsonProperty("F")]
            public string F { get; set; }
            [JsonProperty("DR")]
            public List<DR> DR { get; set; }
        }

        public class Best
        {
            [JsonProperty("data")]
            public Data3 data { get; set; }
            [JsonProperty("seq")]
            public int seq { get; set; }
            [JsonProperty("T")]
            public long T { get; set; }
            [JsonProperty("TY")]
            public string TY { get; set; }
        }

        public class DR2
        {
            [JsonProperty("O", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> O { get; set; }
            [JsonProperty("OC", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> OC { get; set; }
            [JsonProperty("UC", NullValueHandling = NullValueHandling.Ignore)]
            public List<int?> UC { get; set; }
        }

        public class Data4
        {
            [JsonProperty("DR")]
            public List<DR2> DR { get; set; }
        }

        public class Opt
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public Data4 data { get; set; }
            [JsonProperty("seq", NullValueHandling = NullValueHandling.Ignore)]
            public int seq { get; set; }
            [JsonProperty("t", NullValueHandling = NullValueHandling.Ignore)]
            public long T { get; set; }
            [JsonProperty("ty", NullValueHandling = NullValueHandling.Ignore)]
            public string TY { get; set; }
        }

        public class DR3
        {
            [JsonProperty("G")]
            public List<object> G { get; set; }
        }

        public class Data5
        {
            [JsonProperty("SQ")]
            public List<int> SQ { get; set; }
            [JsonProperty("GR")]
            public List<int> GR { get; set; }
            [JsonProperty("RT")]
            public int RT { get; set; }
            [JsonProperty("DR")]
            public List<DR3> DR { get; set; }
            [JsonProperty("W")]
            public List<double> W { get; set; }
            [JsonProperty("E")]
            public bool E { get; set; }
        }

        public class Sq
        {
            [JsonProperty("data")]
            public Data5 data { get; set; }
            [JsonProperty("seq")]
            public int seq { get; set; }
            [JsonProperty("T")]
            public long T { get; set; }
            [JsonProperty("TY")]
            public string TY { get; set; }
        }

        public class DR4
        {
            [JsonProperty("F")]
            public List<object> F { get; set; }
        }

        public class Data6
        {
            [JsonProperty("L")]
            public int L { get; set; }
            [JsonProperty("TL")]
            public int TL { get; set; }
            [JsonProperty("FL")]
            public string FL { get; set; }
            [JsonProperty("S")]
            public string S { get; set; }
            [JsonProperty("R")]
            public string R { get; set; }
            [JsonProperty("RL")]
            public string RL { get; set; }
            [JsonProperty("RC")]
            public string RC { get; set; }
            [JsonProperty("CL")]
            public string CL { get; set; }
            [JsonProperty("SL")]
            public int SL { get; set; }
            [JsonProperty("DR")]
            public List<DR4> DR { get; set; }
        }

        public class Free
        {
            [JsonProperty("data")]
            public Data6 data { get; set; }
            [JsonProperty("seq")]
            public int seq { get; set; }
            [JsonProperty("T")]
            public long T { get; set; }
            [JsonProperty("TY")]
            public string TY { get; set; }
        }

        public class DR5
        {
            [JsonProperty("X")]
            public List<string> X { get; set; }
            [JsonProperty("TI")]
            public List<int> TI { get; set; }
        }

        public class Data7
        {
            [JsonProperty("DR")]
            public List<DR5> DR { get; set; }
        }

        public class Xtra
        {
            [JsonProperty("data")]
            public Data7 data { get; set; }
            [JsonProperty("seq")]
            public int seq { get; set; }
            [JsonProperty("T")]
            public long T { get; set; }
            [JsonProperty("TY")]
            public string TY { get; set; }
        }

        public class Data8
        {
            [JsonProperty("TL")]
            public int TL { get; set; }
        }

        public class Commentary
        {
            [JsonProperty("data")]
            public Data8 data { get; set; }
            [JsonProperty("seq")]
            public int seq { get; set; }
            [JsonProperty("T")]
            public long T { get; set; }
            [JsonProperty("TY")]
            public string TY { get; set; }
        }

        public class Data9
        {
            [JsonProperty("pTrack")]
            public List<double> pTrack { get; set; }
            [JsonProperty("pAir")]
            public List<double> pAir { get; set; }
            [JsonProperty("pRaining")]
            public List<double> pRaining { get; set; }
            [JsonProperty("pWindSpeed")]
            public List<double> pWindSpeed { get; set; }
            [JsonProperty("pHumidity")]
            public List<double> pHumidity { get; set; }
            [JsonProperty("pPressure")]
            public List<double> pPressure { get; set; }
            [JsonProperty("pWindDir")]
            public List<double> pWindDir { get; set; }
        }

        public class Graph3
        {
            [JsonProperty("norm")]
            public int norm { get; set; }
            [JsonProperty("data")]
            public Data9 data { get; set; }
            [JsonProperty("xtitle")]
            public string xtitle { get; set; }
            [JsonProperty("ytitle")]
            public string ytitle { get; set; }
            [JsonProperty("ztitle")]
            public string ztitle { get; set; }
        }

        public class Weather
        {
            [JsonProperty("graph")]
            public Graph3 graph { get; set; }
        }

        public class SPFeed
        {
            [JsonProperty("Scores")]
            public Scores Scores { get; set; }
            [JsonProperty("LapPos")]
            public LapPos LapPos { get; set; }
            [JsonProperty("init")]
            public Init init { get; set; }
            [JsonProperty("best")]
            public Best best { get; set; }
            [JsonProperty("opt")]
            public Opt opt { get; set; }
            [JsonProperty("sq")]
            public Sq sq { get; set; }
            [JsonProperty("free")]
            public Free free { get; set; }
            [JsonProperty("prefix")]
            public string prefix { get; set; }
            [JsonProperty("path")]
            public string path { get; set; }
            [JsonProperty("timezoneOffset")]
            public int timezoneOffset { get; set; }
            [JsonProperty("_kf")]
            public bool _kf { get; set; }
            [JsonProperty("xtra")]
            public Xtra xtra { get; set; }
            [JsonProperty("commentary")]
            public Commentary commentary { get; set; }
            [JsonProperty("Weather")]
            public Weather Weather { get; set; }
        }

        public class ExtrapolatedClock
        {
            [JsonProperty("Utc")]
            public DateTime Utc { get; set; }
            [JsonProperty("Remaining")]
            public string Remaining { get; set; }
            [JsonProperty("Extrapolating")]
            public bool Extrapolating { get; set; }
            [JsonProperty("_kf")]
            public bool _kf { get; set; }
        }

        public class StreamingStatus
        {
            [JsonProperty("Status")]
            public string Status { get; set; }
            [JsonProperty("_kf")]
            public bool _kf { get; set; }
        }

        public class RootObject
        {
            [JsonProperty("SPFeed")]
            public SPFeed SPFeed { get; set; }
            [JsonProperty("ExtrapolatedClock")]
            public ExtrapolatedClock ExtrapolatedClock { get; set; }
            [JsonProperty("StreamingStatus")]
            public StreamingStatus StreamingStatus { get; set; }
        }
    }

}
