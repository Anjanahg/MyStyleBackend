using System;
using System.Collections.Generic;
using MyStyle.Models;
using System.Data;
using System.Data.SqlClient;
using MyStyle.Data;

namespace MyStyle.Repositories
{
    
    public class SearchRepository
    {

        public List<FreelancerData> GetFreelancerData(string CityId, string Unavailabledates, int SkillId , String Session)
        {
            FreelancerData freelancerData;

            List<FreelancerData> searchResult = new List<FreelancerData>();

            IDataReader reader = null;
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "[dbo].[FreelancerData]",
                Connection = SqlConnector.Connection()
            };
            sqlCmd.Parameters.Add("@CityId", SqlDbType.NVarChar).Value = CityId;
            sqlCmd.Parameters.Add("@UnavailableDates", SqlDbType.NVarChar).Value =Unavailabledates ;
            sqlCmd.Parameters.Add("@SkillId", SqlDbType.Int).Value = SkillId ;
            sqlCmd.Parameters.Add("@Session", SqlDbType.NVarChar).Value = Session;
            sqlCmd.Connection.Open();
            reader = sqlCmd.ExecuteReader();
            
            while (reader.Read())
            {
                freelancerData = new FreelancerData();
                freelancerData.FreelancerId= reader["UserId"].ToString();
                freelancerData.FreelancerName= reader["UserName"].ToString();
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