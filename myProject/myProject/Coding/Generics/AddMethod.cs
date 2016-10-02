using System.Security.Cryptography.X509Certificates;

namespace myProject.Coding.Generics
{
    public class AddMethod<TListItem>: MyList<TListItem>
    {
        protected TListItem[] listItems= new TListItem[1];
        protected int Index = 0;
        public override void Add(TListItem item)
        {
            
            listItems[Index] = item;

            TListItem[] tempList = new TListItem[Index + 1];

            for (int i = 0; i < listItems.Length; i++)
            {
                tempList[i] = listItems[i];
            }
            listItems = tempList;
        }
    }
}