package TwoSum;

import java.util.HashMap;

/**
 * @author hupan
 * ����һ���������� nums ��һ��Ŀ��ֵ target�������ڸ��������ҳ���ΪĿ��ֵ���� ���� ���������������ǵ������±ꡣ
 * ����Լ���ÿ������ֻ���Ӧһ���𰸡����ǣ��㲻���ظ��������������ͬ����Ԫ�ء�
 */
public class TwoSum {
	
	public int[] GetTwoSum(int[] nums,int target) {
		HashMap<Integer, Integer> map = new HashMap<>();
		for (int i = 0; i < nums.length; i++) {
			int implement = target - nums[i];
			if (map.containsKey(implement)) {
				return new int[] {map.get(implement),i};
			}
			map.put(nums[i], i);
		}
		return null;
	}
}
