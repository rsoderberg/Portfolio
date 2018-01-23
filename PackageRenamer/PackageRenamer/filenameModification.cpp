/*
PackageRenamer.cpp : Defines the entry point for the console application.
Author: Rachel Soderberg
Date Created: January 20, 2018
Latest Edit: January 20, 2018

Description: Source file containing the functions used to modify file names and file extensions.

Required Files: (Currently contained in "Files" within PackageRenamer folder)
- FUSE_20_HR_February_2018_V1_01192018.xlsm
- ADI.DTD (This is an XML Document)
- Fuse_VOD_105x147.jpg
- Fuse_VOD_Logo_320x240px.bmp

Steps: 1. Take in Excel spreadsheet name.
2. If spreadsheet is .xlsm, convert to .csv.
3. Create packages corresponding to column N until end of file (or until coord == " "?).
Note: Packages are always FUSE00.
3. After package creation and file movement, rename .bmp (column S) and .jpg (column T)

Changing file extensions:
https://www.safaribooksonline.com/library/view/c-cookbook/0596007612/ch10s17.html

*/

#include "stdafx.h"

