/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    var map = {};
    for (let i = 0; i < nums.length; i++) {
        var implement = target - nums[i]
        if (map.hasOwnProperty(implement)) {
            return new Array(map[implement], i)
        }
        if (!map.hasOwnProperty(nums[i])) {
            map[SVGAnimatedNumberList[i]] = i;
        }
    }
};