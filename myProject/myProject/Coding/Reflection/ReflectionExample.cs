using System.Reflection;

namespace myProject.Coding.Reflection
{
    public class ReflectionExample
    {
        public void ReadProperties()
        {
            Entity ent = new Entity();

            PropertyInfo[] propInfos = ent.GetType().GetProperties(BindingFlags.NonPublic|BindingFlags.Instance);
            foreach (var propInfo in propInfos)
            {
                propInfo.SetValue(ent,"dowolny string");
            }
            MethodInfo[] methodInfo = ent.GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo[] fieldInfos = ent.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var fieldInfo in fieldInfos)
            {
                fieldInfo.SetValue(ent, "coś tam");
            }

        }

       


       
    }
}
