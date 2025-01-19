public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int row = matrix.Length;
        int col = matrix[0].Length;

        int[][] ans = new int[col][];

        for(int i =0; i<col; i++){
            ans[i] = new int[row];
        }

        for(int i=0; i<row; i++){
            for(int j=0; j<col;j++){
                ans[j][i]=matrix[i][j];
            }
        }

        return ans;
        
    }
}
