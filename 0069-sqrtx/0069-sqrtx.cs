public class Solution {
    public int MySqrt(int x) {
        for(int i = 0;i<=x ; i++){
            if((long) i * i > x){
                return i - 1;
            }
        }
        return x;
    }
}