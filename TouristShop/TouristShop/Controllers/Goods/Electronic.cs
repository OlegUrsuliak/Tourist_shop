using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TouristShop.Controllers.Goods
{
    class Electronic:DbContext
    {
        public List<Models.Goods.Electronic> GetAllElectronics()
        {
            Connect();

            string allaut = "select * from [Electronics]";
            SqlDataReader dataReader = null;
            List<Models.Goods.Electronic> listElectronics = new List<Models.Goods.Electronic>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listElectronics.Add(new Models.Goods.Electronic
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        number = Convert.ToInt32(dataReader[2]),
                        mass = Convert.ToInt32(dataReader[3]),
                        price = Convert.ToInt32(dataReader[4]),
                        teg = dataReader[5].ToString(),
                        description = dataReader[6].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[7])
                    });
                }
                dataReader.Close();
                Disponse();
                return listElectronics;
            }
            throw new Exception();
        }
        public List<Models.Goods.Electronic> GetOneElectronics(int idForSearch)
        {
            Connect();

            string allaut = $"select * from [Electronics] WHERE [id] = {idForSearch}";
            SqlDataReader dataReader = null;
            List<Models.Goods.Electronic> listElectronics = new List<Models.Goods.Electronic>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listElectronics.Add(new Models.Goods.Electronic
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        number = Convert.ToInt32(dataReader[2]),
                        mass = Convert.ToInt32(dataReader[3]),
                        price = Convert.ToInt32(dataReader[4]),
                        teg = dataReader[5].ToString(),
                        description = dataReader[6].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[7])
                    });
                }
                dataReader.Close();
                Disponse();
                return listElectronics;
            }
            throw new Exception();
        }
        public bool AddElectronics(string nameNew, int numberNew, int massNew, int priceNew, string tegNew, string descriptionNew, int distributor_idNew)
        {
            Connect();
            sqlConnection.Open();
            string addElectronics = @"INSERT INTO [Electronics] ([Name],[Number],[Mass],[Price],[Teg],[Description],[Distributor id])values( " +
                "'" + nameNew + "', '" + numberNew + "', '" + massNew + "', '" + priceNew + "','" + tegNew + "', '" + descriptionNew + "', '" + distributor_idNew + "')";
            sqlCommand = new SqlCommand(addElectronics, sqlConnection);
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool EditBackpack(int idForSearch, string nameNew, int numberNew, int massNew, 
            int priceNew, string tegNew, string descriptionNew, int distributor_idNew)
        {
            sqlConnection.Open();

            string editElectronics = $"UPDATE [Electronics] " +
                $"SET [Name] = '{nameNew}', " +
                $"[Number] = {numberNew}, "+
                $"[Mass] = {massNew}, " +
                $"[Price] = {priceNew}, " +
                $"[Teg] = '{tegNew}', " +
                $"[Description] = '{descriptionNew}', " +
                $"[Distributor id] = {distributor_idNew} " +

                $"where [Id] = {idForSearch}";

            sqlCommand = new SqlCommand(editElectronics, sqlConnection);
            //MessageBox.Show(editBackpack);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteOneElectronics(int selectedId)
        {
            sqlConnection.Open();
            string delElectronics = @"DELETE FROM [Electronics] WHERE Id =" + selectedId;
            sqlCommand = new SqlCommand(delElectronics, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteAllElectronics()
        {
            Connect();
            sqlConnection.Open();
            string delElectronics = "DELETE FROM [Electronics]";
            sqlCommand = new SqlCommand(delElectronics, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                //sqlConnection.Close();
                Disponse();
                return true;
            }
            throw new Exception();
        }
    }
}
