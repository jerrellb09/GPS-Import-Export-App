namespace Import_Test
{
    partial class Form1
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
            this.btnCalampLocateHist = new System.Windows.Forms.Button();
            this.btnShowGLDTbl = new System.Windows.Forms.Button();
            this.btnGldLocateHist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnSkyPatrolLocateHist = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnNewGoldstar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.jerrellTestDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jerrell_Test_DatabaseDataSet = new Import_Test.Jerrell_Test_DatabaseDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.btnShowSkyPatrolTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerrellTestDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerrell_Test_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalampLocateHist
            // 
            this.btnCalampLocateHist.Location = new System.Drawing.Point(106, 34);
            this.btnCalampLocateHist.Name = "btnCalampLocateHist";
            this.btnCalampLocateHist.Size = new System.Drawing.Size(97, 44);
            this.btnCalampLocateHist.TabIndex = 0;
            this.btnCalampLocateHist.Text = "Retrieve Calamp Locate History";
            this.btnCalampLocateHist.UseVisualStyleBackColor = true;
            this.btnCalampLocateHist.Click += new System.EventHandler(this.btnCalampLocateHist_Click);
            // 
            // btnShowGLDTbl
            // 
            this.btnShowGLDTbl.Location = new System.Drawing.Point(106, 702);
            this.btnShowGLDTbl.Name = "btnShowGLDTbl";
            this.btnShowGLDTbl.Size = new System.Drawing.Size(123, 23);
            this.btnShowGLDTbl.TabIndex = 1;
            this.btnShowGLDTbl.Text = "Show Goldstar Table";
            this.btnShowGLDTbl.UseVisualStyleBackColor = true;
            this.btnShowGLDTbl.Click += new System.EventHandler(this.btnShowGLDTbl_Click);
            // 
            // btnGldLocateHist
            // 
            this.btnGldLocateHist.Location = new System.Drawing.Point(243, 34);
            this.btnGldLocateHist.Name = "btnGldLocateHist";
            this.btnGldLocateHist.Size = new System.Drawing.Size(113, 44);
            this.btnGldLocateHist.TabIndex = 2;
            this.btnGldLocateHist.Text = "Retrieve Goldstar Locate History";
            this.btnGldLocateHist.UseVisualStyleBackColor = true;
            this.btnGldLocateHist.Click += new System.EventHandler(this.btnGldLocateHist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 256);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(551, 34);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(111, 44);
            this.btnClearForm.TabIndex = 5;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(106, 100);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1008, 250);
            this.dataGridView3.TabIndex = 10;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(4, 17);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(114, 23);
            this.btnExportCSV.TabIndex = 11;
            this.btnExportCSV.Text = "Export to CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnSkyPatrolLocateHist
            // 
            this.btnSkyPatrolLocateHist.Location = new System.Drawing.Point(396, 34);
            this.btnSkyPatrolLocateHist.Name = "btnSkyPatrolLocateHist";
            this.btnSkyPatrolLocateHist.Size = new System.Drawing.Size(111, 44);
            this.btnSkyPatrolLocateHist.TabIndex = 12;
            this.btnSkyPatrolLocateHist.Text = "Retrieve SkyPatrol Locate History";
            this.btnSkyPatrolLocateHist.UseVisualStyleBackColor = true;
            this.btnSkyPatrolLocateHist.Click += new System.EventHandler(this.btnSkyPatrolLocateHist_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Open Goldstar History CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(294, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnNewGoldstar
            // 
            this.btnNewGoldstar.Location = new System.Drawing.Point(842, 34);
            this.btnNewGoldstar.Name = "btnNewGoldstar";
            this.btnNewGoldstar.Size = new System.Drawing.Size(111, 44);
            this.btnNewGoldstar.TabIndex = 15;
            this.btnNewGoldstar.Text = "Retrieve NEW Goldstar Locate History";
            this.btnNewGoldstar.UseVisualStyleBackColor = true;
            this.btnNewGoldstar.Click += new System.EventHandler(this.btnNewGoldstar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM-dd-yyyy hh:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(500, 46);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 16;
            this.dateTimePicker2.Visible = false;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Start";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(538, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "End";
            this.label2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearFilter);
            this.groupBox1.Controls.Add(this.btnFilterDate);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnExportCSV);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Location = new System.Drawing.Point(106, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 78);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(806, 46);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilter.TabIndex = 23;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.Location = new System.Drawing.Point(716, 46);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(75, 23);
            this.btnFilterDate.TabIndex = 21;
            this.btnFilterDate.Text = "Filter";
            this.btnFilterDate.UseVisualStyleBackColor = true;
            this.btnFilterDate.Click += new System.EventHandler(this.btnFilterDate_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = this.jerrellTestDatabaseDataSetBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1057, 440);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(57, 256);
            this.dataGridView2.TabIndex = 22;
            // 
            // jerrellTestDatabaseDataSetBindingSource
            // 
            this.jerrellTestDatabaseDataSetBindingSource.DataSource = this.jerrell_Test_DatabaseDataSet;
            this.jerrellTestDatabaseDataSetBindingSource.Position = 0;
            // 
            // jerrell_Test_DatabaseDataSet
            // 
            this.jerrell_Test_DatabaseDataSet.DataSetName = "Jerrell_Test_DatabaseDataSet";
            this.jerrell_Test_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 732);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Update SkyPatrol Table";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShowSkyPatrolTable
            // 
            this.btnShowSkyPatrolTable.Location = new System.Drawing.Point(106, 732);
            this.btnShowSkyPatrolTable.Name = "btnShowSkyPatrolTable";
            this.btnShowSkyPatrolTable.Size = new System.Drawing.Size(123, 23);
            this.btnShowSkyPatrolTable.TabIndex = 25;
            this.btnShowSkyPatrolTable.Text = "Show Skypatrol Table";
            this.btnShowSkyPatrolTable.UseVisualStyleBackColor = true;
            this.btnShowSkyPatrolTable.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 762);
            this.Controls.Add(this.btnShowSkyPatrolTable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewGoldstar);
            this.Controls.Add(this.btnSkyPatrolLocateHist);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGldLocateHist);
            this.Controls.Add(this.btnShowGLDTbl);
            this.Controls.Add(this.btnCalampLocateHist);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerrellTestDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerrell_Test_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalampLocateHist;
        private System.Windows.Forms.Button btnShowGLDTbl;
        private System.Windows.Forms.Button btnGldLocateHist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnSkyPatrolLocateHist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnNewGoldstar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource jerrellTestDatabaseDataSetBindingSource;
        private Jerrell_Test_DatabaseDataSet jerrell_Test_DatabaseDataSet;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnShowSkyPatrolTable;
    }
}

