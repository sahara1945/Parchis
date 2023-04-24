namespace Demo_Parchis
{
    partial class Alta
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
            this.nuevo_usuario = new System.Windows.Forms.TextBox();
            this.nuevo_contra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nuevo_usuario
            // 
            this.nuevo_usuario.Location = new System.Drawing.Point(221, 112);
            this.nuevo_usuario.Name = "nuevo_usuario";
            this.nuevo_usuario.Size = new System.Drawing.Size(159, 26);
            this.nuevo_usuario.TabIndex = 0;
            // 
            // nuevo_contra
            // 
            this.nuevo_contra.Location = new System.Drawing.Point(221, 246);
            this.nuevo_contra.Name = "nuevo_contra";
            this.nuevo_contra.Size = new System.Drawing.Size(159, 26);
            this.nuevo_contra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DarseAlta_Click);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuevo_contra);
            this.Controls.Add(this.nuevo_usuario);
            this.Name = "Alta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nuevo_usuario;
        private System.Windows.Forms.TextBox nuevo_contra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}