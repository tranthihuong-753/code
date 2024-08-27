package baiTap;

public class ThacNuoc {
    public static void main(String[] args) {
        run_thacnuoc();
    }
    static int thacnuoc(int[] arr){
        int n = arr.length;
        int[] arrout = new int[n+1]; // arrout[0] = gia tri can tim , con lai chua index 
        int indexarrout = 0;
        arrout[++indexarrout] = arr[0];
        for(int i = 0 ; i < n - 1; i++){
            if(arr[i] < arr[i + 1]){
                if(arr[arrout[indexarrout]] < arr[i + 1]){
                    arrout[0] += (arr[arrout[indexarrout]] - arr[i]);//* ((i - 1) - arrout[indexarrout])
                    arr[i] = arr[arrout[indexarrout]];
                    arrout[++indexarrout] = i + 1;
                }
                if(arr[arrout[indexarrout]] > arr[i + 1]){
                    arrout[0] += (arr[i + 1] - arr[i]);
                    arr[i] = arr[i + 1];
                } 
                if(arr[arrout[indexarrout]] == arr[i + 1]){
                    arrout[0] += (arr[i + 1] - arr[i])*(i - arrout[indexarrout]);
                }
            }
            if(arr[i] > arr[i + 1]){
                arrout[++indexarrout] = i;
            }
        }
        return arrout[0];
    }
    static void run_thacnuoc(){
        int[] a = {2, 4, 3, 6, 1, 4};
        int out = thacnuoc(a);
        System.out.println("DAP 2D = " + out);
    }
}
