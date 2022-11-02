namespace ParaPrint
{
    partial class PrinterSettings_Dialog
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
            this.destination_CB = new System.Windows.Forms.ComboBox();
            this.page_CB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Size_Cb = new System.Windows.Forms.ComboBox();
            this.Copy_count = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.color_CB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.layout_CB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.More_settings_Bt = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Override_box = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.update_override = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Note_Lb = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Groups_Override_list = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.def_box = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Update_default = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Default_Group_list = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Copy_count)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destination";
            // 
            // destination_CB
            // 
            this.destination_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destination_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination_CB.FormattingEnabled = true;
            this.destination_CB.Location = new System.Drawing.Point(116, 42);
            this.destination_CB.Name = "destination_CB";
            this.destination_CB.Size = new System.Drawing.Size(189, 23);
            this.destination_CB.TabIndex = 1;
            // 
            // page_CB
            // 
            this.page_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.page_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_CB.FormattingEnabled = true;
            this.page_CB.Items.AddRange(new object[] {
            "All",
            "Custom"});
            this.page_CB.Location = new System.Drawing.Point(116, 77);
            this.page_CB.Name = "page_CB";
            this.page_CB.Size = new System.Drawing.Size(189, 23);
            this.page_CB.TabIndex = 3;
            this.page_CB.SelectedIndexChanged += new System.EventHandler(this.ChangeValue);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Page";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(585, 510);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.page_CB);
            this.panel1.Controls.Add(this.destination_CB);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 105);
            this.panel1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(26, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Custom (e.g 1-3)";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Print";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(116, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 21);
            this.textBox1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Size_Cb);
            this.panel2.Controls.Add(this.Copy_count);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.color_CB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.layout_CB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 163);
            this.panel2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Size";
            // 
            // Size_Cb
            // 
            this.Size_Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Size_Cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Size_Cb.FormattingEnabled = true;
            this.Size_Cb.Location = new System.Drawing.Point(116, 7);
            this.Size_Cb.Name = "Size_Cb";
            this.Size_Cb.Size = new System.Drawing.Size(189, 23);
            this.Size_Cb.TabIndex = 14;
            // 
            // Copy_count
            // 
            this.Copy_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy_count.Location = new System.Drawing.Point(116, 43);
            this.Copy_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Copy_count.Name = "Copy_count";
            this.Copy_count.Size = new System.Drawing.Size(189, 21);
            this.Copy_count.TabIndex = 13;
            this.Copy_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Color";
            // 
            // color_CB
            // 
            this.color_CB.DisplayMember = "0";
            this.color_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.color_CB.FormattingEnabled = true;
            this.color_CB.Items.AddRange(new object[] {
            "Colored",
            "Black & White"});
            this.color_CB.Location = new System.Drawing.Point(116, 117);
            this.color_CB.Name = "color_CB";
            this.color_CB.Size = new System.Drawing.Size(189, 23);
            this.color_CB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Layout";
            // 
            // layout_CB
            // 
            this.layout_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layout_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.layout_CB.FormattingEnabled = true;
            this.layout_CB.Items.AddRange(new object[] {
            "Portrait",
            "Landscape"});
            this.layout_CB.Location = new System.Drawing.Point(116, 77);
            this.layout_CB.Name = "layout_CB";
            this.layout_CB.Size = new System.Drawing.Size(189, 23);
            this.layout_CB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Copy";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(3, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 528);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.More_settings_Bt);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(552, 34);
            this.panel4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "More Settings";
            // 
            // More_settings_Bt
            // 
            this.More_settings_Bt.Location = new System.Drawing.Point(0, 0);
            this.More_settings_Bt.Name = "More_settings_Bt";
            this.More_settings_Bt.Size = new System.Drawing.Size(549, 34);
            this.More_settings_Bt.TabIndex = 1;
            this.More_settings_Bt.Text = "▀";
            this.More_settings_Bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.More_settings_Bt.Click += new System.EventHandler(this.toggle_click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Override_box);
            this.flowLayoutPanel2.Controls.Add(this.panel6);
            this.flowLayoutPanel2.Controls.Add(this.def_box);
            this.flowLayoutPanel2.Controls.Add(this.panel7);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 40);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(548, 488);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // Override_box
            // 
            this.Override_box.AccessibleName = "override";
            this.Override_box.Location = new System.Drawing.Point(3, 3);
            this.Override_box.Name = "Override_box";
            this.Override_box.Size = new System.Drawing.Size(240, 17);
            this.Override_box.TabIndex = 1;
            this.Override_box.Text = "Assign Printer by Group with Override settings";
            this.Override_box.UseVisualStyleBackColor = true;
            this.Override_box.CheckedChanged += new System.EventHandler(this.override_check);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.update_override);
            this.panel6.Controls.Add(this.treeView1);
            this.panel6.Controls.Add(this.Note_Lb);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.Groups_Override_list);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(3, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(551, 448);
            this.panel6.TabIndex = 9;
            this.panel6.Visible = false;
            // 
            // update_override
            // 
            this.update_override.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_override.Location = new System.Drawing.Point(445, 136);
            this.update_override.Name = "update_override";
            this.update_override.Size = new System.Drawing.Size(94, 23);
            this.update_override.TabIndex = 8;
            this.update_override.Text = "Update Group";
            this.update_override.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Indent = 50;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(13, 165);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(526, 283);
            this.treeView1.TabIndex = 2;
            // 
            // Note_Lb
            // 
            this.Note_Lb.AutoSize = true;
            this.Note_Lb.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Note_Lb.Location = new System.Drawing.Point(15, 67);
            this.Note_Lb.Name = "Note_Lb";
            this.Note_Lb.Size = new System.Drawing.Size(33, 13);
            this.Note_Lb.TabIndex = 7;
            this.Note_Lb.Text = "Note:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Groups Settings";
            // 
            // Groups_Override_list
            // 
            this.Groups_Override_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Groups_Override_list.FormattingEnabled = true;
            this.Groups_Override_list.Location = new System.Drawing.Point(67, 3);
            this.Groups_Override_list.Name = "Groups_Override_list";
            this.Groups_Override_list.Size = new System.Drawing.Size(170, 21);
            this.Groups_Override_list.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Groups";
            // 
            // def_box
            // 
            this.def_box.AccessibleName = "default";
            this.def_box.Location = new System.Drawing.Point(3, 480);
            this.def_box.Name = "def_box";
            this.def_box.Size = new System.Drawing.Size(136, 17);
            this.def_box.TabIndex = 10;
            this.def_box.Text = "Assign Printer by Group";
            this.def_box.UseVisualStyleBackColor = true;
            this.def_box.CheckedChanged += new System.EventHandler(this.Deaf);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Update_default);
            this.panel7.Controls.Add(this.treeView2);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.Default_Group_list);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(3, 503);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(551, 448);
            this.panel7.TabIndex = 11;
            this.panel7.Visible = false;
            // 
            // Update_default
            // 
            this.Update_default.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update_default.Location = new System.Drawing.Point(445, 136);
            this.Update_default.Name = "Update_default";
            this.Update_default.Size = new System.Drawing.Size(94, 23);
            this.Update_default.TabIndex = 8;
            this.Update_default.Text = "Update Group";
            this.Update_default.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView2.Indent = 50;
            this.treeView2.ItemHeight = 20;
            this.treeView2.Location = new System.Drawing.Point(13, 165);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(526, 283);
            this.treeView2.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(15, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Note:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Groups Settings";
            // 
            // Default_Group_list
            // 
            this.Default_Group_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Default_Group_list.FormattingEnabled = true;
            this.Default_Group_list.Location = new System.Drawing.Point(67, 3);
            this.Default_Group_list.Name = "Default_Group_list";
            this.Default_Group_list.Size = new System.Drawing.Size(170, 21);
            this.Default_Group_list.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Groups";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(3, 817);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(558, 31);
            this.panel5.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(9, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PrinterSettings_Dialog
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(585, 510);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrinterSettings_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Setup";
            this.Load += new System.EventHandler(this.PrinterSettings_Dialog_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Copy_count)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox destination_CB;
        private System.Windows.Forms.ComboBox page_CB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox layout_CB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox color_CB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label More_settings_Bt;
        private System.Windows.Forms.NumericUpDown Copy_count;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox Override_box;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Groups_Override_list;
        private System.Windows.Forms.Label Note_Lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Size_Cb;
        private System.Windows.Forms.Button update_override;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox def_box;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Update_default;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Default_Group_list;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
    }
}