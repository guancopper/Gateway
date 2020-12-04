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
using HZH_Controls.Controls;

namespace Gateway
{
    public partial class GatawayIndex : Skin_Mac
    {
        public GatawayIndex()
        {
            InitializeComponent();
        }

        private void GatawayIndex_Load(object sender, EventArgs e)
        {
            List<ListEntity> list = new List<ListEntity>();
            ListEntity listEn1 = new ListEntity();
            listEn1.ID = "1";
            listEn1.Title = "485";
            ListEntity listEn2 = new ListEntity();
            listEn2.ID = "2";
            listEn2.Title = "CAN";
            ListEntity listEn3 = new ListEntity();
            listEn3.ID = "3";
            listEn3.Title = "4G";
            ListEntity listEn4 = new ListEntity();
            listEn4.ID = "4";
            listEn4.Title = "NET";
            ListEntity listEn5 = new ListEntity();
            listEn5.ID = "5";
            listEn5.Title = "WALN/LAN";
            list.Add(listEn1);
            list.Add(listEn2);
            list.Add(listEn3);
            list.Add(listEn4);
            list.Add(listEn5);
            this.ListExt.SetList(list);
            IndexForm indexForm = new IndexForm();
            this.OpenFrm(indexForm);
        }

        //用于关闭panel中的窗体，直接调用即可
        private void CloseFrm()
        {
            //palParent为panel控件
            foreach (Control item in this.RoutePanel.Controls)
            {
                if (item is Form)
                {
                    Form form = (Form)item;
                    form.Close();
                    this.RoutePanel.Controls.Remove(form);
                }
            }
        }
        //在panel中打开指定窗体，调用该方法时，只需传入一个窗体对象即可
        private void OpenFrm(Form frm)
        {
            frm.TopLevel = false;//取消非顶级窗体
            frm.WindowState = FormWindowState.Maximized;//将窗体最大化
            frm.FormBorderStyle = FormBorderStyle.None;//设为无边框
            frm.Parent = this.RoutePanel;//指定该窗体的父窗体
            frm.Show();//展示窗体
        }

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            this.CloseFrm();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.CloseFrm();
            Cloud cloud = new Cloud();
            this.OpenFrm(cloud);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.CloseFrm();
            ProtocolConversion protocol = new ProtocolConversion();
            this.OpenFrm(protocol);
        }
    }
}
