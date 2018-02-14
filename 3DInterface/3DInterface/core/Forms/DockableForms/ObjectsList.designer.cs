using System;

namespace _3DInterface.core.Forms.DockableForms
{
    partial class ObjectsList
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
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new _3DInterface.core.Forms.DockableForms.ThumbnailFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.searchTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.searchTxtBox.Location = new System.Drawing.Point(5, 4);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(161, 21);
            this.searchTxtBox.TabIndex = 8;
            this.searchTxtBox.Text = "Search Item...";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.Location = new System.Drawing.Point(172, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 31);
            this.button8.TabIndex = 9;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Image = global::_3DInterface.Properties.Resources.refresh_icon;
            this.button9.Location = new System.Drawing.Point(272, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 31);
            this.button9.TabIndex = 10;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.CausesValidation = false;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(173, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(130, 480);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // ObjectsList
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(305, 511);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ObjectsList";
            this.Text = "Object Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private ThumbnailFlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}