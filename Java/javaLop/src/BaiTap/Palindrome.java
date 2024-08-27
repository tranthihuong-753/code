/*
Số Palindrome là số nguyên tố mà khi viết ngược lại thì khong đổi 
VD: 2, 3, 5, 7, 11, 101, ... 
 */
package BaiTap;

import static java.lang.Math.pow;
import java.util.Deque;
import java.util.LinkedList;

public class Palindrome {
    public static void main(String[] args) {
        int n = 1881;
        System.out.println(n + " co phai so palindrome " + checkPalindrome(n));
    }
    // Hàm check só nguyên dương nhập vào có phải số Palndrome 
    public static boolean checkPalindrome(int n){
        return checkSoNguyenTo(n) && checkNguoc(n);
    }
    // Hàm check số nguyên tố <Số chỉ chia hết cho 1 và chính nó>
    // Input : So nguyen duong n 
    static boolean checkSoNguyenTo(int n){
        for(int i = 1 ; i < (int)pow(n, 1/2); i++){
            if(n % i == 0){
                return false; // n khong phai so nguyen to 
            }
        }
        return true; // n la so nguyen to 
    }
    // Hàm check viết ngược 
    static boolean checkNguoc(int n){
        Deque<Integer> d = new LinkedList<>();
        while(n != 0){
            int du = n % 10 ; 
            d.add(du);
            n /= 10;
        }
        int length = d.size();
        for(int i = 0 ; i < length/2 ; i++){
            int x = d.pollFirst();
            int y = d.pollLast();
            if(x != y){
                return false;
            }
        }
        return true;
    }
}
