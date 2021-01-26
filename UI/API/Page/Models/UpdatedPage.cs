using Vera.CMS.Application.Services.Page;

namespace Vera.CMS.UI.API.Page.Models
{
    public class UpdatedPage : CreatedPage, IUpdatedPage
    {
        public int Id { get; set; }
    }
}