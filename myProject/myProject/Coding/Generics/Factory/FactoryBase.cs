using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace myProject.Coding.Generics.Factory
{
    public abstract class FactoryBase<T>
    {
        protected Dictionary<string, T>listOfInstances = new Dictionary<string, T>();

        public T GetInstanse(string key)
        {
            return listOfInstances.ContainsKey(key) ? listOfInstances[key] : default(T);
        }
    }
}