
namespace Pacagroup.Comercial.Creditos.WindowsFormConsumer
{
    partial class frmlistadocreditos
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnlistarcreditos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gridCreditos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnlistarcreditos
            // 
            this.btnlistarcreditos.Location = new System.Drawing.Point(104, 89);
            this.btnlistarcreditos.Name = "btnlistarcreditos";
            this.btnlistarcreditos.Size = new System.Drawing.Size(167, 43);
            this.btnlistarcreditos.TabIndex = 1;
            this.btnlistarcreditos.Text = "Listar Creditos";
            this.btnlistarcreditos.UseVisualStyleBackColor = true;
            this.btnlistarcreditos.Click += new System.EventHandler(this.btnlistarcreditos_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(649, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // gridCreditos
            // 
            this.gridCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCreditos.Location = new System.Drawing.Point(89, 162);
            this.gridCreditos.Name = "gridCreditos";
            this.gridCreditos.Size = new System.Drawing.Size(635, 242);
            this.gridCreditos.TabIndex = 4;
            // 
            // frmlistadocreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridCreditos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnlistarcreditos);
            this.Controls.Add(this.button1);
            this.Name = "frmlistadocreditos";
            this.Text = "Formulario WCF CREDITOS";
            ((System.ComponentModel.ISupportInitialize)(this.gridCreditos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlistarcreditos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView gridCreditos;
    }
}

