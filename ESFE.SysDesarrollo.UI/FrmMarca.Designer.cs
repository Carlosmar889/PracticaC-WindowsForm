namespace ESFE.SysDesarrollo.UI
{
    partial class FrmMarca
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
            this.txtNumID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtRegMar = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Descrip = new System.Windows.Forms.Label();
            this.lbl_RegM = new System.Windows.Forms.Label();
            this.btnInser = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnObtener = new System.Windows.Forms.Button();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumID
            // 
            this.txtNumID.BackColor = System.Drawing.Color.Honeydew;
            this.txtNumID.Location = new System.Drawing.Point(363, 37);
            this.txtNumID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumID.Name = "txtNumID";
            this.txtNumID.Size = new System.Drawing.Size(185, 22);
            this.txtNumID.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Honeydew;
            this.txtNombre.Location = new System.Drawing.Point(363, 92);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.Honeydew;
            this.txtDescrip.Location = new System.Drawing.Point(363, 145);
            this.txtDescrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(185, 22);
            this.txtDescrip.TabIndex = 2;
            // 
            // txtRegMar
            // 
            this.txtRegMar.BackColor = System.Drawing.Color.Honeydew;
            this.txtRegMar.Location = new System.Drawing.Point(363, 199);
            this.txtRegMar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegMar.Name = "txtRegMar";
            this.txtRegMar.Size = new System.Drawing.Size(185, 22);
            this.txtRegMar.TabIndex = 3;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(143, 46);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(26, 20);
            this.lbl_ID.TabIndex = 4;
            this.lbl_ID.Text = "Id";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(143, 101);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(64, 20);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Descrip
            // 
            this.lbl_Descrip.AutoSize = true;
            this.lbl_Descrip.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descrip.Location = new System.Drawing.Point(143, 154);
            this.lbl_Descrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Descrip.Name = "lbl_Descrip";
            this.lbl_Descrip.Size = new System.Drawing.Size(90, 20);
            this.lbl_Descrip.TabIndex = 6;
            this.lbl_Descrip.Text = "Descripcion";
            // 
            // lbl_RegM
            // 
            this.lbl_RegM.AutoSize = true;
            this.lbl_RegM.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegM.Location = new System.Drawing.Point(143, 208);
            this.lbl_RegM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RegM.Name = "lbl_RegM";
            this.lbl_RegM.Size = new System.Drawing.Size(136, 20);
            this.lbl_RegM.TabIndex = 7;
            this.lbl_RegM.Text = "Registro de Marca";
            // 
            // btnInser
            // 
            this.btnInser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInser.Location = new System.Drawing.Point(105, 261);
            this.btnInser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInser.Name = "btnInser";
            this.btnInser.Size = new System.Drawing.Size(121, 38);
            this.btnInser.TabIndex = 8;
            this.btnInser.Text = "Insertar";
            this.btnInser.UseVisualStyleBackColor = false;
            this.btnInser.Click += new System.EventHandler(this.btnInser_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(433, 261);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(168, 38);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar Por nombre";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActualizar.Location = new System.Drawing.Point(643, 261);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(121, 38);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnObtener.Location = new System.Drawing.Point(268, 261);
            this.btnObtener.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(121, 38);
            this.btnObtener.TabIndex = 11;
            this.btnObtener.Text = "Obtener Todos";
            this.btnObtener.UseVisualStyleBackColor = false;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // DataGV
            // 
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Location = new System.Drawing.Point(147, 322);
            this.DataGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGV.Name = "DataGV";
            this.DataGV.RowHeadersWidth = 51;
            this.DataGV.Size = new System.Drawing.Size(680, 217);
            this.DataGV.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(804, 261);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 38);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.DataGV);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInser);
            this.Controls.Add(this.lbl_RegM);
            this.Controls.Add(this.lbl_Descrip);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txtRegMar);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMarca";
            this.Text = "FrmMarca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtRegMar;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Descrip;
        private System.Windows.Forms.Label lbl_RegM;
        private System.Windows.Forms.Button btnInser;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.Button btnEliminar;
    }
}