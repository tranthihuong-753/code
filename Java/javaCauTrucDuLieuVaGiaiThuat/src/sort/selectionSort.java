package sort;
// Sap xep chon 

class mySelectionSort{
    // Ham sap xep day so nguyen theo thu tu tang dan gia tri 
    // Input : mang . Output : mang sap xep tang dan 
    public static int[] mslInt(int[] arr){
        int n = arr.length;
        for(int i = 0 ; i < n - 1; i++){
            int index = i;
            int min = arr[i];
            for(int j = i + 1; j < n ; j++){
                if(min > arr[j]){
                    min = arr[j];
                    index = j;
                }
            }
            int x = arr[i];
            arr[i] = arr[index];
            arr[index] = x;  
        }
        return arr;
    }    
}
