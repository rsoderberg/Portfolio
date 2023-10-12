# Box It!  
https://www.hackerrank.com/challenges/box-it/problem  
    
###### Problem:  
Design a class named Box whose dimensions are integers and private to the class. The dimensions are labelled: length l, breadth b, and height h.  
The default constructor of the class should initialize l, b, and h to 0.  
The parameterized constructor Box(int length, int breadth, int height) should initialize Box's l, b, and h to length, breadth, and height.  
The copy constructor Box(Box B) should set l, b, and h to B's l, b, and h, respectively.  
Apart from the above, the class should have four functions:  
	- int getLength(): Returns Box's height  
	- int getBreadth(): Returns Box's breadth  
	- int getHeight(): Returns Box's height  
	- long long CalculateVolume(): Returns the volume of Box  
	
Overload the operator < for the class Box. Box A < Box B if:
	1. A.l < B.l  
	2. A.b < B.b and A.l == B.l  
	3. A.h < B.h and A.b == B.b and A.l == B.l  
	
Overload operator << for the class Box. If B is an object of class Box:
	cout << B should print B.l, B.b, and B.h on a single line separated by spaces.  
  
###### Constraints:  
0 <= l, b, h <= 10^5  
Two boxes being commpared using the < operator will not have all three dimensions equal.  
  
Sample Input:  
	5  
	2 3 4 5  
	4  
	5  
	4  
	2 4 6 7  
Sample Output:  
	3 4 5  
	60  
	3 4 5  
	60  
	4 6 7  