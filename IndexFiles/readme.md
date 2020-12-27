# Virtual indexing
## Task 
 
Index the content of the chosen file by virtual partitioning and counting MD5 hash. 
 
Requirements:
 - Patition the file to < 128 parts. 
 - The size of the part should be counted as ceil(file_size / 128).
 - Print the hashes, total time of program work.
 - Time of reading the file.
 - Time of counting the hash.
 - Load the disk memory and the processor.
 
## Solution description
 - Runs on the Windows Forms for Windows 10
 - Uses System.Cryptographt libs to count the hash
