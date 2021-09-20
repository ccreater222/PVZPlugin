using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVZ_Plugin
{
    public partial class Main : Form
    {
        private PVZPlugins plugins;
        public Main()
        {
            plugins = new PVZPlugins();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter) {
                MessageLable.Text = Sun.Text;
                try {
                    plugins.SetSun(Int32.Parse(Sun.Text));
                }catch(Exception err)
                {
                    MessageLable.Text = "无法设置阳光："+err.Message;
                }

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try {
                if (SunBind.Checked)
                {
                    MessageLable.Text = "当前阳光：" + Sun.Text;
                    plugins.SetSun(Int32.Parse(Sun.Text));
                }
                else
                {
                    MessageLable.Text = "当前阳光：" + (plugins.GetSun()).ToString();
                }
                
            }catch(Exception err)
            {
                MessageLable.Text = err.Message;
            }
            //Util.OpenProcess(Util.PROCESS_ALL_ACCESS, true, 0);
        }
    }
}
