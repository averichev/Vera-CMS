namespace Vera.CMS.Application.Services.Page
{
    public class PageCreator
    {
        private readonly Infrastructure.Database.Entity.Page _page;

        public PageCreator(ICreatedPage createdPage)
        {
            _page = new Infrastructure.Database.Entity.Page
            {
                Content = createdPage.Content,
                Header = createdPage.Header
            };
        }
        
        public PageCreator(IUpdatedPage updatedPage)
        {
            _page = new Infrastructure.Database.Entity.Page
            {
                Content = updatedPage.Content,
                Header = updatedPage.Header,
                Id = updatedPage.Id
            };
        }
        
        public Infrastructure.Database.Entity.Page Get()
        {
            return _page;
        }
    }
}