using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingViews.Views.Home;
using RazorGenerator.Testing;

namespace UnitTestingViews.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var view = new Index();
            Assert.IsNotNull(view.RenderAsHtml());
        }
    }
}
