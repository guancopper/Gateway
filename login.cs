using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using HZH_Controls;

namespace Gateway
{
    public partial class login : Skin_Mac
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.PassWord.PasswordChar = '*';
        }

        private void loginBtn_BtnClick(object sender, EventArgs e)
        {

        }
    }
}
