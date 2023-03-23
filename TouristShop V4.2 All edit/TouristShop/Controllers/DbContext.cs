using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections.Generic;
using System.Data.SqlClient;

namespace TouristShop.Controllers
{
    public class DbContext
    {
        public string conectionString;
        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;

        //public DbContext(){
        //    conectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbTouristShop; Integrated Security=True;Connect Timeout=30;";
        //    sqlConnection = new SqlConnection(conectionString);
        //}
        public void Connect()
        {
            conectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbTouristShop; Integrated Security=True;Connect Timeout=30;";
            sqlConnection = new SqlConnection(conectionString);
        }

        //Відключення від серверу
        public void Disponse(){
            sqlConnection.Close();
        }
    }
}
