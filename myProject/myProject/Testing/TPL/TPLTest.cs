using myProject.Coding.TPL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myProject.Testing.TPL
{
    [TestClass]
    public class TPLTest
    {
        [TestMethod]
        public void Test()
        {
            Paralism pr = new Paralism();
            pr.CreateMultiTaskSave();
        }
    }
}