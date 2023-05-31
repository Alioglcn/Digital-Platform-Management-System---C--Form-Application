namespace DigitalPlatformManagementSystm
{
    partial class HOMEPACKAGE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOMEPACKAGE));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO DIGITAL PLATFORM MANAGEMENT SYSTEM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageKey = "customer-customer-icon-146530250.jpg";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(30, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 126);
            this.button1.TabIndex = 1;
            this.button1.Text = "AUDIENCES";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "bill-icon-vector-logo-design-template-bill-icon-vector-logo-design-template-flat-" +
        "style-illustration-220724353.jpg");
            this.ımageList1.Images.SetKeyName(1, "customer-customer-icon-146530250.jpg");
            this.ımageList1.Images.SetKeyName(2, "feedback-icon-free-vector.jpg");
            this.ımageList1.Images.SetKeyName(3, "icon-content-photos-texts-vector-icons-white-background-trendy-linear-website-pri" +
        "nt-logo-emblem-symbol-interface-168199299.jpg");
            this.ımageList1.Images.SetKeyName(4, "Microsoft_Stream.svg.png");
            this.ımageList1.Images.SetKeyName(5, "shah-rukh-khan-6702391_960_720.png");
            this.ımageList1.Images.SetKeyName(6, "Sprint-logo-design-Codesign-agency.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageKey = "icon-content-photos-texts-vector-icons-white-background-trendy-linear-website-pri" +
    "nt-logo-emblem-symbol-interface-168199299.jpg";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(172, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 126);
            this.button2.TabIndex = 2;
            this.button2.Text = "CONTENTS";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.ImageKey = "Microsoft_Stream.svg.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(311, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 126);
            this.button3.TabIndex = 3;
            this.button3.Text = "STREAMS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.ImageKey = "shah-rukh-khan-6702391_960_720.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(455, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 126);
            this.button4.TabIndex = 4;
            this.button4.Text = "ACTORS";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.ImageKey = "Sprint-logo-design-Codesign-agency.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(85, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 126);
            this.button5.TabIndex = 5;
            this.button5.Text = "FEATURES";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.ImageKey = "feedback-icon-free-vector.jpg";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(229, 170);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 126);
            this.button6.TabIndex = 6;
            this.button6.Text = "REVIEWS";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.ImageKey = "bill-icon-vector-logo-design-template-bill-icon-vector-logo-design-template-flat-" +
    "style-illustration-220724353.jpg";
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(375, 170);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 126);
            this.button7.TabIndex = 7;
            this.button7.Text = "BILLS";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(66, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 311);
            this.panel1.TabIndex = 9;
            // 
            // HOMEPACKAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "HOMEPACKAGE";
            this.Text = "HOMEPAGE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HOMEPACKAGE_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
    }
}

