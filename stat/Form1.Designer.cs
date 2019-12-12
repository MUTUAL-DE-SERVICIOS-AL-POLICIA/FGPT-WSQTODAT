namespace stat
{
    partial class WSQTODAT
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
						this.dataGridView1 = new System.Windows.Forms.DataGridView();
						this.Convertir = new System.Windows.Forms.Button();
						this.button2 = new System.Windows.Forms.Button();
						((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
						this.SuspendLayout();
						// 
						// dataGridView1
						// 
						this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
						this.dataGridView1.Location = new System.Drawing.Point(41, 108);
						this.dataGridView1.Name = "dataGridView1";
						this.dataGridView1.Size = new System.Drawing.Size(1020, 317);
						this.dataGridView1.TabIndex = 1;
						// 
						// Convertir
						// 
						this.Convertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.Convertir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
						this.Convertir.Location = new System.Drawing.Point(41, 66);
						this.Convertir.Name = "Convertir";
						this.Convertir.Size = new System.Drawing.Size(134, 36);
						this.Convertir.TabIndex = 2;
						this.Convertir.Text = "Convertir";
						this.Convertir.UseVisualStyleBackColor = true;
						this.Convertir.Click += new System.EventHandler(this.Button1_Click_1);
						// 
						// button2
						// 
						this.button2.Location = new System.Drawing.Point(983, 12);
						this.button2.Name = "button2";
						this.button2.Size = new System.Drawing.Size(78, 23);
						this.button2.TabIndex = 3;
						this.button2.Text = "Prueba";
						this.button2.UseVisualStyleBackColor = true;
						this.button2.Click += new System.EventHandler(this.Button2_Click);
						// 
						// WSQTODAT
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(1086, 456);
						this.Controls.Add(this.button2);
						this.Controls.Add(this.Convertir);
						this.Controls.Add(this.dataGridView1);
						this.Margin = new System.Windows.Forms.Padding(2);
						this.Name = "WSQTODAT";
						this.Text = "WSQTODAT";
						this.Load += new System.EventHandler(this.Form1_Load);
						((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
						this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.DataGridView dataGridView1;
				private System.Windows.Forms.Button Convertir;
				private System.Windows.Forms.Button button2;
		}
}

