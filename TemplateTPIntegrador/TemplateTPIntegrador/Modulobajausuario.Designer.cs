﻿namespace TemplateTPIntegrador
{
    partial class Modulobajausuario
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
            this.Botondardebaja = new System.Windows.Forms.Button();
            this.Botonreactivarusuario = new System.Windows.Forms.Button();
            this.listausuarios = new System.Windows.Forms.DataGridView();
            this.Listadeusuarios = new System.Windows.Forms.Label();
            this.Iddeusuariotexto = new System.Windows.Forms.TextBox();
            this.Iddenombretexto = new System.Windows.Forms.TextBox();
            this.IngreseID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscarusuarioboton = new System.Windows.Forms.Button();
            this.contrafondologo = new System.Windows.Forms.Panel();
            this.electrohogarlbl = new System.Windows.Forms.Label();
            this.sistemalbl = new System.Windows.Forms.Label();
            this.LogoElectroHogar = new System.Windows.Forms.PictureBox();
            this.Alertabotones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listausuarios)).BeginInit();
            this.contrafondologo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoElectroHogar)).BeginInit();
            this.SuspendLayout();
            // 
            // Botondardebaja
            // 
            this.Botondardebaja.BackColor = System.Drawing.Color.DarkRed;
            this.Botondardebaja.CausesValidation = false;
            this.Botondardebaja.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botondardebaja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Botondardebaja.Location = new System.Drawing.Point(874, 942);
            this.Botondardebaja.Name = "Botondardebaja";
            this.Botondardebaja.Size = new System.Drawing.Size(183, 96);
            this.Botondardebaja.TabIndex = 0;
            this.Botondardebaja.Text = "Dar de baja";
            this.Botondardebaja.UseVisualStyleBackColor = false;
            this.Botondardebaja.Click += new System.EventHandler(this.Botondardebaja_Click);
            // 
            // Botonreactivarusuario
            // 
            this.Botonreactivarusuario.BackColor = System.Drawing.Color.DarkCyan;
            this.Botonreactivarusuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botonreactivarusuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Botonreactivarusuario.Location = new System.Drawing.Point(1300, 942);
            this.Botonreactivarusuario.Name = "Botonreactivarusuario";
            this.Botonreactivarusuario.Size = new System.Drawing.Size(183, 96);
            this.Botonreactivarusuario.TabIndex = 1;
            this.Botonreactivarusuario.Text = "Reactivar usuario";
            this.Botonreactivarusuario.UseVisualStyleBackColor = false;
            this.Botonreactivarusuario.Click += new System.EventHandler(this.Botonreactivarusuario_Click);
            // 
            // listausuarios
            // 
            this.listausuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listausuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listausuarios.Location = new System.Drawing.Point(575, 251);
            this.listausuarios.Name = "listausuarios";
            this.listausuarios.RowHeadersWidth = 62;
            this.listausuarios.RowTemplate.Height = 28;
            this.listausuarios.Size = new System.Drawing.Size(1153, 675);
            this.listausuarios.TabIndex = 2;
            this.listausuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listausuarios_CellContentClick);
            // 
            // Listadeusuarios
            // 
            this.Listadeusuarios.AutoSize = true;
            this.Listadeusuarios.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listadeusuarios.Location = new System.Drawing.Point(978, 186);
            this.Listadeusuarios.Name = "Listadeusuarios";
            this.Listadeusuarios.Size = new System.Drawing.Size(337, 47);
            this.Listadeusuarios.TabIndex = 3;
            this.Listadeusuarios.Text = "Lista de usuarios";
            // 
            // Iddeusuariotexto
            // 
            this.Iddeusuariotexto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iddeusuariotexto.Location = new System.Drawing.Point(636, 50);
            this.Iddeusuariotexto.Name = "Iddeusuariotexto";
            this.Iddeusuariotexto.Size = new System.Drawing.Size(438, 32);
            this.Iddeusuariotexto.TabIndex = 4;
            // 
            // Iddenombretexto
            // 
            this.Iddenombretexto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iddenombretexto.Location = new System.Drawing.Point(1221, 50);
            this.Iddenombretexto.Name = "Iddenombretexto";
            this.Iddenombretexto.Size = new System.Drawing.Size(438, 32);
            this.Iddenombretexto.TabIndex = 5;
            // 
            // IngreseID
            // 
            this.IngreseID.AutoSize = true;
            this.IngreseID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseID.Location = new System.Drawing.Point(735, 9);
            this.IngreseID.Name = "IngreseID";
            this.IngreseID.Size = new System.Drawing.Size(213, 23);
            this.IngreseID.TabIndex = 6;
            this.IngreseID.Text = "Ingrese ID de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese nombre de usuario";
            // 
            // Buscarusuarioboton
            // 
            this.Buscarusuarioboton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Buscarusuarioboton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarusuarioboton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buscarusuarioboton.Location = new System.Drawing.Point(1068, 110);
            this.Buscarusuarioboton.Name = "Buscarusuarioboton";
            this.Buscarusuarioboton.Size = new System.Drawing.Size(160, 73);
            this.Buscarusuarioboton.TabIndex = 8;
            this.Buscarusuarioboton.Text = "Buscar Usuario";
            this.Buscarusuarioboton.UseVisualStyleBackColor = false;
            this.Buscarusuarioboton.Click += new System.EventHandler(this.Buscarusuarioboton_Click);
            // 
            // contrafondologo
            // 
            this.contrafondologo.BackColor = System.Drawing.Color.DarkCyan;
            this.contrafondologo.Controls.Add(this.electrohogarlbl);
            this.contrafondologo.Controls.Add(this.sistemalbl);
            this.contrafondologo.Controls.Add(this.LogoElectroHogar);
            this.contrafondologo.Dock = System.Windows.Forms.DockStyle.Left;
            this.contrafondologo.Location = new System.Drawing.Point(0, 0);
            this.contrafondologo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contrafondologo.Name = "contrafondologo";
            this.contrafondologo.Size = new System.Drawing.Size(397, 1050);
            this.contrafondologo.TabIndex = 11;
            // 
            // electrohogarlbl
            // 
            this.electrohogarlbl.AutoSize = true;
            this.electrohogarlbl.BackColor = System.Drawing.Color.Transparent;
            this.electrohogarlbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electrohogarlbl.ForeColor = System.Drawing.Color.White;
            this.electrohogarlbl.Location = new System.Drawing.Point(22, 300);
            this.electrohogarlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.electrohogarlbl.Name = "electrohogarlbl";
            this.electrohogarlbl.Size = new System.Drawing.Size(286, 39);
            this.electrohogarlbl.TabIndex = 11;
            this.electrohogarlbl.Text = "ElectroHogar S.A.";
            // 
            // sistemalbl
            // 
            this.sistemalbl.AutoSize = true;
            this.sistemalbl.BackColor = System.Drawing.Color.Transparent;
            this.sistemalbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistemalbl.ForeColor = System.Drawing.Color.White;
            this.sistemalbl.Location = new System.Drawing.Point(22, 251);
            this.sistemalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sistemalbl.Name = "sistemalbl";
            this.sistemalbl.Size = new System.Drawing.Size(309, 39);
            this.sistemalbl.TabIndex = 10;
            this.sistemalbl.Text = "Sistema de gestión";
            // 
            // LogoElectroHogar
            // 
            this.LogoElectroHogar.Image = global::TemplateTPIntegrador.Properties.Resources.LogoElectroHogar;
            this.LogoElectroHogar.Location = new System.Drawing.Point(109, 75);
            this.LogoElectroHogar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoElectroHogar.Name = "LogoElectroHogar";
            this.LogoElectroHogar.Size = new System.Drawing.Size(132, 138);
            this.LogoElectroHogar.TabIndex = 0;
            this.LogoElectroHogar.TabStop = false;
            // 
            // Alertabotones
            // 
            this.Alertabotones.AutoSize = true;
            this.Alertabotones.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alertabotones.Location = new System.Drawing.Point(1423, 1103);
            this.Alertabotones.Name = "Alertabotones";
            this.Alertabotones.Size = new System.Drawing.Size(59, 21);
            this.Alertabotones.TabIndex = 12;
            this.Alertabotones.Text = "Alerta";
            this.Alertabotones.Visible = false;
            // 
            // Modulobajausuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.Alertabotones);
            this.Controls.Add(this.contrafondologo);
            this.Controls.Add(this.Buscarusuarioboton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngreseID);
            this.Controls.Add(this.Iddenombretexto);
            this.Controls.Add(this.Iddeusuariotexto);
            this.Controls.Add(this.Listadeusuarios);
            this.Controls.Add(this.listausuarios);
            this.Controls.Add(this.Botonreactivarusuario);
            this.Controls.Add(this.Botondardebaja);
            this.Name = "Modulobajausuario";
            this.Text = "Baja de usuarios";
            this.Load += new System.EventHandler(this.Modulobajausuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listausuarios)).EndInit();
            this.contrafondologo.ResumeLayout(false);
            this.contrafondologo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoElectroHogar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botondardebaja;
        private System.Windows.Forms.Button Botonreactivarusuario;
        private System.Windows.Forms.DataGridView listausuarios;
        private System.Windows.Forms.Label Listadeusuarios;
        private System.Windows.Forms.TextBox Iddeusuariotexto;
        private System.Windows.Forms.TextBox Iddenombretexto;
        private System.Windows.Forms.Label IngreseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscarusuarioboton;
        private System.Windows.Forms.Panel contrafondologo;
        private System.Windows.Forms.Label electrohogarlbl;
        private System.Windows.Forms.Label sistemalbl;
        private System.Windows.Forms.PictureBox LogoElectroHogar;
        private System.Windows.Forms.Label Alertabotones;
    }
}