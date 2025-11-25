namespace AppGestion
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListerStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListerStock
            // 
            this.btnListerStock.Location = new System.Drawing.Point(102, 175);
            this.btnListerStock.Name = "btnListerStock";
            this.btnListerStock.Size = new System.Drawing.Size(123, 23);
            this.btnListerStock.TabIndex = 0;
            this.btnListerStock.Text = "Lister le Stock";
            this.btnListerStock.UseVisualStyleBackColor = true;
            this.btnListerStock.Click += new System.EventHandler(this.btnListerStock_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListerStock);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListerStock;
    }
}

