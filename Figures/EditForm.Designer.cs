namespace Figures
{
    partial class EditForm
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.labelTextBox = new System.Windows.Forms.TextBox();
            this.coordinatesTextBox = new System.Windows.Forms.TextBox();
            this.typeListBox = new System.Windows.Forms.ListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.66666F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.colorLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.areaTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.coordinatesTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.typeListBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.96648F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.73653F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.96407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.16168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.56287F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 191);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(3, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Label";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Area";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coordinates";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FigureType";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorLabel
            // 
            this.colorLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(210, 13);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(56, 13);
            this.colorLabel.TabIndex = 6;
            this.colorLabel.Text = "colorLabel";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorLabel.Click += new System.EventHandler(this.colorLabel_Click);
            // 
            // areaTextBox
            // 
            this.areaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.areaTextBox.Location = new System.Drawing.Point(150, 131);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(177, 20);
            this.areaTextBox.TabIndex = 9;
            this.areaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.areaTextBox_Validating);
            this.areaTextBox.Validated += new System.EventHandler(this.areaTextBox_Validated);
            // 
            // labelTextBox
            // 
            this.labelTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTextBox.Location = new System.Drawing.Point(150, 168);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.Size = new System.Drawing.Size(177, 20);
            this.labelTextBox.TabIndex = 10;
            this.labelTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.labelTextBox_Validating);
            this.labelTextBox.Validated += new System.EventHandler(this.labelTextBox_Validated);
            // 
            // coordinatesTextBox
            // 
            this.coordinatesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.coordinatesTextBox.Location = new System.Drawing.Point(150, 95);
            this.coordinatesTextBox.Name = "coordinatesTextBox";
            this.coordinatesTextBox.Size = new System.Drawing.Size(177, 20);
            this.coordinatesTextBox.TabIndex = 8;
            this.coordinatesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.coordinatesTextBox_Validating);
            this.coordinatesTextBox.Validated += new System.EventHandler(this.coordinatesTextBox_Validated);
            // 
            // typeListBox
            // 
            this.typeListBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.typeListBox.FormattingEnabled = true;
            this.typeListBox.Items.AddRange(new object[] {
            "Triangle",
            "Circle",
            "Square"});
            this.typeListBox.Location = new System.Drawing.Point(150, 39);
            this.typeListBox.Name = "typeListBox";
            this.typeListBox.Size = new System.Drawing.Size(177, 43);
            this.typeListBox.TabIndex = 7;
            this.typeListBox.Validating += new System.ComponentModel.CancelEventHandler(this.typeListBox_Validating);
            this.typeListBox.Validated += new System.EventHandler(this.typeListBox_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(430, 12);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.Location = new System.Drawing.Point(430, 41);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 270);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox labelTextBox;
        private System.Windows.Forms.TextBox coordinatesTextBox;
        private System.Windows.Forms.ListBox typeListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}