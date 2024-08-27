//package sort;
//
//import java.util.Scanner;
//// Sắp xếp nổi bọt 
//class myBubbleSort{
//    // Hàm sắp xếp nổi bọt giảm dần cho kiểu số nguyên 
//    // Tăng dần thì thay dấu ở if là được 
//    // Phải là protected vì dùng trong lớp cùng gói 
//    // Phải là static vì chạy tỏng main 
//    public static int[] myBubbleSortInt(int[] arr){
//        int n = arr.length;
//        for(int i = n-1 ; i > 0 ; i--) // n-1 -> 1
//        {
//            for(int j = 0 ; j < i ; j++) // 0 -> i-1
//            {
//                if(arr[j] > arr[j+1])
//                {
//                    int x = arr[j];
//                    arr[j] = arr[j+1];
//                    arr[j+1] = x;
//                }
//            }
//        }
//        return arr;
//    } 
//}
//// Sắp xếp chọn 
//class mySelectionSort{
//    // Hàm sắp xếp chọn giảm dần cho kiểu số nguyên 
//    // Tăng dần thì thay dấu ở if là được 
//    public static int[] mySelectionSortInt(int[] arr){
//        int n = arr.length;
//        for(int i = 0 ; i < n - 1 ; i++)
//        {
//            int min = arr[i + 1];
//            int index = i + 1;
//            for(int j = i + 2 ; j < n ; j++)
//            {
//                if(min > arr[j])
//                {
//                    min = arr[j];
//                    index = j;
//                }
//            }
//            if(arr[i] < min)
//            {
//                int x = arr[i];
//                arr[i] = arr[index];
//                arr[index] = x;
//            }
//        }
//        return arr;
//    }
//}
//// Sắp xếp chèn 
//class myInsertionSort{
//    // Hàm sắp xếp chèn giảm dần cho kiểu số nguyên 
//    public static int[] myInsertionSortInt(int[] arr){
//        int j;
//        for (int i = 1; i < arr.length; i++)
//        {
//            int x = arr[i]; // Lấy ra phần tử cần chèn
//            for (j = i; j > 0; j--) { // j: vị trí đón nhận
//                if (x > arr[j-1])
//                    arr[j] = arr[j-1]; // Dịch về phía sau
//                else
//                    break;
//            }
//            arr[j] = x;
//        }
//        return arr;
//    }
//}
//
//// Sắp xếp trộn  
//class myMergeSort {
//    // l = left ; m = mid ; r = right 
//    public static int[] myMergeSortInt(int arr[], int l, int r){
//        if (l < r) {
//            int m = (l + r)/2;
//            myMergeSortInt(arr, l, m);
//            myMergeSortInt(arr, m + 1, r);
//            merge(arr, l, m, r); 
//        }
//        return arr;
//    }
//    public static void merge(int arr[], int l, int m, int r){
//        int n1 = m - l + 1; // từ l -> m 
//        int n2 = r - m; // từ r -> m+1 
//        int L[] = new int[n1]; // mảng có index 0 -> m-1 
//        int R[] = new int[n2]; // mảng có index 0 -> m+1-r 
//        for (int i = 0; i < n1; ++i)
//            L[i] = arr[l + i];
//        for (int j = 0; j < n2; ++j)
//            R[j] = arr[m + 1 + j];
//        int i = 0, j = 0;
//        int k = l;
//        while (i < n1 && j < n2) {
//            if (L[i] <= R[j]) {
//                arr[k] = L[i]; 
//                i++;
//            }
//            else {
//                arr[k] = R[j]; 
//                j++;    
//            }
//            k++;
//        }
//        while (i < n1) {
//            arr[k] = L[i]; 
//            i++; 
//            k++;
//        }
//        while (j < n2) {
//            arr[k] = R[j]; 
//            j++; 
//            k++;
//        }
//    }
//}
//
//// Sắp xếp trộn  
////class myMergeSort {
////    // l = left ; m = mid ; r = right 
////    public static int[] myMergeSortInt(int arr[], int l, int r){
////        if (l < r) {
////            int m = (l + r)/2;
////            myMergeSortInt(arr, l, m);
////            myMergeSortInt(arr, m + 1, r);
////            merge(arr, l, m, r); 
////        }
////        return arr;
////    }
////    public static void merge(int arr[], int le, int m, int r){
////        // Tạo mảng bên trái 
////        int[] arr1 = new int[m - le + 1];
////        for(int i = 0; i < m - le + 1; i++){
////            arr1[i] = arr[le+i];
////        }
////        for(int i = 0; i < m - le + 1; i++){
////            System.out.println("a"+i);
////            System.out.println(arr1[i]);
////        }
////        // Tạo mảng bên phải 
////        int[] arr2 = new int[r-m];
////        for(int j = 0 ; j < r-m ; j++){
////            arr2[j] = arr[m+1+j];
////        }
////        for(int j = 0 ; j < r-m ; j++){
////            System.out.println("a"+j);
////            System.out.println(arr2[j]);
////        } 
////        int[] arrChot = new int[r - le +1];
////        int i = 0, j = 0, k = 0;
////        while(true){
////            if(i == m-le+1 && j == r-m)
////            {
////                break;
////            }
////            else if(j == r-m )
////            {
////                for(int z = i; z < m - le + 1; z++){
////                    arrChot[k] = arr1[z];
////                    k++;
////                }
////            }
////            else if(i == m-le+1)
////            {
////                for(int z = i; z < r - m; z++){
////                    arrChot[k] = arr1[z];
////                    k++;
////                }                
////            }
////            else if(arr1[i] <= arr2[j])
////            {
////                arrChot[k] = arr1[i];
////                i++;
////            }
////            else if(arr1[i] > arr2[j])
////            {
////                arrChot[k] = arr2[j];
////                j++ ;                
////            }
////        }        
////    }
////}
//
//public class sapXep {
//    //1. Hàm nhập vào một dãy số nguyên. 
//    public static int[] inputInt(){
//        Scanner scan = new Scanner(System.in);
//        // Nhập vào số lượng phần tử của mảng 
//        System.out.print("Nhập vào số lượng phần tử của mảng số nguyên: ");
//        int n = scan.nextInt();
//        //Khai báo mảng 
//        int[] arr = new int[n];
//        //Nhập vào giá trị của mảng 
//        for(int i = 0; i < n ; i++){
//            arr[i] = scan.nextInt();
//            scan.nextLine();
//        }
//        return arr;
//    }
//    // Hàm in ra dãy đã xếp theo trật tự tăng dần sử dụng thuật toán sắp xếp chèn myInsertionSort.
//    public static void ouputInsertion(int[] arr){
//        myInsertionSort mis = new myInsertionSort();
//        int[] arr2 = mis.myInsertionSortInt(arr);
//        for(int i = 0; i < arr2.length ; i++){
//            System.out.println(arr2);
//        }
//    }
//    //2. Viết ham nhập vào một dãy số nguyên. Viết chương trình cho phép lựa chọn:
//    // 1- In ra dãy theo thuật toán sắp xếp nổi bọt
//    // 2- In ra dãy theo thuật toán sắp xếp chọn
//    // 3- In ra dãy theo thuật toán sắp xếp chèn
//    // 4- In ra dãy theo thuật toán sắp xếp trộn
//    // 5- In ra dãy theo thuật toán sắp xếp nhanh
//    // Nếu nhập số khác: Thoát khỏi chương trình
//    public static void luaChon(int[] arr){
//        // Nhap vao n (1-5)
//        Scanner scan = new Scanner(System.in);
//        int n = 0;
//        try{
//            System.out.println("Nhap vao so nguyen 1-5 : ");
//            n = scan.nextInt();
//            scan.nextLine();
//        }catch(Exception e){
//            System.out.println("!!! Exception : "+e);
//        }
//        // Lua chon 
//        int[] arr2 = null;
//        switch(n){
//            case 1:
//                myBubbleSort a = new myBubbleSort();
//                arr2 = a.myBubbleSortInt(arr);
//                break;
//            case 2:
//                myInsertionSort mis = new myInsertionSort();
//                arr2 = mis.myInsertionSortInt(arr);                
//                break;
//            case 3:
//                myInsertionSort c = new myInsertionSort();
//                arr2 = c.myInsertionSortInt(arr);                
//                break;
//            case 4: 
//                myQuickSort d = new myQuickSort();
//                arr2 = d.myQuickSortInt(arr, 0 , arr.length - 1);                
//                break;
//            case 5:
//                 myHeapSort e = new myHeapSort();
//                arr2 = e.myHeapSortInt(arr);               
//                break;
//            default :
//                return ;
//
//        }
//        for(int i = 0; i < arr2.length ; i++){
//            System.out.println(arr2);
//        }
//    }
//    public static void main(String[] args) {
//        int[] arrInt = {3, 1, 9, 6, 5, 2};
//        myMergeSort x = new myMergeSort();
////////        int[] y = x.myBubbleSortInt(arrInt);
//////        int[] y = x.mySelectionSortInt(arrInt);
////////        int[] y = x.myInsertionSortInt(arrInt);
//        int[] y = x.myMergeSortInt(arrInt, 0, arrInt.length - 1);
////////        int[] y = x.myQuickSortInt(arrInt, 0, arrInt.length - 1);
////////        int[] y = x.myHeapSortInt(arrInt);
//        for(int y1 : y)
//        {
//            System.out.println(y1);
//        }
//    }
//}
//
//
//// Sắp xếp nhanh 
//class myQuickSort{
//    public static int[] myQuickSortInt(int[] arr, int low, int high) {
//        if (low < high) {
//            int pivotIndex = partition(arr, low, high);
//            myQuickSortInt(arr, low, pivotIndex - 1);
//            myQuickSortInt(arr, pivotIndex + 1, high);
//        }
//        return arr;
//    }
//
//    public static int partition(int[] arr, int low, int high) {
//        int pivot = arr[high];
//        //chọn chốt là phần tử cuối
//        int i = low - 1;
//        for (int j = low; j < high; j++) {
//            if (arr[j] < pivot) {
//                i++;
//                swap(arr, i, j); 
//            }
//        }
//        swap(arr, i + 1, high);
//        return i + 1;
//    }   
//    public static void swap(int[] arr, int i, int j) {
//        int temp = arr[i];
//        arr[i] = arr[j];
//        arr[j] = temp;
//    }
//}
//
//// Sắp xếp vun đống 
//class myHeapSort{
//    public static int[] myHeapSortInt(int arr[]){
//        int N = arr.length;
//        for (int i = N / 2 - 1; i >= 0; i--) 
//            heapify(arr, N, i);
//        for (int i = N - 1; i > 0; i--)
//        { 
//            int temp = arr[0];
//            arr[0] = arr[i];
//            arr[i] = temp;
//            heapify(arr, i, 0); 
//        }
//        return arr;
//    }
//    public static void heapify (int arr[], int N, int i)
//    {
//        int largest = i;
//        int left = 2 * i + 1;
//        int right = 2 * i + 2;
//        if (left < N && arr[left] > arr[largest])
//            largest = left;
//        if (right < N && arr[right] > arr[largest])
//            largest = right;
//        if (largest != i) {
//            int swap = arr[i];
//            arr[i] = arr[largest];
//            arr[largest] = swap;
//            heapify(arr, N, largest);
//        }
//    }
//}