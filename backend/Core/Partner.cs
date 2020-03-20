using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.Core
{
    public class Partner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public int Order { get; set; }

        public string Bussiness { get; set; }

        public string Website { get; set; }

        public string Tel { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }
        public string Intro_Phone { get; internal set; }
    }
}