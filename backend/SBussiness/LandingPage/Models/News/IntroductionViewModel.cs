using MainProject.Core;
using MainProject.Framework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.News
{
    public class IntroductionViewModel
    {

        public Introduction Section1 { get; set; } = new Introduction
        {
            Title = "AN TÍN HOMES",
            Content = "<div class=\"description\">" +
            "<div class=\"ckeditor desc-about-block-1\">" +
            "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p> " +
            "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>" +
            "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>" +
            " <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>" +
            "<ul><li>– Tel: 028. 8322.7919/15 – Fax: 028.3825.7189</li><li>– Email: info @harvestdjsc.com</li><li>– Website: www.harvestdjsc.com</li> </ul></div> " +
            "<div class=\"ckeditor desc-about-block-2\">" +
            "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet," +
            " consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipisicing elit," +
            " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p></div></div>",
            Image = "/content/resources/assets/images/about/about-2.png",
        };
        public Introduction Section2 { get; set; } = new Introduction
        {
            Title = "<h3 class=\"wow fadeInUp\" data-wow-delay=\".2s\">mô tả</h3>",
            Image = "/content/resources/assets/images/about/about-3_01.png",
            Content = "<div class=\"description\"><div class=\"ckeditor desc-about-3-block-1\">" +
            "<h3>MÔ TẢ CHUNG</h3><p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
            "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, " +
            "consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>" +
            "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>" +
            "</div></div>"
        };
        public Introduction Section3 { get; set; } = new Introduction
        {
            Title = "fadeInUp\" data-wow-delay=\".2s\">mô tả</h3>",
            Image = "/content/resources/assets/images/about/about-3_01.png",
            Content = "<div class=\"description\"><div class=\"ckeditor desc-about-3-block-1\">" +
             "<h3>MÔ TẢ CHUNG</h3><p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
             "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, " +
             "consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
             "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
             "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>" +
             "<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
             "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
             "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
             "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>" +
             "</div></div>"
        };

        public Introduction Section4 { get; set; } = new Introduction
        {
            Title = "đối tác",
            Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Modi tempora deleniti veniam eum impedit dolorem, nihil enim illo facilis ex nobis asperiores exercitationem voluptatum rem pariatur accusamus a, cumque delectus",
            Image = JsonHelper.Serialize(new List<Partner> {
                new Partner
                {
                    Name = "Name",
                    Bussiness = "Bussiness",
                    Order = 1,
                    Image = "/content/resources/assets/images/about/slider-partner-logo.png",
                    Website = "Lorem ipsum dolor sit amet",
                    Tel = "0969912404",
                    Email = "Lorem ipsum dolor sit amet",
                    Fax = "0969912404"
                },
                new Partner
                {
                    Name = "Name",
                    Bussiness = "Bussiness",
                    Order = 2,
                    Image = "/content/resources/assets/images/about/slider-partner-logo.png",
                    Website = "Lorem ipsum dolor sit amet",
                    Tel = "0969912404",
                    Email = "Lorem ipsum dolor sit amet",
                    Fax = "0969912404"
                },
                new Partner
                {
                    Name = "Name",
                    Bussiness = "Bussiness",
                    Order = 3,
                    Image = "/content/resources/assets/images/about/slider-partner-logo.png",
                    Website = "Lorem ipsum dolor sit amet",
                    Tel = "0969912404",
                    Email = "Lorem ipsum dolor sit amet",
                    Fax = "0969912404"
                },
                new Partner
                {
                    Name = "Name",
                    Bussiness = "Bussiness",
                    Order = 4,
                    Image = "/content/resources/assets/images/about/slider-partner-logo.png",
                    Website = "Lorem ipsum dolor sit amet",
                    Tel = "0969912404",
                    Email = "Lorem ipsum dolor sit amet",
                    Fax = "0969912404"
                },
            })
        };
}
}