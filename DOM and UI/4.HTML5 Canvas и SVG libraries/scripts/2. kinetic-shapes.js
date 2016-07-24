/* globals Kinetic */
(function() {
    window.onload = function() {
        var blob, circle, curvedLine, layer, polygon, rect, stage, straightLine;
        stage = new Kinetic.Stage({
            container: 'container',
            width: 700,
            height: 550
        });
        layer = new Kinetic.Layer();
        rect = new Kinetic.Rect({
            x: 50,
            y: 350,
            width: 57,
            height: 93,
            fill: 'yellow',
            stroke: '#ccc'
        });

        circle = new Kinetic.Circle({
            x: 200,
            y: 350,
            radius: 45,
            fill: 'purple',
            stroke: 'blue',
            strokeWidth: 3
        });

        straightLine = new Kinetic.Line({
            points: [50, 50, 200, 50, 200, 200, 50, 200, 50, 100, 150, 100, 150, 150, 100, 150],
            stroke: 'lightblue',
            strokeWidth: 2,
            lineJoin: 'round'
        });

        curvedLine = new Kinetic.Line({
            points: [250, 50, 400, 50, 400, 200, 250, 200, 250, 100, 350, 100, 350, 150, 300, 150],
            stroke: 'green',
            strokeWidth: 2,
            lineJoin: 'round',
            tension: 1
        });

        polygon = new Kinetic.Line({
            points: [300, 300, 450, 300, 450, 350, 400, 350, 400, 500, 350, 500, 350, 350, 300, 350],
            stroke: 'green',
            fill: 'yellowgreen',
            strokeWidth: 2,
            lineJoin: 'round',
            closed: true
        }).rotate();

        blob = new Kinetic.Line({
            points: [500, 300, 650, 300, 650, 350, 600, 350, 600, 500, 550, 500, 550, 350, 500, 350],
            stroke: 'blue',
            fill: 'purple',
            strokeWidth: 2,
            lineJoin: 'round',
            closed: true,
            tension: 0.5,
            draggable: true //very cool option
                //scaleX: 0.9
        }); //.rotate(25);

        layer.add(rect);
        layer.add(circle);
        layer.add(straightLine);
        layer.add(curvedLine);
        layer.add(polygon);
        layer.add(blob);

        polygon.on('mouseover', function() {
            if (this.fill() === 'yellowgreen') {
                this.fill('pink');
            } else {
                this.fill('yellowgreen');
            }
            layer.draw(); // to update the changes 
        });

        blob.on('click', function() { //add an event 
            this.fill('pink');
        });

        document.getElementById('container').addEventListener('mouseover', function() {
            layer.find('Circle')
                .forEach(function(circle) {
                    if (circle.fill() === 'purple') {
                        circle.fill('blue');
                    } else {
                        circle.fill('purple');
                    }
                    layer.draw(); //
                });
        }); //event on every circle with color purple 
        return stage.add(layer);
    };
}).call(this);