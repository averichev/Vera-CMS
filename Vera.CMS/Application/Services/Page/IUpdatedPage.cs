namespace Vera.CMS.Application.Services.Page
{
    public interface IUpdatedPage : ICreatedPage
    {
        public int Id { get; set; }
    }
}