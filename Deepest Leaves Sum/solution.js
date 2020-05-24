/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number}
 */
var deepestLeavesSum = function (root) {
    var sum = 0;
    var deepestLevel = 0;
    var traverse = function (node, level) {
        if (node == null) {
            return;
        }
        if (level == deepestLevel) {
            sum += node.val;
        }
        if (level > deepestLevel) {
            deepestLevel = level;
            sum = node.val;
        }
        traverse(node.left, level + 1);
        traverse(node.right, level + 1);
    }
    traverse(root, 0);
    return sum;
}


console.log(deepestLeavesSum([1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8]));