
namespace Anti_Device_Ban
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.dname = new MetroFramework.Controls.MetroTextBox();
            this.dmodel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.bypass = new MetroFramework.Controls.MetroTile();
            this.log = new MetroFramework.Controls.MetroTextBox();
            this.dlist = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroListView1
            // 
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(271, 63);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(192, 187);
            this.metroListView1.TabIndex = 0;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // dname
            // 
            // 
            // 
            // 
            this.dname.CustomButton.Image = null;
            this.dname.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.dname.CustomButton.Name = "";
            this.dname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dname.CustomButton.TabIndex = 1;
            this.dname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dname.CustomButton.UseSelectable = true;
            this.dname.CustomButton.Visible = false;
            this.dname.Lines = new string[0];
            this.dname.Location = new System.Drawing.Point(23, 95);
            this.dname.MaxLength = 32767;
            this.dname.Name = "dname";
            this.dname.PasswordChar = '\0';
            this.dname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dname.SelectedText = "";
            this.dname.SelectionLength = 0;
            this.dname.SelectionStart = 0;
            this.dname.ShortcutsEnabled = true;
            this.dname.Size = new System.Drawing.Size(224, 23);
            this.dname.TabIndex = 1;
            this.dname.UseSelectable = true;
            this.dname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dmodel
            // 
            // 
            // 
            // 
            this.dmodel.CustomButton.Image = null;
            this.dmodel.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.dmodel.CustomButton.Name = "";
            this.dmodel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dmodel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dmodel.CustomButton.TabIndex = 1;
            this.dmodel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dmodel.CustomButton.UseSelectable = true;
            this.dmodel.CustomButton.Visible = false;
            this.dmodel.Lines = new string[0];
            this.dmodel.Location = new System.Drawing.Point(23, 162);
            this.dmodel.MaxLength = 32767;
            this.dmodel.Name = "dmodel";
            this.dmodel.PasswordChar = '\0';
            this.dmodel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dmodel.SelectedText = "";
            this.dmodel.SelectionLength = 0;
            this.dmodel.SelectionStart = 0;
            this.dmodel.ShortcutsEnabled = true;
            this.dmodel.Size = new System.Drawing.Size(224, 23);
            this.dmodel.TabIndex = 2;
            this.dmodel.UseSelectable = true;
            this.dmodel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dmodel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Device Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 131);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Device Model";
            // 
            // bypass
            // 
            this.bypass.ActiveControl = null;
            this.bypass.Location = new System.Drawing.Point(41, 205);
            this.bypass.Name = "bypass";
            this.bypass.Size = new System.Drawing.Size(87, 45);
            this.bypass.TabIndex = 5;
            this.bypass.Text = "Bypass";
            this.bypass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bypass.UseSelectable = true;
            this.bypass.Click += new System.EventHandler(this.bypass_Click);
            // 
            // log
            // 
            // 
            // 
            // 
            this.log.CustomButton.Image = null;
            this.log.CustomButton.Location = new System.Drawing.Point(6, 1);
            this.log.CustomButton.Name = "";
            this.log.CustomButton.Size = new System.Drawing.Size(185, 185);
            this.log.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.log.CustomButton.TabIndex = 1;
            this.log.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.log.CustomButton.UseSelectable = true;
            this.log.CustomButton.Visible = false;
            this.log.Lines = new string[0];
            this.log.Location = new System.Drawing.Point(271, 63);
            this.log.MaxLength = 32767;
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.PasswordChar = '\0';
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.log.SelectedText = "";
            this.log.SelectionLength = 0;
            this.log.SelectionStart = 0;
            this.log.ShortcutsEnabled = true;
            this.log.Size = new System.Drawing.Size(192, 187);
            this.log.TabIndex = 6;
            this.log.UseSelectable = true;
            this.log.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.log.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dlist
            // 
            this.dlist.ActiveControl = null;
            this.dlist.Location = new System.Drawing.Point(134, 205);
            this.dlist.Name = "dlist";
            this.dlist.Size = new System.Drawing.Size(87, 45);
            this.dlist.TabIndex = 7;
            this.dlist.Text = "Device List";
            this.dlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dlist.UseSelectable = true;
            this.dlist.Click += new System.EventHandler(this.dlist_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(229, 253);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(254, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "PUBGM device bypass  created warss7878";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 253);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Github:Warss7878";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 273);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dlist);
            this.Controls.Add(this.log);
            this.Controls.Add(this.bypass);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dmodel);
            this.Controls.Add(this.dname);
            this.Controls.Add(this.metroListView1);
            this.Name = "Form1";
            this.Text = "Gameloop Device Bypass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView metroListView1;
        private MetroFramework.Controls.MetroTextBox dname;
        private MetroFramework.Controls.MetroTextBox dmodel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile bypass;
        private MetroFramework.Controls.MetroTextBox log;
        private MetroFramework.Controls.MetroTile dlist;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

