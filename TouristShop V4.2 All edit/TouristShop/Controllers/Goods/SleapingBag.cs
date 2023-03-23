using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TouristShop.Controllers.Goods
{
    class SleapingBag:DbContext
    {
        public List<Models.Goods.SleapingBag> GetAllSleapingBag()
        {
            Connect();

            string allaut = "select * from [Sleaping bag]";
            SqlDataReader dataReader = null;
            List<Models.Goods.SleapingBag> listSleapingBag = new List<Models.Goods.SleapingBag>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listSleapingBag.Add(new Models.Goods.SleapingBag
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        price = Convert.ToInt32(dataReader[2]),
                        number = Convert.ToInt32(dataReader[3]),
                        season = dataReader[4].ToString(),
                        comfortableTemperature = Convert.ToInt32(dataReader[5]),
                        description = dataReader[6].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[7])
                    });
                }
                dataReader.Close();
                Disponse();
                return listSleapingBag;
            }
            throw new Exception();
        }
        public List<Models.Goods.SleapingBag> GetOneSleapingBag(int idForSearch)
        {
            Connect();

            string allaut = $"select * from [Sleaping bag] WHERE [id] = {idForSearch}";
            SqlDataReader dataReader = null;
            List<Models.Goods.SleapingBag> listSleapingBag = new List<Models.Goods.SleapingBag>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listSleapingBag.Add(new Models.Goods.SleapingBag
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        price = Convert.ToInt32(dataReader[2]),
                        number = Convert.ToInt32(dataReader[3]),
                        season = dataReader[4].ToString(),
                        comfortableTemperature = Convert.ToInt32(dataReader[5]),
                        description = dataReader[6].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[7])
                    });
                }
                dataReader.Close();
                Disponse();
                return listSleapingBag;
            }
            throw new Exception();
        }
        public bool AddSleapingBag(string nameNew, int priceNew, int numberNew, string seasonNew, int comfortableTebperatureNew, string descriptionNew, int distributor_idNew)
        {
            Connect();
            sqlConnection.Open();
            string addSleapingBag = @"INSERT INTO [Sleaping bag] ([Name],[Price],[Number],[Season],[Comfortable temperature],[Description],[Distributor id])values(" +
                "'" + nameNew + "', '" + priceNew + "', '" + numberNew + "', '" + seasonNew + "','" + comfortableTebperatureNew + "', '" + descriptionNew + "', '" + distributor_idNew + "')";
            sqlCommand = new SqlCommand(addSleapingBag, sqlConnection);
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool EditSleapingBag(int idForSearch, string nameNew, int priceNew, 
            int numberNew, string seasonNew, int comfortableTebperatureNew, string descriptionNew, int distributor_idNew)
        {
            sqlConnection.Open();

            string editSleapingBag = $"UPDATE [Sleaping bag] " +
                $"SET [Name] = '{nameNew}', " +
                $"[Price] = {priceNew}, " +
                $"[Number] = {numberNew}, " +
                $"[Season] = '{seasonNew}', " +
                $"[Comfortable temperature] = {comfortableTebperatureNew}, " +
                $"[Description] = '{descriptionNew}', " +
                $"[Distributor id] = {distributor_idNew} " +
                $"where [Id] = {idForSearch}";

            sqlCommand = new SqlCommand(editSleapingBag, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteOneSleapingBag(int selectedId)
        {
            sqlConnection.Open();
            string delSleapingBag = @"DELETE FROM [Sleaping bag] WHERE Id =" + selectedId;
            sqlCommand = new SqlCommand(delSleapingBag, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteAllSleapingBag()
        {
            sqlConnection.Open();
            string delElectronics = "DELETE FROM [Sleaping bag]";
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
