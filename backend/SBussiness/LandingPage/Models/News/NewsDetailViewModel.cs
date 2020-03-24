using MainProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.News
{
    public class NewsDetailViewModel
    {
        public Article Article { get; set; } = new Article
        {
            Title = "<h3 class=\"title\">LOREM IPSUM DOLOR SIT AMET, CONSECTETUER ADIPISCING ELIT. AENEAN MASSA.</h3>",
            Body = "<div class=\"description\"><div class=\"ckeditor desc-item-detail\">" +
            "<p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor. " +
            "Aenean massa.Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, " +
            "ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, " +
            "nascetur Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor.Aenean massa. " +
            "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec, " +
            "pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur</p>" +
            "<p>Donec quam felis, " +
            "ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis.</p>" +
            "<img src = \"/content/resources/assets/images/news/news-detail.png\" alt= \"\" >" +
            "<p> Aliquam lorem ante, dapibus in, viverra quis, " +
            "feugiat a, tellus.Phasellus viverra nulla ut metus varius laoreet.Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. " +
            "Curabitur ullamcorper ultricies nisi. Nam eget dui.Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, " +
            "sit amet adipiscing sem neque sed ipsum.Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem.Maecenas nec odio et ante tincidunt tempus. " +
            "Donec vitae sapien ut libero venenatis faucibus.</p>" +
            "<p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. " +
            "Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec, pellentesque eu, " +
            "pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nasceturLorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
            "Aenean commodo ligula eget dolor.Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, " +
            "ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur</p>" +
            "<p>Donec quam felis, " +
            "ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis.Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
            "Aenean commodo ligula eget dolor.Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, " +
            "ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nasceturLorem ipsum dolor sit amet, " +
            "consectetuer adipiscing elit.Aenean commodo ligula eget dolor.Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, " +
            "nascetur ridiculus mus.Donec quam felis, ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, " +
            "nascetur Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor. Aenean massa. " +
            "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec, " +
            "pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur Donec quam felis, ultricies nec, " +
            "pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis.Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo " +
            "ligula eget dolor.Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec, " +
            "pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur.</p>" +
            "<p>Donec quam felis, ultricies nec, pellentesque " +
            "eu, pretium quis, semCum sociis natoque penatibus etmagnis.Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor." +
            "Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec, pellentesque eu, " +
            "pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nasceturLorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean " +
            "commodo ligula eget dolor.Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec," +
            " pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur Lorem ipsum dolor sit amet, consectetuer adipiscing " +
            "elit.Aenean commodo ligula eget dolor.Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis," +
            " ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur Donec quam felis, ultricies nec, " +
            "pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis.Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor." +
            "Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec, pellentesque eu, pretium quis, " +
            "semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur.</p></div></div>"
        };
        public List<Article> Slideses { get; set; } = new List<Article>
        {
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/01.png"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/02.png"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/03.png"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/04.png"
            },
            new Article
            {
                ImageDefault = "/content/resources/assets/images/news/05.png"
            }
        };
    }
}