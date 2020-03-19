using MainProject.Core;
using MainProject.Framework.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MainProject.SBussiness.LandingPage.Models.Home
{
    public class HomeViewModel
    {
        public Category Category { get; set; } = new Category
        {
            Title = "HomePage"
        };
        public Introduction Section1 { get; set; } = new Introduction
        {
            Title = "Giới thiệu",
            Image = "/content/resources/assets/images/index/index-1-about.png",
            Content = "<h3>DỊCH VỤ CHO THUÊ VĂN PHÒNG AN TÍN HOMES</h3><p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
            "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
            "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
            "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
            "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
        };
        public Introduction Section2 { get; set; } = new Introduction
        {
            Title = "Cơ Sở Vật Chất",
            Content = "nhấn để xem",
            Image = JsonHelper.Serialize(new List<Image> { 
                new Image
                {
                   ResourcePath  = "/content/resources/assets/images/index/infrastructure-01.png"
                },
                new Image
                {
                    ResourcePath = "/content/resources/assets/images/index/infrastructure-02.png"
                },
                new Image
                {
                    ResourcePath = "/content/resources/assets/images/index/infrastructure-03.png"
                }
            })
        };
        public List<Article> Newses { get; set; } = new List<Article>
        {
            new Article
            {
                Title = "LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1",
                Order = DateTime.Now,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni."
            },
            new Article
            {
                Title = "LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1",
                ImageDefault = "/content/resources/assets/images/index/newhome-tower.png",
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni."

            },
            new Article
            {
                Title = "LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1",
                Order = DateTime.Now,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni."

            },
            new Article
            {
                Title = "LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1",
                Order = DateTime.Now,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni."

            }

        };
        public List<Article> Opices { get; set; } = new List<Article>
        {
               new Article
               {
                    Title = "CHO THUÊ VĂN PHÒNG TẠI TP.HCM",
                    Description = "Aliquam lorem ante, " +
                   "dapibus in, viverra quis, feugiat a, tellus. " +
                   "Phasellus viverra nulla ut metusvarius laoreet. " +
                   "Quisque rutrum. Aenean imperdiet. " +
                   "Etiam ultriciesnisi vel augue. " +
                   "Curabitur ullamcorper ultricies nisi.",
                    ImageDefault = "/content/resources/assets/images/index/item-project-01.png"
               },
               new Article
               {
                    Title = "CHO THUÊ VĂN PHÒNG TẠI TP.HCM",
                    Description = "Aliquam lorem ante, " +
                   "dapibus in, viverra quis, feugiat a, tellus. " +
                   "Phasellus viverra nulla ut metusvarius laoreet. " +
                   "Quisque rutrum. Aenean imperdiet. " +
                   "Etiam ultriciesnisi vel augue. " +
                   "Curabitur ullamcorper ultricies nisi.",
                    ImageDefault = "/content/resources/assets/images/index/item-project-02.png"
               },
               new Article
               {
                    Title = "CHO THUÊ VĂN PHÒNG TẠI TP.HCM",
                    Description = "Aliquam lorem ante, " +
                   "dapibus in, viverra quis, feugiat a, tellus. " +
                   "Phasellus viverra nulla ut metusvarius laoreet. " +
                   "Quisque rutrum. Aenean imperdiet. " +
                   "Etiam ultriciesnisi vel augue. " +
                   "Curabitur ullamcorper ultricies nisi.",
                    ImageDefault = "/content/resources/assets/images/index/item-project-03.png"
               },
        };
    }

    public class HeaderViewModel
    {
        public List<Banner> Banners { get; set; } = new List<Banner>
        {
            new Banner
            {
                Name = "Banner1",
                ResourcePath = "/content/resources/assets/images/banner/1.png"
            },
            new Banner
            {
                Name = "Banner2",
                ResourcePath = "/content/resources/assets/images/banner/1.png"
            },new Banner
            {
                Name = "Banner3",
                ResourcePath = "/content/resources/assets/images/banner/1.png"
            },new Banner
            {
                Name = "Banner4",
                ResourcePath = "/content/resources/assets/images/banner/1.png"
            },
        };
    }

    public class FooterViewModel
    {
        public Branch Branch { get; set; } = new Branch
        {
            OfficeName = "Văn phòng chính",
            Address = "192/68 Nguyễn Oanh, ....",
            AddressMap = "iframe or some format text show on map"
        };
    }

    public class SubscribeModel
    {
        [Required]
        public string Email { get; set; }
    }
}