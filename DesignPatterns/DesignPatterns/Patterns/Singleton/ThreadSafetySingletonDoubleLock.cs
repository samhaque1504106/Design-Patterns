using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Singleton
{
    internal class ThreadSafetySingletonDoubleLock
    {
        ThreadSafetySingletonDoubleLock() { }
        private static readonly object lockObj = new object ();

        private static ThreadSafetySingletonDoubleLock instance = null;

        public static ThreadSafetySingletonDoubleLock Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                        {
                            if (instance == null)
                            {
                                instance = new ThreadSafetySingletonDoubleLock();
                            }
                        }
                }
                return instance;
            }
        }
    }
}
