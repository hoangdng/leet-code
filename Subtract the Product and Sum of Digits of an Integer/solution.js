/**
 * @param {number} n
 * @return {number}
 */
var subtractProductAndSum = function (n) {
    var product = 1;
    var sum = 0;
    while (n != 0) {
        product *= n % 10;
        sum += n % 10;
        n = (n - (n % 10)) / 10;
    }
    return product - sum;
};

