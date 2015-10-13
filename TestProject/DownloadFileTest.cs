using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace TestProject
{
	[TestClass]
	public class DownloadFileTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			#region Test data
			string address = "https://dl.dropboxusercontent.com/u/98396761/NewTxt.txt";
			string fileName = @"c:\NewTxt.txt";
			#endregion

			DownloadFile.downloadFileFromURL(address, fileName);
			Assert.IsTrue(File.Exists(fileName));
		}
	}
}
