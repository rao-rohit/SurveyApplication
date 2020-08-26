using System;
using System.Collections.Generic;
using System.Text;

namespace CSAdoDotNetDAL.Base
{
    class AdoDotNetBase
    {
        public abstract class ADODotNetBase<T> : CSDALBase.DALBase<T>
           where T : class
        {
            //SQL objects
            SqlConnection con;
            protected SqlCommand cmd;

            //Passing Connection string to base class (DALBase)
            public ADODotNetBase(string ConnectionString) : base(ConnectionString)
            {

            }

            //Run Operation : Calling Fixed Sequence
            public void ExecuteSave(T Entity)
            {
                Open();

                Save(Entity);

                Close();
            }

            public T ExecuteGet(T Entity)
            {
                Open();

                T output = GetFirst(Entity);

                Close();

                return output;
            }


            //Step 1. Open Db connection and set command object
            private void Open()
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
            }

            ///Step 2 : Execute Method will be overrided in child classes. But child classes cannot change the sequence.
            ///So, we have a fix sequence and child classes will define how the individual step will work. This is called teamplate pattern.
            ////// <summary>
            /// Execute method.
            /// </summary>
            public abstract void Save(T Entity);

            public abstract T GetFirst(T Entity);

            //Step 3 Closing Connection
            void Close()
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }

            /// <summary>
            /// Save method to commit final data in DB.
            /// </summary>
            public override void Save()
            {
                foreach (T entity in lstNewDirtyData)
                {
                    ExecuteSave(entity);
                }
            }


            public override T Get(T Entity)
            {
                return ExecuteGet(Entity);
            }




        }
    }