package sort;

class myMergeSort {
    public static int[] mmsInt(int[] arr, int head, int tail){
        if(head < tail){
            int mid = (head + tail)/2;
            System.out.println("int mid "+mid);
            mmsInt(arr, head, mid);
            System.out.println("chia trai");
            mmsInt(arr, mid + 1, tail);
            System.out.println("chia phai");
            int n1 = mid - head + 1;
            int n2 = tail - mid;
            System.out.println("khai bao n1 n2");
            int[] arrLeft = new int[n1];
            int[] arrRight = new int[n2];
            
            System.arraycopy(arr, head, arrLeft, 0, n1);
            System.arraycopy(arr, mid + 1, arrRight, 0, n2);
            System.out.println("copy");
            int i = 0, j = 0, k = head;
            while(i < n1 && j < n2){
                if(arrLeft[i] <= arrRight[j]){
                    arr[k] = arrLeft[i];
                    i++;
                }else{
                    arr[k] = arrRight[j];
                    j++;
                }
                k++;
            }
            while(i < n1){
                arr[k] = arrLeft[i];
                i++;k++;
            }
            while(j < n2){
                arr[k] = arrRight[j];
                j++;k++;
            }
        }
        return arr;
    }
}
