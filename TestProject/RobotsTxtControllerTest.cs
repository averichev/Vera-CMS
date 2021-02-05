using Microsoft.AspNetCore.Mvc;
using Vera.CMS.UI.API.RobotsTxt;
using Vera.CMS.UI.API.RobotsTxt.Models;
using Xunit;

namespace TestProject
{
    public class RobotsTxtControllerTest
    {
        [Fact]
        public void UpdateAction()
        {
            var controller = new RobotsTxtController();
            var update = controller.Update();
            Assert.IsAssignableFrom<IActionResult>(update);
        }

        [Fact]
        public void FileContentTest()
        {
            const string text = "test content of file";
            var file = new FileContent
            {
                Content = text
            };
            Assert.Equal(text, file.Content);
        }
    }
}