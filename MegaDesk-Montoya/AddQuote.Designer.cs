namespace MegaDesk_Montoya
{
    partial class AddQuote
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
            this.CloseAddQuote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitQuote = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.drawersTextBox = new System.Windows.Forms.TextBox();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.rushOrderComboBox = new System.Windows.Forms.ComboBox();
            this.widthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.depthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseAddQuote
            // 
            this.CloseAddQuote.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseAddQuote.Font = new System.Drawing.Font("Lucida Sans", 15F);
            this.CloseAddQuote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseAddQuote.Location = new System.Drawing.Point(247, 283);
            this.CloseAddQuote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseAddQuote.Name = "CloseAddQuote";
            this.CloseAddQuote.Size = new System.Drawing.Size(198, 41);
            this.CloseAddQuote.TabIndex = 0;
            this.CloseAddQuote.Text = "Cancel";
            this.CloseAddQuote.UseVisualStyleBackColor = false;
            this.CloseAddQuote.Click += new System.EventHandler(this.CloseAddQuote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // SubmitQuote
            // 
            this.SubmitQuote.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitQuote.Font = new System.Drawing.Font("Lucida Sans", 15F);
            this.SubmitQuote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubmitQuote.Location = new System.Drawing.Point(27, 283);
            this.SubmitQuote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubmitQuote.Name = "SubmitQuote";
            this.SubmitQuote.Size = new System.Drawing.Size(198, 41);
            this.SubmitQuote.TabIndex = 2;
            this.SubmitQuote.Text = "Submit";
            this.SubmitQuote.UseVisualStyleBackColor = false;
            this.SubmitQuote.Click += new System.EventHandler(this.SubmitQuote_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(277, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 31);
            this.nameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desk Width (inches)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desk Depth (inches)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Desktop Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rush Order Options";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthTextBox.Location = new System.Drawing.Point(277, 65);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(168, 31);
            this.widthTextBox.TabIndex = 9;
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthTextBox_Validating);
            // 
            // drawersTextBox
            // 
            this.drawersTextBox.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersTextBox.Location = new System.Drawing.Point(277, 145);
            this.drawersTextBox.Name = "drawersTextBox";
            this.drawersTextBox.Size = new System.Drawing.Size(168, 31);
            this.drawersTextBox.TabIndex = 11;
            // 
            // depthTextBox
            // 
            this.depthTextBox.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthTextBox.Location = new System.Drawing.Point(277, 105);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(168, 31);
            this.depthTextBox.TabIndex = 10;
            this.depthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthTextBox_KeyPress);
            this.depthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.depthTextBox_Validating);
            // 
            // materialComboBox
            // 
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(277, 185);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(168, 31);
            this.materialComboBox.TabIndex = 12;
            // 
            // rushOrderComboBox
            // 
            this.rushOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushOrderComboBox.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderComboBox.FormattingEnabled = true;
            this.rushOrderComboBox.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "7 days"});
            this.rushOrderComboBox.Location = new System.Drawing.Point(277, 225);
            this.rushOrderComboBox.Name = "rushOrderComboBox";
            this.rushOrderComboBox.Size = new System.Drawing.Size(168, 31);
            this.rushOrderComboBox.TabIndex = 13;
            // 
            // widthErrorProvider
            // 
            this.widthErrorProvider.ContainerControl = this;
            // 
            // depthErrorProvider
            // 
            this.depthErrorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 345);
            this.Controls.Add(this.rushOrderComboBox);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.drawersTextBox);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.SubmitQuote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseAddQuote);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseAddQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitQuote;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox drawersTextBox;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.ComboBox rushOrderComboBox;
        private System.Windows.Forms.ErrorProvider widthErrorProvider;
        private System.Windows.Forms.ErrorProvider depthErrorProvider;
    }
}