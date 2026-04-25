public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        // TODO edgecases
        int l = 1;
        int r = piles.Max();
        int res = piles.Max();

        while (l <=r) {
            int m = l + (r -l)/2;

            if(CanEat(piles, m, h)) {
                r = m -1;
                res = Math.Min(res, m);
            } else {
                l = m +1;
            }
        }

        return res;
    }

    public bool CanEat(int[] piles, int rate, int h) {
        long total = 0;

        foreach(var pile in piles) {
            total += (long)Math.Ceiling((double) pile/rate);
        }

        if(total <= h) {
            return true;
        }

        return false;
    }
}
