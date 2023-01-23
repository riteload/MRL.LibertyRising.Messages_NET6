using System;


namespace MRL.LibertyRising.Messages.ELD
{
    public class EldData
    {
        public Result result { get; set; }
        public DateTime eventAt { get; set; }
        public GPS GPS { get; set; }
        public Device device { get; set; }
        public User user { get; set; }
        public long when { get; set; }
        public string ignition { get; set; }
        public Vehicle vehicle { get; set; }
    }

    public class Result
    {
        public Location2 location2 { get; set; }
        public string location { get; set; }
        public long id { get; set; }
        public string networks { get; set; }
    }

    public class Location2
    {
        public string city { get; set; }
        public string state { get; set; }
        public string bumber { get; set; }
        public string street { get; set; }
        public string suburb { get; set; }
        public string country { get; set; }
        public string rooftop { get; set; }
        public string postcode { get; set; }
    }

    public class GPS
    {
        public bool valid { get; set; }
        public float Lng { get; set; }
        public int Spd { get; set; }
        public float Alt { get; set; }
        public int Dir { get; set; }
        public int NSat { get; set; }
        public int HDOP { get; set; }
        public float Lat { get; set; }
    }

    public class Device
    {
        public int companyId { get; set; }
        public string serialNumber { get; set; }
        public string releaseVersion { get; set; }
        public string name { get; set; }
        public string imei { get; set; }
        public Company company { get; set; }
        public Model model { get; set; }
        public int id { get; set; }
        public Type type { get; set; }
        public int version { get; set; }
    }

    public class Company
    {
        public object[] features { get; set; }
        public int id { get; set; }
    }

    public class Model
    {
        public int id { get; set; }
    }

    public class Type
    {
        public int id { get; set; }
    }

    public class User
    {
        public string lastName { get; set; }
        public bool hasSentinel { get; set; }
        public string licenceNumber { get; set; }
        public string Mobile { get; set; }
        public string timeZone { get; set; }
        public Type1 type { get; set; }
        public int version { get; set; }
        public string firstName { get; set; }
        public string licenceState { get; set; }
        public int companyId { get; set; }
        public Company1 company { get; set; }
        public int id { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string status { get; set; }
    }

    public class Type1
    {
        public int id { get; set; }
    }

    public class Company1
    {
        public object[] features { get; set; }
        public int id { get; set; }
    }

    public class Vehicle
    {
        public string engineNumber { get; set; }
        public string externalId { get; set; }
        public Type2 type { get; set; }
        public int version { get; set; }
        public int companyId { get; set; }
        public string name { get; set; }
        public Company2 company { get; set; }
        public string registration { get; set; }
        public string VIN { get; set; }
        public string model { get; set; }
        public int id { get; set; }
        public string registrationState { get; set; }
        public string make { get; set; }
        public string status { get; set; }
    }

    public class Type2
    {
        public int id { get; set; }
    }

    public class Company2
    {
        public object[] features { get; set; }
        public int id { get; set; }
    }

}
