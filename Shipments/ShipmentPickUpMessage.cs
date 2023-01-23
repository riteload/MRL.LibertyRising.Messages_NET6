using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;


namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentPickUpMessage : ShipmentLocationMessage
    {
        public string Identifier { get; set; }

        [Display(Name = "Pick Up Date")]
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? PickUpDate { get; set; }

        [Display(Name = "Pick Up Time")]
        [JsonConverter(typeof(TimeSpanJsonConverter))]
        public TimeSpan? PickUpTime { get; set; }

        [Display(Name = "Timezone")]
        public string PickUpDateTimeZone { get; set; }

        [Display(Name = "Timezone")]
        public int? PickUpDateTimeZoneId { get; set; }

        [Display(Name = "Timezone Short Name")]
        public string PickUpDateTimeZoneShortName { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? DropOffDateTimeLocal { get; set; }

        [Display(Name = "Timezone")]
        public string DropOffDateTimeZone { get; set; }

        [Display(Name = "Timezone Short Name")]
        public string DropOffDateTimeZoneShortName { get; set; }

        [Display(Name = "Timezone")]
        public int? DropOffDateTimeZoneId { get; set; }

        public WarehouseMessage Warehouse { get; set; }
    }
}
