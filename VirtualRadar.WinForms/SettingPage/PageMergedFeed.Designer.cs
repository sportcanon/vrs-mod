﻿namespace VirtualRadar.WinForms.SettingPage
{
    partial class PageMergedFeed
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
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxIgnoreAircraftWithNoPosition = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericIcaoTimeout = new System.Windows.Forms.NumericUpDown();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listReceiverIds = new VirtualRadar.WinForms.Controls.MasterListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMlatType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMlatType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericIcaoTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "::Receivers:::";
            // 
            // checkBoxIgnoreAircraftWithNoPosition
            // 
            this.checkBoxIgnoreAircraftWithNoPosition.AutoSize = true;
            this.checkBoxIgnoreAircraftWithNoPosition.Location = new System.Drawing.Point(283, 50);
            this.checkBoxIgnoreAircraftWithNoPosition.Name = "checkBoxIgnoreAircraftWithNoPosition";
            this.checkBoxIgnoreAircraftWithNoPosition.Size = new System.Drawing.Size(174, 17);
            this.checkBoxIgnoreAircraftWithNoPosition.TabIndex = 5;
            this.checkBoxIgnoreAircraftWithNoPosition.Text = "::IgnoreAircraftWithNoPosition::";
            this.checkBoxIgnoreAircraftWithNoPosition.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "::IcaoTimeout:::";
            // 
            // numericIcaoTimeout
            // 
            this.numericIcaoTimeout.DecimalPlaces = 2;
            this.numericIcaoTimeout.Location = new System.Drawing.Point(200, 49);
            this.numericIcaoTimeout.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericIcaoTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericIcaoTimeout.Name = "numericIcaoTimeout";
            this.numericIcaoTimeout.Size = new System.Drawing.Size(77, 20);
            this.numericIcaoTimeout.TabIndex = 4;
            this.numericIcaoTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericIcaoTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(200, 0);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(77, 17);
            this.checkBoxEnabled.TabIndex = 0;
            this.checkBoxEnabled.Text = "::Enabled::";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "::Name:::";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(200, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(436, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // listReceiverIds
            // 
            this.listReceiverIds.AllowAdd = false;
            this.listReceiverIds.AllowDelete = false;
            this.listReceiverIds.AllowUpdate = false;
            this.listReceiverIds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listReceiverIds.CheckBoxes = true;
            this.listReceiverIds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colEnabled,
            this.colMlatType});
            this.listReceiverIds.HideAllButList = true;
            this.listReceiverIds.Location = new System.Drawing.Point(200, 75);
            this.listReceiverIds.Name = "listReceiverIds";
            this.listReceiverIds.Size = new System.Drawing.Size(436, 266);
            this.listReceiverIds.TabIndex = 7;
            this.listReceiverIds.SelectedRecordChanged += new System.EventHandler(this.listReceiverIds_SelectedRecordChanged);
            // 
            // colName
            // 
            this.colName.Text = "::Name::";
            this.colName.Width = 175;
            // 
            // colEnabled
            // 
            this.colEnabled.Text = "::Enabled::";
            this.colEnabled.Width = 90;
            // 
            // colMlatType
            // 
            this.colMlatType.Text = "::MultilaterationTypeListHeader::";
            this.colMlatType.Width = 120;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "::MultilaterationType:::";
            // 
            // comboBoxMlatType
            // 
            this.comboBoxMlatType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxMlatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMlatType.FormattingEnabled = true;
            this.comboBoxMlatType.Location = new System.Drawing.Point(200, 348);
            this.comboBoxMlatType.Name = "comboBoxMlatType";
            this.comboBoxMlatType.Size = new System.Drawing.Size(198, 21);
            this.comboBoxMlatType.TabIndex = 9;
            // 
            // PageMergedFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.comboBoxMlatType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listReceiverIds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxIgnoreAircraftWithNoPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericIcaoTimeout);
            this.Controls.Add(this.checkBoxEnabled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Name = "PageMergedFeed";
            this.Size = new System.Drawing.Size(636, 374);
            ((System.ComponentModel.ISupportInitialize)(this.numericIcaoTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxIgnoreAircraftWithNoPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericIcaoTimeout;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private Controls.MasterListView listReceiverIds;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEnabled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMlatType;
        private System.Windows.Forms.ColumnHeader colMlatType;
    }
}
