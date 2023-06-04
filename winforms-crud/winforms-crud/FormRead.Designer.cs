namespace winforms_crud
{
    partial class FormRead
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_nav_delete = new Guna.UI.WinForms.GunaButton();
            this.button_nav_enter = new Guna.UI.WinForms.GunaButton();
            this.button_nav_update = new Guna.UI.WinForms.GunaButton();
            this.datagridview_uid = new Guna.UI.WinForms.GunaDataGridView();
            this.label_head_read = new Guna.UI.WinForms.GunaLabel();
            this.button_show_data = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_uid)).BeginInit();
            this.SuspendLayout();
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
            this.button_nav_delete.Location = new System.Drawing.Point(52, 396);
            this.button_nav_delete.Name = "button_nav_delete";
            this.button_nav_delete.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.button_nav_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_nav_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.button_nav_delete.OnHoverImage = null;
            this.button_nav_delete.OnPressedColor = System.Drawing.Color.Black;
            this.button_nav_delete.Radius = 5;
            this.button_nav_delete.Size = new System.Drawing.Size(121, 30);
            this.button_nav_delete.TabIndex = 31;
            this.button_nav_delete.Text = "Delete Records";
            this.button_nav_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_delete.Click += new System.EventHandler(this.button_nav_delete_Click);
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
            this.button_nav_enter.TabIndex = 30;
            this.button_nav_enter.Text = "Enter Records";
            this.button_nav_enter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_enter.Click += new System.EventHandler(this.button_nav_enter_Click);
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
            this.button_nav_update.Location = new System.Drawing.Point(432, 396);
            this.button_nav_update.Name = "button_nav_update";
            this.button_nav_update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button_nav_update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_nav_update.OnHoverForeColor = System.Drawing.Color.White;
            this.button_nav_update.OnHoverImage = null;
            this.button_nav_update.OnPressedColor = System.Drawing.Color.Black;
            this.button_nav_update.Radius = 5;
            this.button_nav_update.Size = new System.Drawing.Size(121, 30);
            this.button_nav_update.TabIndex = 29;
            this.button_nav_update.Text = "Update Records";
            this.button_nav_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_nav_update.Click += new System.EventHandler(this.button_nav_update_Click);
            // 
            // datagridview_uid
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.datagridview_uid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.datagridview_uid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_uid.BackgroundColor = System.Drawing.Color.White;
            this.datagridview_uid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_uid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview_uid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_uid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.datagridview_uid.ColumnHeadersHeight = 4;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_uid.DefaultCellStyle = dataGridViewCellStyle18;
            this.datagridview_uid.EnableHeadersVisualStyles = false;
            this.datagridview_uid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_uid.Location = new System.Drawing.Point(69, 126);
            this.datagridview_uid.Name = "datagridview_uid";
            this.datagridview_uid.RowHeadersVisible = false;
            this.datagridview_uid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_uid.Size = new System.Drawing.Size(333, 204);
            this.datagridview_uid.TabIndex = 32;
            this.datagridview_uid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.datagridview_uid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_uid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridview_uid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridview_uid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridview_uid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridview_uid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_uid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_uid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridview_uid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview_uid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridview_uid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridview_uid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridview_uid.ThemeStyle.HeaderStyle.Height = 4;
            this.datagridview_uid.ThemeStyle.ReadOnly = false;
            this.datagridview_uid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_uid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview_uid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridview_uid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview_uid.ThemeStyle.RowsStyle.Height = 22;
            this.datagridview_uid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_uid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label_head_read
            // 
            this.label_head_read.AutoSize = true;
            this.label_head_read.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head_read.Location = new System.Drawing.Point(62, 65);
            this.label_head_read.Name = "label_head_read";
            this.label_head_read.Size = new System.Drawing.Size(178, 40);
            this.label_head_read.TabIndex = 33;
            this.label_head_read.Text = "UID Records";
            // 
            // button_show_data
            // 
            this.button_show_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_show_data.AnimationHoverSpeed = 0.07F;
            this.button_show_data.AnimationSpeed = 0.03F;
            this.button_show_data.BackColor = System.Drawing.Color.Transparent;
            this.button_show_data.BaseColor = System.Drawing.Color.ForestGreen;
            this.button_show_data.BorderColor = System.Drawing.Color.Black;
            this.button_show_data.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_show_data.FocusedColor = System.Drawing.Color.Empty;
            this.button_show_data.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_show_data.ForeColor = System.Drawing.Color.White;
            this.button_show_data.Image = null;
            this.button_show_data.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_show_data.ImageSize = new System.Drawing.Size(20, 20);
            this.button_show_data.Location = new System.Drawing.Point(179, 396);
            this.button_show_data.Name = "button_show_data";
            this.button_show_data.OnHoverBaseColor = System.Drawing.Color.LimeGreen;
            this.button_show_data.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_show_data.OnHoverForeColor = System.Drawing.Color.White;
            this.button_show_data.OnHoverImage = null;
            this.button_show_data.OnPressedColor = System.Drawing.Color.Black;
            this.button_show_data.Radius = 5;
            this.button_show_data.Size = new System.Drawing.Size(121, 30);
            this.button_show_data.TabIndex = 34;
            this.button_show_data.Text = "Show Records";
            this.button_show_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_show_data.Click += new System.EventHandler(this.button_show_data_Click);
            // 
            // FormRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.button_show_data);
            this.Controls.Add(this.label_head_read);
            this.Controls.Add(this.datagridview_uid);
            this.Controls.Add(this.button_nav_delete);
            this.Controls.Add(this.button_nav_enter);
            this.Controls.Add(this.button_nav_update);
            this.Name = "FormRead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UID Records";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_uid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton button_nav_delete;
        private Guna.UI.WinForms.GunaButton button_nav_enter;
        private Guna.UI.WinForms.GunaButton button_nav_update;
        private Guna.UI.WinForms.GunaDataGridView datagridview_uid;
        private Guna.UI.WinForms.GunaLabel label_head_read;
        private Guna.UI.WinForms.GunaButton button_show_data;
    }
}