/**
 * @param {number[]} nums
 * @return {number}
 */
var findMaxConsecutiveOnes = function (nums) {
    var countArr = [];
    var count = 0;
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] == 1) {
            count++;
        }
        if (nums[i] == 0 || i == nums.length - 1) {
            countArr.push(count);
            count = 0;
        }
    }
    return Math.max(...countArr);
};

console.log(findMaxConsecutiveOnes([1, 0, 1, 1, 0, 1]));