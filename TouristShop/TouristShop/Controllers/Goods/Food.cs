using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TouristShop.Controllers.Goods
{
    class Food:DbContext
    {
        public List<Models.Goods.Food> GetAllFood()
        {
            Connect();

            string allaut = "select * from [Food]";
            SqlDataReader dataReader = null;
            List<Models.Goods.Food> listFood = new List<Models.Goods.Food>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listFood.Add(new Models.Goods.Food
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
                return listFood;
            }
            throw new Exception();
        }
        public List<Models.Goods.Food> GetOneFood(int idForSearch)
        {
            Connect();

            string allaut = $"select * from [Food] WHERE [id] = {idForSearch}";
            SqlDataReader dataReader = null;
            List<Models.Goods.Food> listFood = new List<Models.Goods.Food>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listFood.Add(new Models.Goods.Food
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
                return listFood;
            }
            throw new Exception();
        }
        public bool AddFood(string nameNew, int numberNew, int massNew, int priceNew, string tegNew, string descriptionNew, int distributor_idNew)
        {
            Connect();
            sqlConnection.Open();
            string addDistributor = @"INSERT INTO [Food] ([Name],[Number],[Mass],[Price],[Teg],[Description],[Distributor id])values( " +
                "'" + nameNew + "', '" + numberNew + "', '" + massNew + "', '" + priceNew + "', '" + tegNew + "', '" + descriptionNew + "', '" + distributor_idNew + "')";
            sqlCommand = new SqlCommand(addDistributor, sqlConnection);
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool EditFood(int idForSearch, string nameNew, int numberNew, int massNew, 
            int priceNew, string tegNew, string descriptionNew, int distributor_idNew)
        {
            sqlConnection.Open();

            string editBackpack = $"UPDATE [Food] " +
                $"SET [Name] = '{nameNew}', " +
                $"[Number] = {numberNew}, " +
                 $"[Mass] = {massNew}, " +
                $"[Price] = {priceNew}, " +
                $"[Teg] = '{tegNew}', " +
                $"[Description] = '{descriptionNew}', " +
                $"[Distributor id] = {distributor_idNew} " +

                $"where [Id] = {idForSearch}";

            sqlCommand = new SqlCommand(editBackpack, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteOneFood(int selectedId)
        {
            sqlConnection.Open();
            string delFood = @"DELETE FROM [Food] WHERE Id =" + selectedId;
            sqlCommand = new SqlCommand(delFood, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteAllFood()
        {
            Connect();
            sqlConnection.Open();
            string delFood = "DELETE FROM [Food]";
            sqlCommand = new SqlCommand(delFood, sqlConnection);

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
