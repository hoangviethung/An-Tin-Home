﻿using MainProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.Contact
{
    public class ContactViewModel
    {
        public Branch Branch { get; set; } = new Branch
        {
            OfficeName = "AN TÍN HOMES",
            Description = "Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium.",
            Address = "<span>Địa chỉ:</span><p> Tòa nhà H3,384 Hoàng Diệu,Quận 4,TP.Hồ Chí Minh </p> ",
            Email = "<span>Email:</span><p> info@antingroup.vn </p> ",
            Fax = "<span>Fax:</span><p> 028. 38266766 </p> ",
            Lat = Convert.ToDecimal(10.1251),
            Lng = Convert.ToDecimal(11.125),
            Phone = "<div class=\"icon\"><img src=\"/content/resources/assets/icons/phone.png\" alt=\"alt\"></div><a href=\"tel:02838266766\">028. 38266766</a>"
        };
        public Category Category { get; set; } = new Category
        {
            Title = "Liên Hệ",
            Description = "<h3 class=\"wow fadeInUp\" data-wow-delay=\".2s\">AN TÍN HOMES</h3><p class=\"lcl lcl-2\">Donec pede justo, " +
            "fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. " +
            "Nullam dictum felis eu pede mollis pretium.</p>"
        };
    }
}