using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TouristShop.Controllers.Goods
{
    class Tent:DbContext
    {
        public List<Models.Goods.Tent> GetAllTent()
        {
            Connect();

            string allaut = "select * from [Tent]";
            SqlDataReader dataReader = null;
            List<Models.Goods.Tent> listTent = new List<Models.Goods.Tent>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listTent.Add(new Models.Goods.Tent
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        size = Convert.ToInt32(dataReader[2]),
                        number = Convert.ToInt32(dataReader[3]),
                        mass = Convert.ToInt32(dataReader[4]),
                        price = Convert.ToInt32(dataReader[5]),
                        description = dataReader[6].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[7])

                    });

                }

                dataReader.Close();
                Disponse();
                return listTent;
            }
            throw new Exception();

        }
        public List<Models.Goods.Tent> GetOneTent(int idForSearch)
        {
            Connect();

            string allaut = $"select * from [Tent] WHERE [id] = {idForSearch}";
            SqlDataReader dataReader = null;
            List<Models.Goods.Tent> listTent = new List<Models.Goods.Tent>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listTent.Add(new Models.Goods.Tent
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        size = Convert.ToInt32(dataReader[2]),
                        number = Convert.ToInt32(dataReader[3]),
                        mass = Convert.ToInt32(dataReader[4]),
                        price = Convert.ToInt32(dataReader[5]),
                        description = dataReader[6].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[7])

                    });

                }

                dataReader.Close();
                Disponse();
                return listTent;
            }
            throw new Exception();

        }
        public bool AddTent(string nameNew, int sizeNew, int numberNew, int massNew, int priceNew, string descriptionNew, int distributor_idNew)
        {
            Connect();
            sqlConnection.Open();
            string addTent = @"INSERT INTO [Tent] ([Name],[Size],[Number],[Mass],[Price],[Description],[Distributor id])values( " +
                "'" + nameNew + "', '" + sizeNew + "', '" + numberNew + "','" + massNew + "','" + priceNew + "', '" + descriptionNew + "', '" + distributor_idNew + "')";
            sqlCommand = new SqlCommand(addTent, sqlConnection);
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool EditTent(int idForSearch, string nameNew, int sizeNew, 
            int numberNew, int massNew, int priceNew, string descriptionNew, int distributor_idNew)
        {
            sqlConnection.Open();

            string editTent = $"UPDATE [Tent] " +
                $"SET [Name] = '{nameNew}', " +
                $"[Size] = {sizeNew}, " +
                $"[Number] = {numberNew}, " +
                $"[Mass] = {massNew}, " +
                $"[Price] = {priceNew}, " +
                $"[Description] = '{descriptionNew}', " +
                $"[Distributor id] = {distributor_idNew} " +

                $"where [Id] = {idForSearch}";

            sqlCommand = new SqlCommand(editTent, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteOneTent(int selectedId)
        {
            sqlConnection.Open();
            string delTent = @"DELETE FROM [Tent] WHERE Id =" + selectedId;
            sqlCommand = new SqlCommand(delTent, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteAllTent()
        {
            sqlConnection.Open();
            string delElectronics = "DELETE FROM [Tent]";
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
