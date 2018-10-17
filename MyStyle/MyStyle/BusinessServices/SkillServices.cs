using MyStyle.Models;
using MyStyle.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MyStyle.Data;

namespace MyStyle.BusinessServices
{
    public class SkillServices :ISkillServices
    {
        public List<Skill> GetSkill()
        {
            return new GetSkillRepository().GetSkill();
        }
    }
}