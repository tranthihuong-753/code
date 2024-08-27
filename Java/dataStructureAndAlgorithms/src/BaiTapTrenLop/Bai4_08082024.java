package BaiTapTrenLop;

public class Bai4_08082024 {
    public static void main(String[] args) {
        run_QuickSort();
    }
    // Viet ham dem so cap phan tu co tong < k trong mang[n]
    static int Count(int k , int[] arr, int head, int tail){
        int count = 0;
        int n = arr.length;
        int[] arr1 = new int[n]; int index1 = 0; // phan tu < k/2
        int[] arr2 = new int[n]; int index2 = 0;// phan tu >= k/2 && < k
        for(int i = 0 ; i < n ; i++){
            if(arr[i] < (k/2)){
                boolean check = true;
                for(int j = 0 ; j < index1 ; j++){
                    if(arr[i] == arr1[j]){
                        check = false;
                        break;
                    }
                }
                if(check == true){
                    arr1[index1++] = arr[i];
                }
            }
            if(arr[i] >= (k/2) && arr[i] < k){
                boolean check = true;
                for(int j = 0 ; j < index2 ; j++){
                    if(arr[i] == arr1[j]){
                        check = false;
                        break;
                    }
                }
                if(check == true){
                    arr1[index2++] = arr[i];
                }
            }
        } //O((1+index)*index/2) (index = MAX(index1, index2))
        
        return count;
    }
    //Quick sort
    static int[] QuickSort(int[] arr, int head, int tail){
        int indexpivot = tail;
        for(int i = head ; i < indexpivot ; i++){
            if(arr[i] > arr[indexpivot]){
                int x1 = arr[i];
                arr[i] = arr[indexpivot - 1];
                arr[indexpivot - 1] = x1;
                
                int x2 = arr[indexpivot - 1];
                arr[indexpivot - 1] = arr[indexpivot];
                arr[indexpivot] = x2;
                
                --indexpivot;
                --i;
            }
        }
        if(tail > head){
            QuickSort(arr, head, indexpivot - 1);
            QuickSort(arr, indexpivot + 1, tail);
        }
        return arr;
    }
    
    static void run_QuickSort(){
//        int[] ar = {2, 4, 2, 6, 3, 0 , 389, -3};
//        int[] ar1 = QuickSort(ar, 0, ar.length - 1);
//        for(int i = 0 ; i < ar.length ; i++){
//            System.out.println(ar1[i] + " ");
//        }
        int[] arr = {2, 4, 2, 6, 3, 0 , 389, -3};
        int[] arrnew = QuickSort(arr, 0, arr.length - 1);
        for(int i = 0 ; i < arr.length ; i++){
            System.out.print(arrnew[i] + " ");
        } 
    }
}

