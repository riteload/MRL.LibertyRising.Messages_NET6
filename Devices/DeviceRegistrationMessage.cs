namespace MRL.LibertyRising.Messages.Devices
{
    public class DeviceRegistrationMessage
    {
        public string NotificationToken { get; set; }
        public string PlatformIdentifier { get; set; }
        public string DeviceIdentifier { get; set; }
    }
}
