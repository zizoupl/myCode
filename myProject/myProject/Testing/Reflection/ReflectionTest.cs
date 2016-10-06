using myProject.Coding.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myProject.Testing.Reflection
{
    [TestClass]
    public class ReflectionTest
    {
        [TestMethod]
        public void Test()
        {
            ReflectionExample example = new ReflectionExample();

            example.ReadProperties();
  
        }
    }
}