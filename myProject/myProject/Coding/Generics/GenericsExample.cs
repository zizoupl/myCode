namespace myProject.Coding.Generics
{
    public class GenericsExample
    {
        public void Test()
        {
            MyList<int>listOfInt = new MyList<int>();
            MyList<string>listOfString = new MyList<string>();
            MyList<GenericsExample>listOfGenericsExample = new MyList<GenericsExample>();

            listOfInt.Add(4);
            listOfString.Add("napis");
            listOfGenericsExample.Add(new GenericsExample());
        }
    }
}