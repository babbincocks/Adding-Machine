namespace MainForm
{
    partial class frmMain
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lbFeed = new System.Windows.Forms.ListBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblHotkeys = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(232, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(16, 302);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(154, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(232, 253);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(88, 32);
            this.btnTotal.TabIndex = 6;
            this.btnTotal.Text = "&Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lbFeed
            // 
            this.lbFeed.FormattingEnabled = true;
            this.lbFeed.Location = new System.Drawing.Point(16, 21);
            this.lbFeed.Name = "lbFeed";
            this.lbFeed.Size = new System.Drawing.Size(186, 264);
            this.lbFeed.TabIndex = 0;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(232, 76);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(88, 32);
            this.btnSubtract.TabIndex = 3;
            this.btnSubtract.Text = "&Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(232, 135);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(88, 32);
            this.btnMultiply.TabIndex = 4;
            this.btnMultiply.Text = "&Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(232, 196);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(88, 32);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "&Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // lblHotkeys
            // 
            this.lblHotkeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHotkeys.Location = new System.Drawing.Point(220, 302);
            this.lblHotkeys.Name = "lblHotkeys";
            this.lblHotkeys.Size = new System.Drawing.Size(100, 69);
            this.lblHotkeys.TabIndex = 8;
            this.lblHotkeys.Text = "Hotkeys\r\nF1 ----> Add\r\nF2 ----> Subtract\r\nF3 ----> Multiply\r\nF4 ----> Divide";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 389);
            this.Controls.Add(this.lblHotkeys);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.lbFeed);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmMain";
            this.Text = "Adding Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ListBox lbFeed;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblHotkeys;
    }
}

