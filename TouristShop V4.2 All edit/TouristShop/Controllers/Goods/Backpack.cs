using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;

namespace TouristShop.Controllers.Goods{
    class Backpack:DbContext{
        //public int idForSearcher;
        public List<Models.Goods.Backpack> GetAllBackpack(){
            Connect();
            string allaut = "select * from [Backpack]";

            SqlDataReader dataReader = null;
            List<Models.Goods.Backpack> listBackpack = new List<Models.Goods.Backpack>();

            sqlConnection.Open();
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listBackpack.Add(new Models.Goods.Backpack
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        price = Convert.ToInt32(dataReader[2]),
                        number = Convert.ToInt32(dataReader[3]),
                        size = Convert.ToInt32(dataReader[4]),
                        mass = Convert.ToInt32(dataReader[5]),
                        teg = dataReader[6].ToString(),
                        description = dataReader[7].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[8])
                    }) ;
                }
                dataReader.Close();
                Disponse();
                return listBackpack;
            }
            else
            {
                MessageBox.Show("Connect error");
            }
            throw new Exception();
        }
        public List<Models.Goods.Backpack> GetOneBackpack(int idForSearch)
        {
            Connect();
            string allaut = $"select * from [Backpack] WHERE [id] = {idForSearch}";

            SqlDataReader dataReader = null;
            List<Models.Goods.Backpack> listBackpack = new List<Models.Goods.Backpack>();

            sqlConnection.Open();
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listBackpack.Add(new Models.Goods.Backpack
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        price = Convert.ToInt32(dataReader[2]),
                        number = Convert.ToInt32(dataReader[3]),
                        size = Convert.ToInt32(dataReader[4]),
                        mass = Convert.ToInt32(dataReader[5]),
                        teg = dataReader[6].ToString(),
                        description = dataReader[7].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[8])
                    });
                }
                dataReader.Close();
                Disponse();
                return listBackpack;
            }
            else
            {
                MessageBox.Show("Connect error");
            }
            throw new Exception();
        }
        public bool AddBackpack(string nameNew, int priceNew, int numberNew, int sizeNew, int massNew, string tegNew, string descriptionNew, int distributor_idNew)
        {
            Connect();
            sqlConnection.Open();
            
            string addBackpack = @"INSERT INTO [Backpack] ([Name],[Price],[Number],[Size],[Mass],[Teg],[Description],[Distributor id])values( " +
                "'" + nameNew + "', '" + priceNew + "', '" + numberNew + "', '" + sizeNew + "','" + massNew + "','" + tegNew + "', '" + descriptionNew + "', '" + distributor_idNew + "')";

            sqlCommand = new SqlCommand(addBackpack, sqlConnection);
            

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool EditBackpack(int idForSearch, string nameNew, int priceNew, int numberNew, int sizeNew,
            int massNew, string tegNew, string descriptionNew, int distributor_idNew)
        {
            sqlConnection.Open();

            string editBackpack = $"UPDATE [Backpack] " +
                $"SET [Name] = '{nameNew}', " +
                $"[Price] = {priceNew}, " +
                $"[Number] = {numberNew}, " +
                $"[Size] = {sizeNew}, " +
                $"[Mass] = {massNew}, " +
                $"[Teg] = '{tegNew}', " +
                $"[Description] = '{descriptionNew}', " +
                $"[Distributor id] = {distributor_idNew} " +

                $"where [Id] = {idForSearch}";

                //$"[Mass] = {massNew}, " + //For int No need ' '
                //$"[Teg] = '{tegNew}', " + //For string need 'Текстова змінна'


            sqlCommand = new SqlCommand(editBackpack, sqlConnection);
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }



        public bool DeleteOneBackpack(int selectedId)
        {
            sqlConnection.Open();
            string delBackpack = @"DELETE FROM [Backpack] WHERE Id =" + selectedId;
            sqlCommand = new SqlCommand(delBackpack, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteAllBackpack()
        {
            sqlConnection.Open();
            string delElectronics = "DELETE FROM [Backpack]";
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
