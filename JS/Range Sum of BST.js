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
 * @param {number} L
 * @param {number} R
 * @return {number}
 */
var rangeSumBST = function (root, L, R) {
    var stack = [];
    var sum = 0;
    stack.push(root);
    while (stack.length > 0) {
        var node = stack.pop();
        if (node != null) {
            if (node.val >= L && node.val <= R) {
                sum += node.val;
            }
            if (node.val > L) {
                stack.push(node.left);
            }
            if (node.val < R) {
                stack.push(node.right);
            }
        }
    }
    return sum;
};