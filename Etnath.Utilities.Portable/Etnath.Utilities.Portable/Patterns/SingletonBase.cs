using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etnath.Utilities.Portable.Patterns
{
    /// <summary>
    /// Inherit from this class to ensure only one instance of a given class is instanciated
    /// </summary>
    /// <typeparam name="T">The class that must be a singleton</typeparam>
    public class SingletonBase<T> where T : class
    {
        /// <summary>
        /// The singleton instance. the default contructor of the class T is used to build the instance.
        /// </summary>
        private static readonly Lazy<T> _instance = new Lazy<T>(() => Activator.CreateInstance<T>());

        /// <summary>
        /// Return the singleton instance.
        /// </summary>
        public static T Instance
        {
            get { return _instance.Value; }
        }
    }
}
