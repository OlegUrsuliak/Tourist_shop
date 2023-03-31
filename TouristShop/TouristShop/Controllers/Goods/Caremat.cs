using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows;

namespace TouristShop.Controllers.Goods
{
    class Caremat:DbContext
    {
        public List<Models.Goods.Caremat> GetAllCaremat()
        {
            Connect();

            string allaut = "select * from [Сaremat]";
            SqlDataReader dataReader = null;
            List<Models.Goods.Caremat> listCaremat = new List<Models.Goods.Caremat>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listCaremat.Add(new Models.Goods.Caremat
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        price = Convert.ToInt32(dataReader[2]),
                        mass = Convert.ToInt32(dataReader[3]),
                        number = Convert.ToInt32(dataReader[4]),
                        description = dataReader[5].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[6])
                    });
                }
                dataReader.Close();
                Disponse();
                return listCaremat;
            }
            throw new Exception();
        }
        public List<Models.Goods.Caremat> GetOneCaremat(int idForSearch)
        {
            Connect();

            string allaut = $"select * from [Сaremat] WHERE [id] = {idForSearch}";
            SqlDataReader dataReader = null;
            List<Models.Goods.Caremat> listCaremat = new List<Models.Goods.Caremat>();
            sqlConnection.Open();

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand = new SqlCommand(allaut, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listCaremat.Add(new Models.Goods.Caremat
                    {
                        id = Convert.ToInt32(dataReader[0]),
                        name = dataReader[1].ToString(),
                        price = Convert.ToInt32(dataReader[2]),
                        mass = Convert.ToInt32(dataReader[3]),
                        number = Convert.ToInt32(dataReader[4]),
                        description = dataReader[5].ToString(),
                        distributor_id = Convert.ToInt32(dataReader[6])
                    });
                }
                dataReader.Close();
                Disponse();
                return listCaremat;
            }
            throw new Exception();
        }
        public bool AddCaremat(string nameNew, int priceNew, int massNew, int numberNew, string descriptionNew, int distributorIdNew)
        {
            Connect();
            sqlConnection.Open();
            string addCaremat = @"INSERT INTO [Сaremat] ([Name],[Price],[Mass],[Number],[Description],[Distributor id])values( " +
                "'" + nameNew + "', '" + priceNew + "', '" + massNew + "', '" + numberNew + "', '" + descriptionNew + "', '" + distributorIdNew + "')";
            sqlCommand = new SqlCommand(addCaremat, sqlConnection);
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool EditCaremat(int idForSearch, string nameNew, int priceNew, 
            int massNew, int numberNew, string descriptionNew, int distributorIdNew)
        {
            sqlConnection.Open();

            string editCaremat = $"UPDATE [Сaremat] " +
                $"SET [Name] = '{nameNew}', " +
                $"[Price] = {priceNew}, " +
                $"[Mass] = {massNew}, " +
                $"[Number] = {numberNew}, " +
                $"[Description] = '{descriptionNew}', " +
                $"[Distributor id] = {distributorIdNew} " +
                
                $"where [Id] = { idForSearch}";

            //MessageBox.Show(editCaremat);

            sqlCommand = new SqlCommand(editCaremat, sqlConnection);
            
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteOneCaremat(int selectedId)
        {
            sqlConnection.Open();
            string delCaremat = @"DELETE FROM [Сaremat] WHERE Id =" + selectedId;
            sqlCommand = new SqlCommand(delCaremat, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
        public bool DeleteAllCaremat()
        {
            Connect();
            sqlConnection.Open();
            string delElectronics = "DELETE FROM [Сaremat]";
            sqlCommand = new SqlCommand(delElectronics, sqlConnection);

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlCommand.ExecuteNonQuery();
                Disponse();
                return true;
            }
            throw new Exception();
        }
    }
}
