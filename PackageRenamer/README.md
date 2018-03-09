# Package Renamer 
###### Contracted Project
###### PackageRenamer is a console program intended to be used on MAC OS X to bulk process packages (folders) and the file content contained within each package. Every row (beginning with row 6) is considered a unique asset (package).  
---  
#### Method
##### Libraries:  
fstream - Handle file input/output  
iostream - Handle input/output  
sstream - Stream-style manipulation for strings input/output  
string - Access find and replace methods for modifying file extension  
vector - Dynamic array data storage  
  
##### Data Structure:  
Vector (including 2D vectors) for .csv file storage, reading, and output.  
  
##### Testing:   
  
  
##### Error Handling:  
Necessary:  
	- Excel file exists and is not empty. 
	- File extension change was successful.  
	- Folder containing ADI.DTD, .bmp, and .jpg was opened successfully.  
	- .ADI, .bmp, and .jpg files exist.  
	- .bmp and .jpg renames were successful.  
Implemented:  