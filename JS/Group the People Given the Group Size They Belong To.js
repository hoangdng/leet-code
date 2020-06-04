/**
 * @param {number[]} groupSizes
 * @return {number[][]}
 */
var groupThePeople = function (groupSizes) {
    var group = [];
    var result = [];
    for (let i = 0; i < groupSizes.length; i++) {
        if (!group[groupSizes[i]]) {
            group[groupSizes[i]] = [];
        }
        group[groupSizes[i]].push(i);
        if (group[groupSizes[i]].length == groupSizes[i]) {
            result.push(group[groupSizes[i]]);
            group[groupSizes[i]] = [];
        }
    }
    return result;
};

