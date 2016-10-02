using myProject.Coding.Generics.Factory;

namespace myProject.Testing.GenericsTest
{
    public class GenericsTest
    {
        public void Test()
        {
            StringOperations factory = new StringOperations();
            factory.GetInstanse("Krzysiek").GetName();
        }
    }
}