using MyStyle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyStyle.Repositories
{
    public class GetSkillRepository
    {
        public List<Skill> GetSkill()
        {
            Skill skill;

            List<Skill> skills= new List<Skill>();

            IDataReader reader = null;
            SqlCommand sqlCmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "[dbo].[GetSkill]",
                Connection = SqlConnector.Connection()
            };


            sqlCmd.Connection.Open();
            reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                skill = new Skill();
                skill.SkillName = reader["SkillName"].ToString();
                skill.SkillId = reader["SkillId"].ToString();



                skills.Add(skill);

            }
            sqlCmd.Connection.Close();
            return skills;

        }
    }
}