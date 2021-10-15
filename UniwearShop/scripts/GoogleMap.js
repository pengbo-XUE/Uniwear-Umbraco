function initMap() {
    var myMapCenter = { lat: -37.82183713408313, lng: 144.96061676199554 };



    var map = new google.maps.Map(document.getElementById('map-canvas'), {
        center: myMapCenter,
        zoom: 10
    });


    function markStore(storeInfo) {


        var marker = new google.maps.Marker({
            map: map,
            position: storeInfo.location,
            title: storeInfo.name
        });


        marker.addListener('click', function () {
            showStoreInfo(storeInfo);
        });
    }


    function showStoreInfo(storeInfo) {
        var info_div = document.getElementById('info_div');
        info_div.innerHTML = 'Store name: '
            + storeInfo.name
            + '<br>Hours: ' + storeInfo.hours;
    }

    var stores = [
        {
            name: 'Knox Feild Store',
            location: { lat: -37.86879416645634, lng: 145.23965179913287 },
            hours: '9AM to 6PM'
        },
        {
            name: 'South Melbourne Store',
            location: { lat: -37.82972899994847, lng: 144.96619829444438 },
            hours: '10AM to 6PM'
        }
    ];

    stores.forEach(function (store) {
        markStore(store);
    });

}