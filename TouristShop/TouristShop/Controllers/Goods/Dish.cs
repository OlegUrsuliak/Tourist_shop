using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace TouristShop.Controllers.Goods
{
    class Dish : DbContext
    {
        public List<Models.Goods.Dish> GetAllDish()
        {
            Connect();

            string allaut = "select * from [Dishes]";
            SqlDataReader dataReader = null;
            List<Models.Goods.Dish> listDishes = new List<Models.Goods.Dish>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listDishes.Add(new Models.Goods.Dish
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        price = Convert.ToInt32(dataReader[2]),
                        mass = Convert.ToInt32(dataReader[3]),
                        number = Convert.ToInt32(dataReader[4]),
                        teg = dataReader[5].ToString(),
                        description = dataReader[6].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[7])
                    });
                }
                dataReader.Close();
                Disponse();
                return listDishes;
            }
            throw new Exception();
        }
        public List<Models.Goods.Dish> GetOneDish(int idForSearch)
        {
            Connect();

            string allaut = $"select * from [Dishes] WHERE [id] = {idForSearch}";
            SqlDataReader dataReader = null;
            List<Models.Goods.Dish> listDishes = new List<Models.Goods.Dish>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listDishes.Add(new Models.Goods.Dish
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        price = Convert.ToInt32(dataReader[2]),
                        mass = Convert.ToInt32(dataReader[3]),
                        number = Convert.ToInt32(dataReader[4]),
                        teg = dataReader[5].ToString(),
                        description = dataReader[6].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[7])
                    });
                }
                dataReader.Close();
                Disponse();
                return listDishes;
            }
            throw new Exception();
        }
        public bool AddDish(string nameNew, int priceNew, int massNew, int numberNew, string tegNew, string descriptionNew, int distributor_idNew)
        {
            Connect();
            sqlConnection.Open();
            string addDishes = @"INSERT INTO [Dishes] ([Name],[Price],[Mass],[Number],[Teg],[Description],[Distributor id])values( " +
                "'" + nameNew + "', '" + priceNew + "', '" + massNew + "', '" + numberNew + "','" + tegNew + "', '" + descriptionNew + "', '" + distributor_idNew + "')";
            sqlCommand = new SqlCommand(addDishes, sqlConnection);
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool EditDish(int idForSearch, string nameNew, int priceNew, int massNew, 
            int numberNew, string tegNew, string descriptionNew, int distributor_idNew)
        {
            sqlConnection.Open();

            string editDish = $"UPDATE [Dishes] " +
                $"SET [Name] = '{nameNew}', " +
                $"[Price] = {priceNew}, " +
                $"[Mass] = {massNew}, " +
                $"[Number] = {numberNew}, " +
                $"[Teg] = '{tegNew}', " +
                $"[Description] = '{descriptionNew}', " +
                $"[Distributor id] = {distributor_idNew} " +

                $"where [Id] = {idForSearch}";

            sqlCommand = new SqlCommand(editDish, sqlConnection);
            //MessageBox.Show(editBackpack);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteOneDishes(int selectedId)
        {
            sqlConnection.Open();
            string delDishes = @"DELETE FROM [Dishes] WHERE Id =" + selectedId;
            sqlCommand = new SqlCommand(delDishes, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteAllDishes()
        {
            Connect();
            sqlConnection.Open();
            string delElectronics = "DELETE FROM [Dishes]";
            sqlCommand = new SqlCommand(delElectronics, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                //sqlConnection.Close();
                Disponse();
                return true;
            }
            throw new Exception();
            Disponse();
        }
    }
}
