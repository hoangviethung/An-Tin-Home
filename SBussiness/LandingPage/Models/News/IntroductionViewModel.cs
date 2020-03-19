using MainProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.News
{
    public class IntroductionViewModel
    {

        public Category Section1 { get; set; } = new Category
        {
            SeName = "Giới thiệu",
            Title = "AN TÍN HOMES",
            Description = "<div class=\"description\">" +
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
            ImageDefault = "/content/resources/assets/images/about/about-2.png"
        };
        public Category Section2 { get; set; } = new Category
        {
            Title = "<h3 class=\"wow fadeInUp\" data-wow-delay=\".2s\">mô tả</h3>",
            MetaTitle = "<p>LOREM IPSUM DOLOR SIT AMET</p>",
            ImageDefault = "/content/resources/assets/images/about/about-3_01.png",
            Description = "<div class=\"description\"><div class=\"ckeditor desc-about-3-block-1\">" +
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
        public List<Category> Section3 { get; set; } = new List<Category>
        {
            new Category
            {
                Title = "<div class=\"name\">LOREM IPSUM DOLOR SIT AMET, CONSECTETUER 2</div>",
                MetaTitle = "<div class=\"numbers\">01</div>",
                Description = "<ul class=\"list-info\">" +
                "<li class=\"item\">" +
                "<span>Lĩnh Vực Kinh Doanh: </span><p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor</p></li>" +
                "<li class=\"item\"><span>Website: </span><p>Lorem ipsum dolor sit amet</p></li>" +
                "<li class=\"item\"><span>Tel: </span><p>0969912404</p></li>" +
                "<li class=\"item\"><span>Fax: </span><p>1231234122</p></li>" +
                "<li class=\"item\"><span>Email: </span><p>Lorem ipsum dolor sit ame</p></li></ul>",
                ImageDefault = "/content/resources/assets/images/about/slider-partner-logo.png"
            },
            new Category
            {
                Title = "<div class=\"name\">LOREM IPSUM DOLOR SIT AMET, CONSECTETUER 2</div>",
                MetaTitle = "<div class=\"numbers\">01</div>",
                Description = "<ul class=\"list-info\">" +
                "<li class=\"item\">" +
                "<span>Lĩnh Vực Kinh Doanh: </span><p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor</p></li>" +
                "<li class=\"item\"><span>Website: </span><p>Lorem ipsum dolor sit amet</p></li>" +
                "<li class=\"item\"><span>Tel: </span><p>0969912404</p></li>" +
                "<li class=\"item\"><span>Fax: </span><p>1231234122</p></li>" +
                "<li class=\"item\"><span>Email: </span><p>Lorem ipsum dolor sit ame</p></li></ul>",
                ImageDefault = "/content/resources/assets/images/about/slider-partner-logo.png"
            },
            new Category
            {
                Title = "<div class=\"name\">LOREM IPSUM DOLOR SIT AMET, CONSECTETUER 2</div>",
                MetaTitle = "<div class=\"numbers\">01</div>",
                Description = "<ul class=\"list-info\">" +
                "<li class=\"item\">" +
                "<span>Lĩnh Vực Kinh Doanh: </span><p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor</p></li>" +
                "<li class=\"item\"><span>Website: </span><p>Lorem ipsum dolor sit amet</p></li>" +
                "<li class=\"item\"><span>Tel: </span><p>0969912404</p></li>" +
                "<li class=\"item\"><span>Fax: </span><p>1231234122</p></li>" +
                "<li class=\"item\"><span>Email: </span><p>Lorem ipsum dolor sit ame</p></li></ul>",
                ImageDefault = "/content/resources/assets/images/about/slider-partner-logo.png"
            },
            new Category
            {
                Title = "<div class=\"name\">LOREM IPSUM DOLOR SIT AMET, CONSECTETUER 2</div>",
                MetaTitle = "<div class=\"numbers\">01</div>",
                Description = "<ul class=\"list-info\">" +
                "<li class=\"item\">" +
                "<span>Lĩnh Vực Kinh Doanh: </span><p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor</p></li>" +
                "<li class=\"item\"><span>Website: </span><p>Lorem ipsum dolor sit amet</p></li>" +
                "<li class=\"item\"><span>Tel: </span><p>0969912404</p></li>" +
                "<li class=\"item\"><span>Fax: </span><p>1231234122</p></li>" +
                "<li class=\"item\"><span>Email: </span><p>Lorem ipsum dolor sit ame</p></li></ul>",
                ImageDefault = "/content/resources/assets/images/about/slider-partner-logo.png"
            },
        };
}
}