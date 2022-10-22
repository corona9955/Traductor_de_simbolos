namespace Traductor_de_simbolos
{
    partial class Traductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Traductor));
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.btnTraducir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIntruccion = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblInstruccion2 = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblLine = new System.Windows.Forms.Label();
            this.panelEntrada = new System.Windows.Forms.Panel();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.panelSalida = new System.Windows.Forms.Panel();
            this.pbxSalida2 = new System.Windows.Forms.PictureBox();
            this.pbxSalida1 = new System.Windows.Forms.PictureBox();
            this.pbxInfo2 = new System.Windows.Forms.PictureBox();
            this.pbxInfo = new System.Windows.Forms.PictureBox();
            this.panelTitulo.SuspendLayout();
            this.panelEntrada.SuspendLayout();
            this.panelSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalida1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEntrada.Location = new System.Drawing.Point(58, 151);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(217, 75);
            this.txtEntrada.TabIndex = 0;
            // 
            // txtSalida
            // 
            this.txtSalida.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSalida.Location = new System.Drawing.Point(325, 151);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(217, 75);
            this.txtSalida.TabIndex = 1;
            // 
            // btnTraducir
            // 
            this.btnTraducir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTraducir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraducir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraducir.ForeColor = System.Drawing.Color.White;
            this.btnTraducir.Location = new System.Drawing.Point(100, 243);
            this.btnTraducir.Name = "btnTraducir";
            this.btnTraducir.Size = new System.Drawing.Size(130, 40);
            this.btnTraducir.TabIndex = 2;
            this.btnTraducir.Text = "Traducir";
            this.btnTraducir.UseVisualStyleBackColor = false;
            this.btnTraducir.Click += new System.EventHandler(this.btnTraducir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(375, 243);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 40);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(92, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(433, 45);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Traductor de símbolos";
            // 
            // lblIntruccion
            // 
            this.lblIntruccion.AutoSize = true;
            this.lblIntruccion.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntruccion.ForeColor = System.Drawing.Color.White;
            this.lblIntruccion.Location = new System.Drawing.Point(55, 74);
            this.lblIntruccion.Name = "lblIntruccion";
            this.lblIntruccion.Size = new System.Drawing.Size(287, 23);
            this.lblIntruccion.TabIndex = 5;
            this.lblIntruccion.Text = "Introduzca símbolos a traducir:";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.ForeColor = System.Drawing.Color.White;
            this.lblSalida.Location = new System.Drawing.Point(3, 2);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(63, 23);
            this.lblSalida.TabIndex = 6;
            this.lblSalida.Text = "Salida";
            // 
            // lblInstruccion2
            // 
            this.lblInstruccion2.AutoSize = true;
            this.lblInstruccion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion2.ForeColor = System.Drawing.Color.White;
            this.lblInstruccion2.Location = new System.Drawing.Point(56, 97);
            this.lblInstruccion2.Name = "lblInstruccion2";
            this.lblInstruccion2.Size = new System.Drawing.Size(225, 15);
            this.lblInstruccion2.TabIndex = 7;
            this.lblInstruccion2.Text = "Favor de dejar un espacio por símbolo...";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTitulo.Controls.Add(this.lblLine);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(605, 54);
            this.panelTitulo.TabIndex = 8;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(-3, 40);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(613, 13);
            this.lblLine.TabIndex = 11;
            this.lblLine.Text = "_________________________________________________________________________________" +
    "____________________";
            // 
            // panelEntrada
            // 
            this.panelEntrada.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelEntrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEntrada.Controls.Add(this.lblEntrada);
            this.panelEntrada.Location = new System.Drawing.Point(59, 125);
            this.panelEntrada.Name = "panelEntrada";
            this.panelEntrada.Size = new System.Drawing.Size(215, 26);
            this.panelEntrada.TabIndex = 9;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.ForeColor = System.Drawing.Color.White;
            this.lblEntrada.Location = new System.Drawing.Point(3, 2);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(79, 23);
            this.lblEntrada.TabIndex = 11;
            this.lblEntrada.Text = "Entrada";
            // 
            // panelSalida
            // 
            this.panelSalida.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSalida.Controls.Add(this.lblSalida);
            this.panelSalida.Location = new System.Drawing.Point(326, 125);
            this.panelSalida.Name = "panelSalida";
            this.panelSalida.Size = new System.Drawing.Size(215, 26);
            this.panelSalida.TabIndex = 10;
            // 
            // pbxSalida2
            // 
            this.pbxSalida2.Image = ((System.Drawing.Image)(resources.GetObject("pbxSalida2.Image")));
            this.pbxSalida2.Location = new System.Drawing.Point(546, 268);
            this.pbxSalida2.Name = "pbxSalida2";
            this.pbxSalida2.Size = new System.Drawing.Size(59, 50);
            this.pbxSalida2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSalida2.TabIndex = 14;
            this.pbxSalida2.TabStop = false;
            this.pbxSalida2.Visible = false;
            this.pbxSalida2.Click += new System.EventHandler(this.pbxSalida2_Click);
            this.pbxSalida2.MouseLeave += new System.EventHandler(this.pbxSalida2_MouseLeave);
            // 
            // pbxSalida1
            // 
            this.pbxSalida1.Image = global::Traductor_de_simbolos.Properties.Resources.btnSalida;
            this.pbxSalida1.Location = new System.Drawing.Point(546, 268);
            this.pbxSalida1.Name = "pbxSalida1";
            this.pbxSalida1.Size = new System.Drawing.Size(59, 50);
            this.pbxSalida1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSalida1.TabIndex = 13;
            this.pbxSalida1.TabStop = false;
            this.pbxSalida1.MouseHover += new System.EventHandler(this.pbxSalida1_MouseHover);
            // 
            // pbxInfo2
            // 
            this.pbxInfo2.Image = global::Traductor_de_simbolos.Properties.Resources.BotonAyuda2;
            this.pbxInfo2.Location = new System.Drawing.Point(0, 280);
            this.pbxInfo2.Name = "pbxInfo2";
            this.pbxInfo2.Size = new System.Drawing.Size(44, 38);
            this.pbxInfo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxInfo2.TabIndex = 12;
            this.pbxInfo2.TabStop = false;
            this.pbxInfo2.Visible = false;
            this.pbxInfo2.Click += new System.EventHandler(this.pbxInfo2_Click);
            this.pbxInfo2.MouseLeave += new System.EventHandler(this.pbxInfo2_MouseLeave);
            // 
            // pbxInfo
            // 
            this.pbxInfo.Image = global::Traductor_de_simbolos.Properties.Resources.BotonAyuda;
            this.pbxInfo.Location = new System.Drawing.Point(0, 280);
            this.pbxInfo.Name = "pbxInfo";
            this.pbxInfo.Size = new System.Drawing.Size(44, 38);
            this.pbxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxInfo.TabIndex = 11;
            this.pbxInfo.TabStop = false;
            this.pbxInfo.Click += new System.EventHandler(this.pbxInfo_Click_1);
            this.pbxInfo.MouseHover += new System.EventHandler(this.pbx1_MouseHover);
            // 
            // Traductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(605, 321);
            this.ControlBox = false;
            this.Controls.Add(this.pbxSalida2);
            this.Controls.Add(this.pbxSalida1);
            this.Controls.Add(this.pbxInfo2);
            this.Controls.Add(this.pbxInfo);
            this.Controls.Add(this.panelSalida);
            this.Controls.Add(this.panelEntrada);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.lblInstruccion2);
            this.Controls.Add(this.lblIntruccion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnTraducir);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Traductor";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelEntrada.ResumeLayout(false);
            this.panelEntrada.PerformLayout();
            this.panelSalida.ResumeLayout(false);
            this.panelSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalida1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button btnTraducir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIntruccion;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblInstruccion2;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelEntrada;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Panel panelSalida;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.PictureBox pbxInfo;
        private System.Windows.Forms.PictureBox pbxInfo2;
        private System.Windows.Forms.PictureBox pbxSalida1;
        private System.Windows.Forms.PictureBox pbxSalida2;
    }
}

