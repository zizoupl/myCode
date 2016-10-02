using System.Collections.Generic;
using myProject.Coding.ExtensionMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myProject.Testing.ExtensionMethod
{   
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void Test()
        {
            "".IsPalindrome("");
            "".IamExtensive();//generyczna
            
        }

        [TestMethod]
        public void TableTest()
        {
            string[] test = new[] {""};
            test.Whatever();
            test.IamExtensive();//generyczna
        }
    }
}