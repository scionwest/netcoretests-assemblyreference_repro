using ApiApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new ValuesController();

            var results = controller.Get();
        }
    }
}
