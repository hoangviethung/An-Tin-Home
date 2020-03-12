let mapSelector = document.querySelector('#map');
let dealerLocatorList = document.querySelector('.dealer-locator-list .list');
let map, lastItemClickedIndex, locations, infoWindow, markers = [];
let mapOption = {
	zoom: 12,
	styles: [{
			"featureType": "all",
			"elementType": "labels",
			"stylers": [{
				"visibility": "off"
			}]
		},
		{
			"featureType": "administrative",
			"elementType": "labels",
			"stylers": [{
				"visibility": "on"
			}]
		},
		{
			"featureType": "landscape",
			"elementType": "all",
			"stylers": [{
				"visibility": "on"
			}]
		},
		{
			"featureType": "landscape",
			"elementType": "geometry",
			"stylers": [{
				"visibility": "on"
			}]
		},
		{
			"featureType": "landscape",
			"elementType": "geometry.fill",
			"stylers": [{
					"visibility": "on"
				},
				{
					"color": "#f1fff1"
				}
			]
		},
		{
			"featureType": "landscape.man_made",
			"elementType": "geometry.fill",
			"stylers": [{
				"color": "#b4ecbd"
			}]
		},
		{
			"featureType": "road",
			"elementType": "all",
			"stylers": [{
					"visibility": "on"
				},
				{
					"color": "#d8e8da"
				}
			]
		},
		{
			"featureType": "road",
			"elementType": "labels",
			"stylers": [{
				"visibility": "on"
			}]
		},
		{
			"featureType": "road",
			"elementType": "labels.text",
			"stylers": [{
				"visibility": "on"
			}]
		},
		{
			"featureType": "road.highway",
			"elementType": "all",
			"stylers": [{
				"visibility": "on"
			}]
		},
		{
			"featureType": "road.highway",
			"elementType": "labels",
			"stylers": [{
				"visibility": "on"
			}]
		},
		{
			"featureType": "road.highway",
			"elementType": "labels.text",
			"stylers": [{
				"visibility": "on"
			}]
		},
		{
			"featureType": "road.highway",
			"elementType": "labels.text.fill",
			"stylers": [{
				"visibility": "on"
			}]
		},
		{
			"featureType": "road.local",
			"elementType": "all",
			"stylers": [{
				"visibility": "on"
			}]
		},
		{
			"featureType": "road.local",
			"elementType": "labels",
			"stylers": [{
				"visibility": "on"
			}]
		},
		{
			"featureType": "road.local",
			"elementType": "labels.text",
			"stylers": [{
				"visibility": "on"
			}]
		},
		{
			"featureType": "road.local",
			"elementType": "labels.text.fill",
			"stylers": [{
					"visibility": "on"
				},
				{
					"color": "#467855"
				}
			]
		},
		{
			"featureType": "transit",
			"elementType": "all",
			"stylers": [{
				"visibility": "off"
			}]
		},
		{
			"featureType": "water",
			"elementType": "all",
			"stylers": [{
				"color": "#effefd"
			}]
		}
	]
};

const addMarkers = () => {
	markers = [];
	const bounds = new google.maps.LatLngBounds();
	locations.forEach((location, index) => {
		let locationLatLng = new google.maps.LatLng(location.lat, location.lng);
		let marker = new google.maps.Marker({
			map: map,
			title: location.title,
			position: locationLatLng,
			icon: location.icon,
		});
		bounds.extend(marker.position);
		markers.push(marker);
		showInfoMarkerOnMap(marker, index);
	});

	map.fitBounds(bounds);
};

const showInfoMarkerOnMap = (marker, index) => {
	google.maps.event.addListener(marker, 'click', function() {
		infoWindow.setContent(`
				<h3>${locations[index].title}</h3>
				<p>${locations[index].address}</p>
				<p>${locations[index].phone}</p>
			`);
		lastItemClickedIndex = index;
		infoWindow.open(map, marker);
		map.panTo(marker.getPosition());
		map.setZoom(12);
	})
	google.maps.event.addListener(map, 'click', function() {
		infoWindow.close();
	})
};

const getLocationList = () => {
	if (dealerLocatorList) {
		// dealerLocatorList.innerHTML = '';
		// markers.forEach((marker, index) => {
		// 	if (map.getBounds().contains(marker.getPosition())) {
		// 		const newMarker = document.createElement('div');
		// 		newMarker.classList.add('dealer-locator-item');
		// 		newMarker.innerHTML = `
		// 				<h3>${locations[index].title}</h3>
		// 				<p>${locations[index].address}</p>
		// 				<p>${locations[index].phone}</p>
		// 			`;
		// 		newMarker.setAttribute('marker-id', `${index}`);
		// 		newMarker.addEventListener('click', () => {
		// 			lastItemClickedIndex = index;
		// 			const markerIndex = newMarker.getAttribute('marker-id');
		// 			google.maps.event.trigger(markers[markerIndex], 'click');
		// 		});
		// 		dealerLocatorList.appendChild(newMarker);
		// 	}
		// });

		dealerLocatorList.innerHTML = '';
		markers.forEach((marker, index) => {
			const newMarker = document.createElement('div');
			newMarker.classList.add('dealer-locator-item');
			newMarker.innerHTML =
				`
				<h3>${locations[index].title}</h3>
				<p>${locations[index].address}</p>
				<p>${locations[index].phone}</p>
			`;
			newMarker.setAttribute('marker-id', `${index}`);
			newMarker.addEventListener('click', () => {
				lastItemClickedIndex = index;
				const markerIndex = newMarker.getAttribute('marker-id');
				google.maps.event.trigger(markers[markerIndex], 'click');
			});
			dealerLocatorList.appendChild(newMarker);
		})
	}
};

const initialize = () => {
	locations = locationsInput;
	infoWindow = new google.maps.InfoWindow();
	map = new google.maps.Map(mapSelector, mapOption);
	addMarkers();
	let listener = google.maps.event.addListener(map, 'idle', () => {
		if (map.getZoom() > 12) {
			map.setZoom(12);
		}
		google.maps.event.removeListener(listener);
	});
	google.maps.event.addListener(map, 'bounds_changed', getLocationList);
};

if (mapSelector) {
	google.maps.event.addDomListener(window, 'load', initialize);
	if (dealerLocatorList) {
		getLocationList();
	}
}