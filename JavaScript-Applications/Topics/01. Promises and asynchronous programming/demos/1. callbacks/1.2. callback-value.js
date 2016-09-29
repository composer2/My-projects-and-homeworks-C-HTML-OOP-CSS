(function () {
    function dropBomb(success) {
        setTimeout(function () {
            document.getElementById('bomb').innerHTML = 'BOOM';

            var dropDateTime = new Date();

            success(dropDateTime);
        }, 2000);
    }

    function reportBombDrop(time) {
        document.getElementById('bomb-report').innerHTML = "Bomb dropped at "
            + time.getHours() + ':' + time.getMinutes() + ':' + time.getSeconds();
    }

    document.getElementById("drop-bomb").onclick = function () {
                dropBomb(reportBombDrop);
    };
} ());