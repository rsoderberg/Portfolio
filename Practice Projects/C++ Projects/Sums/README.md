# Sums
###### Given an integer array and a number k (sum), output all pairs that sum up to k.  
---
#### Method:
	- Remove any numbers that exceed the value of the sum.  
	- Remove any duplicate numbers, we do not want duplicate pairs.  
	- Compare remaining array with the sum to find pairs. I chose to store them in a new array of [2] for clarity, but simply printing from the original vector will also suffice.  
	- Remove pairs as they're used.  

##### Libraries:  
iostream - Input/output
vector - Number storage 