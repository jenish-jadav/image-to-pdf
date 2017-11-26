using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ImageToPDF
{
    public partial class Dashboard : Form
    {
        private iTextSharp.text.Rectangle Page_Size;
        private bool status = false;
        private String Temp_Folder = "Temp";

        public String getTempFile(String ImagePath)
        {
            String newfilePath = ImagePath;
            if (!Directory.Exists(Temp_Folder))
                Directory.CreateDirectory(Temp_Folder);
            newfilePath = Path.Combine(Temp_Folder, Path.GetFileNameWithoutExtension(ImagePath) + ".jpg");
            return newfilePath;
        }

        private iTextSharp.text.Image addImage(String ImagePath)
        {
            
            if (isImageCompress.Checked)
            {
                using (Bitmap bitmap = (Bitmap)System.Drawing.Image.FromFile(ImagePath))
                {
                    using (Bitmap newBitmap = new Bitmap(bitmap))
                    {
                        newBitmap.SetResolution(50, 50);
                        newBitmap.Save(getTempFile(ImagePath), ImageFormat.Jpeg);
                    }
                }
                ImagePath = getTempFile(ImagePath);
            }
            
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(ImagePath);
            image.ScaleToFit(Page_Size);
            //image.SpacingAfter = 10;
            image.Alignment = Element.ALIGN_CENTER;
            image.CompressionLevel = PdfStream.BEST_COMPRESSION;
            return image;
        }

        private iTextSharp.text.Paragraph addParagraph(String text = "")
        {
            return new iTextSharp.text.Paragraph(text);
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Date > new DateTime(2017, 02, 11))
            {
                MessageBox.Show("Application Error: xnjds nwjdkj j206", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {

            DialogResult dr = myOpenFileDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in myOpenFileDialog.FileNames)
                {
                    listSourceFiles.Items.Add(file);
                }
                if (listSourceFiles.Items.Count > 0)
                    listSourceFiles.SelectedIndex = 0;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            DialogResult dr = mySaveFileDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtDestinationPath.Text = mySaveFileDialog.FileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listSourceFiles.Items.Clear();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        public void MoveItem(int direction)
        {
            if (listSourceFiles.SelectedItem == null || listSourceFiles.SelectedIndex < 0)
                return;
            int newIndex = listSourceFiles.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= listSourceFiles.Items.Count)
                return;
            object selected = listSourceFiles.SelectedItem;

            listSourceFiles.Items.Remove(selected);
            listSourceFiles.Items.Insert(newIndex, selected);
            listSourceFiles.SetSelected(newIndex, true);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (listSourceFiles.Items.Count == 0)
            {
                showMessage("Please select source file.");
                btnSelectFiles.Focus();
                return;
            }
            else if (listSourceFiles.SelectedIndex < 0)
            {
                showMessage("Please select source file to preview.");
                return;
            }

            if (listSourceFiles.SelectedItem != null && listSourceFiles.SelectedIndex >= 0)
                Process.Start(listSourceFiles.SelectedItem.ToString());
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            toolStrip_Status.Text = "Processing...";
            if (listSourceFiles.Items.Count == 0)
            {
                showMessage("Please select source file(s).");
                btnSelectFiles.Focus();
                return;
            }
            if (txtDestinationPath.Text.Length == 0)
            {
                showMessage("Please select destination file.");
                btnSaveFile.Focus();
                return;
            }

            myBackgroundWorker.RunWorkerAsync();
            toolStrip_ProgressBar.Style = ProgressBarStyle.Marquee;
        }

        private void showMessage(String message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void myBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Document doc = new Document(PageSize.A4, 0, 0, 0, 0);
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(txtDestinationPath.Text, FileMode.Create));
                writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_5);
                writer.CompressionLevel = PdfStream.BEST_COMPRESSION;
                
                Page_Size = doc.PageSize;
                doc.Open();
                foreach (string file in listSourceFiles.Items)
                {
                    //toolStrip_Status.Text = "Processing " + file;
                    doc.Add(addImage(file));
                    //doc.Add(addParagraph());
                }
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                doc.Close();
                if (Directory.Exists(Temp_Folder))
                    Directory.Delete(Temp_Folder, true);
            }
        }



        private void myBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (cbIsOpen.Checked && File.Exists(txtDestinationPath.Text))
            {
                Process.Start(txtDestinationPath.Text);
            }

            toolStrip_ProgressBar.Style = ProgressBarStyle.Blocks;
            toolStrip_ProgressBar.Value = 0;
            if (status)
            {
                toolStrip_Status.Text = "The conversation ended successfully.";
                clearAll();
            }
            else
            {
                toolStrip_Status.Text = "Something is wrong...";
            }
            status = false;
        }

        private void clearAll()
        {
            listSourceFiles.Items.Clear();
            txtDestinationPath.Text = String.Empty;
            cbIsOpen.Checked = true;
            btnSelectFiles.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:jadav.jenish@outlook.com");
        }

        //public static void Temp()
        //{
        //    String stc = @"F:\Personal\Documents\Mobile Scan Documments\jnis.pdf";
        //    String dtc = "new.pdf";
        //    ExtractImagesFromPDF(stc, dtc);
        //}

        //public static void ExtractImagesFromPDF(string sourcePdf, string outputPath)
        //{
        //    // NOTE:  This will only get the first image it finds per page.
        //    PdfReader pdf = new PdfReader(sourcePdf);
        //    RandomAccessFileOrArray raf = new iTextSharp.text.pdf.RandomAccessFileOrArray(sourcePdf);

        //    try
        //    {
        //        for (int pageNumber = 1; pageNumber <= pdf.NumberOfPages; pageNumber++)
        //        {
        //            PdfDictionary pg = pdf.GetPageN(pageNumber);

        //            // recursively search pages, forms and groups for images.
        //            PdfObject obj = FindImageInPDFDictionary(pg);
        //            if (obj != null)
        //            {

        //                int XrefIndex = Convert.ToInt32(((PRIndirectReference)obj).Number.ToString(System.Globalization.CultureInfo.InvariantCulture));
        //                PdfObject pdfObj = pdf.GetPdfObject(XrefIndex);
        //                PdfStream pdfStrem = (PdfStream)pdfObj;
        //                byte[] bytes = PdfReader.GetStreamBytesRaw((PRStream)pdfStrem);
        //                if ((bytes != null))
        //                {
        //                    using (System.IO.MemoryStream memStream = new System.IO.MemoryStream(bytes))
        //                    {
        //                        memStream.Position = 0;
        //                        System.Drawing.Image img = System.Drawing.Image.FromStream(memStream);
        //                        // must save the file while stream is open.
        //                        if (!Directory.Exists(outputPath))
        //                            Directory.CreateDirectory(outputPath);

        //                        string path = Path.Combine(outputPath, String.Format(@"{0}.jpg", pageNumber));
        //                        System.Drawing.Imaging.EncoderParameters parms = new System.Drawing.Imaging.EncoderParameters(1);
        //                        parms.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Compression, 0);
        //                        //System.Drawing.Imaging.ImageCodecInfo jpegEncoder = Utilities.GetImageEncoder("JPEG");
        //                        img.Save(path, null , parms);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch(Exception Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //    }
        //    finally
        //    {
        //        pdf.Close();
        //        raf.Close();
        //    }
        //}

        //private static PdfObject FindImageInPDFDictionary(PdfDictionary pg)
        //{
        //    PdfDictionary res =
        //        (PdfDictionary)PdfReader.GetPdfObject(pg.Get(PdfName.RESOURCES));


        //    PdfDictionary xobj =
        //      (PdfDictionary)PdfReader.GetPdfObject(res.Get(PdfName.XOBJECT));
        //    if (xobj != null)
        //    {
        //        foreach (PdfName name in xobj.Keys)
        //        {

        //            PdfObject obj = xobj.Get(name);
        //            if (obj.IsIndirect())
        //            {
        //                PdfDictionary tg = (PdfDictionary)PdfReader.GetPdfObject(obj);

        //                PdfName type =
        //                  (PdfName)PdfReader.GetPdfObject(tg.Get(PdfName.SUBTYPE));

        //                //image at the root of the pdf
        //                if (PdfName.IMAGE.Equals(type))
        //                {
        //                    return obj;
        //                }// image inside a form
        //                else if (PdfName.FORM.Equals(type))
        //                {
        //                    return FindImageInPDFDictionary(tg);
        //                } //image inside a group
        //                else if (PdfName.GROUP.Equals(type))
        //                {
        //                    return FindImageInPDFDictionary(tg);
        //                }

        //            }
        //        }
        //    }

        //    return null;

        //}


    }
}
