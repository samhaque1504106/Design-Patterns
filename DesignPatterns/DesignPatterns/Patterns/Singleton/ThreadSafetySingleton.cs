using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Singleton
{
    internal class ThreadSafetySingleton
    {
        //In the code, the thread is locked on a shared object and checks whether an instance has been created or not.
        //It takes care of the memory barrier issue and ensures that only one thread will create an instance.For example: 
        //Since only one thread can be in that part of the code at a time, by the time the second thread enters it, the first 
        //thread will have created the instance, so the expression will evaluate as false.
        //The biggest problem with this is performance; performance suffers since a lock is required every time an instance is requested.
        private ThreadSafetySingleton() { }

        private static readonly object lockObj = new object();

        private static ThreadSafetySingleton instance = null;
        public static ThreadSafetySingleton Instance
        {
            get
            {
                lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafetySingleton();
                        }
                        return instance;
                    }
            }
        }
    }
}
