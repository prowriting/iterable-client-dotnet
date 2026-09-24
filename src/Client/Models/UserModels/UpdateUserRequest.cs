using Newtonsoft.Json;

namespace Armut.Iterable.Client.Models.UserModels
{
    public class UpdateUserRequest : UserModel
    {
        public bool MergeNestedObjects { get; set; }

        /// <summary>
        /// Whether Iterable should add fields it doesn't recognise to the project schema. Left unset, the field is
        /// omitted and the project's setting applies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateNewFields { get; set; }
    }

}