using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace PDF_PageSizeCount
{
	public partial class Form1 : Form
	{
		//private int A0Counter = 0;
		//private int A1Counter = 0;
		//private int A2Counter = 0;
		//private int A3Counter = 0;
		//private int A4Counter = 0;
		//private int A5Counter = 0;
		//private int A6Counter = 0;
		//private int A7Counter = 0;
		//private int A8Counter = 0;
		//private int A9Counter = 0;
		//private int A10Counter = 0;
		//private int RA1Counter = 0;
		//private int LetterCounter = 0;
		private List<string> HeightWidth = new List<string>();
		StringBuilder content;

		public Form1()
		{
			InitializeComponent();

			//Create a PdfDocument instance and load the sample.pdf file.
			PdfDocument doc = new PdfDocument();
			doc.LoadFromFile("Sample.pdf");

			int pageCount = doc.Pages.Count;
			for (int i = 0; i < pageCount; i++)
			{
				//Get the width and height of the page in the PDF file.
				PdfPageBase page = doc.Pages[i];
				float pointWidth = page.Size.Width;
				float pointHeight = page.Size.Height;
				//if (page.Size == PdfPageSize.A0)
				//{
				//	A0Counter++;
				//}
				//else if (page.Size == PdfPageSize.A1)
				//{
				//	A1Counter++;
				//}
				//else if (page.Size == PdfPageSize.A2)
				//{
				//	A2Counter++;
				//}
				//else if (page.Size == PdfPageSize.A3)
				//{
				//	A3Counter++;
				//}
				//else if (page.Size == PdfPageSize.A4)
				//{
				//	A4Counter++;
				//}
				//else if (page.Size.Height == 420 && page.Size.Width == 595)
				//{
				//	A5Counter++;
				//}
				//else if (page.Size == PdfPageSize.A6)
				//{
				//	A6Counter++;
				//}
				//else if (page.Size == PdfPageSize.A7)
				//{
				//	A7Counter++;
				//}
				//else if (page.Size == PdfPageSize.A8)
				//{
				//	A8Counter++;
				//}
				//else if (page.Size == PdfPageSize.A9)
				//{
				//	A9Counter++;
				//}
				//else if (page.Size == PdfPageSize.A10)
				//{
				//	A10Counter++;
				//}


				//Create PdfUnitConvertor to convert the unit
				PdfUnitConvertor unitCvtr = new PdfUnitConvertor();

				////Convert the size with "pixel"
				//float pixelWidth = unitCvtr.ConvertUnits(pointWidth, PdfGraphicsUnit.Point, PdfGraphicsUnit.Pixel);
				//float pixelHeight = unitCvtr.ConvertUnits(pointHeight, PdfGraphicsUnit.Point, PdfGraphicsUnit.Pixel);

				//Convert the size with "inch"
				float inchWidth = unitCvtr.ConvertUnits(pointWidth, PdfGraphicsUnit.Point, PdfGraphicsUnit.Inch);
				float inchHeight = unitCvtr.ConvertUnits(pointHeight, PdfGraphicsUnit.Point, PdfGraphicsUnit.Inch);

				////Convert the size with "centimeter"
				//float centimeterWidth = unitCvtr.ConvertUnits(pointWidth, PdfGraphicsUnit.Point, PdfGraphicsUnit.Centimeter);
				//float centimeterHeight = unitCvtr.ConvertUnits(pointHeight, PdfGraphicsUnit.Point, PdfGraphicsUnit.Centimeter);

				//Create StringBuilder to save 
				//Add pointSize string to StringBuilder
				//content.AppendLine("The page size of the file is (width: " + pointWidth + "pt, height: " + pointHeight + "pt).");
				//content.AppendLine("The page size of the file is (width: " + pixelWidth + "pixel, height: " + pixelHeight + "pixel).");
				string heightWidth = Math.Round(inchWidth,1) + "," + Math.Round(inchHeight,1);
				HeightWidth.Add(heightWidth);
				//content.AppendLine("The page size of the file is (width: " + centimeterWidth + "cm, height: " + centimeterHeight + "cm.)");

				//richTextBox1.Text += heightWidth;


			}

			content = new StringBuilder();
			foreach (var text in HeightWidth)
			{
				content.AppendLine(text);
			}

			String output = "Temp.txt";
			//Save them to a txt file
			File.WriteAllText(output, content.ToString());

			richTextBox1.Text += "Now CountWriter Starts\n";



			foreach (var text in HeightWidth)
			{
				CountWriter(text);
			}

			if (File.Exists("Temp.txt"))
			{
				File.Delete("Temp.txt");
			}
			//CountWriter("33.11 x 46.81", A0Counter);
			//CountWriter("23.39 x 33.11", A1Counter);
			//CountWriter("16.54 x 23.39", A2Counter);
			//CountWriter("11.69 x 16.54", A3Counter);
			//CountWriter("8.27 x 11.69", A4Counter);
			//CountWriter("5.83 x 8.27", A5Counter);
			//CountWriter("4.13 x 5.83", A6Counter);
			//CountWriter("2.91 x 4.13", A7Counter);
			//CountWriter("2.05 x 2.91", A8Counter);
			//richTextBox1.Text += "\nA1 Counts: " + A1Counter;
			//richTextBox1.Text += "\nA2 Counts: " + A2Counter;
			//richTextBox1.Text += "\nA3 Counts: " + A3Counter;
			//richTextBox1.Text += "\nA4 Counts: " + A4Counter;
			//richTextBox1.Text += "\nA5 Counts: " + A5Counter;
			//richTextBox1.Text += "\nA6 Counts: " + A6Counter;
			//richTextBox1.Text += "\nA7 Counts: " + A7Counter;
			//richTextBox1.Text += "\nA8 Counts: " + A8Counter;
			//richTextBox1.Text += "\nA9 Counts: " + A9Counter;
			//richTextBox1.Text += "\nA10 Counts: " + A10Counter;
			//richTextBox1.Text += "\nRA1 Counts: " + RA1Counter;




			//counting pages using Regular Expression
			//FileStream fs = new FileStream("Sample.pdf", FileMode.Open, FileAccess.Read);
			//StreamReader r = new StreamReader(fs);
			//string pdfText = r.ReadToEnd();

			//Regex rx1 = new Regex(@"/Type\s*/Page[^s]");
			//MatchCollection matches = rx1.Matches(pdfText);
			//MessageBox.Show("The PDF file has " + matches.Count.ToString() + " page(s).");

		}

		private void CountWriter(string text)
		{
			int count = 0;
			using (StreamReader sr = new StreamReader("Temp.txt"))
			{
				while (!sr.EndOfStream)
				{
					var counts = sr
						.ReadLine()
						.Split(' ')
						.GroupBy(s => s)
						.Select(g => new { Word = g.Key, Count = g.Count() });
					var wc = counts.SingleOrDefault(c => c.Word == text);
					count += (wc == null) ? 0 : wc.Count;
				}
			}

			richTextBox1.Text += "\n"+ text +" Count(s): " + count;
		}
	}
}
