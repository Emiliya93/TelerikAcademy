var distance,
    pointOne = {
        x: 12,
        y: 14
    },
    pointTwo = {
        x: 10,
        y: 2
    };

distance = calculateDistanceBetweenTwoPoints(pointOne, pointTwo);
console.log('----------------------------------------------------');
console.log('Task 1:')
console.log('Distance between the two points: ' + distance);
console.log('----------------------------------------------------');

function calculateDistanceBetweenTwoPoints(firstPoint, secondPoint) {
    var dx = secondPoint.x - firstPoint.x,
        dy = secondPoint.y - firstPoint.y;

    return Math.sqrt(dx * dx + dy * dy);
}