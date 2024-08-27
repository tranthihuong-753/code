#include <iostream>
#define MAX_SIZE 10 
using namespace std;

int queue[MAX_SIZE];
int front = 0, rear = 0;
 
void endQueue(int data)
{
	// KT đã đầy chưa  
	if(rear == MAX_SIZE)
	{
		cout << "Full" << endl;
	}
	else
	{
		// Thêm 1 phần tử  
		queue[rear] = data;
		rear++; 
	}
}
void deleteQueue()
{
	if(front == rear)
	{
		cout << "Queue rỗng" ;
	} 
	else
	{
		queue[front] = 0;
		front++; 
	 } 
} 
int Front(){
	return queue[front];
}
int size(){
	return rear - front;
}
int main(){
	endQueue(8);
	endQueue(84);
	endQueue(83);
	endQueue(483);
	endQueue(7);
	endQueue(3);
	endQueue(24);
	deleteQueue();
	return 0;
	cout << Front();
	cout << size();
}
