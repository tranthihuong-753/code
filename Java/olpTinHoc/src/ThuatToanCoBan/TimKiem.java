package ThuatToanCoBan;
import static ThuatToanCoBan.SapXep.QuickSort;
import java.math.*;

public class TimKiem {
    public static void main(String[] args) {
        run_JumpSearch();
        run_BinarySearch();
    }
    // Thuật toán Jump search , tim kiem 1 phan tu trong mang da sap xep 
    static int JumpSearch(int[] arr, int x){
        int n = arr.length;
        int step = (int)Math.pow(n, 0.5); // Luon lam tron xuong 
        int step_fake = step;
        for(int i = step_fake ; i >= step_fake - step ; i--){
            if(arr[step_fake] == x){
                System.out.println("2");
                return step_fake;
            }
            if(arr[step_fake] > x){
                if(arr[i] == x){
                    return i;
                }
            }
            if(i == step_fake - step){
                step_fake+=step;
            }
        }
        return -1;
    }
    static void run_JumpSearch(){
        int x = 1;
        int[] arr = {1, -3, 4, 0, 4 };
        int[] arrnew = QuickSort(arr, 0, arr.length - 1);
        System.out.println("index = "+JumpSearch(arrnew, x));
    }
    // Thuat toan tim kiem nhi phan, tim kiem 1 phan tu trong mang da sap xep 
    static int BinarySearch(int[] arr, int head, int tail, int x){
        int n = arr.length;
        int chia = (tail - head)/2;
        if(arr[chia] == x){
            return chia;
        }
        if(arr[chia] > x){
            BinarySearch(arr, head, chia - 1, x);
        }
        if(arr[chia] < x){
            BinarySearch(arr, chia + 1 , tail, x);
        }
        return -1;
    }  
    static void run_BinarySearch(){
        int x = 1;
        int[] arr = {1, -3, 4, 0, 4 };
        int[] arrnew = QuickSort(arr, 0, arr.length - 1);
        System.out.println("indexs = "+BinarySearch(arrnew, 0, arr.length - 1, x));        
    }
}
