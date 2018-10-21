namespace MegaDesk2_JanaeFairbourn
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
            this.label1 = new System.Windows.Forms.Label();
            this.timeInput = new System.Windows.Forms.ComboBox();
            this.surfaceInput = new System.Windows.Forms.ComboBox();
            this.drawersInput = new System.Windows.Forms.NumericUpDown();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.b1_getQuote = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.b1_cancelAddQuote = new System.Windows.Forms.Button();
            this.priceOutput = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Quote";
            // 
            // timeInput
            // 
            this.timeInput.FormattingEnabled = true;
            this.timeInput.Location = new System.Drawing.Point(470, 212);
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(100, 21);
            this.timeInput.TabIndex = 32;
            // 
            // surfaceInput
            // 
            this.surfaceInput.FormattingEnabled = true;
            this.surfaceInput.Location = new System.Drawing.Point(470, 179);
            this.surfaceInput.Name = "surfaceInput";
            this.surfaceInput.Size = new System.Drawing.Size(100, 21);
            this.surfaceInput.TabIndex = 31;
            // 
            // drawersInput
            // 
            this.drawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersInput.Location = new System.Drawing.Point(470, 140);
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(69, 24);
            this.drawersInput.TabIndex = 30;
            // 
            // depthInput
            // 
            this.depthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthInput.Location = new System.Drawing.Point(170, 213);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(69, 24);
            this.depthInput.TabIndex = 29;
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthInput.Location = new System.Drawing.Point(170, 180);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(69, 24);
            this.widthInput.TabIndex = 28;
            // 
            // b1_getQuote
            // 
            this.b1_getQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1_getQuote.Location = new System.Drawing.Point(116, 302);
            this.b1_getQuote.Name = "b1_getQuote";
            this.b1_getQuote.Size = new System.Drawing.Size(123, 35);
            this.b1_getQuote.TabIndex = 27;
            this.b1_getQuote.Text = "Get Quote";
            this.b1_getQuote.UseVisualStyleBackColor = true;
            this.b1_getQuote.Click += new System.EventHandler(this.b1_getQuote_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(314, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Delivery:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Surface Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Number of Drawers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Depth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Desk Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Customer Name:";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(200, 89);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(242, 26);
            this.nameInput.TabIndex = 19;
            // 
            // b1_cancelAddQuote
            // 
            this.b1_cancelAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1_cancelAddQuote.Location = new System.Drawing.Point(330, 302);
            this.b1_cancelAddQuote.Name = "b1_cancelAddQuote";
            this.b1_cancelAddQuote.Size = new System.Drawing.Size(95, 35);
            this.b1_cancelAddQuote.TabIndex = 18;
            this.b1_cancelAddQuote.Text = "Cancel";
            this.b1_cancelAddQuote.UseVisualStyleBackColor = true;
            this.b1_cancelAddQuote.Click += new System.EventHandler(this.b1_cancelAddQuote_Click);
            // 
            // priceOutput
            // 
            this.priceOutput.Location = new System.Drawing.Point(318, 256);
            this.priceOutput.Name = "priceOutput";
            this.priceOutput.Size = new System.Drawing.Size(100, 20);
            this.priceOutput.TabIndex = 34;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(150, 256);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(89, 20);
            this.priceLabel.TabIndex = 33;
            this.priceLabel.Text = "Desk Price:";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 358);
            this.Controls.Add(this.priceOutput);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.surfaceInput);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.b1_getQuote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.b1_cancelAddQuote);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timeInput;
        private System.Windows.Forms.ComboBox surfaceInput;
        private System.Windows.Forms.NumericUpDown drawersInput;
        private System.Windows.Forms.NumericUpDown depthInput;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.Button b1_getQuote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button b1_cancelAddQuote;
        private System.Windows.Forms.TextBox priceOutput;
        private System.Windows.Forms.Label priceLabel;
    }
}