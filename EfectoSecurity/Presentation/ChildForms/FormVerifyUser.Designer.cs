namespace Presentation.ChildForms
{
    partial class FormVerifyUser
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
            this.txtConcect = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameSucursal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypeSucursal = new System.Windows.Forms.TextBox();
            this.btnSaveSucursal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConcect
            // 
            this.txtConcect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcect.Location = new System.Drawing.Point(26, 78);
            this.txtConcect.Name = "txtConcect";
            this.txtConcect.Size = new System.Drawing.Size(310, 26);
            this.txtConcect.TabIndex = 0;
            this.txtConcect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserPass_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(360, 72);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 40);
            this.btnOk.TabIndex = 128;
            this.btnOk.Text = "Aceptar conexion";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMessage.Location = new System.Drawing.Point(23, 101);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(64, 16);
            this.lblMessage.TabIndex = 129;
            this.lblMessage.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 130;
            this.label1.Text = "Conexion a servidor";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(360, 141);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(150, 40);
            this.btnCheck.TabIndex = 131;
            this.btnCheck.Text = "Data Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(23, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 133;
            this.label2.Text = "Nombre de Sucursal";
            // 
            // txtNameSucursal
            // 
            this.txtNameSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSucursal.Location = new System.Drawing.Point(26, 155);
            this.txtNameSucursal.Name = "txtNameSucursal";
            this.txtNameSucursal.Size = new System.Drawing.Size(310, 26);
            this.txtNameSucursal.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(23, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 135;
            this.label3.Text = "Tipo de Sucursal";
            // 
            // txtTypeSucursal
            // 
            this.txtTypeSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeSucursal.Location = new System.Drawing.Point(26, 219);
            this.txtTypeSucursal.Name = "txtTypeSucursal";
            this.txtTypeSucursal.Size = new System.Drawing.Size(310, 26);
            this.txtTypeSucursal.TabIndex = 134;
            // 
            // btnSaveSucursal
            // 
            this.btnSaveSucursal.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveSucursal.FlatAppearance.BorderSize = 0;
            this.btnSaveSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSucursal.ForeColor = System.Drawing.Color.White;
            this.btnSaveSucursal.Location = new System.Drawing.Point(360, 213);
            this.btnSaveSucursal.Name = "btnSaveSucursal";
            this.btnSaveSucursal.Size = new System.Drawing.Size(150, 40);
            this.btnSaveSucursal.TabIndex = 136;
            this.btnSaveSucursal.Text = "Guardar";
            this.btnSaveSucursal.UseVisualStyleBackColor = false;
            this.btnSaveSucursal.Click += new System.EventHandler(this.btnSaveSucursal_Click);
            // 
            // FormVerifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 281);
            this.Controls.Add(this.btnSaveSucursal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTypeSucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameSucursal);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtConcect);
            this.Name = "FormVerifyUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de seguridad";
            this.Controls.SetChildIndex(this.txtConcect, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnCheck, 0);
            this.Controls.SetChildIndex(this.txtNameSucursal, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtTypeSucursal, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnSaveSucursal, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConcect;
        internal System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameSucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTypeSucursal;
        internal System.Windows.Forms.Button btnSaveSucursal;
    }
}