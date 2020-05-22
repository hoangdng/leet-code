/**
 * @param {number[]} nums
 * @return {number[]}
 */
var smallerNumbersThanCurrent = function (nums) {
    var sortedNums = nums.slice(0).sort((a, b) => a - b);
    return nums.map(num => sortedNums.indexOf(num));
};

