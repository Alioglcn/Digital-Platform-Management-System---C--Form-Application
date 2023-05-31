namespace DigitalPlatformManagementSystm
{
    partial class ACTORS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACTORS));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.actoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.digitalPlatformManagementSystemDataSet1 = new DigitalPlatformManagementSystm.DigitalPlatformManagementSystemDataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.digitalPlatformManagementSystemDataSet = new DigitalPlatformManagementSystm.DigitalPlatformManagementSystemDataSet();
            this.digitalPlatformManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorsTableAdapter = new DigitalPlatformManagementSystm.DigitalPlatformManagementSystemDataSet1TableAdapters.actorsTableAdapter();
            this.digitalPlatformManagementSystemDataSet2 = new DigitalPlatformManagementSystm.DigitalPlatformManagementSystemDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalPlatformManagementSystemDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalPlatformManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalPlatformManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalPlatformManagementSystemDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actoridDataGridViewTextBoxColumn,
            this.actornameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.actorsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(435, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 661);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // actoridDataGridViewTextBoxColumn
            // 
            this.actoridDataGridViewTextBoxColumn.DataPropertyName = "actor_id";
            this.actoridDataGridViewTextBoxColumn.HeaderText = "actor_id";
            this.actoridDataGridViewTextBoxColumn.Name = "actoridDataGridViewTextBoxColumn";
            // 
            // actornameDataGridViewTextBoxColumn
            // 
            this.actornameDataGridViewTextBoxColumn.DataPropertyName = "actor_name";
            this.actornameDataGridViewTextBoxColumn.HeaderText = "actor_name";
            this.actornameDataGridViewTextBoxColumn.Name = "actornameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // actorsBindingSource
            // 
            this.actorsBindingSource.DataMember = "actors";
            this.actorsBindingSource.DataSource = this.digitalPlatformManagementSystemDataSet1;
            // 
            // digitalPlatformManagementSystemDataSet1
            // 
            this.digitalPlatformManagementSystemDataSet1.DataSetName = "DigitalPlatformManagementSystemDataSet1";
            this.digitalPlatformManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // button5
            // 
            this.button5.ImageKey = "549_clear.jpg";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(282, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 59);
            this.button5.TabIndex = 32;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "218-2187414_-circle-hd-png-download.png");
            this.ımageList1.Images.SetKeyName(1, "a.png");
            this.ımageList1.Images.SetKeyName(2, "png-transparent-grass-area-symbol-brand-sign-add-logo-grass-desktop-wallpaper.png" +
        "");
            this.ımageList1.Images.SetKeyName(3, "update-logo.jpg");
            this.ımageList1.Images.SetKeyName(4, "549_clear.jpg");
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(141, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 26);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(141, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 26);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Actor Name :";
            // 
            // button4
            // 
            this.button4.ImageKey = "a.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(26, 737);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 105);
            this.button4.TabIndex = 31;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ImageKey = "update-logo.jpg";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(976, 689);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 105);
            this.button3.TabIndex = 30;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ImageKey = "218-2187414_-circle-hd-png-download.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(771, 689);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 105);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageKey = "png-transparent-grass-area-symbol-brand-sign-add-logo-grass-desktop-wallpaper.png" +
    "";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(563, 689);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 105);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // digitalPlatformManagementSystemDataSet
            // 
            this.digitalPlatformManagementSystemDataSet.DataSetName = "DigitalPlatformManagementSystemDataSet";
            this.digitalPlatformManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // digitalPlatformManagementSystemDataSetBindingSource
            // 
            this.digitalPlatformManagementSystemDataSetBindingSource.DataSource = this.digitalPlatformManagementSystemDataSet;
            this.digitalPlatformManagementSystemDataSetBindingSource.Position = 0;
            // 
            // actorsTableAdapter
            // 
            this.actorsTableAdapter.ClearBeforeFill = true;
            // 
            // digitalPlatformManagementSystemDataSet2
            // 
            this.digitalPlatformManagementSystemDataSet2.DataSetName = "DigitalPlatformManagementSystemDataSet";
            this.digitalPlatformManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ACTORS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1183, 857);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ACTORS";
            this.Text = "ACTORS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ACTORS_FormClosing);
            this.Load += new System.EventHandler(this.ACTORS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalPlatformManagementSystemDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalPlatformManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalPlatformManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalPlatformManagementSystemDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource digitalPlatformManagementSystemDataSetBindingSource;
        private DigitalPlatformManagementSystemDataSet digitalPlatformManagementSystemDataSet;
        private DigitalPlatformManagementSystemDataSet1 digitalPlatformManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource actorsBindingSource;
        private DigitalPlatformManagementSystemDataSet1TableAdapters.actorsTableAdapter actorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn actoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList ımageList1;
        private DigitalPlatformManagementSystemDataSet digitalPlatformManagementSystemDataSet2;
        private System.Windows.Forms.Button button5;
    }
}