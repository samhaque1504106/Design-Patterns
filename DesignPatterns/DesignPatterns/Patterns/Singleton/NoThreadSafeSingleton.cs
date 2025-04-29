using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Singleton
{
    public sealed class NoThreadSafeSingleton
    {
        //The following code is not thread-safe.
        //Two different threads could both have evaluated the test(if instance == null)
        //and found it to be true, then both create instances, which violates the singleton pattern.

        private NoThreadSafeSingleton() { } //private empty parameterless constrctr

        private static NoThreadSafeSingleton instance = null; //static object reference 

        public static NoThreadSafeSingleton Instance  //static property
        {
            get
            {
                if (instance == null)
                    instance = new NoThreadSafeSingleton();
                return instance;
            }

        }

    }
}
