/**
 * @param {string} s
 * @return {number}
 */
var balancedStringSplit = function(s) {
    var result = 0;
    var count = 0;
    for (let i = 0; i < s.length; i++) {
        if (s.charAt(i) == 'L')
        {
            count++;
        }    
        else {
            count--;
        }
        if (count == 0)
        {
            result++;
        }
    }
    return result;
};

