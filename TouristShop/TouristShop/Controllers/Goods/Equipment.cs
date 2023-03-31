using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TouristShop.Controllers.Goods
{
    class Equipment:DbContext
    {
        public List<Models.Goods.Equipment> GetAllEquipment()
        {
            Connect();

            string allaut = "select * from [Equipment]";
            SqlDataReader dataReader = null;
            List<Models.Goods.Equipment> listEquipment = new List<Models.Goods.Equipment>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listEquipment.Add(new Models.Goods.Equipment
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        number = Convert.ToInt32(dataReader[2]),
                        mass = Convert.ToInt32(dataReader[3]),
                        price = Convert.ToInt32(dataReader[4]),
                        description = dataReader[5].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[6])
                    });
                }
                dataReader.Close();
                Disponse();
                return listEquipment;
            }
            throw new Exception();
        }
        public List<Models.Goods.Equipment> GetOneEquipment(int idForSearch)
        {
            Connect();

            string allaut = $"select * from [Equipment] WHERE [id] = {idForSearch}";
            SqlDataReader dataReader = null;
            List<Models.Goods.Equipment> listEquipment = new List<Models.Goods.Equipment>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listEquipment.Add(new Models.Goods.Equipment
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        number = Convert.ToInt32(dataReader[2]),
                        mass = Convert.ToInt32(dataReader[3]),
                        price = Convert.ToInt32(dataReader[4]),
                        description = dataReader[5].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[6])
                    });
                }
                dataReader.Close();
                Disponse();
                return listEquipment;
            }
            throw new Exception();
        }
        public bool AddEquipment(string nameNew, int numberNew, int massNew, int priceNew, string descriptionNew, int distributor_idNew)
        {
            Connect();
            sqlConnection.Open();
            string addEquipment = @"INSERT INTO [Equipment] ([Name],[Number],[Mass],[Price],[Description],[Distributor id])values(" +
                "'" + nameNew + "', '" + numberNew + "', '" + massNew + "', '" + priceNew + "', '" + descriptionNew + "', '" + distributor_idNew + "')";
            sqlCommand = new SqlCommand(addEquipment, sqlConnection);
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool EditEquipment(int idForSearch, string nameNew, int numberNew, int massNew, 
            int priceNew, string descriptionNew, int distributor_idNew)
        {
            sqlConnection.Open();

            string editEquipment = $"UPDATE [Equipment] " +
                $"SET [Name] = '{nameNew}', " +
                $"[Number] = {numberNew}, " +
                $"[Mass] = {massNew}, " +
                $"[Price] = {priceNew}, " +
                $"[Description] = '{descriptionNew}', " +
                $"[Distributor id] = {distributor_idNew} " +

                $"where [Id] = {idForSearch}";

            sqlCommand = new SqlCommand(editEquipment, sqlConnection);
            //MessageBox.Show(editBackpack);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteOneEquipment(int selectedId)
        {
            sqlConnection.Open();
            string delEquipment = @"DELETE FROM [Equipment] WHERE Id =" + selectedId;
            sqlCommand = new SqlCommand(delEquipment, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteAllEquipment()
        {
            Connect();
            sqlConnection.Open();
            string delEquipment = "DELETE FROM [Equipment]";
            sqlCommand = new SqlCommand(delEquipment, sqlConnection);

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
