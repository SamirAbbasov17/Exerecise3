using System.Diagnostics.Metrics;
using System.Net;

namespace Exerecise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] allData = { "Employe", "Customer", "Category", "Product", "Shipper", "Shipper", "Department", "Order", "OrderDetail", "Address", "Country", "City", "Town", "Contact" };

            string path = "C:\\Users\\User\\Desktop\\Code Acadamy\\Exerecise3\\Exerecise3\\Models\\";

            foreach (string data in allData) 
            {
                string newPath = path + data +".cs";

                string mainClasses = $"""
                    namespace Exerecise3;

                    public class {data}
                    {"{"}



                    {"}"}
                    
                    """;
                
                if( File.Exists(newPath) ) {
                    File.Delete(newPath);
                    File.WriteAllText(newPath, mainClasses);
                }
                else
                {
                    File.WriteAllText(newPath, mainClasses);
                }
            }
        }
    }
}