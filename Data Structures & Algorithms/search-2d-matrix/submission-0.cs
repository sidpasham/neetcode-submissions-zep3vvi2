public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // edgecases

        int rows = matrix.Length -1;
        int cols = matrix[0].Length -1;
        int top = 0;
        int bot = rows;
        int midrow = 0;

        while (top <= bot) {
            midrow = top + ((bot-top)/2);

            if(target < matrix[midrow][0]) {
                bot = midrow - 1;
            }
            else if (target > matrix[midrow][cols]) {
                top = midrow + 1;
            } 
            else {
                break;
            }
        }

        if(!(top <= bot)) {
            return false;
        }

        int l = 0;
        int r = cols;

        while (l <= r) {
            int m = l + ((r-l)/2);

            if(target < matrix[midrow][m]) {
                r = m -1;
            }
            else if (target > matrix[midrow][m]) {
                l = m +1;
            }
            else if (target == matrix[midrow][m]) {
                return true;
            }
        }

        return false;        
    }
}
