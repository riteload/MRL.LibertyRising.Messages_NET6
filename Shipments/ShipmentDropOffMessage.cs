using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentDropOffMessage : ShipmentLocationMessage
    {
        public string Identifier { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime PickUpDateTimeLocal { get; set; }

        [Display(Name = "Timezone")] 
        public string PickUpDateTimeZone { get; set; }

        [Display(Name = "Timezone")]
        public int? PickUpDateTimeZoneId { get; set; }

        [Display(Name = "Timezone Short Name")]
        public string PickUpDateTimeZoneShortName { get; set; }

        [Display(Name = "Drop off Date")]
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? DropOffDate { get; set; }

        [Display(Name = "Drop off Time")]
        [JsonConverter(typeof(TimeSpanJsonConverter))]
        public TimeSpan? DropOffTime { get; set; }

        [Display(Name = "Timezone")]
        public string DropOffDateTimeZone { get; set; }

        [Display(Name = "Timezone Short Name")]
        public string DropOffDateTimeZoneShortName { get; set; }

        [Display(Name = "Timezone")]
        public int? DropOffDateTimeZoneId { get; set; }

        public WarehouseMessage Warehouse { get; set; }
    }
}
