using MainProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.News
{
    public class OfficeDetailViewModel
    {
        public Article Section1 { get; set; } = new Article
        {
            Title = "Văn phòng cho thuê - Diện tích 30m2",
            Description = "<div class=\"block-tab-offices-detail\">" +
            "<div class=\"tab-container\">" +
            "<ul class=\"list-tab\">" +
            "<li class=\"item wow fadeInLeft active\" data-wow-delay=\".2s\" toggle-for=\"tab-01\">" +
            "<div class=\"link\">vị trí</div></li>" +
            "<li class=\"item wow fadeInLeft\" data-wow-delay=\".4s\" toggle-for=\"tab-02\"><div class=\"link\">cơ sở vật chất</div></li>" +
            "<li class=\"item wow fadeInLeft\" data-wow-delay=\".6s\" toggle-for=\"tab-03\"><div class=\"link\">hạ tầng kĩ thuật</div></li>" +
            "<li class=\"item wow fadeInLeft\" data-wow-delay=\".8s\" toggle-for=\"tab-04\"><div class=\"link\">dịch vụ tiện ích</div></li>" +
            "<li class=\"item wow fadeInLeft\" data-wow-delay=\"1s\" toggle-for=\"tab-05\"> <div class=\"link\">thư viện hình ảnh</div></li>" +
            "</ul>" +
            "<div class=\"tab-content\">" +
            "<div class=\"content\" tab-id=\"tab-01\">" +
            "<div class=\"description\"> <div class=\"ckeditor desc-item-detail\">" +
            "<p>Địa chỉ: Harvest Tower - 12 Lê Thánh Tôn, P.Bến Nghé, Quận 1, TP.HCM</p>" +
            "</div>" +
            "</div>" +
            "<div id =\"map\"></div>" +
            "</div>" +
            "<div class=\"content\" tab-id=\"tab-02\">" +
            "<div class=\"ckeditor desc-item-detail\">" +
            "<p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor.Aenean massa.Cum sociis natoque penatibus et magnis dis parturient montes," +
            "nascetur ridiculus mus.Donec quam felis, ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur Lorem ipsum dolor sit amet," +
            " consectetuer adipiscing elit.Aenean commodo ligula eget dolor.Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec, " +
            "pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur </p>" +
            "<p> Donec quam felis, ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis.</p>" +
            "<img src =\"/content/resources/assets/images/news/news-detail.png\" alt= \"\">" +
            "<p> Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus.Phasellus viverra nulla ut metus varius laoreet.Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue." +
            "Curabitur ullamcorper ultricies nisi. Nam eget dui.Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum.Nam quam nunc, " +
            "blandit vel, " +
            "luctus pulvinar, hendrerit id, lorem.Maecenas nec odio et ante tincidunt tempus.Donec vitae sapien ut libero venenatis faucibus. </p>" +
            "<p>Lorem ipsum dolor sit amet, " +
            "consectetuer adipiscing elit.Aenean commodo ligula eget dolor.Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, " +
            "ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nasceturLorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
            "Aenean commodo ligula eget dolor.Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec, pellentesque eu, " +
            "pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur </p>" +
            "</div>" +
            "</div>" +
            "<div class=\"content\" tab-id=\"tab-03\">" +
            "<div class=\"ckeditor desc-item-detail\">" +
            "<p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor.Aenean massa.Cum sociis natoque penatibus et magnis dis " +
            "parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur Lorem ipsum " +
            "dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor.Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis," +
            " ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur</p>" +
            "<p>Donec quam felis, ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis.</p>" +
            "<img src = \"/content/resources/assets/images/news/news-detail.png\" alt= \"\">" +
            "<p>Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus.Phasellus viverra nulla ut metus varius laoreet.Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue.Curabitur ullamcorper ultricies nisi. Nam eget dui.Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, " +
            "sem quam semper libero, sit amet adipiscing sem neque sed ipsum.Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem.Maecenas nec odio et ante tincidunt tempus." +
            "Donec vitae sapien ut libero venenatis faucibus.</p>" +
            "<p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit.Aenean commodo ligula eget dolor.Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, " +
            "nascetur ridiculus mus.Donec quam felis, ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nasceturLorem ipsum dolor sit amet, " +
            "consectetuer adipiscing elit.Aenean commodo ligula eget dolor.Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, " +
            "ultricies nec, pellentesque eu, pretium quis, semCum sociis natoque penatibus etmagnis dis parturient montes, nascetur</p>" +
            "</div>" +
            "</div>" +
            "<div class=\"content\" tab-id=\"tab-04\">" +
            "<div class=\"ckeditor desc-item-detail\">" +
            "<ul>" +
            "<li>" +
            "<p>+ Hệ thống đèn, máy lạnh có sẵn</p>" +
            "</li>" +
            "<li>" +
            "<p>+ Camera quan sát, bảo vệ trực tại công ty 24/24</p></li>" +
            "<li>" +
            "<p>+ Dịch vụ vệ sinh, hút thảm, dọn rác sinh hoạt hàng ngày tại văn phòng</p></li><li>" +
            "<p>+ Giá cả: cạnh tranh</p></li></ul></div></div><div class=\"content\" tab-id=\"tab-05\"><div class=\"list-image-detail\"><div class=\"item\">" +
            "<a href = \"/content/resources/assets/images/news/01.png\" data-fancybox=\"list-images\">" +
            "<img class=\"ofcv lazyload blur-up\" data-src=\"/content/resources/assets/images/news/01.png\" alt=\"\"></a></div>" +
            "<div class=\"item\"><a href = \"/content/resources/assets/images/news/02.png\" data-fancybox=\"list-images\">" +
            "<img class=\"ofcv lazyload blur-up\" data-src=\"/content/resources/assets/images/news/02.png\" alt=\"alt\"></a></div>" +
            "<div class=\"item\">" +
            "<a href = \"/content/resources/assets/images/news/03.png\" data-fancybox=\"list-images\">" +
            "<img class=\"ofcv lazyload blur-up\" data-src=\"/content/resources/assets/images/news/03.png\" alt=\"alt\"></a></div>" +
            "<div class=\"item\"><a href = \"/content/resources/assets/images/news/04.png\" data-fancybox=\"list-images\">" +
            "<img class=\"ofcv lazyload blur-up\" data-src=\"/content/resources/assets/images/news/04.png\" alt=\"alt\"></a></div>" +
            "<div class=\"item\"><a href = \"/content/resources/assets/images/news/05.png\" data-fancybox=\"list-images\">" +
            "<img class=\"ofcv lazyload blur-up\" data-src=\"/content/resources/assets/images/news/05.png\" alt=\"alt\"></a></div>" +
            "</div><!-- DANH SÁCH HÌNH ẢNH POPUP - GẮN ĐÚNG LINK ẢNH + DATA FANCYBOX-->" +
            "<div class=\"d-n\"><a href = \"/content/resources/assets/images/news/01.png\" data-fancybox=\"list-images\">" +
            "<img src = \"/content/resources/assets/images/news/01.png\" alt=\"\"></a>" +
            "<a href = \"/content/resources/assets/images/news/02.png\" data-fancybox=\"list-images\">" +
            "<img src = \"/content/resources/assets/images/news/02.png\" alt=\"\"></a>" +
            "<a href = \"/content/resources/assets/images/news/03.png\" data-fancybox=\"list-images\">" +
            "<img src = \"/content/resources/assets/images/news/03.png\" alt=\"\"></a>" +
            "<a href = \"/content/resources/assets/images/news/04.png\" data-fancybox=\"list-images\">" +
            "<img src = \"/content/resources/assets/images/news/04.png\" alt=\"\"></a>" +
            "<a href = \"/content/resources/assets/images/news/05.png\" data-fancybox=\"list-images\">" +
            "<img src = \"/content/resources/assets/images/news/05.png\" alt=\"\">" +
            "</a>" +
            "</div>" +
            "</div>" +
            "</div>" +
            "</div>" +
            "</div>"
        };
    }
}