namespace MegaDesk2_JanaeFairbourn
{
    partial class DisplayQuotes
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
            this.b1_cancelAddQuote = new System.Windows.Forms.Button();
            this.displayDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // b1_cancelAddQuote
            // 
            this.b1_cancelAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1_cancelAddQuote.Location = new System.Drawing.Point(431, 320);
            this.b1_cancelAddQuote.Name = "b1_cancelAddQuote";
            this.b1_cancelAddQuote.Size = new System.Drawing.Size(95, 35);
            this.b1_cancelAddQuote.TabIndex = 19;
            this.b1_cancelAddQuote.Text = "Cancel";
            this.b1_cancelAddQuote.UseVisualStyleBackColor = true;
            this.b1_cancelAddQuote.Click += new System.EventHandler(this.b1_cancelAddQuote_Click);
            // 
            // displayDataGrid
            // 
            this.displayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGrid.Location = new System.Drawing.Point(39, 27);
            this.displayDataGrid.Name = "displayDataGrid";
            this.displayDataGrid.Size = new System.Drawing.Size(562, 277);
            this.displayDataGrid.TabIndex = 20;
            // 
            // DisplayQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 367);
            this.Controls.Add(this.displayDataGrid);
            this.Controls.Add(this.b1_cancelAddQuote);
            this.Name = "DisplayQuotes";
            this.Text = "DisplayQuotes";
            this.Load += new System.EventHandler(this.DisplayQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1_cancelAddQuote;
        private System.Windows.Forms.DataGridView displayDataGrid;
    }
}