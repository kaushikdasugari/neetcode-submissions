public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        List<List<int>> output = new List<List<int>>();

        //Bute force O(N^3) 3 loops 

        for(int i=0;i<nums.Length;i++){
            for(int j = i+1 ;j<nums.Length;j++){
                if(i != j){
                    for(int k = j+1;k<nums.Length;k++){
                        if(i!=k && k !=j){
                            if((nums[i] + nums[j] + nums[k]) == 0){
                                output.Add([nums[i],nums[j],nums[k]]);
                            }
                        }
                        else{ 
                                continue;
                            }
                       
                    }
                }
                 else{ 
                        continue;
                     }
            }
        }


        return output.DistinctBy(list => string.Join(",", list.OrderBy(x => x)))
    .ToList();;
    }
}
