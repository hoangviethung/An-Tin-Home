import Cookie from "./lib/Cookie";
import Loading from "./lib/Loading";

const mainSlider = () => {
	var swiper = new Swiper('.block-main-banner .swiper-container', {
		loop: true,
		speed: 1000,
		autoplay: {
			delay: 3000,
			disableOnInteraction: false,
		},
		grabCursor: true,
		watchSlidesProgress: true,
		mousewheelControl: true,
		keyboardControl: true,
		pagination: {
			el: '.main-banner .swiper-pagination',
			type: 'bullets',
			clickable: true,
		},
	})
}

// CHECK LAYOUT CÓ BANNER KHÔNG
const checkLayoutBanner = () => {
	const mainSlider = $('.main-banner');
	const heightHeader = $('header').outerHeight();
	if (mainSlider.length >= 1 && mainSlider.css('display') == 'block') {
		mainSlider.css('padding-top', heightHeader);
	} else {
		$('.main-banner').css('padding-top', heightHeader);
	}
}

const sliderPartner = () => {
	var swiper = new Swiper('.slider-partner .swiper-container', {
		loop: true,
		speed: 1000,
		autoplay: {
			delay: 3000,
			disableOnInteraction: false,
		},
		grabCursor: true,
		watchSlidesProgress: true,
		mousewheelControl: true,
		keyboardControl: true,
		slidesPerView: 2,
		breakpoints: {
			768: {
				slidesPerView: 4
			}
		}
	})
}

const sliderFacilities = () => {
	var swiper = new Swiper('.slider-facilities .swiper-container', {
		loop: true,
		speed: 1000,
		autoplay: {
			delay: 3000,
			disableOnInteraction: false,
		},
		grabCursor: true,
		watchSlidesProgress: true,
		mousewheelControl: true,
		keyboardControl: true,
		slidesPerView: 1,
		breakpoints: {
			768: {
				slidesPerView: 2,
			}
		}
	})
}

const sliderAboutPartner = () => {
	var swiper = new Swiper('.slider-about-partner .swiper-container', {
		loop: true,
		speed: 1000,
		autoplay: {
			delay: 3000,
			disableOnInteraction: false,
		},
		spaceBetween: 60,
		grabCursor: true,
		watchSlidesProgress: true,
		mousewheelControl: true,
		keyboardControl: true,
		slidesPerView: 1,
		breakpoints: {
			768: {
				slidesPerView: 2,
			},
			1140: {
				slidesPerView: 3,
			}
		},
		navigation: {
			nextEl: '.slider-about-partner .swiper-button-next',
			prevEl: '.slider-about-partner .swiper-button-prev',
		},
	})
}

const sliderProjects = () => {
	var swiper = new Swiper('.slider-projects .swiper-container', {
		loop: true,
		speed: 1000,
		autoplay: {
			delay: 3000,
			disableOnInteraction: false,
		},
		spaceBetween: 60,
		grabCursor: true,
		watchSlidesProgress: true,
		mousewheelControl: true,
		keyboardControl: true,
		slidesPerView: 1,
		breakpoints: {
			768: {
				slidesPerView: 2,
				spaceBetween: 10,
			},
			1140: {
				slidesPerView: 3,
			}
		},
		navigation: {
			nextEl: '.slider-projects .swiper-button-next',
			prevEl: '.slider-projects .swiper-button-prev',
		},
	})
}

const ajaxMailFooter = () => {
	$('footer .block-form button').on('click', function(e) {
		e.preventDefault();
		const url = $(this).attr('data-url');
		const email = $('footer .block-form input.email').val();
		$.ajax({
			type: "POST",
			url: url,
			data: {
				email: email,
			},
			success: function(res) {
				if (res.Code === 200) {
					alert(res.Message)
				} else {
					alert(res.Message)
				}
			}
		});
	});
}

const toggleMenuMobile = () => {
	$('.toggle-menu.mobile').on('click', function() {
		$(this).toggleClass('active');
		$(this).siblings('.main-nav').toggleClass('active');
		$('body').toggleClass('disabled')
		$('#overlay').toggleClass('active');
		$('.sub-menu').removeClass('active');
	});

	$('#overlay').on('click', function() {
		$(this).removeClass('active');
		$('body').removeClass('disabled')
		$('.main-nav').removeClass('active');
		$('.sub-menu').removeClass('active');
		$('.toggle-menu.mobile').removeClass('active');
	})
}

const menuMobile = () => {
	const heightLogo = $('header .logo').innerHeight();
	$('header .main-nav').css('top', heightLogo);
}

const setHeightOverFolowBySomeElement = (selector) => {
	$(selector).each(function() {
		const heightGet = $(this).find('[data-getHeight]').innerHeight();
		const heightSet = $(this).find('[data-setHeight]');
		const responsive = heightSet.attr('data-setHeight');
		if (window.innerWidth > responsive) {
			heightSet.css('max-height', heightGet)
		}
	})
}

document.addEventListener('DOMContentLoaded', () => {
	Loading();
	// SLIDER
	mainSlider();
	sliderPartner();
	sliderFacilities();
	sliderProjects();
	// checkLayoutBanner();
	ajaxMailFooter();
	menuMobile();
	toggleMenuMobile();
	setHeightOverFolowBySomeElement('.about-2, .about-3, .list-news');
	sliderAboutPartner();
});

document.addEventListener('resize', () => {
	setHeightOverFolowBySomeElement('.about-2, .about-3, .list-news');
})