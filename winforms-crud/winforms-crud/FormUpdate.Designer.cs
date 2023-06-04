namespace winforms_crud
{
    partial class FormUpdate
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
            this.button_nav_enter = new Guna.UI.WinForms.GunaButton();
            this.button_nav_read = new Guna.UI.WinForms.GunaButton();
            this.button_clear_uid_update = new Guna.UI.WinForms.GunaButton();
            this.textBox_update_uid = new Guna.UI.WinForms.GunaTextBox();
            this.label_updated_uid = new Guna.UI.WinForms.GunaLabel();
            this.label_head_update = new Guna.UI.WinForms.GunaLabel();
            this.button_update_uid = new Guna.UI.WinForms.GunaButton();
            this.textBox_old_uid = new Guna.UI.WinForms.GunaTextBox();
            this.label_prev_update = new Guna.UI.WinForms.GunaLabel();
            this.button_nav_delete = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
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
            this.button_nav_enter.Location = new System.Drawing.Point(306, 396);
            this.button_nav_enter.Name = "button_nav_enter";
            this.button_nav_enter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button_nav_enter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_nav_enter.OnHoverForeColor = System.Drawing.Color.White;
            this.button_nav_enter.OnHoverImage = null;
            this.button_nav_enter.OnPressedColor = System.Drawing.Color.Black;
            this.button_nav_enter.Radius = 5;
            this.button_nav_enter.Size = new System.Drawing.Size(121, 30);
            this.button_nav_enter.TabIndex = 24;
            this.button_nav_enter.Text = "Enter Records";
            this.button_nav_enter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_enter.Click += new System.EventHandler(this.button_nav_enter_Click);
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
            this.button_nav_read.TabIndex = 23;
            this.button_nav_read.Text = "Read Records";
            this.button_nav_read.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_read.Click += new System.EventHandler(this.button_nav_read_Click);
            // 
            // button_clear_uid_update
            // 
            this.button_clear_uid_update.AnimationHoverSpeed = 0.07F;
            this.button_clear_uid_update.AnimationSpeed = 0.03F;
            this.button_clear_uid_update.BackColor = System.Drawing.Color.Transparent;
            this.button_clear_uid_update.BaseColor = System.Drawing.Color.Gray;
            this.button_clear_uid_update.BorderColor = System.Drawing.Color.Black;
            this.button_clear_uid_update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_clear_uid_update.FocusedColor = System.Drawing.Color.Empty;
            this.button_clear_uid_update.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_uid_update.ForeColor = System.Drawing.Color.White;
            this.button_clear_uid_update.Image = null;
            this.button_clear_uid_update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_clear_uid_update.ImageSize = new System.Drawing.Size(20, 20);
            this.button_clear_uid_update.Location = new System.Drawing.Point(163, 291);
            this.button_clear_uid_update.Name = "button_clear_uid_update";
            this.button_clear_uid_update.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.button_clear_uid_update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_clear_uid_update.OnHoverForeColor = System.Drawing.Color.White;
            this.button_clear_uid_update.OnHoverImage = null;
            this.button_clear_uid_update.OnPressedColor = System.Drawing.Color.Black;
            this.button_clear_uid_update.Radius = 5;
            this.button_clear_uid_update.Size = new System.Drawing.Size(107, 30);
            this.button_clear_uid_update.TabIndex = 21;
            this.button_clear_uid_update.Text = "Clear";
            this.button_clear_uid_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_clear_uid_update.Click += new System.EventHandler(this.button_clear_uid_update_Click);
            // 
            // textBox_update_uid
            // 
            this.textBox_update_uid.BackColor = System.Drawing.Color.Transparent;
            this.textBox_update_uid.BaseColor = System.Drawing.Color.White;
            this.textBox_update_uid.BorderColor = System.Drawing.Color.Silver;
            this.textBox_update_uid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_update_uid.FocusedBaseColor = System.Drawing.Color.White;
            this.textBox_update_uid.FocusedBorderColor = System.Drawing.Color.Gray;
            this.textBox_update_uid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_update_uid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_update_uid.Location = new System.Drawing.Point(50, 236);
            this.textBox_update_uid.Name = "textBox_update_uid";
            this.textBox_update_uid.PasswordChar = '\0';
            this.textBox_update_uid.Radius = 5;
            this.textBox_update_uid.SelectedText = "";
            this.textBox_update_uid.Size = new System.Drawing.Size(279, 36);
            this.textBox_update_uid.TabIndex = 19;
            // 
            // label_updated_uid
            // 
            this.label_updated_uid.AutoSize = true;
            this.label_updated_uid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_updated_uid.Location = new System.Drawing.Point(45, 198);
            this.label_updated_uid.Name = "label_updated_uid";
            this.label_updated_uid.Size = new System.Drawing.Size(120, 25);
            this.label_updated_uid.TabIndex = 18;
            this.label_updated_uid.Text = "Updated UID";
            // 
            // label_head_update
            // 
            this.label_head_update.AutoSize = true;
            this.label_head_update.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head_update.Location = new System.Drawing.Point(43, 45);
            this.label_head_update.Name = "label_head_update";
            this.label_head_update.Size = new System.Drawing.Size(215, 40);
            this.label_head_update.TabIndex = 17;
            this.label_head_update.Text = "Update User ID";
            // 
            // button_update_uid
            // 
            this.button_update_uid.AnimationHoverSpeed = 0.07F;
            this.button_update_uid.AnimationSpeed = 0.03F;
            this.button_update_uid.BackColor = System.Drawing.Color.Transparent;
            this.button_update_uid.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.button_update_uid.BorderColor = System.Drawing.Color.Black;
            this.button_update_uid.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_update_uid.FocusedColor = System.Drawing.Color.Empty;
            this.button_update_uid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update_uid.ForeColor = System.Drawing.Color.White;
            this.button_update_uid.Image = null;
            this.button_update_uid.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_update_uid.ImageSize = new System.Drawing.Size(20, 20);
            this.button_update_uid.Location = new System.Drawing.Point(50, 291);
            this.button_update_uid.Name = "button_update_uid";
            this.button_update_uid.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button_update_uid.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_update_uid.OnHoverForeColor = System.Drawing.Color.White;
            this.button_update_uid.OnHoverImage = null;
            this.button_update_uid.OnPressedColor = System.Drawing.Color.Black;
            this.button_update_uid.Radius = 5;
            this.button_update_uid.Size = new System.Drawing.Size(107, 30);
            this.button_update_uid.TabIndex = 25;
            this.button_update_uid.Text = "Update";
            this.button_update_uid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_update_uid.Click += new System.EventHandler(this.button_update_uid_Click);
            // 
            // textBox_old_uid
            // 
            this.textBox_old_uid.BackColor = System.Drawing.Color.Transparent;
            this.textBox_old_uid.BaseColor = System.Drawing.Color.White;
            this.textBox_old_uid.BorderColor = System.Drawing.Color.Silver;
            this.textBox_old_uid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_old_uid.FocusedBaseColor = System.Drawing.Color.White;
            this.textBox_old_uid.FocusedBorderColor = System.Drawing.Color.Gray;
            this.textBox_old_uid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_old_uid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_old_uid.Location = new System.Drawing.Point(50, 149);
            this.textBox_old_uid.Name = "textBox_old_uid";
            this.textBox_old_uid.PasswordChar = '\0';
            this.textBox_old_uid.Radius = 5;
            this.textBox_old_uid.SelectedText = "";
            this.textBox_old_uid.Size = new System.Drawing.Size(279, 36);
            this.textBox_old_uid.TabIndex = 27;
            // 
            // label_prev_update
            // 
            this.label_prev_update.AutoSize = true;
            this.label_prev_update.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prev_update.Location = new System.Drawing.Point(45, 111);
            this.label_prev_update.Name = "label_prev_update";
            this.label_prev_update.Size = new System.Drawing.Size(78, 25);
            this.label_prev_update.TabIndex = 26;
            this.label_prev_update.Text = "Old UID";
            // 
            // button_nav_delete
            // 
            this.button_nav_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_nav_delete.AnimationHoverSpeed = 0.07F;
            this.button_nav_delete.AnimationSpeed = 0.03F;
            this.button_nav_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_nav_delete.BaseColor = System.Drawing.Color.Red;
            this.button_nav_delete.BorderColor = System.Drawing.Color.Black;
            this.button_nav_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_nav_delete.FocusedColor = System.Drawing.Color.Empty;
            this.button_nav_delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nav_delete.ForeColor = System.Drawing.Color.White;
            this.button_nav_delete.Image = null;
            this.button_nav_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_delete.ImageSize = new System.Drawing.Size(20, 20);
            this.button_nav_delete.Location = new System.Drawing.Point(179, 396);
            this.button_nav_delete.Name = "button_nav_delete";
            this.button_nav_delete.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.button_nav_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_nav_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.button_nav_delete.OnHoverImage = null;
            this.button_nav_delete.OnPressedColor = System.Drawing.Color.Black;
            this.button_nav_delete.Radius = 5;
            this.button_nav_delete.Size = new System.Drawing.Size(121, 30);
            this.button_nav_delete.TabIndex = 28;
            this.button_nav_delete.Text = "Delete Records";
            this.button_nav_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_delete.Click += new System.EventHandler(this.button_nav_delete_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.button_nav_delete);
            this.Controls.Add(this.textBox_old_uid);
            this.Controls.Add(this.label_prev_update);
            this.Controls.Add(this.button_update_uid);
            this.Controls.Add(this.button_nav_enter);
            this.Controls.Add(this.button_nav_read);
            this.Controls.Add(this.button_clear_uid_update);
            this.Controls.Add(this.textBox_update_uid);
            this.Controls.Add(this.label_updated_uid);
            this.Controls.Add(this.label_head_update);
            this.Name = "FormUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update UID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton button_nav_enter;
        private Guna.UI.WinForms.GunaButton button_nav_read;
        private Guna.UI.WinForms.GunaButton button_clear_uid_update;
        private Guna.UI.WinForms.GunaTextBox textBox_update_uid;
        private Guna.UI.WinForms.GunaLabel label_updated_uid;
        private Guna.UI.WinForms.GunaLabel label_head_update;
        private Guna.UI.WinForms.GunaButton button_update_uid;
        private Guna.UI.WinForms.GunaTextBox textBox_old_uid;
        private Guna.UI.WinForms.GunaLabel label_prev_update;
        private Guna.UI.WinForms.GunaButton button_nav_delete;
    }
}