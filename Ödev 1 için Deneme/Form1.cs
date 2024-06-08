/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: ZEYNEP YENER
**				ÖĞRENCİ NUMARASI.......: B231210099
**              DERSİN ALINDIĞI GRUP...: B GRUBU    
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //File sınıfını kullanabilmek için ekledim.

namespace Ödev_1_için_Deneme
{
    public partial class Form1 : Form
    {
        //Dosyanın kaydedilme durumunu kontrol eder.
        private bool isFileSaved = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kesButonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaButonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();   
        }

        private void dikdortgenCizButonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color selectedColor = colorDialog1.Color;
            System.Drawing.Graphics yeniNesne;
            yeniNesne = this.CreateGraphics();
            Pen myPen = new Pen(selectedColor, 3);
            Rectangle yeniDikdrtgn = new Rectangle(50, 50, 250, 200);
            //RichTextBox üzerine dikdörtgeni çizmek için bir Graphics nesnesi kullandım.
            using (Graphics grafik = richTextBox1.CreateGraphics())
            {
                grafik.DrawRectangle(myPen, yeniDikdrtgn);
            }
            myPen.Dispose();//Kalemi temizler.
        }


        private void dikdortgenCiz2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color selectedColor = colorDialog1.Color;
            System.Drawing.Graphics yeniNesne;
            yeniNesne = this.CreateGraphics();
            Pen myPen = new Pen(selectedColor, 3);
            Rectangle yeniDikdrtgn = new Rectangle(50, 50, 250, 200);
            //RichTextBox üzerine dikdörtgeni çizmek için bir Graphics nesnesi kullandım.
            using (Graphics grafik = richTextBox1.CreateGraphics())
            {
                grafik.DrawRectangle(myPen, yeniDikdrtgn);
            }
            myPen.Dispose();//Kalemi temizler.
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        

        private void acToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Lütfen Bir Dosya Seçiniz.";
            openFileDialog1.Filter = "Metin Dosyaları|*.rtf|Tüm Dosyalar|*.*";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Multiselect = false;
            // Kullanıcının bir dosya seçip seçmediğini kontrol eder.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void yapistirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cikisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Dosyanın kaydedilip kaydedilmediğini kontrol eder.
            if (!isFileSaved)
            {
                DialogResult result = MessageBox.Show("Dosyayı kaydetmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
                //Message box'tan gelen sonuç evet ise dosyayı kaydetmeye yarayan fonksiyonu çalıştırır.
                if (result == DialogResult.Yes)
                {
                    // Kullanıcının bir dosya seçip seçmediğini kontrol eder.
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                }
                //Message box'tan gelen sonuç iptal ise geri döner.
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            Application.Exit();
        }

        private void kaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           //Kullanıcının bir dosya seçip seçmediğini kontrol eder.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                saveFileDialog1.Filter = "Metin Dosyaları|*.rtf|Tüm Dosyalar|*.*";
            }
        }

        private void yaziRengiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color selectedColor = colorDialog1.Color;

            // RichTextBox içindeki seçili metnin rengini değiştir.
            richTextBox1.SelectionColor = selectedColor;

        }

        private void yaziTipiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            Font selectedFont = fontDialog1.Font;
            richTextBox1.SelectionFont = selectedFont;
        }

        private void zeminRengiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();  
            Color selectedColor2 = colorDialog2.Color;  
            richTextBox1.SelectionBackColor = selectedColor2;
        }

        private void yeniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Dosyanın kaydedilip kaydedilmediğini sorgular.
            if(!isFileSaved)
            {
                DialogResult result = MessageBox.Show("Dosyayı kaydetmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
                //Message box'tan gelen sonuç evet ise dosyayı kaydetmeye yarayan fonksiyonu çalıştırır.
                if (result== DialogResult.Yes)
                {
                    // Kullanıcının bir dosya seçip seçmediğini kontrol eder.
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                }
                //Message box'tan gelen sonuç iptal ise geri döner.
                else if (result == DialogResult.Cancel)
                {
                    return;
                }

            }
            richTextBox1.Text = " ";
        }

        private void tumunuSecToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void geriAlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();    
        }

        private void boldButonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mevcut yazı tipini alır.
            Font currentFont = richTextBox1.SelectionFont;

            // Eğer yazı tipi null ise, varsayılan bir yazı tipi oluştur.
            if (currentFont == null)
            {
                currentFont = richTextBox1.Font;
            }

            FontStyle newStyle = currentFont.Bold ? currentFont.Style & ~FontStyle.Bold : currentFont.Style | FontStyle.Bold;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);

            // Seçili metnin yazı tipini değiştir
            richTextBox1.SelectionFont = newFont;
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;

            // Eğer yazı tipi null ise, varsayılan bir yazı tipi oluşturur.
            if (currentFont == null)
            {
                currentFont = richTextBox1.Font;
            }

            FontStyle newStyle = currentFont.Italic ? currentFont.Style & ~FontStyle.Italic : currentFont.Style | FontStyle.Italic;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);

            // Seçili metnin yazı tipini değiştir
            richTextBox1.SelectionFont = newFont;
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;

            // Eğer yazı tipi null ise, varsayılan bir yazı tipi oluşturur.
            if (currentFont == null)
            {
                currentFont = richTextBox1.Font;
            }
            FontStyle newStyle = currentFont.Underline ? currentFont.Style & ~FontStyle.Underline : currentFont.Style | FontStyle.Underline;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);

            // Seçili metnin yazı tipini değiştir
            richTextBox1.SelectionFont = newFont;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("#include <stdio.h>\r\n\r\nint main() {\r\n    printf(\"Hello, World!\\n\");\r\n    return 0;\r\n} ");
        }

        private void cSharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("using System;\r\n\r\nclass Program\r\n{\r\n    static void Main()\r\n    {\r\n        Console.WriteLine(\"Hello, World!\");\r\n    }\r\n}\r\n");
        }

        private void cPlusPlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    cout << \"Hello, World!\" << endl;\r\n    return 0;\r\n}\r\n");

        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapistirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void tumunuSecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        
        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void kalinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;

            // Eğer yazı tipi null ise, varsayılan bir yazı tipi oluşturur.
            if (currentFont == null)
            {
                currentFont = richTextBox1.Font;
            }

            FontStyle newStyle = currentFont.Bold ? currentFont.Style & ~FontStyle.Bold : currentFont.Style | FontStyle.Bold;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);

            richTextBox1.SelectionFont = newFont;
        }

        private void italikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            // Eğer yazı tipi null ise, varsayılan bir yazı tipi oluşturur.
            if (currentFont == null)
            {
                currentFont = richTextBox1.Font;
            }

            FontStyle newStyle = currentFont.Italic ? currentFont.Style & ~FontStyle.Italic : currentFont.Style | FontStyle.Italic;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);

            richTextBox1.SelectionFont = newFont;
        }

        private void altiCiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            // Eğer yazı tipi null ise, varsayılan bir yazı tipi oluşturur.
            if (currentFont == null)
            {
                currentFont = richTextBox1.Font;
            }

            FontStyle newStyle = currentFont.Underline ? currentFont.Style & ~FontStyle.Underline : currentFont.Style | FontStyle.Underline;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);

            richTextBox1.SelectionFont = newFont;
        }

        private void ozellestirilmisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            Font selectedFont = fontDialog1.Font;
            richTextBox1.SelectionFont = selectedFont;
        }

        private void yaziRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color selectedColor = colorDialog1.Color;

            // RichTextBox içindeki seçili metnin rengini değiştir
            richTextBox1.SelectionColor = selectedColor;
        }

        private void zeminRengiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            Color selectedColor2 = colorDialog2.Color;
            richTextBox1.SelectionBackColor = selectedColor2;
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dosyanın kaydedilip kaydedilmediğini kontrol eder.
            if (!isFileSaved)
            {
                DialogResult result = MessageBox.Show("Dosyayı kaydetmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
                //Message box'tan gelen sonuç evet ise dosyayı kaydetmeye yarayan fonksiyonu çalıştırır.
                if (result == DialogResult.Yes)
                {
                    // Kullanıcının bir dosya seçip seçmediğini kontrol eder.
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                }
                //Message box'tan gelen sonuç iptal ise geri döner.
                else if (result == DialogResult.Cancel)
                {
                    return;
                }

            }
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dosyanın kaydedilip kaydedilmediğini kontrol eder.
            if (!isFileSaved)
            {
                DialogResult result = MessageBox.Show("Dosyayı kaydetmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
                //Message box'tan gelen sonuç evet ise dosyayı kaydetmeye yarayan fonksiyonu çalıştırır.
                if (result == DialogResult.Yes)
                {
                    // Kullanıcının bir dosya seçip seçmediğini kontrol eder.
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                }
                //Message box'tan gelen sonuç iptal ise geri döner.
                else if (result == DialogResult.Cancel)
                {
                    return;
                }

            }
        }
    }
}

