using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBFileShareClient
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Connecting to network resource...");

                    var ret = NetResource.CopyFile("SMBFileShareClient.pdb", @"\\10.0.0.31\mike", @"PHATGOCODE\FileRepositoryUser", "^Slinky4$");
                    if (ret != null)
                    {
                        Console.Error.WriteLine("Error returned: " + ret);
                    }

                    Console.WriteLine("Success!");

                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Error: " + ex);
                }
                finally
                {
                    Console.WriteLine("*** END ***");
                    Console.Out.Flush();
                    System.Threading.Thread.Sleep(5000);
                }
            }
           


        }
    }
}
