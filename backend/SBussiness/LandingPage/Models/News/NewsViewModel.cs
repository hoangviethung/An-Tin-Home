﻿using MainProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.News
{
    public class NewsViewModel
    {
        public List<Article> Articles { get; set; } = new List<Article>
        {
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/01.png",
                Title = "<h3 class=\"lcl lcl-2\">LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. " +
                "1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1</h3>",
                Description = "<p class=\"lcl lcl-5\">Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni</p>"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/02.png",
                Title = "<h3 class=\"lcl lcl-2\">LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. " +
                "1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1</h3>",
                Description = "<p class=\"lcl lcl-5\">Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni</p>"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/03.png",
                Title = "<h3 class=\"lcl lcl-2\">LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. " +
                "1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1</h3>",
                Description = "<p class=\"lcl lcl-5\">Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni</p>"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/04.png",
                Title = "<h3 class=\"lcl lcl-2\">LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. " +
                "1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1</h3>",
                Description = "<p class=\"lcl lcl-5\">Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni</p>"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/05.png",
                Title = "<h3 class=\"lcl lcl-2\">LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. " +
                "1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1</h3>",
                Description = "<p class=\"lcl lcl-5\">Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni</p>"
            }
        };
        public Category Category { get; set; } = new Category
        {
            Title = "TIN TỨC",
            Description = "<h3 class=\"wow fadeInUp\" data-wow-delay=\".2s\">AN TÍN HOMES</h3>" +
            "<p class=\"lcl lcl-2\">Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, " +
            "venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium.</p>"
        };
    }
}