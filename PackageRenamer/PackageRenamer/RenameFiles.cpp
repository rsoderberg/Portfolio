/*
Author: Rachel Soderberg
Date Created: January 20, 2018
Latest Edit: March 19, 2018

Description: Modify file names and file extensions.

Required Files: (Currently contained in "Files" within PackageRenamer folder)
- FUSE_20_HR_February_2018_V1_01192018.xlsm

Steps: 1. Take in Excel spreadsheet name.
2. If spreadsheet is .xlsm, convert to .csv.
3. Create packages corresponding to column N until end of file (or until coord == " "?).
Note: Packages are always FUSE00.
3. After package creation and file movement, rename .bmp (column S) and .jpg (column T)
*/

#include "stdafx.h"
#include "Prototypes.h"

void renameExcelFile() {
	//std::ofstream oldFile("fusetest");
	//std::ofstream newFile("fusetest.csv");

	/*
	std::string codeFile = basename(filename) + ".code";
	outFile.open(codeFile);


	ofstream myfile ("example.txt");
	if (myfile.is_open())
	{
	myfile << "This is a line.\n";
	myfile << "This is another line.\n";
	myfile.close();
	}
	else cout << "Unable to open file";
	*/
}

void renameImageFiles() {
	// Open .csv file, read data, rename image using data read
	// Test this concept with a single column .csv file at first


}

/*
File Input/Output
http://www.cplusplus.com/doc/tutorial/files/

Changing file extensions:
https://www.safaribooksonline.com/library/view/c-cookbook/0596007612/ch10s17.html
https://stackoverflow.com/questions/757933/how-do-you-change-the-filename-extension-stored-in-a-string-in-c
Boost.Filesystem Library
http://www.boost.org/doc/libs/1_66_0/libs/filesystem/doc/index.htm
*/