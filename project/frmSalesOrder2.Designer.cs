namespace project
{
    partial class frmSalesOrder2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DataGridViewRow = new System.Windows.Forms.DataGridView();
            this.btnAddItem_Click = new System.Windows.Forms.Button();
            this.btnEditItem_Click = new System.Windows.Forms.Button();
            this.btnSaveOrder_Click = new System.Windows.Forms.Button();
            this.btnCancel_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(508, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // DataGridViewRow
            // 
            this.DataGridViewRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRow.Location = new System.Drawing.Point(428, 270);
            this.DataGridViewRow.Name = "DataGridViewRow";
            this.DataGridViewRow.RowTemplate.Height = 24;
            this.DataGridViewRow.Size = new System.Drawing.Size(240, 150);
            this.DataGridViewRow.TabIndex = 2;
            // 
            // btnAddItem_Click
            // 
            this.btnAddItem_Click.Location = new System.Drawing.Point(508, 200);
            this.btnAddItem_Click.Name = "btnAddItem_Click";
            this.btnAddItem_Click.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem_Click.TabIndex = 3;
            this.btnAddItem_Click.Text = "button1";
            this.btnAddItem_Click.UseVisualStyleBackColor = true;
            // 
            // btnEditItem_Click
            // 
            this.btnEditItem_Click.Location = new System.Drawing.Point(609, 200);
            this.btnEditItem_Click.Name = "btnEditItem_Click";
            this.btnEditItem_Click.Size = new System.Drawing.Size(75, 23);
            this.btnEditItem_Click.TabIndex = 4;
            this.btnEditItem_Click.Text = "button1";
            this.btnEditItem_Click.UseVisualStyleBackColor = true;
            // 
            // btnSaveOrder_Click
            // 
            this.btnSaveOrder_Click.Location = new System.Drawing.Point(690, 212);
            this.btnSaveOrder_Click.Name = "btnSaveOrder_Click";
            this.btnSaveOrder_Click.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOrder_Click.TabIndex = 5;
            this.btnSaveOrder_Click.Text = "button1";
            this.btnSaveOrder_Click.UseVisualStyleBackColor = true;
            // 
            // btnCancel_Click
            // 
            this.btnCancel_Click.Location = new System.Drawing.Point(363, 214);
            this.btnCancel_Click.Name = "btnCancel_Click";
            this.btnCancel_Click.Size = new System.Drawing.Size(75, 23);
            this.btnCancel_Click.TabIndex = 6;
            this.btnCancel_Click.Text = "button1";
            this.btnCancel_Click.UseVisualStyleBackColor = true;
            // 
            // frmSalesOrder2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel_Click);
            this.Controls.Add(this.btnSaveOrder_Click);
            this.Controls.Add(this.btnEditItem_Click);
            this.Controls.Add(this.btnAddItem_Click);
            this.Controls.Add(this.DataGridViewRow);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSalesOrder2";
            this.Text = "frmSalesOrder2";
            this.Load += new System.EventHandler(this.frmSalesOrder2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DataGridViewRow;
        private System.Windows.Forms.Button btnAddItem_Click;
        private System.Windows.Forms.Button btnEditItem_Click;
        private System.Windows.Forms.Button btnSaveOrder_Click;
        private System.Windows.Forms.Button btnCancel_Click;
    }
}