
namespace LibrarySortApplication
{
    partial class FindCallNumbers
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
            this.Question = new System.Windows.Forms.Label();
            this.cmbLevel1 = new System.Windows.Forms.ComboBox();
            this.cmbLevel2 = new System.Windows.Forms.ComboBox();
            this.cmbLevel3 = new System.Windows.Forms.ComboBox();
            this.btnLvlCheck1 = new System.Windows.Forms.Button();
            this.btnLvlCheck2 = new System.Windows.Forms.Button();
            this.btnLvlCheck3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(12, 49);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(66, 24);
            this.Question.TabIndex = 1;
            this.Question.Text = "label1";
            // 
            // cmbLevel1
            // 
            this.cmbLevel1.FormattingEnabled = true;
            this.cmbLevel1.Location = new System.Drawing.Point(6, 37);
            this.cmbLevel1.Name = "cmbLevel1";
            this.cmbLevel1.Size = new System.Drawing.Size(328, 21);
            this.cmbLevel1.TabIndex = 2;
            // 
            // cmbLevel2
            // 
            this.cmbLevel2.FormattingEnabled = true;
            this.cmbLevel2.Location = new System.Drawing.Point(6, 37);
            this.cmbLevel2.Name = "cmbLevel2";
            this.cmbLevel2.Size = new System.Drawing.Size(328, 21);
            this.cmbLevel2.TabIndex = 3;
            // 
            // cmbLevel3
            // 
            this.cmbLevel3.FormattingEnabled = true;
            this.cmbLevel3.Location = new System.Drawing.Point(6, 37);
            this.cmbLevel3.Name = "cmbLevel3";
            this.cmbLevel3.Size = new System.Drawing.Size(328, 21);
            this.cmbLevel3.TabIndex = 4;
            // 
            // btnLvlCheck1
            // 
            this.btnLvlCheck1.Location = new System.Drawing.Point(363, 37);
            this.btnLvlCheck1.Name = "btnLvlCheck1";
            this.btnLvlCheck1.Size = new System.Drawing.Size(75, 23);
            this.btnLvlCheck1.TabIndex = 5;
            this.btnLvlCheck1.Text = "button1";
            this.btnLvlCheck1.UseVisualStyleBackColor = true;
            this.btnLvlCheck1.Click += new System.EventHandler(this.btnLvlCheck1_Click);
            // 
            // btnLvlCheck2
            // 
            this.btnLvlCheck2.Location = new System.Drawing.Point(380, 37);
            this.btnLvlCheck2.Name = "btnLvlCheck2";
            this.btnLvlCheck2.Size = new System.Drawing.Size(75, 23);
            this.btnLvlCheck2.TabIndex = 6;
            this.btnLvlCheck2.Text = "button2";
            this.btnLvlCheck2.UseVisualStyleBackColor = true;
            this.btnLvlCheck2.Click += new System.EventHandler(this.btnLvlCheck2_Click);
            // 
            // btnLvlCheck3
            // 
            this.btnLvlCheck3.Location = new System.Drawing.Point(363, 37);
            this.btnLvlCheck3.Name = "btnLvlCheck3";
            this.btnLvlCheck3.Size = new System.Drawing.Size(75, 23);
            this.btnLvlCheck3.TabIndex = 7;
            this.btnLvlCheck3.Text = "button3";
            this.btnLvlCheck3.UseVisualStyleBackColor = true;
            this.btnLvlCheck3.Click += new System.EventHandler(this.btnLvlCheck3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 163);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbLevel1);
            this.tabPage1.Controls.Add(this.btnLvlCheck1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbLevel2);
            this.tabPage2.Controls.Add(this.btnLvlCheck2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 137);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbLevel3);
            this.tabPage3.Controls.Add(this.btnLvlCheck3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(559, 137);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FindCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 327);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Question);
            this.Name = "FindCallNumbers";
            this.Text = "FindCallNumbers";
            this.Load += new System.EventHandler(this.FindCallNumbers_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.ComboBox cmbLevel1;
        private System.Windows.Forms.ComboBox cmbLevel2;
        private System.Windows.Forms.ComboBox cmbLevel3;
        private System.Windows.Forms.Button btnLvlCheck1;
        private System.Windows.Forms.Button btnLvlCheck2;
        private System.Windows.Forms.Button btnLvlCheck3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}