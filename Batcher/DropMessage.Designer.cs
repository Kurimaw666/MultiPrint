namespace ParaPrint
{
    partial class dropMessage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.diaglog_Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dialog_ok = new System.Windows.Forms.Button();
            this.dialog_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.manualG_Settings = new System.Windows.Forms.CheckBox();
            this.Diaglog_text = new System.Windows.Forms.Label();
            this.dialog_CB_Group_choices = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(5)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.diaglog_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 39);
            this.panel1.TabIndex = 0;
            // 
            // diaglog_Title
            // 
            this.diaglog_Title.AutoSize = true;
            this.diaglog_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaglog_Title.ForeColor = System.Drawing.SystemColors.Control;
            this.diaglog_Title.Location = new System.Drawing.Point(3, 9);
            this.diaglog_Title.Name = "diaglog_Title";
            this.diaglog_Title.Size = new System.Drawing.Size(50, 18);
            this.diaglog_Title.TabIndex = 1;
            this.diaglog_Title.Text = "Group";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.dialog_ok);
            this.panel2.Controls.Add(this.dialog_exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 40);
            this.panel2.TabIndex = 1;
            // 
            // dialog_ok
            // 
            this.dialog_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.dialog_ok.Dock = System.Windows.Forms.DockStyle.Right;
            this.dialog_ok.Location = new System.Drawing.Point(337, 0);
            this.dialog_ok.Name = "dialog_ok";
            this.dialog_ok.Size = new System.Drawing.Size(75, 40);
            this.dialog_ok.TabIndex = 1;
            this.dialog_ok.Text = "Set name";
            this.dialog_ok.UseVisualStyleBackColor = true;
            // 
            // dialog_exit
            // 
            this.dialog_exit.BackColor = System.Drawing.Color.Transparent;
            this.dialog_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dialog_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.dialog_exit.Location = new System.Drawing.Point(412, 0);
            this.dialog_exit.Name = "dialog_exit";
            this.dialog_exit.Size = new System.Drawing.Size(75, 40);
            this.dialog_exit.TabIndex = 0;
            this.dialog_exit.Text = "Cancel";
            this.dialog_exit.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.manualG_Settings);
            this.panel3.Controls.Add(this.Diaglog_text);
            this.panel3.Controls.Add(this.dialog_CB_Group_choices);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 104);
            this.panel3.TabIndex = 2;
            // 
            // manualG_Settings
            // 
            this.manualG_Settings.AutoSize = true;
            this.manualG_Settings.ForeColor = System.Drawing.Color.Gray;
            this.manualG_Settings.Location = new System.Drawing.Point(38, 78);
            this.manualG_Settings.Name = "manualG_Settings";
            this.manualG_Settings.Size = new System.Drawing.Size(107, 17);
            this.manualG_Settings.TabIndex = 2;
            this.manualG_Settings.Text = "Manual Grouping";
            this.manualG_Settings.UseVisualStyleBackColor = true;
            // 
            // Diaglog_text
            // 
            this.Diaglog_text.AutoSize = true;
            this.Diaglog_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diaglog_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Diaglog_text.Location = new System.Drawing.Point(35, 21);
            this.Diaglog_text.Name = "Diaglog_text";
            this.Diaglog_text.Size = new System.Drawing.Size(119, 15);
            this.Diaglog_text.TabIndex = 1;
            this.Diaglog_text.Text = "Please Select Group";
            // 
            // dialog_CB_Group_choices
            // 
            this.dialog_CB_Group_choices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dialog_CB_Group_choices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialog_CB_Group_choices.FormattingEnabled = true;
            this.dialog_CB_Group_choices.ItemHeight = 24;
            this.dialog_CB_Group_choices.Items.AddRange(new object[] {
            "-",
            "format"});
            this.dialog_CB_Group_choices.Location = new System.Drawing.Point(38, 39);
            this.dialog_CB_Group_choices.Name = "dialog_CB_Group_choices";
            this.dialog_CB_Group_choices.Size = new System.Drawing.Size(433, 32);
            this.dialog_CB_Group_choices.TabIndex = 0;
            // 
            // dropMessage
            // 
            this.AcceptButton = this.dialog_ok;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.dialog_exit;
            this.ClientSize = new System.Drawing.Size(487, 183);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "dropMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notify";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label diaglog_Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dialog_ok;
        private System.Windows.Forms.Button dialog_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Diaglog_text;
        public System.Windows.Forms.ComboBox dialog_CB_Group_choices;
        internal System.Windows.Forms.CheckBox manualG_Settings;
    }
}