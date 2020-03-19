using MainProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.News
{
    public class OfficeViewModel
    {
        public List<Article> Office { get; set; } = new List<Article>
        {
            new Article
            {
                ImageDefault = "/content/resources/assets/images/index/item-project-01.png",
                Title = "<div class=\"name\">Văn phòng cho thuê - Diện tích 30m2</div>"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/index/item-project-02.png",
                Title = "<div class=\"name\">Văn phòng cho thuê - Diện tích 30m2</div>"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/index/item-project-03.png",
                Title = "<div class=\"name\">Văn phòng cho thuê - Diện tích 30m2</div>"
            }
        };
    }
}