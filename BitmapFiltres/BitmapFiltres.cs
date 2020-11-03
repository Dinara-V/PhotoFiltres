using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BitmapFiltres
{
    public partial class BitmapFiltres : Form
    {
        public BitmapFiltres()
        {
            InitializeComponent();
        }
        private Bitmap image;
        private List<IFilter> filtres;
        private ChangeImage changeImage;
        private bool fileOpened = false;
        private bool filterApplied = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                image = new Bitmap(openFileDialog1.FileName);
                fileOpened = true;
            }
            //image = new Bitmap("c:\\temp\\Photo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
            filtres= new List<IFilter>();
            filtres.Add(new Negative(image));
            filtres.Add(new BlackAndWhite(image));
            filtres.Add(new ShadesOfGray(image));
            filtres.Add(new Mirror(image));
            filtres.Add(new Red(image));
            filtres.Add(new Blue(image));
            trackBar1.Maximum = filtres.Count-1;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            changeImage = new ChangeImage(pictureBox1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (fileOpened)
            {
                changeImage.applyFilter(filtres[trackBar1.Value]);
                filterApplied = true;
            }
            else
                MessageBox.Show("Сначала откройте картинку");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filterApplied)
            {
                saveFileDialog1.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    changeImage.GetImage.Save(saveFileDialog1.FileName);
                }
            }
            else
                MessageBox.Show("Сначала примените фильтр");
        }
    }
}
