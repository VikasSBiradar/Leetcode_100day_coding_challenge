public class Solution {
    public int BulbSwitch(int n) {
        int onCount = 0;

        for(int i=1; i*i<=n;i++){
            onCount++;
        }
        return onCount;
    }
}