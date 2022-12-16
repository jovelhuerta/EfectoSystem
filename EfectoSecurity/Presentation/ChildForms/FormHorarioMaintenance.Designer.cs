namespace Presentation.ChildForms
{
    partial class FormHorarioMaintenance
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
            this.lblCaption = new System.Windows.Forms.Label();
            this.txtHora = new Presentation.Helpers.CustomDate();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.lblTolerancia = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblCaption.Location = new System.Drawing.Point(43, 72);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(191, 31);
            this.lblCaption.TabIndex = 128;
            this.lblCaption.Text = "Mantenimiento";
            // 
            // txtHora
            // 
            this.txtHora.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txtHora.BorderSize = 0;
            this.txtHora.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHora.CalendarTitleForeColor = System.Drawing.SystemColors.Control;
            this.txtHora.CustomFormat = "\"HH:mm\"";
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHora.Location = new System.Drawing.Point(71, 178);
            this.txtHora.MinimumSize = new System.Drawing.Size(4, 35);
            this.txtHora.Name = "txtHora";
            this.txtHora.ShowUpDown = true;
            this.txtHora.Size = new System.Drawing.Size(154, 35);
            this.txtHora.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(91)))));
            this.txtHora.TabIndex = 129;
            this.txtHora.TextColor = System.Drawing.Color.White;
            this.txtHora.Value = new System.DateTime(2022, 7, 16, 12, 28, 0, 0);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.ForeColor = System.Drawing.Color.DimGray;
            this.lblEntrada.Location = new System.Drawing.Point(67, 141);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(109, 20);
            this.lblEntrada.TabIndex = 130;
            this.lblEntrada.Text = "Hora Entrada:";
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTolerancia.Location = new System.Drawing.Point(341, 184);
            this.txtTolerancia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(160, 25);
            this.txtTolerancia.TabIndex = 132;
            // 
            // lblTolerancia
            // 
            this.lblTolerancia.AutoSize = true;
            this.lblTolerancia.BackColor = System.Drawing.Color.Transparent;
            this.lblTolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTolerancia.ForeColor = System.Drawing.Color.DimGray;
            this.lblTolerancia.Location = new System.Drawing.Point(337, 141);
            this.lblTolerancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTolerancia.Name = "lblTolerancia";
            this.lblTolerancia.Size = new System.Drawing.Size(146, 20);
            this.lblTolerancia.TabIndex = 133;
            this.lblTolerancia.Text = "Minutos Tolerancia:";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(623, 185);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(5);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(259, 28);
            this.cmbPuesto.TabIndex = 136;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.DimGray;
            this.lblPuesto.Location = new System.Drawing.Point(619, 141);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(63, 20);
            this.lblPuesto.TabIndex = 137;
            this.lblPuesto.Text = "Puesto:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(503, 338);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 49);
            this.btnSave.TabIndex = 138;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(206, 338);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 49);
            this.btnCancel.TabIndex = 139;
            this.btnCancel.Text = "X  Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormHorarioMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 392);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.txtTolerancia);
            this.Controls.Add(this.lblTolerancia);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblCaption);
            this.Name = "FormHorarioMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Horarios";
            this.Controls.SetChildIndex(this.lblCaption, 0);
            this.Controls.SetChildIndex(this.txtHora, 0);
            this.Controls.SetChildIndex(this.lblEntrada, 0);
            this.Controls.SetChildIndex(this.lblTolerancia, 0);
            this.Controls.SetChildIndex(this.txtTolerancia, 0);
            this.Controls.SetChildIndex(this.lblPuesto, 0);
            this.Controls.SetChildIndex(this.cmbPuesto, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblCaption;
        private Helpers.CustomDate txtHora;
        internal System.Windows.Forms.Label lblEntrada;
        internal System.Windows.Forms.TextBox txtTolerancia;
        internal System.Windows.Forms.Label lblTolerancia;
        internal System.Windows.Forms.ComboBox cmbPuesto;
        internal System.Windows.Forms.Label lblPuesto;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnCancel;
    }
}