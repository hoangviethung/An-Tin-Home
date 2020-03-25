using MainProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.Contact
{
    public class ContactViewModel
    {
        public List<Branch> Branches { get; set; } = new List<Branch>
        {
            new Branch
            {
                OfficeName = "AN TÍN HOMES",
                Description = "Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium.",
                Address = "<span>Địa chỉ:</span><p> Tòa nhà H3,384 Hoàng Diệu,Quận 4,TP.Hồ Chí Minh </p> ",
                Email = "<span>Email:</span><p> info@antingroup.vn </p> ",
                Fax = "<span>Fax:</span><p> 028. 38266766 </p> ",
                AddressMap = "<div id=\"map\"></div>",
                Phone = "<div class=\"icon\"><img src=\"/content/resources/assets/icons/phone.png\" alt=\"alt\"></div><a href=\"tel:02838266766\">028. 38266766</a>"
            },
            new Branch
            {
                OfficeName = "AN TÍN HOMES",
                Description = "Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium.",
                Address = "<span>Địa chỉ:</span><p> Tòa nhà H3,384 Hoàng Diệu,Quận 4,TP.Hồ Chí Minh </p> ",
                Email = "<span>Email:</span><p> info@antingroup.vn </p> ",
                Fax = "<span>Fax:</span><p> 028. 38266766 </p> ",
                AddressMap = "<div id=\"map\"></div>",
                Phone = "<div class=\"icon\"><img src=\"/content/resources/assets/icons/phone.png\" alt=\"alt\"></div><a href=\"tel:02838266766\">028. 38266766</a>"
            }
        };
        public Category Category { get; set; } = new Category
        {
            Title = "Liên Hệ",
            Description = "Donec pede justo,"+
            "fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. " +
            "Nullam dictum felis eu pede mollis pretium."
        };
    }
}