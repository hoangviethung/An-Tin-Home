using MainProject.Core;
using MainProject.SBussiness.LandingPage.Models.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View(new NewsViewModel());
        }
        public ActionResult Detail()
        {
            return View(new NewsDetailViewModel());
        }
        public ActionResult Introduction()
        {
            return View(new IntroductionViewModel());
        }
        //GET: OFFICE
        public ActionResult Office()
        {
            return View(new NewsViewModel()
            {
                Category = new Category
                {
                    Title = "CHO THUÊ VĂN PHÒNG",
                    Description = "Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. " +
                            "In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium."
                },
                Articles = new List<Article>
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
                }
            });
        }
        public ActionResult OfficeDetail()
        {
            return View(new NewsDetailViewModel()
            {
                Article = new Article
                {
                    Title = "LOREM IPSUM DOLOR SIT AMET, CONSECTETUER ADIPISCING ELIT. AENEAN MASSA.",
                    Body = "<p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor. " +
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
                            "semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur.</p>"
                },
                Articles = new List<Article>
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
                }
            });
        }
    }
}