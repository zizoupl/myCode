using System.Diagnostics;
using System.Threading.Tasks;

namespace myProject.Coding.TPL
{
    public class Paralism
    {
        private Randomizer random; //= new Randomizer();
        public void CreateMultiTaskSave()
        {
            TaskFactory tf = new TaskFactory();

            using (random = new Randomizer())
            {
              //  for (;;)
              Stopwatch st = new Stopwatch();
                st.Start();
                    for (int i = 0; i < 10000; i++)
                    {
                       // tf.StartNew(DelegateMethod);
                        DelegateMethod();
                    }

                st.Stop();
                var result = st.Elapsed;
                //random.Save();
            }
        }

        private void DelegateMethod()
        {
            random.Save();
        }
    }
}