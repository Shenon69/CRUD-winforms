namespace winforms_crud
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
            this.label_uid = new Guna.UI.WinForms.GunaLabel();
            this.textBox_uid = new Guna.UI.WinForms.GunaTextBox();
            this.button_submit_uid = new Guna.UI.WinForms.GunaButton();
            this.button_clear_uid = new Guna.UI.WinForms.GunaButton();
            this.button_nav_delete = new Guna.UI.WinForms.GunaButton();
            this.button_nav_update = new Guna.UI.WinForms.GunaButton();
            this.button_nav_read = new Guna.UI.WinForms.GunaButton();
            this.label_head_submit = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // label_uid
            // 
            this.label_uid.AutoSize = true;
            this.label_uid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uid.Location = new System.Drawing.Point(64, 137);
            this.label_uid.Name = "label_uid";
            this.label_uid.Size = new System.Drawing.Size(92, 25);
            this.label_uid.TabIndex = 0;
            this.label_uid.Text = "Enter UID";
            // 
            // textBox_uid
            // 
            this.textBox_uid.BackColor = System.Drawing.Color.Transparent;
            this.textBox_uid.BaseColor = System.Drawing.Color.White;
            this.textBox_uid.BorderColor = System.Drawing.Color.Silver;
            this.textBox_uid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_uid.FocusedBaseColor = System.Drawing.Color.White;
            this.textBox_uid.FocusedBorderColor = System.Drawing.Color.Gray;
            this.textBox_uid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_uid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_uid.Location = new System.Drawing.Point(69, 175);
            this.textBox_uid.Name = "textBox_uid";
            this.textBox_uid.PasswordChar = '\0';
            this.textBox_uid.Radius = 5;
            this.textBox_uid.SelectedText = "";
            this.textBox_uid.Size = new System.Drawing.Size(279, 36);
            this.textBox_uid.TabIndex = 1;
            // 
            // button_submit_uid
            // 
            this.button_submit_uid.AnimationHoverSpeed = 0.07F;
            this.button_submit_uid.AnimationSpeed = 0.03F;
            this.button_submit_uid.BackColor = System.Drawing.Color.Transparent;
            this.button_submit_uid.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
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
            this.button_submit_uid.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button_submit_uid.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_submit_uid.OnHoverForeColor = System.Drawing.Color.White;
            this.button_submit_uid.OnHoverImage = null;
            this.button_submit_uid.OnPressedColor = System.Drawing.Color.Black;
            this.button_submit_uid.Radius = 5;
            this.button_submit_uid.Size = new System.Drawing.Size(107, 30);
            this.button_submit_uid.TabIndex = 2;
            this.button_submit_uid.Text = "Submit";
            this.button_submit_uid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_submit_uid.Click += new System.EventHandler(this.button_submit_uid_Click);
            // 
            // button_clear_uid
            // 
            this.button_clear_uid.AnimationHoverSpeed = 0.07F;
            this.button_clear_uid.AnimationSpeed = 0.03F;
            this.button_clear_uid.BackColor = System.Drawing.Color.Transparent;
            this.button_clear_uid.BaseColor = System.Drawing.Color.Gray;
            this.button_clear_uid.BorderColor = System.Drawing.Color.Black;
            this.button_clear_uid.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_clear_uid.FocusedColor = System.Drawing.Color.Empty;
            this.button_clear_uid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_uid.ForeColor = System.Drawing.Color.White;
            this.button_clear_uid.Image = null;
            this.button_clear_uid.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_clear_uid.ImageSize = new System.Drawing.Size(20, 20);
            this.button_clear_uid.Location = new System.Drawing.Point(182, 230);
            this.button_clear_uid.Name = "button_clear_uid";
            this.button_clear_uid.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.button_clear_uid.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_clear_uid.OnHoverForeColor = System.Drawing.Color.White;
            this.button_clear_uid.OnHoverImage = null;
            this.button_clear_uid.OnPressedColor = System.Drawing.Color.Black;
            this.button_clear_uid.Radius = 5;
            this.button_clear_uid.Size = new System.Drawing.Size(107, 30);
            this.button_clear_uid.TabIndex = 3;
            this.button_clear_uid.Text = "Clear";
            this.button_clear_uid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_clear_uid.Click += new System.EventHandler(this.button_clear_uid_Click);
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
            this.button_nav_delete.TabIndex = 4;
            this.button_nav_delete.Text = "Delete Records";
            this.button_nav_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_delete.Click += new System.EventHandler(this.button_nav_delete_Click);
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
            this.button_nav_update.TabIndex = 5;
            this.button_nav_update.Text = "Update Records";
            this.button_nav_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_update.Click += new System.EventHandler(this.button_nav_update_Click);
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
            this.button_nav_read.TabIndex = 6;
            this.button_nav_read.Text = "Read Records";
            this.button_nav_read.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_read.Click += new System.EventHandler(this.button_nav_read_Click);
            // 
            // label_head_submit
            // 
            this.label_head_submit.AutoSize = true;
            this.label_head_submit.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head_submit.Location = new System.Drawing.Point(62, 65);
            this.label_head_submit.Name = "label_head_submit";
            this.label_head_submit.Size = new System.Drawing.Size(282, 40);
            this.label_head_submit.TabIndex = 7;
            this.label_head_submit.Text = "Submit New User ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.label_head_submit);
            this.Controls.Add(this.button_nav_read);
            this.Controls.Add(this.button_nav_update);
            this.Controls.Add(this.button_nav_delete);
            this.Controls.Add(this.button_clear_uid);
            this.Controls.Add(this.button_submit_uid);
            this.Controls.Add(this.textBox_uid);
            this.Controls.Add(this.label_uid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit UID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel label_uid;
        private Guna.UI.WinForms.GunaTextBox textBox_uid;
        private Guna.UI.WinForms.GunaButton button_submit_uid;
        private Guna.UI.WinForms.GunaButton button_clear_uid;
        private Guna.UI.WinForms.GunaButton button_nav_delete;
        private Guna.UI.WinForms.GunaButton button_nav_update;
        private Guna.UI.WinForms.GunaButton button_nav_read;
        private Guna.UI.WinForms.GunaLabel label_head_submit;
    }
}

