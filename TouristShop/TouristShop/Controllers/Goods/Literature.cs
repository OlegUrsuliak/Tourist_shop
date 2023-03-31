using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TouristShop.Controllers.Goods
{
    class Literature:DbContext
    {
        public List<Models.Goods.Literature> GetAllLiterature()
        {
            Connect();

            string allaut = "select * from [Literature]";
            SqlDataReader dataReader = null;
            List<Models.Goods.Literature> listLiterature = new List<Models.Goods.Literature>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listLiterature.Add(new Models.Goods.Literature
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        price = Convert.ToInt32(dataReader[2]),
                        number = Convert.ToInt32(dataReader[3]),
                        teg = dataReader[4].ToString(),
                        description = dataReader[5].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[6])
                    });
                }
                dataReader.Close();
                Disponse();
                return listLiterature;
            }
            throw new Exception();
        }
        public List<Models.Goods.Literature> GetOneLiterature(int idForSearch)
        {
            Connect();

            string allaut = $"select * from [Literature] WHERE [id] = {idForSearch}";
            SqlDataReader dataReader = null;
            List<Models.Goods.Literature> listLiterature = new List<Models.Goods.Literature>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listLiterature.Add(new Models.Goods.Literature
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        price = Convert.ToInt32(dataReader[2]),
                        number = Convert.ToInt32(dataReader[3]),
                        teg = dataReader[4].ToString(),
                        description = dataReader[5].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[6])
                    });
                }
                dataReader.Close();
                Disponse();
                return listLiterature;
            }
            throw new Exception();
        }
        public bool AddLiterature(string nameNew, int priceNew, int numberNew, string tegNew, string descriptionNew, int distributor_idNew)
        {
            Connect();
            sqlConnection.Open();
            string addLiterature = @"INSERT INTO [Literature] ([Name],[Price],[Number],[Teg],[Description],[Distributor id])values( " +
                "'" + nameNew + "', '" + priceNew + "', '" + numberNew + "', '" + tegNew + "', '" + descriptionNew + "', '" + distributor_idNew + "')";
            sqlCommand = new SqlCommand(addLiterature, sqlConnection);
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool EditLiterature(int idForSearch, string nameNew, int priceNew, 
            int numberNew, string tegNew, string descriptionNew, int distributor_idNew)
        {
            sqlConnection.Open();

            string editLiterature = $"UPDATE [Literature] " +
                $"SET [Name] = '{nameNew}', " +
                $"[Price] = {priceNew}, " +
                $"[Number] = {numberNew}, " +
                $"[Teg] = '{tegNew}', " +
                $"[Description] = '{descriptionNew}', " +
                $"[Distributor id] = {distributor_idNew} " +

                $"where [Id] = {idForSearch}";

            sqlCommand = new SqlCommand(editLiterature, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteOneLiterature(int selectedId)
        {
            sqlConnection.Open();
            string delLiterature = @"DELETE FROM [Literature] WHERE Id =" + selectedId;
            sqlCommand = new SqlCommand(delLiterature, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteAllLiterature()
        {
            Connect();
            sqlConnection.Open();
            string delElectronics = "DELETE FROM [Literature]";
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
