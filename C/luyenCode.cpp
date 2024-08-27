#include <stdio.h>
int main(){
	int n, i, j; 
 	scanf("%d", &n);
 	if(n<1 || n>100){
 		return 0;  
	 } 
 	int a[n];
	for(i=0;i<n;i++){
		scanf("%d", &a[i]); 
		if(a[i]<1 || a[i]>10^9){
			return 0;  
		} 
	} 
	for(j=0;j<n;j++){
//		int m; 
//		if(a[j]/10!=0){
//			while(a[j]/10!=0){
//				m=0; 
//				while(a[j]!=0){
//					m+=(a[j]%10); 
//					a[j]/=10;
//				} 
//				a[j]=m; 
//			}
//			printf("%d\n", m); 			
//		}else{
//			printf("%d\n", a[j]);
//		} 

		if(a[j]%10==0){
			printf("%d\n", a[j]); 
		} else{
			int z=0;
			while(a[j]%10!=0) {
				z+=(a[j]%10);
				a[j]/=10; 
			}
			printf("%d\n", z); 
		} 
	} 	
	
} 
