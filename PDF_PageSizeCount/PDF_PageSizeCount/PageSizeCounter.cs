using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace PDF_PageSizeCount
{
	public partial class PageSizeCounter : Form
	{
		private List<string> HeightWidth = new List<string>();
		StringBuilder content = new StringBuilder();
		OpenFileDialog opf = new OpenFileDialog();
		bool isDrag;
		Point startPoint = new Point(0, 0);
		public PageSizeCounter()
		{
			InitializeComponent();
		}

		private void Button_Choose_Click(object sender, EventArgs e)
		{
			Grd_PageSizeCounter.Rows.Clear();
			HeightWidth.Clear();

			if (content.Length > 0)
			{
				content.Clear();
			}
			opf.Multiselect = false;

			opf.Filter = "Choose PDF File(*.pdf;)|*.pdf;";

			if (opf.ShowDialog() == DialogResult.OK)
			{
				Filepath.Text = opf.FileName;

				//Create a PdfDocument instance and load the sample.pdf file.
				PdfDocument doc = new PdfDocument();
				doc.LoadFromFile(Filepath.Text);

				int pageCount = doc.Pages.Count;

				if (pageCount > 0)
				{
					for (int i = 0; i < pageCount; i++)
					{
						//Get the width and height of the page in the PDF file.
						PdfPageBase page = doc.Pages[i];
						float pointWidth = page.Size.Width;
						float pointHeight = page.Size.Height;

						//Create PdfUnitConvertor to convert the unit
						PdfUnitConvertor unitCvtr = new PdfUnitConvertor();

						//Convert the size with "inch"
						float inchWidth = unitCvtr.ConvertUnits(pointWidth, PdfGraphicsUnit.Point, PdfGraphicsUnit.Inch);
						float inchHeight = unitCvtr.ConvertUnits(pointHeight, PdfGraphicsUnit.Point, PdfGraphicsUnit.Inch);

						string heightWidth = Math.Round(inchWidth, 1) + "," + Math.Round(inchHeight, 1);
						HeightWidth.Add(heightWidth);

					}

					foreach (var text in HeightWidth)
					{
						content.AppendLine(text);
					}

					String output = "Temp.txt";
					//Save them to a txt file
					File.WriteAllText(output, content.ToString());

					foreach (var text in HeightWidth.Distinct().ToList())
					{
						CountWriter(text, Path.GetFileName(Filepath.Text));
					}

					if (File.Exists("Temp.txt"))
					{
						File.Delete("Temp.txt");
					}
				}
				else
				{
					MessageBox.Show("File is empty", "Process Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("No File Selected", "Process Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CountWriter(string text, string filename)
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

			int place = text.LastIndexOf(",");
			string width = text.Substring(0, place);
			string height = text.Substring(place + 1);

			Grd_PageSizeCounter.Rows.Add(count, height, width, filename);

		}

		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void PageSizeCounter_MouseDown(object sender, MouseEventArgs e)
		{
			isDrag = true;
			startPoint = new Point(e.X, e.Y);
		}

		private void PageSizeCounter_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDrag)
			{
				Point point = PointToScreen(e.Location);
				this.Location = new Point(point.X - startPoint.X, point.Y - startPoint.Y);
			}
		}

		private void PageSizeCounter_MouseUp(object sender, MouseEventArgs e)
		{
			isDrag = false;
		}

		private void Button_MultipleFiles_Click(object sender, EventArgs e)
		{
			Grd_PageSizeCounter.Rows.Clear();
			HeightWidth.Clear();
			Filepath.Text = "";
			if (content.Length > 0)
			{
				content.Clear();
			}

			opf.Multiselect = true;

			opf.Filter = "Choose PDF File(*.pdf;)|*.pdf;";

			if (opf.ShowDialog() == DialogResult.OK)
			{
				foreach (String file in opf.FileNames)
				{
					try
					{
						//Create a PdfDocument instance and load the sample.pdf file.
						PdfDocument doc = new PdfDocument();
						doc.LoadFromFile(file);

						int pageCount = doc.Pages.Count;

						if (pageCount > 0)
						{
							for (int i = 0; i < pageCount; i++)
							{
								//Get the width and height of the page in the PDF file.
								PdfPageBase page = doc.Pages[i];
								float pointWidth = page.Size.Width;
								float pointHeight = page.Size.Height;

								//Create PdfUnitConvertor to convert the unit
								PdfUnitConvertor unitCvtr = new PdfUnitConvertor();

								//Convert the size with "inch"
								float inchWidth = unitCvtr.ConvertUnits(pointWidth, PdfGraphicsUnit.Point, PdfGraphicsUnit.Inch);
								float inchHeight = unitCvtr.ConvertUnits(pointHeight, PdfGraphicsUnit.Point, PdfGraphicsUnit.Inch);

								string heightWidth = Math.Round(inchWidth, 1) + "," + Math.Round(inchHeight, 1);
								HeightWidth.Add(heightWidth);

							}

							foreach (var text in HeightWidth)
							{
								content.AppendLine(text);
							}

							String output = "Temp.txt";
							//Save them to a txt file
							File.WriteAllText(output, content.ToString());

							foreach (var text in HeightWidth.Distinct().ToList())
							{
								CountWriter(text, Path.GetFileName(file));
							}
							if (File.Exists("Temp.txt"))
							{
								File.Delete("Temp.txt");
							}
							HeightWidth.Clear();
							if (content.Length > 0)
							{
								content.Clear();
							}
						}
						else
						{
							MessageBox.Show("File is empty", "Process Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}

					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message);
					}
				}
			}
			else
			{
				MessageBox.Show("No File Selected", "Process Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}