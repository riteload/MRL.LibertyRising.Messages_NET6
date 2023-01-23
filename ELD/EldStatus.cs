using System;

namespace MRL.LibertyRising.Messages.ELDStatus
{
    public class EldStatus
    {
        public DateTime eventAt { get; set; }
        public Company company { get; set; }
        public GPS GPS { get; set; }
        public Device device { get; set; }
        public User user { get; set; }
        public Status status { get; set; }
    }

    public class Company
    {
        public Parent parent { get; set; }
        public string country { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public string customerNumber { get; set; }
        public string locale { get; set; }
        public int version { get; set; }
        public string statisticsTz { get; set; }
        public string slug { get; set; }
        public string status { get; set; }
    }

    public class Parent
    {
        public int id { get; set; }
    }

    public class GPS
    {
        public bool valid { get; set; }
        public long At { get; set; }
        public int Lng { get; set; }
        public int Spd { get; set; }
        public int Alt { get; set; }
        public int Dir { get; set; }
        public int NSat { get; set; }
        public int HDOP { get; set; }
        public int Lat { get; set; }
    }

    public class Device
    {
        public string serialNumber { get; set; }
        public string externalId { get; set; }
        public Type type { get; set; }
        public int version { get; set; }
        public string operatingSystem { get; set; }
        public int companyId { get; set; }
        public string phone { get; set; }
        public string sim { get; set; }
        public string name { get; set; }
        public string imei { get; set; }
        public Company1 company { get; set; }
        public Model model { get; set; }
        public int id { get; set; }
        public string firmwareVersion { get; set; }
        public string softwareVersion { get; set; }
        public string status { get; set; }
    }

    public class Type
    {
        public int id { get; set; }
    }

    public class Company1
    {
        public object[] features { get; set; }
        public int id { get; set; }
    }

    public class Model
    {
        public int id { get; set; }
    }

    public class User
    {
        public string lastName { get; set; }
        public bool hasSentinel { get; set; }
        public string licenceNumber { get; set; }
        public string mobile { get; set; }
        public string timeZone { get; set; }
        public Type1 type { get; set; }
        public int version { get; set; }
        public string externalPin { get; set; }
        public string externalReference { get; set; }
        public string firstName { get; set; }
        public string licenceState { get; set; }
        public int companyId { get; set; }
        public Company2 company { get; set; }
        public int id { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string status { get; set; }
    }

    public class Type1
    {
        public int id { get; set; }
    }

    public class Company2
    {
        public object[] features { get; set; }
        public int id { get; set; }
    }

    public class Status
    {
        public Laststatusevent lastStatusEvent { get; set; }
        public Lastrelevantevent lastRelevantEvent { get; set; }
        public string advice { get; set; }
        public Ruleset ruleset { get; set; }
        public float cpu { get; set; }
        public bool hasViolations { get; set; }
        public long predictionBaseAt { get; set; }
        public Totals totals { get; set; }
        public Shorthaul shorthaul { get; set; }
        public long periodFinishAt { get; set; }
        public Bigday bigDay { get; set; }
        public long periodStartAt { get; set; }
        public Nextviolation nextViolation { get; set; }
        public Work24 work24 { get; set; }
        public long checkpointAt { get; set; }
        public Drive8 drive8 { get; set; }
        public string driver { get; set; }
        public Today today { get; set; }
        public Lastevent lastEvent { get; set; }
        public Drive24 drive24 { get; set; }
        public int time { get; set; }
        public long reportStartAt { get; set; }
        public long reportFinishAt { get; set; }
        public long pivotTimeAt { get; set; }
    }

    public class Laststatusevent
    {
        public string action { get; set; }
        public int id { get; set; }
        public string type { get; set; }
        public long timeAt { get; set; }
    }

    public class Lastrelevantevent
    {
        public string action { get; set; }
        public int id { get; set; }
        public string type { get; set; }
        public long timeAt { get; set; }
    }

    public class Ruleset
    {
        public int period { get; set; }
        public string name { get; set; }
        public Options options { get; set; }
        public string region { get; set; }
        public int minRest { get; set; }
        public string desc { get; set; }
    }

    public class Options
    {
        public string hidenights { get; set; }
        public string mergeenabled { get; set; }
        public string rulesetradiuskm { get; set; }
        public string eldregistration { get; set; }
        public string locationrequired { get; set; }
        public string eldmanufacturer { get; set; }
        public string editenabled { get; set; }
        public string editvehicle { get; set; }
        public string editregistration { get; set; }
        public string editodometer { get; set; }
        public string eldid { get; set; }
        public object rulesetheterogenousmapping { get; set; }
        public object rulesetbigdaypossible { get; set; }
        public string editnotes { get; set; }
        public string eventactions { get; set; }
        public string editlocation { get; set; }
        public object rulesetuseslocation { get; set; }
    }

    public class Totals
    {
        public float rest { get; set; }
        public float startLatitude { get; set; }
        public int worked { get; set; }
        public Period period { get; set; }
        public int work { get; set; }
        public int available { get; set; }
        public float startLongitude { get; set; }
        public float rested { get; set; }
        public int remaining { get; set; }
        public bool isWorking { get; set; }
    }

    public class Period
    {
        public string type { get; set; }
        public long startAt { get; set; }
        public long finishAt { get; set; }
    }

    public class Shorthaul
    {
        public bool exemptionApplies { get; set; }
    }

    public class Bigday
    {
        public bool qualified { get; set; }
        public Period1 period { get; set; }
        public bool inUse { get; set; }
    }

    public class Period1
    {
        public string type { get; set; }
        public long startAt { get; set; }
        public long finishAt { get; set; }
    }

    public class Nextviolation
    {
        public Period2 period { get; set; }
        public bool isQuantum { get; set; }
        public string type2 { get; set; }
        public Rule rule { get; set; }
        public string detail { get; set; }
        public string type { get; set; }
        public long startAt { get; set; }
        public long finishAt { get; set; }
    }

    public class Period2
    {
        public long start { get; set; }
        public long finish { get; set; }
        public string type { get; set; }
    }

    public class Rule
    {
        public string description { get; set; }
        public string section { get; set; }
        public string id { get; set; }
    }

    public class Work24
    {
        public int startLatitude { get; set; }
        public Period3 period { get; set; }
        public int work { get; set; }
        public int available { get; set; }
        public float startLongitude { get; set; }
        public int remaining { get; set; }
        public bool isWorking { get; set; }
    }

    public class Period3
    {
        public string type { get; set; }
        public long startAt { get; set; }
        public long finishAt { get; set; }
    }

    public class Drive8
    {
        public int startLatitude { get; set; }
        public Period4 period { get; set; }
        public int work { get; set; }
        public int available { get; set; }
        public int startLongitude { get; set; }
        public int remaining { get; set; }
        public bool isWorking { get; set; }
    }

    public class Period4
    {
        public string type { get; set; }
        public long startAt { get; set; }
        public long finishAt { get; set; }
    }

    public class Today
    {
        public int driving { get; set; }
        public long checkTime { get; set; }
        public float offDuty { get; set; }
        public int drivingAvail { get; set; }
        public string timezone { get; set; }
        public long resetTime { get; set; }
        public int onDuty { get; set; }
        public int onDutyAvail { get; set; }
        public int sleeping { get; set; }
    }

    public class Lastevent
    {
        public string commodity { get; set; }
        public string shipper { get; set; }
        public string notes { get; set; }
        public int deviceSequenceNumber { get; set; }
        public string trailer1Id { get; set; }
        public object trailer2Id { get; set; }
        public string source { get; set; }
        public GPS1 GPS { get; set; }
        public string type { get; set; }
        public long timeAt { get; set; }
        public string uuid { get; set; }
        public Vehicle vehicle { get; set; }
        public string declaredOdometer { get; set; }
        public string declaredLocation { get; set; }
        public Company3 company { get; set; }
        public int id { get; set; }
        public int odometer { get; set; }
        public string manifest { get; set; }
        public string timeZone { get; set; }
        public string _params { get; set; }
        public int version { get; set; }
        public string declaredRegistration { get; set; }
        public string location { get; set; }
        public Device1 device { get; set; }
        public User1 user { get; set; }
        public string mappedAction { get; set; }
        public string status { get; set; }
    }

    public class GPS1
    {
        public bool valid { get; set; }
        public float Lng { get; set; }
        public float Lat { get; set; }
    }

    public class Vehicle
    {
        public int id { get; set; }
        public int version { get; set; }
    }

    public class Company3
    {
        public int id { get; set; }
        public int version { get; set; }
    }

    public class Device1
    {
        public int id { get; set; }
        public int version { get; set; }
    }

    public class User1
    {
        public int id { get; set; }
        public int version { get; set; }
    }

    public class Drive24
    {
        public int startLatitude { get; set; }
        public Period5 period { get; set; }
        public int work { get; set; }
        public int available { get; set; }
        public int startLongitude { get; set; }
        public int remaining { get; set; }
        public bool isWorking { get; set; }
    }

    public class Period5
    {
        public string type { get; set; }
        public long startAt { get; set; }
        public long finishAt { get; set; }
    }

}

