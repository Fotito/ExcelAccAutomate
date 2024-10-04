using ClosedXML;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("please give the name or filepath of the excel file. use a .xlxs file");
        string path = Console.ReadLine();
        while (path == null)
        {
            Console.WriteLine("please give the name or filepath of the excel file");
            path = Console.ReadLine();
        }

        FileInfo fileInfo = new FileInfo(path);
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        ExcelPackage package = new ExcelPackage(fileInfo);
        
            Console.WriteLine("give the name of the sheet with the RSA balance");
            string rsaWSheet = Console.ReadLine();

        ExcelWorksheet rsaSheet = package.Workbook.Worksheets[rsaWSheet];
      int  resCol = rsaSheet.Columns.Count();
       int resRow = rsaSheet.Rows.Count();
                  
        Console.WriteLine("give the name of the sheet with the Fasta Balances");
                string fasWSheet = Console.ReadLine();

        ExcelWorksheet FastaSheet = package.Workbook.Worksheets[fasWSheet];
                       int  fasColumns = FastaSheet.Columns.Count();
                    int    fasRows=FastaSheet.Rows.Count();
                        
                  
                //create objects of all 3 classes, fill rsa and fasta with record from excel.
                //do that all in a loop that repeats so long as both have more records to take from
                //use a nested loop, where it looks through ID numbers until it finds one that is the same
                //once it does, fill the 2 account objects, then make a combined account with data from the 2 objects

                //use a for loop until it finds the column with the header of ID number
                //then sort through both columns and from there find 2 IDs that match. 
                //then in that row, get all the seperate things like balance outstanding, closing amount and whatnot
              
                /* for (int i = 0; i <= resCol; i++) {
                    if (rsaSheet.Cells[1, i] != null) { }
                }*/

            }
        }

