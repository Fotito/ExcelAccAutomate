using ClosedXML;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("please give the name or filepath of the excel file. use a .xlsx file");
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
                        
                  for (int i = 2; i <= resRow; i++)
{// make rsa account object
	
	for (int j = 2; j <=fasRows; j++) {
	//make fasta account object, do aformantioned processing, ad combined account to array
	}
	
}

	               List <RsaAcc> rsaAccs = new List <RsaAcc>();
 List <FastaAcs> fasAccs= new List<FastaAcs>();

 for (int j = 2; j <= fasRows; j++)
 {
     fasAccs.Add(new FastaAcs(FastaSheet.Cells[j, 1].Value.ToString(),
         FastaSheet.Cells[j, 2].Value.ToString(),
         FastaSheet.Cells[j, 3].Value.ToString(),
         FastaSheet.Cells[j, 4].Value.ToString(),
         FastaSheet.Cells[j, 5].Value.ToString(),
         FastaSheet.Cells[j, 6].Value.ToString(),
         FastaSheet.Cells[j, 7].Value.ToString(),
         double.Parse(FastaSheet.Cells[j, 25].Value.ToString())
         ));
 }

 for (int i = 2; i <= resRow; i++)
 {
     if (rsaSheet.Cells[i, 1].Value.ToString().Equals("FASTA (Pty) Ltd"))
     {
         try { 
             rsaAccs.Add(new RsaAcc(rsaSheet.Cells[i, 1].Value.ToString(),
                 rsaSheet.Cells[i, 4].Value.ToString(),
                 rsaSheet.Cells[i, 5].Value.ToString(),
                 rsaSheet.Cells[i, 6].Value.ToString(),
                 rsaSheet.Cells[i, 8].Value.ToString(),
                 rsaSheet.Cells[i, 9].Value.ToString(),
                Convert.ToDouble(rsaSheet.Cells[i, 11].Value.ToString()),
                 Convert.ToDouble(rsaSheet.Cells[i, 12].Value.ToString())
                 ));
             Console.WriteLine(i);
         }
         catch (Exception e) { Console.WriteLine("something is wrong with the record at row " + i); }

     }

 }
 //get lists for bth, create 2 lists, compare
 

 for (int i = 0; i <= rsaAccs.Count; i++) {

     for (int j = 0; j <= fasAccs.Count; j++) {
         if ((rsaAccs[i].getID()).Equals(fasAccs[j].getID())) {
             rsaAccs.Remove(rsaAccs[i]);
             fasAccs.Remove(fasAccs[j]);
         }


     }

 }

 Console.WriteLine(rsaAccs.Count+" "+fasAccs.Count);
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

