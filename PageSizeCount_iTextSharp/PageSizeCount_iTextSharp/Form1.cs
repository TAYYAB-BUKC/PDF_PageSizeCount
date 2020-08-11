using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PageSizeCount_iTextSharp
{
	public partial class Form1 : Form
	{
		OpenFileDialog opf = new OpenFileDialog();
		private string name;
		public Form1()
		{
			InitializeComponent();

			opf.Filter = "Choose PDF File(*.pdf;)|*.pdf;";

			if (opf.ShowDialog() == DialogResult.OK)
			{
					name = opf.FileName;
			}

			iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(name);
			int pageCount = reader.NumberOfPages;

			for (int i = 1; i <= pageCount; i++)
			{
				var page = reader.GetPageSize(i);

				richTextBox1.Text += "\n" + (page.Width / 72); 
			}


		}
	}
}
