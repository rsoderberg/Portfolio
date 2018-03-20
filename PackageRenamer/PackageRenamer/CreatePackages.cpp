/*
Author: Rachel Soderberg
Date Created: February 13, 2018
Latest Edit: March 19, 2018

Description: Take in data from .CSV file and rename files using specific columns.

Required Files: (Currently contained in "Files" within PackageRenamer folder)
- FUSE_20_HR_February_2018_V1_01192018.csv (fusetest.csv)
- ADI.DTD (This is an XML Document)
- Fuse_VOD_105x147.jpg
- Fuse_VOD_Logo_320x240px.bmp
*/

#include "stdafx.h"
#include "Prototypes.h"

// Col N, S, T
// Col N: Packages
// Col S: .bmp files
// Col T: .jpg files

void readFromCSV() {
	std::vector<std::vector<std::string>> data;

	std::ifstream infile (FILENAME);

	int rowCounter = 0, colCounter = 0; // Counters to compare to user row/col input for table data manipulation
	int rowTotal = 0, colTotal = 0; // Header input given by user
	int numRecords = 0, numRows = 0; // Number of records and rows in the table excluding header(s)
	int recordsPerRow = 0; // Number of records in a single row
	int totalRecords = 0; // Total number of records in table

	//std::vector<int> colB; // Column B for testing parsing
	//std::vector<int> colN;
	//std::vector<int> colS;
	//std::vector<int> colT;

	//int colN = 0, colS = 0, colT = 0; // Columns N(13), S(18), and T(19) for parsing

	std::cout << "How many header rows does the file have? (0 if none): ";
	std::cin >> rowTotal;

	std::cout << "How many header columns does the file have? (0 if none): ";
	std::cin >> colTotal;

	while (infile) {
		std::string temp;
		if (!getline(infile, temp)) break;

		std::istringstream ss(temp);
		std::vector<std::string> record;

		while (ss) {
			std::string temp;
			if (!getline(ss, temp, ',')) break;
			record.push_back(temp);
		}

		data.push_back(record);
	}

	if (!infile.eof()) {
		std::cerr << "Error opening file\n";
	}

	for (std::vector<std::vector<std::string>>::iterator it = data.begin(); it != data.end(); ++it) { // Find number of rows in file
			++numRows;
		for (std::vector<std::string>::iterator jt = it->begin(); jt != it->end(); ++jt) { // Find total number of records in file
			++numRecords;
		}
	}
	totalRecords = numRecords; // Store total number of records before excluding header(s)
	recordsPerRow = totalRecords / numRows; // Find number of records held in each row

	numRows = numRows - rowTotal; // Find number of rows minus header(s) excluded by user
	numRecords = totalRecords - (rowTotal * recordsPerRow); // Find number of records minus excluded header(s)

	std::cout << "numRecords: " << numRecords << " numRows: " << numRows << " recordsPerRow: " << recordsPerRow << '\n';

	// 2203 total records expected, 288 records per row, 34 rows				   
	// Print a specific column (col B out of a 21-record 3x7 grid) - need records 2, 5, 8, 11, 14, 17, 20... aka every third output.
	for (std::vector<std::vector<std::string>>::iterator it = data.begin(); it != data.end(); ++it) { // 'it' is a pointer to vector<int>
		for (std::vector<std::string>::iterator jt = it->begin(); jt != it->end(); ++jt) { // 'jt' is a pointer to an integer
			if (rowCounter >= rowTotal && colCounter >= colTotal) { // Skip header rows and columns
				for (int i = 13; i < totalRecords; i += recordsPerRow) { // Col N(13)
					if (colCounter == i) {
						std::cout << *jt << " "; // Print results
					}
				}
			}
			++colCounter;
		}
		++rowCounter;
		std::cout << '\n';
	}
	std::cout << '\n';
}



/*
Reading CSV files
http://www.cplusplus.com/forum/general/13087/
https://stackoverflow.com/questions/12650482/using-ifstreamoperator-to-load-an-array-from-a-csv-file
https://stackoverflow.com/questions/1120140/how-can-i-read-and-parse-csv-files-in-c

Parsing CSV files
By Sastanin: https://stackoverflow.com/questions/1120140/how-can-i-read-and-parse-csv-files-in-c
*/