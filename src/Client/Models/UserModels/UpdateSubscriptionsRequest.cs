using Armut.Iterable.Client.Models.Base;

namespace Armut.Iterable.Client.Models.UserModels
{

    public class UpdateSubscriptionsRequest: BaseUserModel
    {
        public int[] EmailListIds { get; set; }
        public int[] UnsubscribedChannelIds { get; set; }
        public int[] UnsubscribedMessageTypeIds { get; set; }
        public int[] SubscribedMessageTypeIds { get; set; }
        public int? CampaignId { get; set; }
        public int? TemplateId { get; set; }
    }

}