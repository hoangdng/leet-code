/**
 * @param {string} J
 * @param {string} S
 * @return {number}
 */
var numJewelsInStones = function (J, S) {
    var countAppearance = S.split("").reduce((count, char) => {
        count[char] ? count[char]++ : count[char] = 1;
        return count;
    }, {});
    var result = 0;
    for (let i = 0; i < J.length; i++) {
        if (J.charAt(i) in countAppearance)
            result+=countAppearance[J.charAt(i)];
    }
    return result;
};

