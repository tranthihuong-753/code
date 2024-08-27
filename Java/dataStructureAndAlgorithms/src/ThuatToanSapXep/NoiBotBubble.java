package ThuatToanSapXep;

public class NoiBotBubble {
    public static void main(String[] args) {
//        int[] arr = {2, -1, 3, 4, -6, 0, 2, 5};
//        printArr(BubbleSort(arr));
        String[] arrs = {"AB", "AAC", "F", "H", "U", "O", "o", "N", "n"};
        printArr(BubbleSort(arrs));
    } 
    static int[] BubbleSort(int[] arr){
        int n = arr.length;
        boolean check = true;
        while(check){
            check = false;
            for(int i = 0 ; i < n - 1 ; i++){
                if(arr[i] > arr[i+1]){
                    int x = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = x;
                    check = true;
                }
            }
            n--;
        }
        return arr;
    }
    static String[] BubbleSort(String[] arr){
        int n = arr.length;
        boolean check = true;
        while(check){
            check = false;
            for(int i = 0 ; i < n - 1 ; i++){
                if(arr[i].compareTo(arr[i+1]) > 0){
                    String x = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = x;
                    check = true;
                }
            }
            n--;
        }
        return arr;        
    } 
    public static void printArr(String[] arr){
        System.out.print("Array: ");
        for(int i = 0; i < arr.length ; i++){
            System.out.print(" " + arr[i]);
        }
    } 
 
}
