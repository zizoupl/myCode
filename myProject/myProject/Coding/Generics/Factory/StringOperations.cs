using myProject.Coding.Interface;

namespace myProject.Coding.Generics.Factory
{
    public class StringOperations:FactoryBase<IStringOperations>
    {
        public StringOperations()
        {
            listOfInstances.Add("krzysiek", null);
        }
    }
}