namespace xprox_charCounter
{
    partial class FrmChartCounter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el texto";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(21, 50);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4);
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(451, 282);
            this.txtChange.TabIndex = 1;
            this.txtChange.TextChanged += new System.EventHandler(this.txtChange_TextChanged);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(17, 362);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(144, 16);
            this.labelCount.TabIndex = 2;
            this.labelCount.Text = "Número de carácteres:";
            this.labelCount.Click += new System.EventHandler(this.labelCount_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(309, 15);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(71, 28);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copiar";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(388, 15);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmChartCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 406);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmChartCounter";
            this.Text = "xprox_charCounter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnRefresh;
    }
}

