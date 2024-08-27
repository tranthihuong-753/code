package CauTrucDuLieuVaGiaiThuat.SapXep;

public class BublleSort {
    public static void main(String[] args) {
        run_BS();
    }
    // Sắp xếp tăng dần của mảng 
    static int[] BS(int[] arr){
        int n = arr.length;
        for(int i = n - 1 ; i > 0 ; i--){
            for(int j = 0 ; j < i ; j++){
                if(arr[j] > arr[j + 1]){
                    int x = arr[j];
                    arr[j] =arr[j + 1];
                    arr[j + 1] = x;
                }
            }
        }
        return arr;
    }
    static void run_BS(){
        int[] arr = {2, 3, 0 ,4, -2, -5, 3};
        int[] arrBS = BS(arr);
        for(int i = 0 ; i < arrBS.length ; i++){
            System.out.print(" " + arrBS[i]);
        }
    }
}
