/* 
Josh Bartlett
16Aug2019
Assignment 9.3
Compare two file's sizes that contain the same movie quote, one created using Notepad and the other Word. 
Display the files' sizes and the ratio of the sizes.
*/

using static System.Console;
using System.IO;
using System;

class FileComparison
{
    static void Main()
    {
        // string variable to hold the path to the file holding the movie quote files. Will have to be changed to where the project file is saved
        // the @ makes it so it doesn't read the \s as escape sequences
        string path = @"C:\Users\jmbartlett\Desktop\school\2. summer2019\businessSystemProgramming\code\Assignment9.3\";
        
        // create FileInfo objects for each file and then get their size converted to integer
        FileInfo nFileInfo = new FileInfo(path + "MovieQuote.txt");
        int NpSize = Convert.ToInt32(nFileInfo.Length);
        
        FileInfo wFileInfo = new FileInfo(path + "MovieQuote.docx");
        int WdSize = Convert.ToInt32(wFileInfo.Length);
        
        // integer variable to hold the greatest common denominator for use with ratio. calls the GCD function
        int gcd = GCD(WdSize, NpSize);

        // display the files sizes and the ratio using the gcd
        WriteLine("The quote file's size typed in Notepad is " + NpSize + " bytes");
        WriteLine("The quote file's size typed in Word is " + WdSize + " bytes");
        WriteLine("The ratio of the Word file to the Notepad file is {0}:{1}", WdSize / gcd, NpSize / gcd);

        // keeps console open until a key is pressed
        ReadKey(true);
    }

    // Euclidean algorithm found online at https://www.dotnetspider.com/forum/309004-How-calculate-ratio-using-C.aspx
    // to find the greatest common denominator
    static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}
