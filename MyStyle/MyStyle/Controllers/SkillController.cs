using MyStyle.BusinessServices;
using MyStyle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyStyle.Controllers
{
    public class SkillController : ApiController
    {

        private SkillServices _skillServices;

        public SkillController()
        {
            _skillServices = new SkillServices();


        }
        [HttpPost]
        public List<Skill> GetSkill()
        {
            return _skillServices.GetSkill();
        }
    }
}
