



//!!! START in live-server 
//!!! if the net is slow will respond with "Unable to retrieve your location";
//!!! if the location is blocked it will respond with "Unable to retrieve your location"

(function () {

    var output = document.getElementById("out");
    output.innerHTML = "<p>Locating…</p>";

    function geoFindMe() {
        return new Promise(function (resolve, reject) {
            navigator.geolocation.getCurrentPosition(
                function (position) {
                    resolve(position);
                },
                function (error) {
                    reject(error);
                });
        });
    }

    function getLocationAndRenderIt(position) {
        var latitude = position.coords.latitude;
        var longitude = position.coords.longitude;

        output.innerHTML = '<p>Latitude is ' + latitude + '° <br>Longitude is ' + longitude + '°</p>';

        var img = new Image();
        img.src = "https://maps.googleapis.com/maps/api/staticmap?center=" + latitude + "," + longitude + "&zoom=13&size=300x300&sensor=false";

        output.appendChild(img);
    }

    function getErrorAndRenderIt() {
        if (!navigator.geolocation) {
            output.innerHTML = "<p>Geolocation is not supported by your browser</p>";
            return;
        }
        output.innerHTML = "Unable to retrieve your location";
    }


    geoFindMe()
        .then(getLocationAndRenderIt)
        .catch(getErrorAndRenderIt);
} ());