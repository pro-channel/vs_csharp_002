using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// クリック時の処理です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actionButton_Click(object sender, EventArgs e)
        {
            this.MessageLabel.Text = "クリックされました。";
        }

        /// <summary>
        /// マウスが乗った時の処理です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actionButton_MouseHover(object sender, EventArgs e)
        {
            this.MessageLabel.Text = "マウスが乗りました。";
        }

        /// <summary>
        /// マウスが外れた時の処理です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actionButton_MouseLeave(object sender, EventArgs e)
        {
            this.MessageLabel.Text = "マウスが降りました。";
        }
    }
}
