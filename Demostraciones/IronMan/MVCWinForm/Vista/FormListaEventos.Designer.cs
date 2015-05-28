namespace MVCWinForm.Vista
{
    partial class FormListaEventos
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
            this.listBoxEventos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxEventos
            // 
            this.listBoxEventos.FormattingEnabled = true;
            this.listBoxEventos.Location = new System.Drawing.Point(73, 39);
            this.listBoxEventos.Name = "listBoxEventos";
            this.listBoxEventos.Size = new System.Drawing.Size(285, 147);
            this.listBoxEventos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(192, 9);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(0, 13);
            this.lblAccion.TabIndex = 2;
            // 
            // FormListaEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 274);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxEventos);
            this.Name = "FormListaEventos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormListaEventos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEventos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAccion;
    }
}