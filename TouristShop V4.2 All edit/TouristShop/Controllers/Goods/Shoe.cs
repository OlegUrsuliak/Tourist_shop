using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TouristShop.Controllers.Goods
{
    class Shoe:DbContext
    {
        public List<Models.Goods.Shoe> GetAllShoes()
        {
            Connect();

            string allaut = "select * from [Shoes]";
            SqlDataReader dataReader = null;
            List<Models.Goods.Shoe> listShoes = new List<Models.Goods.Shoe>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listShoes.Add(new Models.Goods.Shoe
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        sex = dataReader[2].ToString(),
                        size = Convert.ToInt32(dataReader[3]),
                        price = Convert.ToInt32(dataReader[4]),
                        number = Convert.ToInt32(dataReader[5]),
                        teg = dataReader[6].ToString(),
                        description = dataReader[7].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[8])

                    });
                }
                dataReader.Close();
                Disponse();
                return listShoes;
            }
            throw new Exception();
        }
        public List<Models.Goods.Shoe> GetOneShoes(int idForSearch)
        {
            Connect();

            string allaut = $"select * from [Shoes] WHERE [id] = {idForSearch}";
            SqlDataReader dataReader = null;
            List<Models.Goods.Shoe> listShoes = new List<Models.Goods.Shoe>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listShoes.Add(new Models.Goods.Shoe
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        sex = dataReader[2].ToString(),
                        size = Convert.ToInt32(dataReader[3]),
                        price = Convert.ToInt32(dataReader[4]),
                        number = Convert.ToInt32(dataReader[5]),
                        teg = dataReader[6].ToString(),
                        description = dataReader[7].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[8])

                    });
                }
                dataReader.Close();
                Disponse();
                return listShoes;
            }
            throw new Exception();
        }
        public bool AddShoes(string nameNew, string sexNew, int sizeNew, int priceNew, int numberNew, string tegNew, string descriptionNew, int distributor_idNew)
        {
            Connect();
            sqlConnection.Open();
            string addShoes = @"INSERT INTO [Shoes] ([Name],[Sex],[Size],[Price],[Number],[Teg],[Description],[Distributor id])values( " +
                "'" + nameNew + "', '" + sexNew + "', '" + sizeNew + "', '" + priceNew + "','" + numberNew + "','" + tegNew + "', '" + descriptionNew + "', '" + distributor_idNew + "')";
            sqlCommand = new SqlCommand(addShoes, sqlConnection);
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool EditShoe(int idForSearch, string nameNew, string sexNew, 
            int sizeNew, int priceNew, int numberNew, string tegNew, string descriptionNew, int distributor_idNew)
        {
            sqlConnection.Open();

            string editShoe = $"UPDATE [Shoes] " +
                $"SET [Name] = '{nameNew}', " +
                $"[Sex] = '{sexNew}', " +
                $"[Size] = {sizeNew}, " +
                $"[Price] = {priceNew}, " +
                $"[Number] = {numberNew}, " +
                $"[Teg] = '{tegNew}', " +
                $"[Description] = '{descriptionNew}', " +
                $"[Distributor id] = {distributor_idNew} " +

                $"where [Id] = {idForSearch}";

            sqlCommand = new SqlCommand(editShoe, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteOneShoes(int selectedId)
        {
            sqlConnection.Open();
            string delShoes = @"DELETE FROM [Shoes] WHERE Id =" + selectedId;
            sqlCommand = new SqlCommand(delShoes, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteAllShoes()
        {
            sqlConnection.Open();
            string delElectronics = "DELETE FROM [Shoes]";
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
