using Queens_University.Exceptions;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Queens_University.DAL
{
    /// <summary>
    /// Add Sigleton DP to Create DB Connection
    /// </summary>
    public sealed class DBConnection
    {
        private static DBConnection dbInstance;


        private DBConnection()
        {

        }

        public static DBConnection GetInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new DBConnection();
            }
            return dbInstance;
        }


        public SqlConnection GetDBConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationSettings.AppSettings[Constants.CON_STRING];
                if (ConnectionState.Closed == con.State)
                    con.Open();
                return con;

            }
            catch (ConfigurationException ex)
            {
                MessageBox.Show(Constants.ERRPR_OCCURED);
                throw new ConfigurationSettingException(ex.Message);
            }
            catch (CustomizeSqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw new ConfigurationSettingException(ex.Message);
            }
        }
    }
}
