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
var sumEvenGrandparent = function(root) {
    return iterateTree(root, 1, 1);
};

var iterateTree = function (node, parent, grandparent) {
    if (node == null) return 0;
    return iterateTree(node.left, node.val, parent) + iterateTree(node.right, node.val, parent) + (grandparent % 2 == 0 ? node.val : 0);
}