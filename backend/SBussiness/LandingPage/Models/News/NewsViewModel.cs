using MainProject.Core;
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
                Title = "LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT." +
                "1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1",
                Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/02.png",
                Title = "LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT." +
                "1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1",
                Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/03.png",
                Title = "LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT." +
                "1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1",
                Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/04.png",
                Title = "LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT." +
                "1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1",
                Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/05.png",
                Title = "LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT." +
                "1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1 LOREM IPSUM DOLOR SIT AMET, CON SECTE TUER ELIT. 1",
                Body = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni et magni Lorem ipsum dolor sit amet, " +
                "consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magni"
            }
        };
        public Category NewsCategory { get; set; } = new Category
        {
            Title = "TIN TỨC",
            Description ="Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, " +
                            "venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium."
        };
    }
}