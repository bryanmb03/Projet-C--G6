namespace EMPIRE
{
    partial class Form1
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
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.labelArticles = new System.Windows.Forms.Label();
            this.listBoxArticles = new System.Windows.Forms.ListBox();
            this.buttonAcheter = new System.Windows.Forms.Button();
            this.buttonVoirAttente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(42, 42);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(89, 20);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Votre Nom:";
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(151, 42);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(261, 26);
            this.textBoxClient.TabIndex = 1;
            // 
            // labelArticles
            // 
            this.labelArticles.AutoSize = true;
            this.labelArticles.Location = new System.Drawing.Point(46, 89);
            this.labelArticles.Name = "labelArticles";
            this.labelArticles.Size = new System.Drawing.Size(61, 20);
            this.labelArticles.TabIndex = 2;
            this.labelArticles.Text = "Articles";
            // 
            // listBoxArticles
            // 
            this.listBoxArticles.FormattingEnabled = true;
            this.listBoxArticles.ItemHeight = 20;
            this.listBoxArticles.Location = new System.Drawing.Point(50, 122);
            this.listBoxArticles.Name = "listBoxArticles";
            this.listBoxArticles.Size = new System.Drawing.Size(374, 104);
            this.listBoxArticles.TabIndex = 3;
            // 
            // buttonAcheter
            // 
            this.buttonAcheter.Location = new System.Drawing.Point(50, 257);
            this.buttonAcheter.Name = "buttonAcheter";
            this.buttonAcheter.Size = new System.Drawing.Size(324, 40);
            this.buttonAcheter.TabIndex = 4;
            this.buttonAcheter.Text = "Acheter/Mettre en attente";
            this.buttonAcheter.UseVisualStyleBackColor = true;
            // 
            // buttonVoirAttente
            // 
            this.buttonVoirAttente.Location = new System.Drawing.Point(50, 317);
            this.buttonVoirAttente.Name = "buttonVoirAttente";
            this.buttonVoirAttente.Size = new System.Drawing.Size(324, 36);
            this.buttonVoirAttente.TabIndex = 5;
            this.buttonVoirAttente.Text = "Voir la file d\'attente";
            this.buttonVoirAttente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVoirAttente);
            this.Controls.Add(this.buttonAcheter);
            this.Controls.Add(this.listBoxArticles);
            this.Controls.Add(this.labelArticles);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.labelClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Label labelArticles;
        private System.Windows.Forms.ListBox listBoxArticles;
        private System.Windows.Forms.Button buttonAcheter;
        private System.Windows.Forms.Button buttonVoirAttente;
    }
}

