namespace Vista
{
    partial class PanelAdmin
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
            this.menuVertical = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.iconoRestaurar = new System.Windows.Forms.PictureBox();
            this.iconoMini = new System.Windows.Forms.PictureBox();
            this.iconoMaxi = new System.Windows.Forms.PictureBox();
            this.iconoCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuVertical.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.DarkRed;
            this.menuVertical.Controls.Add(this.button5);
            this.menuVertical.Controls.Add(this.button4);
            this.menuVertical.Controls.Add(this.button3);
            this.menuVertical.Controls.Add(this.button2);
            this.menuVertical.Controls.Add(this.button1);
            this.menuVertical.Controls.Add(this.pictureBox2);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 788);
            this.menuVertical.TabIndex = 0;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.iconoRestaurar);
            this.panelTitulo.Controls.Add(this.iconoMini);
            this.panelTitulo.Controls.Add(this.iconoMaxi);
            this.panelTitulo.Controls.Add(this.iconoCerrar);
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(250, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1136, 50);
            this.panelTitulo.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1136, 738);
            this.panelContenedor.TabIndex = 2;
            // 
            // iconoRestaurar
            // 
            this.iconoRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoRestaurar.Image = global::Vista.Properties.Resources.icon_restaurar;
            this.iconoRestaurar.Location = new System.Drawing.Point(1078, 12);
            this.iconoRestaurar.Name = "iconoRestaurar";
            this.iconoRestaurar.Size = new System.Drawing.Size(20, 20);
            this.iconoRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoRestaurar.TabIndex = 4;
            this.iconoRestaurar.TabStop = false;
            this.iconoRestaurar.Visible = false;
            this.iconoRestaurar.Click += new System.EventHandler(this.iconoRestaurar_Click);
            // 
            // iconoMini
            // 
            this.iconoMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMini.Image = global::Vista.Properties.Resources.icon_minimizar;
            this.iconoMini.Location = new System.Drawing.Point(1052, 12);
            this.iconoMini.Name = "iconoMini";
            this.iconoMini.Size = new System.Drawing.Size(20, 20);
            this.iconoMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMini.TabIndex = 3;
            this.iconoMini.TabStop = false;
            this.iconoMini.Click += new System.EventHandler(this.iconoMini_Click);
            // 
            // iconoMaxi
            // 
            this.iconoMaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMaxi.Image = global::Vista.Properties.Resources.icon_maximizar;
            this.iconoMaxi.Location = new System.Drawing.Point(1078, 12);
            this.iconoMaxi.Name = "iconoMaxi";
            this.iconoMaxi.Size = new System.Drawing.Size(20, 20);
            this.iconoMaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMaxi.TabIndex = 2;
            this.iconoMaxi.TabStop = false;
            this.iconoMaxi.Click += new System.EventHandler(this.iconoMaxi_Click);
            // 
            // iconoCerrar
            // 
            this.iconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoCerrar.Image = global::Vista.Properties.Resources.icon_cerrar2;
            this.iconoCerrar.Location = new System.Drawing.Point(1104, 12);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(20, 20);
            this.iconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoCerrar.TabIndex = 1;
            this.iconoCerrar.TabStop = false;
            this.iconoCerrar.Click += new System.EventHandler(this.iconoCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Vista.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button5.Image = global::Vista.Properties.Resources.money_bag;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 536);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "Ventas";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button4.Image = global::Vista.Properties.Resources.can;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Bebidas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button3.Image = global::Vista.Properties.Resources.warehouse;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Image = global::Vista.Properties.Resources.collaboration;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Empleados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Vista.Properties.Resources.pizza;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pizzas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vista.Properties.Resources.fondopizza;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 188);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuVertical.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox iconoCerrar;
        private System.Windows.Forms.PictureBox iconoMaxi;
        private System.Windows.Forms.PictureBox iconoMini;
        private System.Windows.Forms.PictureBox iconoRestaurar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}