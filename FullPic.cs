using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_WF_
{
    public partial class FullPic : Form
    {
        public FullPic()
        {
            InitializeComponent();
        }

        public void Show(string str)
        {
            this.Show();
            try
            {
                
                FileStream fs = new System.IO.FileStream($"Image\\{str}.jpg", FileMode.Open, FileAccess.Read);
                this.BackgroundImage = Image.FromStream(fs);
                fs.Close();
            }
            catch
            {
            }
        }
    }
}
