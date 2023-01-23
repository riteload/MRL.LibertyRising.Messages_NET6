namespace MRL.LibertyRising.Messages.Preferences
{
    public class NotificationSettingMessage
    {
        public int NotificationTypeId { get; set; }
        public string NotificationType { get; set; }
        public string Title { get; set; }
        public bool? On { get; set; }
        public bool? Email { get; set; }
        public bool? Sms { get; set; }
    }
}
