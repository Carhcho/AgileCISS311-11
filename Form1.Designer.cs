﻿
namespace dropbox11
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.advisorComboBox = new System.Windows.Forms.ComboBox();
            this.adviseeListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an Advisor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Advisee Names";
            // 
            // advisorComboBox
            // 
            this.advisorComboBox.FormattingEnabled = true;
            this.advisorComboBox.Location = new System.Drawing.Point(330, 104);
            this.advisorComboBox.Name = "advisorComboBox";
            this.advisorComboBox.Size = new System.Drawing.Size(121, 21);
            this.advisorComboBox.TabIndex = 2;
            this.advisorComboBox.SelectedIndexChanged += new System.EventHandler(this.advisorComboBox_SelectedIndexChanged);
            // 
            // adviseeListBox
            // 
            this.adviseeListBox.FormattingEnabled = true;
            this.adviseeListBox.Location = new System.Drawing.Point(29, 158);
            this.adviseeListBox.Name = "adviseeListBox";
            this.adviseeListBox.Size = new System.Drawing.Size(735, 225);
            this.adviseeListBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Add Advisee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adviseeListBox);
            this.Controls.Add(this.advisorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox advisorComboBox;
        private System.Windows.Forms.ListBox adviseeListBox;
        private System.Windows.Forms.Button button1;
    }
}

