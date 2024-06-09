/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thuatToan;

import java.util.Scanner;

/**
 *
 * @author dhhuo
 */
public class tongchanle {
    public static void main(String[] args) {
        Scanner a=new Scanner(System.in);
        int x=a.nextInt();
        int chan=0, le=0;
        int y=0;
        while(x!=0){
            y=x%10;
            if(y%2==0){
                chan+=y;
            }else{
                le+=y;
            }
            x/=10;
        }
        System.out.println(chan+"\n"+le);
   
 }
}