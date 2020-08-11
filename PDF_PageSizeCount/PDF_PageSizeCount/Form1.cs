using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace PDF_PageSizeCount
{
	public partial class Form1 : Form
	{
		private int A0Counter = 0;
		private int A1Counter = 0;
		private int A2Counter = 0;
		private int A3Counter = 0;
		private int A4Counter = 0;
		private int A5Counter = 0;
		private int A6Counter = 0;
		private int A7Counter = 0;
		private int A8Counter = 0;
		private int A9Counter = 0;
		private int A10Counter = 0;
		private int RA1Counter = 0;
		private int LetterCounter = 0;
		
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
				var size = PdfPageSize.A5;
				size.Height = 420;
				size.Width = 525;
				if (page.Size == PdfPageSize.A0)
				{
					A0Counter++;
				}
				else if (page.Size == PdfPageSize.A1)
				{
					A1Counter++;
				}
				else if (page.Size == PdfPageSize.A2)
				{
					A2Counter++;
				}
				else if (page.Size == PdfPageSize.A3)
				{
					A3Counter++;
				}
				else if (page.Size == PdfPageSize.A4)
				{
					A4Counter++;
				}
				else if (page.Size.Height == 420 && page.Size.Width == 595)
				{
					A5Counter++;
				}
				else if (page.Size == PdfPageSize.A6)
				{
					A6Counter++;
				}
				else if (page.Size == PdfPageSize.A7)
				{
					A7Counter++;
				}
				else if (page.Size == PdfPageSize.A8)
				{
					A8Counter++;
				}
				else if (page.Size == PdfPageSize.A9)
				{
					A9Counter++;
				}
				else if (page.Size == PdfPageSize.A10)
				{
					A10Counter++;
				}
				else if (page.Size.Height == 2438 && page.Size.Width == 1729)
				{
					RA1Counter++;
				}
			}
			richTextBox1.Text += "\nA0 Counts: " + A0Counter;
			richTextBox1.Text += "\nA1 Counts: " + A1Counter;
			richTextBox1.Text += "\nA2 Counts: " + A2Counter;
			richTextBox1.Text += "\nA3 Counts: " + A3Counter;
			richTextBox1.Text += "\nA4 Counts: "+  A4Counter;
			richTextBox1.Text += "\nA5 Counts: " + A5Counter;
			richTextBox1.Text += "\nA6 Counts: " + A6Counter;
			richTextBox1.Text += "\nA7 Counts: " + A7Counter;
			richTextBox1.Text += "\nA8 Counts: " + A8Counter;
			richTextBox1.Text += "\nA9 Counts: " + A9Counter;
			richTextBox1.Text += "\nA10 Counts: " + A10Counter;
			richTextBox1.Text += "\nRA1 Counts: " + RA1Counter;
		}
	}
}
