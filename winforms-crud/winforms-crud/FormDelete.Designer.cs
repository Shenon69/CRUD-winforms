namespace winforms_crud
{
    partial class FormDelete
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
            this.label_head_delete = new Guna.UI.WinForms.GunaLabel();
            this.button_clear_uid_delete = new Guna.UI.WinForms.GunaButton();
            this.button_submit_uid = new Guna.UI.WinForms.GunaButton();
            this.textBox_delete_uid = new Guna.UI.WinForms.GunaTextBox();
            this.label_uid = new Guna.UI.WinForms.GunaLabel();
            this.button_nav_read = new Guna.UI.WinForms.GunaButton();
            this.button_nav_update = new Guna.UI.WinForms.GunaButton();
            this.button_nav_enter = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label_head_delete
            // 
            this.label_head_delete.AutoSize = true;
            this.label_head_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head_delete.Location = new System.Drawing.Point(62, 65);
            this.label_head_delete.Name = "label_head_delete";
            this.label_head_delete.Size = new System.Drawing.Size(205, 40);
            this.label_head_delete.TabIndex = 8;
            this.label_head_delete.Text = "Delete User ID";
            // 
            // button_clear_uid_delete
            // 
            this.button_clear_uid_delete.AnimationHoverSpeed = 0.07F;
            this.button_clear_uid_delete.AnimationSpeed = 0.03F;
            this.button_clear_uid_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_clear_uid_delete.BaseColor = System.Drawing.Color.Gray;
            this.button_clear_uid_delete.BorderColor = System.Drawing.Color.Black;
            this.button_clear_uid_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_clear_uid_delete.FocusedColor = System.Drawing.Color.Empty;
            this.button_clear_uid_delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_uid_delete.ForeColor = System.Drawing.Color.White;
            this.button_clear_uid_delete.Image = null;
            this.button_clear_uid_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_clear_uid_delete.ImageSize = new System.Drawing.Size(20, 20);
            this.button_clear_uid_delete.Location = new System.Drawing.Point(182, 230);
            this.button_clear_uid_delete.Name = "button_clear_uid_delete";
            this.button_clear_uid_delete.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.button_clear_uid_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_clear_uid_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.button_clear_uid_delete.OnHoverImage = null;
            this.button_clear_uid_delete.OnPressedColor = System.Drawing.Color.Black;
            this.button_clear_uid_delete.Radius = 5;
            this.button_clear_uid_delete.Size = new System.Drawing.Size(107, 30);
            this.button_clear_uid_delete.TabIndex = 12;
            this.button_clear_uid_delete.Text = "Clear";
            this.button_clear_uid_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_clear_uid_delete.Click += new System.EventHandler(this.button_clear_uid_delete_Click);
            // 
            // button_submit_uid
            // 
            this.button_submit_uid.AnimationHoverSpeed = 0.07F;
            this.button_submit_uid.AnimationSpeed = 0.03F;
            this.button_submit_uid.BackColor = System.Drawing.Color.Transparent;
            this.button_submit_uid.BaseColor = System.Drawing.Color.Red;
            this.button_submit_uid.BorderColor = System.Drawing.Color.Black;
            this.button_submit_uid.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_submit_uid.FocusedColor = System.Drawing.Color.Empty;
            this.button_submit_uid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit_uid.ForeColor = System.Drawing.Color.White;
            this.button_submit_uid.Image = null;
            this.button_submit_uid.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_submit_uid.ImageSize = new System.Drawing.Size(20, 20);
            this.button_submit_uid.Location = new System.Drawing.Point(69, 230);
            this.button_submit_uid.Name = "button_submit_uid";
            this.button_submit_uid.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.button_submit_uid.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_submit_uid.OnHoverForeColor = System.Drawing.Color.White;
            this.button_submit_uid.OnHoverImage = null;
            this.button_submit_uid.OnPressedColor = System.Drawing.Color.Black;
            this.button_submit_uid.Radius = 5;
            this.button_submit_uid.Size = new System.Drawing.Size(107, 30);
            this.button_submit_uid.TabIndex = 11;
            this.button_submit_uid.Text = "Delete";
            this.button_submit_uid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_submit_uid.Click += new System.EventHandler(this.button_submit_uid_Click);
            // 
            // textBox_delete_uid
            // 
            this.textBox_delete_uid.BackColor = System.Drawing.Color.Transparent;
            this.textBox_delete_uid.BaseColor = System.Drawing.Color.White;
            this.textBox_delete_uid.BorderColor = System.Drawing.Color.Silver;
            this.textBox_delete_uid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_delete_uid.FocusedBaseColor = System.Drawing.Color.White;
            this.textBox_delete_uid.FocusedBorderColor = System.Drawing.Color.Gray;
            this.textBox_delete_uid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_delete_uid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_delete_uid.Location = new System.Drawing.Point(69, 175);
            this.textBox_delete_uid.Name = "textBox_delete_uid";
            this.textBox_delete_uid.PasswordChar = '\0';
            this.textBox_delete_uid.Radius = 5;
            this.textBox_delete_uid.SelectedText = "";
            this.textBox_delete_uid.Size = new System.Drawing.Size(279, 36);
            this.textBox_delete_uid.TabIndex = 10;
            // 
            // label_uid
            // 
            this.label_uid.AutoSize = true;
            this.label_uid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uid.Location = new System.Drawing.Point(64, 137);
            this.label_uid.Name = "label_uid";
            this.label_uid.Size = new System.Drawing.Size(92, 25);
            this.label_uid.TabIndex = 9;
            this.label_uid.Text = "Enter UID";
            // 
            // button_nav_read
            // 
            this.button_nav_read.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_nav_read.AnimationHoverSpeed = 0.07F;
            this.button_nav_read.AnimationSpeed = 0.03F;
            this.button_nav_read.BackColor = System.Drawing.Color.Transparent;
            this.button_nav_read.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.button_nav_read.BorderColor = System.Drawing.Color.Black;
            this.button_nav_read.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_nav_read.FocusedColor = System.Drawing.Color.Empty;
            this.button_nav_read.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nav_read.ForeColor = System.Drawing.Color.White;
            this.button_nav_read.Image = null;
            this.button_nav_read.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_read.ImageSize = new System.Drawing.Size(20, 20);
            this.button_nav_read.Location = new System.Drawing.Point(433, 396);
            this.button_nav_read.Name = "button_nav_read";
            this.button_nav_read.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button_nav_read.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_nav_read.OnHoverForeColor = System.Drawing.Color.White;
            this.button_nav_read.OnHoverImage = null;
            this.button_nav_read.OnPressedColor = System.Drawing.Color.Black;
            this.button_nav_read.Radius = 5;
            this.button_nav_read.Size = new System.Drawing.Size(121, 30);
            this.button_nav_read.TabIndex = 15;
            this.button_nav_read.Text = "Read Records";
            this.button_nav_read.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_read.Click += new System.EventHandler(this.button_nav_read_Click);
            // 
            // button_nav_update
            // 
            this.button_nav_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_nav_update.AnimationHoverSpeed = 0.07F;
            this.button_nav_update.AnimationSpeed = 0.03F;
            this.button_nav_update.BackColor = System.Drawing.Color.Transparent;
            this.button_nav_update.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.button_nav_update.BorderColor = System.Drawing.Color.Black;
            this.button_nav_update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_nav_update.FocusedColor = System.Drawing.Color.Empty;
            this.button_nav_update.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nav_update.ForeColor = System.Drawing.Color.White;
            this.button_nav_update.Image = null;
            this.button_nav_update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_update.ImageSize = new System.Drawing.Size(20, 20);
            this.button_nav_update.Location = new System.Drawing.Point(306, 396);
            this.button_nav_update.Name = "button_nav_update";
            this.button_nav_update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button_nav_update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_nav_update.OnHoverForeColor = System.Drawing.Color.White;
            this.button_nav_update.OnHoverImage = null;
            this.button_nav_update.OnPressedColor = System.Drawing.Color.Black;
            this.button_nav_update.Radius = 5;
            this.button_nav_update.Size = new System.Drawing.Size(121, 30);
            this.button_nav_update.TabIndex = 14;
            this.button_nav_update.Text = "Update Records";
            this.button_nav_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_update.Click += new System.EventHandler(this.button_nav_update_Click);
            // 
            // button_nav_enter
            // 
            this.button_nav_enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_nav_enter.AnimationHoverSpeed = 0.07F;
            this.button_nav_enter.AnimationSpeed = 0.03F;
            this.button_nav_enter.BackColor = System.Drawing.Color.Transparent;
            this.button_nav_enter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.button_nav_enter.BorderColor = System.Drawing.Color.Black;
            this.button_nav_enter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_nav_enter.FocusedColor = System.Drawing.Color.Empty;
            this.button_nav_enter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nav_enter.ForeColor = System.Drawing.Color.White;
            this.button_nav_enter.Image = null;
            this.button_nav_enter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_enter.ImageSize = new System.Drawing.Size(20, 20);
            this.button_nav_enter.Location = new System.Drawing.Point(179, 396);
            this.button_nav_enter.Name = "button_nav_enter";
            this.button_nav_enter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button_nav_enter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_nav_enter.OnHoverForeColor = System.Drawing.Color.White;
            this.button_nav_enter.OnHoverImage = null;
            this.button_nav_enter.OnPressedColor = System.Drawing.Color.Black;
            this.button_nav_enter.Radius = 5;
            this.button_nav_enter.Size = new System.Drawing.Size(121, 30);
            this.button_nav_enter.TabIndex = 16;
            this.button_nav_enter.Text = "Enter Records";
            this.button_nav_enter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_enter.Click += new System.EventHandler(this.button_nav_enter_Click);
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.button_nav_enter);
            this.Controls.Add(this.button_nav_read);
            this.Controls.Add(this.button_nav_update);
            this.Controls.Add(this.button_clear_uid_delete);
            this.Controls.Add(this.button_submit_uid);
            this.Controls.Add(this.textBox_delete_uid);
            this.Controls.Add(this.label_uid);
            this.Controls.Add(this.label_head_delete);
            this.Name = "FormDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete UID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel label_head_delete;
        private Guna.UI.WinForms.GunaButton button_clear_uid_delete;
        private Guna.UI.WinForms.GunaButton button_submit_uid;
        private Guna.UI.WinForms.GunaTextBox textBox_delete_uid;
        private Guna.UI.WinForms.GunaLabel label_uid;
        private Guna.UI.WinForms.GunaButton button_nav_read;
        private Guna.UI.WinForms.GunaButton button_nav_update;
        private Guna.UI.WinForms.GunaButton button_nav_enter;
    }
}