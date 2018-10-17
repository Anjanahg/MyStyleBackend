using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStyle.Data;
using MyStyle.Models;
using System.Data.SqlClient;
using System.Data;

namespace MyStyle.Repositories
{
    public class HomePageRepository
    {
        public HomePageData GetHomePageData()
        {
            HomePageData homePageData = new HomePageData();
            IDataReader reader = null;
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "HomePageData",
                Connection = SqlConnector.Connection()
            };

           
            sqlCmd.Connection.Open();
            reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {

                homePageData.FreelancerCount = reader["FreelancerCount"].ToString();
                homePageData.SalonCount = reader["SalonCount"].ToString();
                homePageData.JobsCount = reader["JobCount"].ToString();

                
            }

            sqlCmd.Connection.Close();
            return homePageData;
        }




       
    }
}