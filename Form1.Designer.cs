
namespace WindowsFormsFiche1
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
            this.lb_liste = new System.Windows.Forms.ListBox();
            this.tb_saisie = new System.Windows.Forms.TextBox();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.lb_texte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_liste
            // 
            this.lb_liste.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_liste.FormattingEnabled = true;
            this.lb_liste.HorizontalScrollbar = true;
            this.lb_liste.Location = new System.Drawing.Point(79, 63);
            this.lb_liste.Name = "lb_liste";
            this.lb_liste.Size = new System.Drawing.Size(230, 186);
            this.lb_liste.Sorted = true;
            this.lb_liste.TabIndex = 0;
            // 
            // tb_saisie
            // 
            this.tb_saisie.Location = new System.Drawing.Point(79, 264);
            this.tb_saisie.Name = "tb_saisie";
            this.tb_saisie.Size = new System.Drawing.Size(230, 20);
            this.tb_saisie.TabIndex = 1;
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.AccessibleName = "";
            this.bt_ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ajouter.Location = new System.Drawing.Point(79, 290);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(109, 23);
            this.bt_ajouter.TabIndex = 2;
            this.bt_ajouter.TabStop = false;
            this.bt_ajouter.Text = "ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_supprimer.Location = new System.Drawing.Point(200, 290);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(109, 23);
            this.bt_supprimer.TabIndex = 3;
            this.bt_supprimer.Text = "supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = true;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // lb_texte
            // 
            this.lb_texte.AutoSize = true;
            this.lb_texte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texte.Location = new System.Drawing.Point(75, 26);
            this.lb_texte.Name = "lb_texte";
            this.lb_texte.Size = new System.Drawing.Size(197, 24);
            this.lb_texte.TabIndex = 4;
            this.lb_texte.Text = "Une liste déroulante";
            // 
            // Form1
            // 
            this.AcceptButton = this.bt_ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 328);
            this.Controls.Add(this.lb_texte);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.tb_saisie);
            this.Controls.Add(this.lb_liste);
            this.Name = "Form1";
            this.Text = "Premier programme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_liste;
        private System.Windows.Forms.TextBox tb_saisie;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Label lb_texte;
    }
}

