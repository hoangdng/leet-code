/**
 * @param {number} num
 * @return {number}
 */
var numberOfSteps = (num) => {
    if (num === 1) {
        return 1;
    }
    if (num % 2 === 0) {
        return 1 + numberOfSteps(num / 2);
    } else {
        return 1 + numberOfSteps(num - 1);
    }
};

