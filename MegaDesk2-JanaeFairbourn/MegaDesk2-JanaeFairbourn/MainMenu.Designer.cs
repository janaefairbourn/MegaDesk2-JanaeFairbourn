namespace MegaDesk2_JanaeFairbourn
{
    partial class MainMenu
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
            this.b1_addNewQuote = new System.Windows.Forms.Button();
            this.b2_viewQuotes = new System.Windows.Forms.Button();
            this.b3_searchQuotes = new System.Windows.Forms.Button();
            this.b4_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b1_addNewQuote
            // 
            this.b1_addNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1_addNewQuote.Location = new System.Drawing.Point(39, 29);
            this.b1_addNewQuote.Name = "b1_addNewQuote";
            this.b1_addNewQuote.Size = new System.Drawing.Size(187, 62);
            this.b1_addNewQuote.TabIndex = 0;
            this.b1_addNewQuote.Text = "Add New Quote";
            this.b1_addNewQuote.UseVisualStyleBackColor = true;
            this.b1_addNewQuote.Click += new System.EventHandler(this.b1_addNewQuote_Click);
            // 
            // b2_viewQuotes
            // 
            this.b2_viewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2_viewQuotes.Location = new System.Drawing.Point(39, 97);
            this.b2_viewQuotes.Name = "b2_viewQuotes";
            this.b2_viewQuotes.Size = new System.Drawing.Size(187, 62);
            this.b2_viewQuotes.TabIndex = 1;
            this.b2_viewQuotes.Text = "View Quotes";
            this.b2_viewQuotes.UseVisualStyleBackColor = true;
            this.b2_viewQuotes.Click += new System.EventHandler(this.b2_viewQuotes_Click);
            // 
            // b3_searchQuotes
            // 
            this.b3_searchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3_searchQuotes.Location = new System.Drawing.Point(39, 165);
            this.b3_searchQuotes.Name = "b3_searchQuotes";
            this.b3_searchQuotes.Size = new System.Drawing.Size(187, 62);
            this.b3_searchQuotes.TabIndex = 2;
            this.b3_searchQuotes.Text = "Search Quotes";
            this.b3_searchQuotes.UseVisualStyleBackColor = true;
            this.b3_searchQuotes.Click += new System.EventHandler(this.b3_searchQuotes_Click);
            // 
            // b4_exit
            // 
            this.b4_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4_exit.Location = new System.Drawing.Point(39, 233);
            this.b4_exit.Name = "b4_exit";
            this.b4_exit.Size = new System.Drawing.Size(187, 62);
            this.b4_exit.TabIndex = 3;
            this.b4_exit.Text = "Exit";
            this.b4_exit.UseVisualStyleBackColor = true;
            this.b4_exit.Click += new System.EventHandler(this.b4_exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 326);
            this.Controls.Add(this.b4_exit);
            this.Controls.Add(this.b3_searchQuotes);
            this.Controls.Add(this.b2_viewQuotes);
            this.Controls.Add(this.b1_addNewQuote);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1_addNewQuote;
        private System.Windows.Forms.Button b2_viewQuotes;
        private System.Windows.Forms.Button b3_searchQuotes;
        private System.Windows.Forms.Button b4_exit;
    }
}

