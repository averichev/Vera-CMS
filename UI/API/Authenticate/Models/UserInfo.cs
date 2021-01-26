namespace Vera.CMS.UI.API.Authenticate.Models
{
    public class UserInfo
    {
        public UserInfo(string id, string userName)
        {
            Id = id;
            UserName = userName;
        }

        public string UserName { get; set; }
        public string Id { get; set; }
    }
}