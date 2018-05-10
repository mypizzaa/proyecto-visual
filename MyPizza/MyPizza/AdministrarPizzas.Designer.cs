namespace Vista
{
    partial class AdministrarPizzas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirBebidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem,
            this.administrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.volverToolStripMenuItem.Text = "Volver";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirPizzaToolStripMenuItem,
            this.modificarPizzaToolStripMenuItem,
            this.añadirBebidaToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // añadirPizzaToolStripMenuItem
            // 
            this.añadirPizzaToolStripMenuItem.Name = "añadirPizzaToolStripMenuItem";
            this.añadirPizzaToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.añadirPizzaToolStripMenuItem.Text = "Añadir pizza";
            // 
            // modificarPizzaToolStripMenuItem
            // 
            this.modificarPizzaToolStripMenuItem.Name = "modificarPizzaToolStripMenuItem";
            this.modificarPizzaToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.modificarPizzaToolStripMenuItem.Text = "Modificar Pizza";
            // 
            // añadirBebidaToolStripMenuItem
            // 
            this.añadirBebidaToolStripMenuItem.Name = "añadirBebidaToolStripMenuItem";
            this.añadirBebidaToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.añadirBebidaToolStripMenuItem.Text = "Añadir Bebida";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Añadir pizza";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar Pizza";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(753, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "Añadir Bebida";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AdministrarPizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 646);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministrarPizzas";
            this.Text = "AdministrarPizzas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirPizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirBebidaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}