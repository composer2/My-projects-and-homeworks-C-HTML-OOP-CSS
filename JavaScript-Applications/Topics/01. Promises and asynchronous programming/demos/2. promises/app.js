(function () {
    var location = document.getElementById('location-element');

    function getGeoLocationPositionPromise() {
        return new Promise((resolve, reject) => {
            navigator.geolocation.getCurrentPosition(
                (position) => { resolve(position) },
                (error) => { reject(error) });
        });
    }

    function parseLatAndLongCoords(geolocationPosition) {
        if (geolocationPosition.coords) {
            return {
                lat: geolocationPosition.coords.latitude,
                long: geolocationPosition.coords.longitude
            };
        } else {
            throw new Error("Can't get your coords");
        }
    }

    function createGeolocationImage(coords) {
        let img = document.createElement('img'),
            imgSrc = "http://maps.googleapis.com/maps/api/staticmap?center=" + coords.lat + "," + coords.long + "&zoom=13&size=500x500&sensor=false";
        img.setAttribute('src', imgSrc);
        location.appendChild(img);

    }

    function fadeOutPromise(selector, time) {
        return new Promise((resolve, reject) => {
            var target = $(selector);
            target.fadeOut(time, null, function () {
                resolve(target);
            });
        });
    }

    getGeoLocationPositionPromise()
        .then(parseLatAndLongCoords)
        .then(createGeolocationImage);

    setInterval(function () {
        var currentDateTime = new Date();
        document.getElementById("clock").innerHTML = currentDateTime.getHours() + ":" + currentDateTime.getMinutes() + ":" + currentDateTime.getSeconds();
    }, 1000);
} ());