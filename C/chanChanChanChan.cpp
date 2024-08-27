// https://luyencode.net/problem/sapxep
//#include<stdio.h>
#include <iostream>
#define true 1
#define false 0
using namespace std;
int main(){
	// Nhap vao so luong mang 
	int n; 
	scanf("%d", &n);
	// Nhap vao mang 
	int arr[n];
//	int i;
	for(int i = 0 ; i < n ; i++){
		scanf("%d", &arr[i]);
	}
	// Tao mang 2 chieu 
	int arrOut[n][2];
	int indexLeft = 0; 
	int index = 0;
	int value = 0;
	int count = 0 ; 
	// Dem va luu vao mang luon 
	for(int i = 0 ; i < n ; i++){
//		int soluong = 0 ; 
		int check = 1; //chua co phan tu nay trong arrOut 
		indexLeft = i;
		value = arr[i];
		printf("value = %d\n", value);
		for(int j = 0 ; j < n ; j++){
			if(arr[i] == arrOut[j][0]){
				check = 0;
			}
		} 
		printf("check = %d\n", check);
		if(check == 1){
			for(int i = indexLeft ; i < n ; i++){
				if(value == arr[i]){
					count++;
				}
			}
			arrOut[index][0] = value; 
			arrOut[index][1] = count; 
			indexLeft = 0; 
			index++;
			value = 0;
			count = 0 ; 		
		}
	}
	//In ra mang 
	for(int i = 0 ; i < index ; i++){
		printf("%d %d \n", arrOut[i][0], arrOut[i][1]);
	}
}

