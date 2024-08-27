package day10082024;

import java.util.Deque;
import java.util.LinkedList;

public class bai3_DayConSoLuongMinChiaHetChoK {
    public static void main(String[] args) {
        run_DAY_DayConSoLuongMinTong();
    }
    // In put : Dãy gồm n phần tử, full nguyên dương  && k
    // Output : Dãy con gồm nhiều phần tử nhất && Tổng các phần tử chia hết cho k 
//    static int[] DAY(int[] arr, int k){
//        int sum = 0 ; 
//        for(int i = 0 ; i < arr.length ; i++){
//            sum += arr[i];
//        }
//        int sum_du = sum%k;
//
//    }
    // Input : Dãy gồm n phần tử, full nguyên dương  && int sum_du 
    // Output : mảng chứa index thỏa mãn số lượng phần tử min && tổng các phần tử = sum_du 
    static int[] DAY_DayConSoLuongMinTong(int[] arr, int sum_du){
        int n = arr.length;
        Deque<Integer> quout = new LinkedList<>(); // luu index 
        int sum = 0;
        int indexbatdau = 0 ;
        while(indexbatdau != n - 1){
            System.out.println("index = "+indexbatdau);
            Deque<Integer> qucheck = new LinkedList<>(); // luu index 
            for(int i = indexbatdau ; i < n ; i++){
                System.out.println("    i = "+i);
                if(sum + arr[i] == sum_du){
                    System.out.println("    =");
                    qucheck.add(i);
                    break;
                }               
                if(sum + arr[i] < sum_du){
                    System.out.println("    <");
                    sum += arr[i];
                    qucheck.add(i);
                    System.out.println(""+qucheck.peek());
                }
                System.out.println("qu : " + qucheck.peek());
            }
            indexbatdau++;
            if(qucheck.size() < quout.size()){
                quout = qucheck;
            }
            if(quout.size() == 1){
                break;
            }
        }
        // chuyen quout thanh mang int[]
        int nout = quout.size();
        int[] arrout = new int[nout];
        for(int i = 0 ; i < nout ; i++){
            arrout[i] = quout.poll();
        }
        return arrout;
    }
    static void run_DAY_DayConSoLuongMinTong(){
        int[] arr = {1,3,8,6,2,7,9};
        int sum_du = 6;
        int[] arr1 = DAY_DayConSoLuongMinTong(arr, sum_du);
        for(int x : arr1){
            System.out.print(x+" ");
        }
    }
}
