using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace TouristShop.Controllers.Goods
{
    class Clothes:DbContext
    {
        public List<Models.Goods.Clothes> GetAllClothes()
        {
            Connect();
            string allaut = "select * from [Clothes]";
            SqlDataReader dataReader = null;
            List<Models.Goods.Clothes> listClothes = new List<Models.Goods.Clothes>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listClothes.Add(new Models.Goods.Clothes
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        sex = dataReader[2].ToString(),
                        size = dataReader[3].ToString(),
                        teg = dataReader[4].ToString(),
                        price = Convert.ToInt32(dataReader[5]),
                        number = Convert.ToInt32(dataReader[6]),
                        description = dataReader[7].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[8])
                    });
                }
                dataReader.Close();
                Disponse();
                return listClothes;
            }
            throw new Exception();
        }
        public List<Models.Goods.Clothes> GetOneClothes(int idForSearch)
        {
            Connect();
            string allaut = $"select * from [Clothes] WHERE [id] = {idForSearch}";

            SqlDataReader dataReader = null;
            List<Models.Goods.Clothes> listClothes = new List<Models.Goods.Clothes>();

            sqlConnection.Open();
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listClothes.Add(new Models.Goods.Clothes
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        sex = dataReader[2].ToString(),
                        size = dataReader[3].ToString(),
                        teg = dataReader[4].ToString(),
                        price = Convert.ToInt32(dataReader[5]),
                        number = Convert.ToInt32(dataReader[6]),
                        description = dataReader[7].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[8])
                    });
                }
                dataReader.Close();
                Disponse();
                return listClothes;
            }
            throw new Exception();
        }
        public bool AddClothes(string nameNew, string sexNew, string sizeNew, string tegNew, int priceNew, int numberNew, string descriptionNew, int distributor_idNew)
        {
            Connect();
            sqlConnection.Open();
            string addClothes = @"INSERT INTO [Clothes] ([Name],[Sex],[Size],[Teg],[Price],[Number],[Description],[Distributor id])values(" +
                "'" + nameNew + "', '" + sexNew + "', '" + sizeNew + "', '" + tegNew + "','" + priceNew + "','" + numberNew + "', '" + descriptionNew + "', '" + distributor_idNew + "')";
            sqlCommand = new SqlCommand(addClothes, sqlConnection);
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool EditClothes(int idForSearch, string nameNew, string sexNew, string sizeNew, 
            string tegNew, int priceNew, int numberNew, string descriptionNew, int distributor_idNew)
        {
            sqlConnection.Open();

            string editClothes = $"UPDATE [Clothes] " +
                $"SET [Name] = '{nameNew}', " +
                $"[Sex] = '{sexNew}', " +
                $"[Size] = {sizeNew}, " +
                $"[Teg] = '{tegNew}', " +
                $"[Price] = {priceNew}, " +
                $"[Number] = {numberNew}, " +
                $"[Description] = '{descriptionNew}', " +
                $"[Distributor id] = {distributor_idNew} " +

                $"where [Id] = {idForSearch}";

            sqlCommand = new SqlCommand(editClothes, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteOneClothes(int selectedId)
        {
            sqlConnection.Open();
            string delClothes = @"DELETE FROM [Clothes] WHERE Id =" + selectedId;
            sqlCommand = new SqlCommand(delClothes, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteAllClothes()
        {
            Connect();
            sqlConnection.Open();
            string delElectronics = "DELETE FROM [Clothes]";
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
