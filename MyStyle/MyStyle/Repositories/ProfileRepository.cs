using MyStyle.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyStyle.Repositories
{
    public class ProfileRepository
    {
        

        public FreelancerData GetDetails(int UserId)
        {
            FreelancerData freelancerData = new FreelancerData();


            IDataReader reader = null;
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "[dbo].[ProfileDetails]",
                Connection = SqlConnector.Connection()
            };
            sqlCmd.Parameters.Add("@UserId", SqlDbType.Int).Value = UserId;

            sqlCmd.Connection.Open();
            reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                
                freelancerData.FreelancerId = reader["UserId"].ToString();
                freelancerData.FreelancerName = reader["UserName"].ToString();
                freelancerData.FreelancerDescription = reader["Description"].ToString();
                freelancerData.FreelancerAddress = reader["Address"].ToString();
                freelancerData.FreelancerRegDate = reader["RegDate"].ToString();
                freelancerData.FreelancerPhone = reader["Phone"].ToString();
                freelancerData.FreelancerSessionPrice = reader["SessionPrice"].ToString();
                freelancerData.ImageURL=reader["ImageURL"].ToString();


            }

            sqlCmd.Connection.Close();
            return freelancerData;

        }


    }
}