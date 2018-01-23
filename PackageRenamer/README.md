# Package Renamer 
###### Contracted Project
###### PackageRenamer is a console program intended to be used on MAC OS X to bulk process packages (folders) and the file content contained within each package. Each row (beginning with row 6) is a unique asset (package).  
---  
#### Method
##### Libraries:  
iostream - handle input/output
string - access rfind and replace methods for modifying file extension 
  
##### Data Structure:  
None at this time, may implement a vector as data quantities will be unique to each use and need to grow/shrink accordingly.  
  
##### Testing:  
Necessary:  
	- Excel file conversion to .csv.  
	- Excel file read.   
	- Folder creation.  
	- File copy to folders.  
	- File renames.  
Implemented:  
  
  
##### Error Handling:  
Necessary:  
	- Excel file exists and is not empty. 
	- File extension change was successful.  
	- Folder containing ADI.DTD, .bmp, and .jpg was opened successfully.  
	- .ADI, .bmp, and .jpg files exist.  
	- .bmp and .jpg renames were successful.  
Implemented:  