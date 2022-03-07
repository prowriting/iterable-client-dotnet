using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Armut.Iterable.Client.Models.Base;

namespace Armut.Iterable.Client.Models.EventModels
{
    public class EventTrackInAppBaseRequest : BaseUserModel
    {
        public string MessageId { get; set; }
        public MessageContext MessageContext { get; set; }
        public DeviceInfo DeviceInfo { get; set; }
        public int CreatedAt { get; set; }
    }

    public class MessageContext
    {
        public bool SaveToInbox { get; set; }
        public bool SilentInbox { get; set; }
        public string Location { get; set; }
    }

    public class DeviceInfo
    {
        public string DeviceId { get; set; }
        public string Platform { get; set; }
        public string AppPackageName { get; set; }
    }

}
