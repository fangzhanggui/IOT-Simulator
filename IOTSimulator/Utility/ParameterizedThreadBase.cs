using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IOTSimulator.Utility
{
    public abstract class ParameterizedThreadBase:ThreadBase
    {
        protected delegate void ParameterizedThread(object parameter);

        abstract protected ParameterizedThread ThreadFunction
        {
            get;
        }

        abstract protected Object ThreadParameter
        {
            get;
        }

        public override bool Start()
        {
            return this.Start(new ParameterizedThreadStart(this.ThreadFunction), this.ThreadParameter);
        }

        protected virtual bool Start(ParameterizedThreadStart threadStart,object parameter)
        {
            this.Thread = new Thread(threadStart);
            StackTrace st = new StackTrace(false);
            this.Thread.Name = st.GetFrame(1).GetMethod().ReflectedType.FullName;
            try
            {
                this.EndEvent = new ManualResetEvent(false);
                this.Thread.Start();
            }
            catch(Exception ex)
            {
                EventLog.WriteEntry(System.Reflection.Assembly.GetExecutingAssembly().ToString(), ex.ToString(), EventLogEntryType.Warning);
                return false;
            }
            return true;
        }
    }
}
