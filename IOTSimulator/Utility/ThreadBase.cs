using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IOTSimulator.Utility
{
    public abstract class ThreadBase
    {
        private const Int32 THREAD_END_JOIN_TIMEOUT = 5000;

        private Thread thread = null;

        private Int32 interval = 1000;

        private ManualResetEvent threadEndEvent = null;

        public Int32 Interval
        {
            get
            {
                return this.interval;
            }
            set
            {
                this.interval = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                if(this.thread == null)
                {
                    return false;
                }
                else
                {
                    return this.thread.IsAlive;
                }
            }
        }

        protected ManualResetEvent EndEvent
        {
            get
            {
                return this.threadEndEvent;
            }
            set
            {
                this.threadEndEvent = value;
            }
        }

        protected Thread Thread
        {
            get
            {
                return thread;
            }
            set
            {
                thread = value;
            }
        }

        public virtual Boolean Start()
        {
            this.thread = new Thread(this.ThreadFunction);
            StackTrace st = new StackTrace(false);
            this.thread.Name = st.GetFrame(1).GetMethod().ReflectedType.FullName;
            try
            {
                this.EndEvent = new ManualResetEvent(false);
                this.thread.Start();
            }
            catch(Exception ex)
            {
                EventLog.WriteEntry(System.Reflection.Assembly.GetExecutingAssembly().ToString(), ex.ToString(), EventLogEntryType.Warning);
                return false;
            }
            return true;
        }

        public virtual bool EndJoin()
        {
            try
            {
                this.EndEvent.Set();
                if(!this.thread.Join(THREAD_END_JOIN_TIMEOUT))
                {
                    //
                    this.Abort();
                }
                this.thread = null;
            }
            catch(Exception ex)
            {
                EventLog.WriteEntry(System.Reflection.Assembly.GetExecutingAssembly().ToString(), ex.ToString(), EventLogEntryType.Warning);
                return false;
            }

            return true;
        }

        public virtual bool Abort()
        {
            try
            {
                this.thread.Abort();
                this.thread = null;
            }
            catch(Exception ex)
            {
                EventLog.WriteEntry(System.Reflection.Assembly.GetExecutingAssembly().ToString(), ex.ToString(), EventLogEntryType.Warning);
                return false;
            }
            return true;
        }

        protected virtual void ThreadFunction()
        {

        }
    }
}
