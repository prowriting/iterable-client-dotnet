using Newtonsoft.Json;

namespace Armut.Iterable.Client.Models.UserModels
{
    public class BulkUpdateUserRequest
    {
        public UserModel[] Users { get; set; }

        /// <summary>
        /// Whether Iterable should add fields it doesn't recognise to the project schema, for every user in the
        /// request. Left unset, the field is omitted and the project's setting applies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateNewFields { get; set; }
    }
}