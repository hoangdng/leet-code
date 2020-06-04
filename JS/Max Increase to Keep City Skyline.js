/**
 * @param {number[][]} grid
 * @return {number}
 */
var maxIncreaseKeepingSkyline = function (grid) {
    var maxRow = new Array(grid.length).fill(0);
    var maxCol = new Array(grid.length).fill(0);
    for (let i = 0; i < grid.length; i++) {
        for (let j = 0; j < grid.length; j++) {
            maxRow[i] = Math.max(maxRow[i], grid[i][j]);
            maxCol[j] = Math.max(maxCol[j], grid[i][j]);
        }
    }
    var result = 0;
    for (let i = 0; i < grid.length; i++) {
        for (let j = 0; j < grid.length; j++) {
            result += Math.min(maxRow[i] - grid[i][j], maxCol[j] - grid[i][j]);
        }
    }
    return result;
};
