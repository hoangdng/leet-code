/**
 * @param {number[][]} points
 * @return {number}
 */
var minTimeToVisitAllPoints = function(points) {
    var range = 0;
    for (let i = 1; i < points.length; i++) {
        var dx = Math.abs(points[i][0] - points[i - 1][0]);
        var dy = Math.abs(points[i][1] - points[i - 1][1]);
        range += Math.max(dx, dy);
    }
    return range;
};