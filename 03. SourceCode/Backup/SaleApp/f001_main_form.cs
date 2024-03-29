using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

using System.Data;

namespace SaleApp
{
	/// <summary>
	/// Summary description for f001_main_form.
	/// </summary>
	public class f001_main_form : System.Windows.Forms.Form
    {
        private IContainer components;

		public f001_main_form()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
            format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f001_main_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanTriHêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_user_management = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTưĐiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_directory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_type_of_directory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_license = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.mnu_category = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.nhậpLiệuToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.mnu_license});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đToolStripMenuItem,
            this.quanTriHêThôngToolStripMenuItem,
            this.quanLyTưĐiênToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnu_exit});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đToolStripMenuItem
            // 
            this.đToolStripMenuItem.Name = "đToolStripMenuItem";
            this.đToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.đToolStripMenuItem.Text = "Đăng nhập";
            // 
            // quanTriHêThôngToolStripMenuItem
            // 
            this.quanTriHêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_user_management});
            this.quanTriHêThôngToolStripMenuItem.Name = "quanTriHêThôngToolStripMenuItem";
            this.quanTriHêThôngToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.quanTriHêThôngToolStripMenuItem.Text = "Quản trị hệ thống";
            // 
            // mnu_user_management
            // 
            this.mnu_user_management.Name = "mnu_user_management";
            this.mnu_user_management.Size = new System.Drawing.Size(153, 22);
            this.mnu_user_management.Text = "Người sử dụng";
            this.mnu_user_management.Click += new System.EventHandler(this.mnu_user_management_Click);
            // 
            // quanLyTưĐiênToolStripMenuItem
            // 
            this.quanLyTưĐiênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_directory,
            this.mnu_type_of_directory});
            this.quanLyTưĐiênToolStripMenuItem.Name = "quanLyTưĐiênToolStripMenuItem";
            this.quanLyTưĐiênToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.quanLyTưĐiênToolStripMenuItem.Text = "Quản lý từ điển";
            // 
            // mnu_directory
            // 
            this.mnu_directory.Name = "mnu_directory";
            this.mnu_directory.Size = new System.Drawing.Size(136, 22);
            this.mnu_directory.Text = "Từ điển";
            this.mnu_directory.Click += new System.EventHandler(this.mnu_directory_Click);
            // 
            // mnu_type_of_directory
            // 
            this.mnu_type_of_directory.Name = "mnu_type_of_directory";
            this.mnu_type_of_directory.Size = new System.Drawing.Size(136, 22);
            this.mnu_type_of_directory.Text = "Loại từ điển";
            this.mnu_type_of_directory.Click += new System.EventHandler(this.mnu_type_of_directory_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // mnu_exit
            // 
            this.mnu_exit.Name = "mnu_exit";
            this.mnu_exit.Size = new System.Drawing.Size(168, 22);
            this.mnu_exit.Text = "Thoát";
            this.mnu_exit.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_category});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // nhậpLiệuToolStripMenuItem
            // 
            this.nhậpLiệuToolStripMenuItem.Name = "nhậpLiệuToolStripMenuItem";
            this.nhậpLiệuToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.nhậpLiệuToolStripMenuItem.Text = "Nhập liệu";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // mnu_license
            // 
            this.mnu_license.Name = "mnu_license";
            this.mnu_license.Size = new System.Drawing.Size(75, 20);
            this.mnu_license.Text = "Bản quyền";
            this.mnu_license.Click += new System.EventHandler(this.mnu_license_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // mnu_category
            // 
            this.mnu_category.Name = "mnu_category";
            this.mnu_category.Size = new System.Drawing.Size(163, 22);
            this.mnu_category.Text = "Nhóm sản phẩm";
            this.mnu_category.Click += new System.EventHandler(this.mnu_category_Click);
            // 
            // f001_main_form
            // 
            this.ClientSize = new System.Drawing.Size(1008, 742);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f001_main_form";
            this.Text = "F001 - Chuong trinh quan ly ban hang - version 2011.08.14";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        internal ImageList ImageList;
        private ToolStripMenuItem đToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnu_exit;
        private ToolStripMenuItem quanTriHêThôngToolStripMenuItem;
        private ToolStripMenuItem mnu_user_management;
        private ToolStripMenuItem mnu_license;
        private ToolStripMenuItem quanLyTưĐiênToolStripMenuItem;
        private ToolStripMenuItem mnu_directory;
        private ToolStripMenuItem mnu_type_of_directory;
        private ToolStripMenuItem mnu_category;
        private ToolStripMenuItem nhậpLiệuToolStripMenuItem;


        #region public Interface
        public void display(ref IPConstants.HowUserWantTo_Exit_MainForm o_exitMode)
        {
            this.ShowDialog();
            o_exitMode = m_exitMode;
        }

        #endregion
        #region Data Structures
      
        #endregion

        #region Members
        
        IPConstants.HowUserWantTo_Exit_MainForm m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
        #endregion
        
        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
          
            set_define_events();
        }
      
        private void show_manager_user()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.BACK_UP_AND_RESTORE))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được quyền truy nhập phần này !!! ");
                return;
            }
            f999_ht_nguoi_su_dung v_frm_999 = new f999_ht_nguoi_su_dung();
            v_frm_999.display();
        }
        private void show_introduction()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f996_license_form v_frm996 = new f996_license_form();
            v_frm996.display();
            //			IP.Core.IPSystemAdmin.f996_license v_frm = new f996_license () ;
            //			v_frm.display () ;
        }

        private void show_tu_dien_phan_quyen()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.CHUC_NANG))
            //{
            //    BaseMessages.MsgBox_Infor(" Người sử dụng không có quyền truy nhập phần này ! ");
            //    return;
            //}
            f100_TuDien v_frm = new f100_TuDien();
            v_frm.ShowDialog();
        }

        private void set_inital_form_load()
        {
           
        }
        private void show_category()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f201_dm_category v_frm201 = new f201_dm_category();
            v_frm201.display();           
        }

      
        #endregion
        //
        //
        //   event handlers
        //
        //
        private void set_define_events()
        {
            

            
            
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseMessages.MsgBox_Confirm("Bạn có thật sự muốn kết thúc chương trình không ? "))
                {
                    m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_user_management_Click(object sender, EventArgs e)
        {
            try
            {
                show_manager_user();
                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void mnu_license_Click(object sender, EventArgs e)
        {
            try
            {

                show_introduction();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_directory_Click(object sender, EventArgs e)
        {
            try
            {

                show_tu_dien_phan_quyen();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_type_of_directory_Click(object sender, EventArgs e)
        {
            try
            {

                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_category_Click(object sender, EventArgs e)
        {
            try
            {
                show_category();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    

    

        
    }
}
