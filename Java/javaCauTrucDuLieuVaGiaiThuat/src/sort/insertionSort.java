package sort;
// Sap xep chen 

class myInsertionSort{
    // Ham sap xep day so nguyen theo thu tu tang dan gia tri 
    // Input : mang . Output : mang sap xep tang dan 
    public static int[] misInt(int[] arr){
        int n = arr.length;
        for(int i = 1 ; i < n ; i++){
            for(int j = i ; j > 0 ; j--){
                if(arr[j] >= arr[j-1]){
                    break;
                }else{
                    int x = arr[j];
                    arr[j] = arr[j-1];
                    arr[j-1] = x;
                }
            }
        }
        return arr;
    }    
}
