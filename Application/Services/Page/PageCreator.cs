namespace Vera.CMS.Application.Services.Page
{
    public class PageCreator
    {
        private readonly ICreatedPage _createdPage;

        public PageCreator(ICreatedPage createdPage)
        {
            _createdPage = createdPage;
        }
        
        public Infrastructure.Database.Entity.Page Create()
        {
            return new()
            {
                Content = _createdPage.Content,
                Header = _createdPage.Header
            };
        }
    }
}