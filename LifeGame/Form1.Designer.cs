
namespace LifeGame
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
            this.swftbMDP = new System.Windows.Forms.TextBox();
            this.swftbLogin = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.swfbInscription = new System.Windows.Forms.Button();
            this.swfbConnexion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.swfdgvDataGrid = new System.Windows.Forms.DataGridView();
            this.swfbStop = new System.Windows.Forms.Button();
            this.swfbStart = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swfdgvDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // swftbMDP
            // 
            this.swftbMDP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swftbMDP.Location = new System.Drawing.Point(527, 217);
            this.swftbMDP.Name = "swftbMDP";
            this.swftbMDP.PasswordChar = '*';
            this.swftbMDP.Size = new System.Drawing.Size(269, 22);
            this.swftbMDP.TabIndex = 1;
            // 
            // swftbLogin
            // 
            this.swftbLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swftbLogin.Location = new System.Drawing.Point(527, 160);
            this.swftbLogin.Name = "swftbLogin";
            this.swftbLogin.Size = new System.Drawing.Size(269, 22);
            this.swftbLogin.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, -24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1308, 640);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.swfbInscription);
            this.tabPage1.Controls.Add(this.swfbConnexion);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.swftbMDP);
            this.tabPage1.Controls.Add(this.swftbLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1300, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // swfbInscription
            // 
            this.swfbInscription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.swfbInscription.Location = new System.Drawing.Point(1201, 304);
            this.swfbInscription.Name = "swfbInscription";
            this.swfbInscription.Size = new System.Drawing.Size(93, 45);
            this.swfbInscription.TabIndex = 3;
            this.swfbInscription.Text = "Inscription";
            this.swfbInscription.UseVisualStyleBackColor = true;
            this.swfbInscription.Click += new System.EventHandler(this.swfbInscription_Click);
            // 
            // swfbConnexion
            // 
            this.swfbConnexion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swfbConnexion.Location = new System.Drawing.Point(615, 304);
            this.swfbConnexion.Name = "swfbConnexion";
            this.swfbConnexion.Size = new System.Drawing.Size(93, 45);
            this.swfbConnexion.TabIndex = 2;
            this.swfbConnexion.Text = "Connexion";
            this.swfbConnexion.UseVisualStyleBackColor = true;
            this.swfbConnexion.Click += new System.EventHandler(this.swfbConnexion_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "MDP";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.swfbStart);
            this.tabPage2.Controls.Add(this.swfbStop);
            this.tabPage2.Controls.Add(this.swfdgvDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1300, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // swfdgvDataGrid
            // 
            this.swfdgvDataGrid.AllowUserToAddRows = false;
            this.swfdgvDataGrid.AllowUserToDeleteRows = false;
            this.swfdgvDataGrid.AllowUserToResizeColumns = false;
            this.swfdgvDataGrid.AllowUserToResizeRows = false;
            this.swfdgvDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.swfdgvDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.swfdgvDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.swfdgvDataGrid.ColumnHeadersVisible = false;
            this.swfdgvDataGrid.Location = new System.Drawing.Point(3, 3);
            this.swfdgvDataGrid.Name = "swfdgvDataGrid";
            this.swfdgvDataGrid.RowHeadersVisible = false;
            this.swfdgvDataGrid.RowHeadersWidth = 51;
            this.swfdgvDataGrid.RowTemplate.Height = 24;
            this.swfdgvDataGrid.Size = new System.Drawing.Size(1294, 564);
            this.swfdgvDataGrid.TabIndex = 0;
            this.swfdgvDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.swfdgvDataGrid_CellClick);
            // 
            // swfbStop
            // 
            this.swfbStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.swfbStop.Location = new System.Drawing.Point(1219, 573);
            this.swfbStop.Name = "swfbStop";
            this.swfbStop.Size = new System.Drawing.Size(75, 32);
            this.swfbStop.TabIndex = 2;
            this.swfbStop.Text = "Stop";
            this.swfbStop.UseVisualStyleBackColor = true;
            this.swfbStop.Click += new System.EventHandler(this.swfbStop_Click);
            // 
            // swfbStart
            // 
            this.swfbStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.swfbStart.Location = new System.Drawing.Point(1138, 573);
            this.swfbStart.Name = "swfbStart";
            this.swfbStart.Size = new System.Drawing.Size(75, 32);
            this.swfbStart.TabIndex = 3;
            this.swfbStart.Text = "Start";
            this.swfbStart.UseVisualStyleBackColor = true;
            this.swfbStart.Click += new System.EventHandler(this.swfbStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 628);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.swfdgvDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox swftbMDP;
        private System.Windows.Forms.TextBox swftbLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button swfbConnexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button swfbInscription;
        private System.Windows.Forms.DataGridView swfdgvDataGrid;
        private System.Windows.Forms.Button swfbStart;
        private System.Windows.Forms.Button swfbStop;
    }
}

