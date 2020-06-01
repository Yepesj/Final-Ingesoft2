using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatosPizzza
{
   public class SqlBase : IDisposable
    {

        protected string connection = ConfigurationManager.AppSettings["CADENACONEXION"];
        protected SqlConnection cn;
        protected SqlTransaction tran;
        protected bool transaccionError;
        public SqlBase()
        {
            try
            {
                transaccionError = false;
                cn = new SqlConnection(connection);
                cn.Open();
                tran = cn.BeginTransaction();
            }
            catch (Exception e)
            {
                // transaccionError = true;
                throw new Exception(e.Message);
            }
        }
        public void Dispose()
        {
            if (tran != null)
            {
                if (transaccionError == true)
                {
                    tran.Rollback();
                }
                else
                {
                    tran.Commit();
                }
                tran.Dispose();
                tran = null;
            }
            if (connection != null)
            {
                cn.Close();
                cn.Dispose();
                cn = null;
            }


        }

    }
}
