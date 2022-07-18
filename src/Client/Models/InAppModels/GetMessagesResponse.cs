using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armut.Iterable.Client.Models.InAppModels
{

    public class GetMessagesResponse
    {
        public InAppMessage[] InAppMessages { get; set; }
    }

    public class InAppMessage
    {
        public string MessageId { get; set; }
        public int CampaignId { get; set; }
        public long CreatedAt { get; set; }
        public long ExpiresAt { get; set; }
        public Content Content { get; set; }
        public bool SaveToInbox { get; set; }
        public InboxMetadata InboxMetadata { get; set; }
        public int PriorityLevel { get; set; }
        public bool Read { get; set; }
        public bool JsonOnly { get; set; }
    }

    public class Content
    {
        public string Html { get; set; }
    }

    public class InboxMetadata
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Icon { get; set; }
    }
}

