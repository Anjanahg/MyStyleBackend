using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MyStyle.Data;


namespace MyStyle.Repositories
{
    public class TopRatedFreelancersRepository
    {

        public List<FreelancerData> TopRatedFreelancers()
        {
            FreelancerData freelancerData;

            List<FreelancerData> searchResult = new List<FreelancerData>();

            IDataReader reader = null;
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "[dbo].[TopRatedFreelancers]",
                Connection = SqlConnector.Connection()
            };

            if (sqlCmd.Connection.State == ConnectionState.Closed) sqlCmd.Connection.Open();
            reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                freelancerData = new FreelancerData();
                freelancerData.FreelancerId = reader["UserId"].ToString();
                freelancerData.FreelancerName = reader["UserName"].ToString();
                freelancerData.FreelancerDescription = reader["Description"].ToString();
                freelancerData.FreelancerAddress = reader["Address"].ToString();
                freelancerData.FreelancerRegDate = reader["RegDate"].ToString();
                freelancerData.FreelancerPhone = reader["Phone"].ToString();
                freelancerData.FreelancerSessionPrice = reader["SessionPrice"].ToString();
                freelancerData.ImageURL = reader["ImageURL"].ToString();

                searchResult.Add(freelancerData);

            }

            sqlCmd.Connection.Close();
            return searchResult;

        }


    }
}