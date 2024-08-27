package day03082024;

public class Bai1_DaySo {
    public static void main(String[] args) {
//        run_2a();
//        run_2b();
        run_2c();
    }
    static int[] bubbleSort(int[] arr){
        int n = arr.length;
        for(int i = n - 1 ; i > 0 ; i--){
            boolean check = true;
            for(int j = 0 ; j < i ; j++){
                if(arr[j] > arr[j + 1]){
                    int x = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = x; 
                    check = false;
                }
            }
            if(check == true){
                break;
            }
        }
        return arr;
    }
    // 1a Tim ra day lien tiep dai nhat tao thanh cap so cong
    static int[] CapSoCong(int[] arr){
        int n = arr.length;
        int[][] arrout = new int[n][n];
        int max = 1; // luu tru so luong phan tu dai nhat 
        int indexmax = 0; // luu tru arrout co so luong phan tu dai nhat dau tien 
        for(int i = 0 ; i < n -1 ; i++){
            if(max > (n-i)){
                break;
            }
            int d = - arr[i] + arr[i + 1];
            arrout[i][0] = arr[i]; 
            arrout[i][1] = arr[i + 1];
            int dem = 2 ; //luu tru so luong phan tu cua ban ghi arrout hien tai de so sanh voi max 
            for(int j = i+1 ; j < n -1 ; j++){
                if((- arr[j] + arr[j+1]) != d){
                    break;
                }
                arrout[i][dem] = arr[j + 1];
                dem ++ ;
            }
            if(dem > max){
                max = dem;
                indexmax = i;
            }
        }
        return arrout[indexmax];
    }
    //y tuong la coi tu 0 - (n - 1) , sxap 
    static void run_2a(){
//        int[] arr = {3, 2, 0, -6, 8}; // 3 2 
//        int[] arr = {1, 2, 5, 6, 7, 5, 4, 3, 2}; // 5 4 3 2 
        int[] arr = {1, 3, 6, 9, 12, -11, 30, -10}; // 3 6 9 12 
        int[] arrcheck = CapSoCong(arr); 
        for(int x : arrcheck){
            if(x != 0){
                System.out.print(x+" ");
            }
        }        
    }
    static int[] CapSoNhan(int[] arr){
        int n = arr.length;
        int[][] arrout = new int[n][n];
        int max = 1; // luu tru so luong phan tu dai nhat 
        int indexmax = 0; // luu tru arrout co so luong phan tu dai nhat dau tien 
        for(int i = 0 ; i < n -1 ; i++){
            if(arr[i] == 0){
                arrout[i][0] = 0;
                break;
            }
            if(arr[i + 1] == 0){
                arrout[i][0] = arr[i];
                break;
            }
            if(max > (n-i)){
                break;
            }
            int d;
            int du;
            if(arr[i+1] > arr[i]){
                d = arr[i + 1]/arr[i];
                du = arr[i + 1]%arr[i];
            }else{
                d = arr[i]/arr[i + 1];
                du = arr[i]%arr[i + 1];
            }
            arrout[i][0] = arr[i]; 
            arrout[i][1] = arr[i + 1];
            int dem = 2 ; //luu tru so luong phan tu cua ban ghi arrout hien tai de so sanh voi max 
            for(int j = i+1 ; j < n -1 ; j++){
                if(arr[j + 1] == 0){
                    break;
                }                
                if(arr[i+1] > arr[i]){
                    if( ((arr[j + 1]/arr[j]) != d) && ((arr[j + 1]%arr[j]) != du) ){
                        break;
                    }
                }
                if(arr[i+1] < arr[i]){
                    if( ((arr[j]/arr[j + 1]) != d) && ((arr[j]%arr[j + 1]) != du) ){
                        break;
                    }
                }
                arrout[i][dem] = arr[j + 1];
                dem ++ ;
            }
            if(dem > max){
                max = dem;
                indexmax = i;
            }
        }
        return arrout[indexmax];        
    }
    static void run_2b(){
//        int[] arr = {2, 4, 8, 16, 32, 7};
//        int[] arr = {7, 32, 16, 8, 4, 2};
        int[] arr = {2, 7, -3, 6, -12, 24, 0, -4 , -2}; // -3 6 -12 24 
        int[] arrcheck = CapSoNhan(arr);
        for(int x : arrcheck){
            if(x != 0){
                System.out.print(x+" ");
            }
        }        
    }
    static int[] DayDangSong(int[] arr){
        int[] arrout = bubbleSort(arr);
        int n = arrout.length;
        for(int i = 1 ; i <= n/2; i = i+2){
            if(n % 2 == 0){
                arrout[n/2] = arrout[n/2];
                break;
            }            
            int x = arrout[i];
            arrout[i] = arrout[n-i];
            arrout[n - i] = x;
        }
        return arrout;
    }
    static void run_2c(){
        int[] arr = {1, 3, 2, 6, 7 ,4};
        int[] arrcheck = DayDangSong(arr);
        for(int x : arrcheck){
            if(x != 0){
                System.out.print(x+" ");
            }
        }          
    }
}
 