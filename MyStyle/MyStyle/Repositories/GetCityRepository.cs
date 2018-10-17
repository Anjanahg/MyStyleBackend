using MyStyle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyStyle.Repositories
{
    public class GetCityRepository
    {

        

            public List<City> GetCity()
            {
                City city;

                List<City> cities = new List<City>();

                IDataReader reader = null;
                SqlCommand sqlCmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "[dbo].[GetCity]",
                    Connection = SqlConnector.Connection()
                };
       

                sqlCmd.Connection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    city = new City();
                    city.CityName = reader["CityName"].ToString();
                    city.CityId = reader["CityId"].ToString();



                    cities.Add(city);

                }
                sqlCmd.Connection.Close();
                return cities;

            }

        
    }
}