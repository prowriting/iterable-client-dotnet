namespace Armut.Iterable.Client.Models.Base
{
    public abstract class BaseUserModel
    {
        public string UserId { get; set; }
        
        public string Email { get; set; }

        public bool PreferUserId { get; set; }

        public bool MergeNestedObjects { get; set; }
    }
}