using MainProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.News
{
    public class OfficeViewModel
    {
        public Category OfficeCategory { get; set; } = new Category
        {
            Title = "CHO THUÊ VĂN PHÒNG",
            Description ="Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. " +
            "In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium."
        };
        public List<Article> Offices { get; set; } = new List<Article>
        {
            new Article
            {
                ImageDefault = "/content/resources/assets/images/index/item-project-01.png",
                Title = "Văn phòng cho thuê - Diện tích 30m2"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/index/item-project-02.png",
                Title = "Văn phòng cho thuê - Diện tích 30m2"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/index/item-project-03.png",
                Title = "Văn phòng cho thuê - Diện tích 30m2"
            }
        };
    }
}