using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class NotificationMessageNode
    {
        public string NodeIdCee2728acb144e4aa5e20067929a8a1f { get; set; }
        public Guid Id { get; set; }
        public string NotificationNodeName { get; set; }
        public bool? NotificationNodeActive { get; set; }
        public Guid? NotificationUserId { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
