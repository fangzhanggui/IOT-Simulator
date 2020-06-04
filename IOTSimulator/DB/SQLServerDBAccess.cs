using IOTSimulator.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IOTSimulator.DB
{
    class SQLServerDBAccess:ParameterizedThreadBase
    {
        #region 私有变量
        static private String m_connectionString = "";

        static private SqlConnection m_sqlConnection = null;

        private SqlCommand m_sqlCommand = null;
        #endregion

        public SQLServerDBAccess()
        {
        }

        protected override ParameterizedThread ThreadFunction => throw new NotImplementedException();

        protected override object ThreadParameter => throw new NotImplementedException();

        public bool InitialDBInstance(String dbInstanceName,String dbName,Int32 interval,Int32 timeout,String uid,String dbFilePath)
        {
            bool sqlServerAlive = false; 

            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = dbInstanceName;
            sqlConnectionStringBuilder.InitialCatalog = dbName;
            sqlConnectionStringBuilder.ConnectTimeout = interval;
            sqlConnectionStringBuilder.IntegratedSecurity = true;   //Windows认证

            if(File.Exists(dbFilePath))
            {
                sqlConnectionStringBuilder.AttachDBFilename = dbFilePath;
                Microsoft.SqlServer.Management.Smo.Server server = null;
                bool retry = true;
                Int32 SQLSERVER_CONNECT_RETRY_COUNT = 10;
                Int32 SQLSERVER_CONNECT_RETRY_INTERVAL = 1000;
                Int32 connectTryCount = 0;
                while(retry)
                {
                    connectTryCount++;
                    try
                    {
                        server = new Microsoft.SqlServer.Management.Smo.Server(dbInstanceName);
                        retry = false;
                        sqlServerAlive = server.Databases.Contains(dbName);
                    }
                    catch(Exception ex)
                    {
                        retry = connectTryCount <= SQLSERVER_CONNECT_RETRY_COUNT;
                        Thread.Sleep(SQLSERVER_CONNECT_RETRY_INTERVAL);
                        //日志
                    }
                }

                if(sqlServerAlive)
                {
                    try
                    {
                        server.DetachDatabase(dbName, false);
                    }
                    catch(Exception ex)
                    {
                        //日志
                    }
                }

            }
            else
            {
                //
            }

            this.m_connectionString = sqlConnectionStringBuilder.ConnectionString;
            return sqlServerAlive;
        }

        public void open()
        {

        }
    }
}
