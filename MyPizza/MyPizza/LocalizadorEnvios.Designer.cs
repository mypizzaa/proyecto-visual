﻿namespace Vista
{
    partial class LocalizadorEnvios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizadorEnvios));
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPedidos = new System.Windows.Forms.TextBox();
            this.txtDniEmpleado = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bVerTodos = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.listViewPedidos = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconoCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Location = new System.Drawing.Point(34, 52);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(170, 20);
            this.txtCodigoPedido.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo del pedido :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.bConfirmar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdPedidos);
            this.panel1.Controls.Add(this.txtDniEmpleado);
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(213, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 703);
            this.panel1.TabIndex = 11;
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.Color.Black;
            this.bConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bConfirmar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bConfirmar.Location = new System.Drawing.Point(22, 78);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(170, 29);
            this.bConfirmar.TabIndex = 21;
            this.bConfirmar.Text = "confirmar";
            this.bConfirmar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "DNI Repartidor :";
            // 
            // txtIdPedidos
            // 
            this.txtIdPedidos.Location = new System.Drawing.Point(211, 52);
            this.txtIdPedidos.Name = "txtIdPedidos";
            this.txtIdPedidos.Size = new System.Drawing.Size(910, 20);
            this.txtIdPedidos.TabIndex = 10;
            // 
            // txtDniEmpleado
            // 
            this.txtDniEmpleado.Location = new System.Drawing.Point(22, 52);
            this.txtDniEmpleado.Name = "txtDniEmpleado";
            this.txtDniEmpleado.Size = new System.Drawing.Size(170, 20);
            this.txtDniEmpleado.TabIndex = 9;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(22, 148);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1099, 519);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.bVerTodos);
            this.panel2.Controls.Add(this.bBuscar);
            this.panel2.Controls.Add(this.listViewPedidos);
            this.panel2.Controls.Add(this.txtCodigoPedido);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 703);
            this.panel2.TabIndex = 12;
            // 
            // bVerTodos
            // 
            this.bVerTodos.BackColor = System.Drawing.Color.Black;
            this.bVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bVerTodos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bVerTodos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bVerTodos.Location = new System.Drawing.Point(34, 113);
            this.bVerTodos.Name = "bVerTodos";
            this.bVerTodos.Size = new System.Drawing.Size(170, 29);
            this.bVerTodos.TabIndex = 22;
            this.bVerTodos.Text = "ver todos los pedidos";
            this.bVerTodos.UseVisualStyleBackColor = false;
            this.bVerTodos.Visible = false;
            this.bVerTodos.Click += new System.EventHandler(this.bVerTodos_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.Black;
            this.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBuscar.Location = new System.Drawing.Point(34, 78);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(170, 29);
            this.bBuscar.TabIndex = 21;
            this.bBuscar.Text = "buscar";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // listViewPedidos
            // 
            this.listViewPedidos.Location = new System.Drawing.Point(31, 148);
            this.listViewPedidos.Name = "listViewPedidos";
            this.listViewPedidos.Size = new System.Drawing.Size(173, 522);
            this.listViewPedidos.TabIndex = 1;
            this.listViewPedidos.UseCompatibleStateImageBehavior = false;
            this.listViewPedidos.View = System.Windows.Forms.View.Tile;
            this.listViewPedidos.SelectedIndexChanged += new System.EventHandler(this.listViewPedidos_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.configuraciónToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.configuraciónToolStripMenuItem.Text = "Volver";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // iconoCerrar
            // 
            this.iconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoCerrar.BackColor = System.Drawing.Color.Black;
            this.iconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconoCerrar.Image")));
            this.iconoCerrar.Location = new System.Drawing.Point(1326, 0);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(28, 24);
            this.iconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconoCerrar.TabIndex = 46;
            this.iconoCerrar.TabStop = false;
            this.iconoCerrar.Click += new System.EventHandler(this.iconoCerrar_Click);
            // 
            // LocalizadorEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1354, 752);
            this.Controls.Add(this.iconoCerrar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocalizadorEnvios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocalizadorEnvios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIdPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDniEmpleado;
        private System.Windows.Forms.ListView listViewPedidos;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bVerTodos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.PictureBox iconoCerrar;
    }
}