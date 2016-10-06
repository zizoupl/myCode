namespace myProject.Coding.Delegates
{
    public class DelegateExample //wskaźnik na funkcje
    {
        public delegate void NameOfDelegate(string candidate);

        public NameOfDelegate del; //pole przechowujące fizycznie stos delegata

        public void Test()
        {
            
        }

    }
}