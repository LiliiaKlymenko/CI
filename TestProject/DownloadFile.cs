using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace TestProject
{
	class DownloadFile
	{
		public static void downloadFileFromURL(string address, string fileName)
		{
			using (WebClient webClient = new WebClient())
			{
                if (File.Exists(fileName))
                {
                    Console.WriteLine("File already exist!");
                }
                else
                {
                    Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n", fileName, address);
                    webClient.DownloadFile(address, @fileName);
                    Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, address);
                    string appDirectory = Environment.CurrentDirectory;
                    Console.WriteLine("\nThe file is saved at:\t" + fileName);
                }
			}

		}
	}
}
