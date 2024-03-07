namespace Jeuxdevie
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            swfbInscription = new Button();
            swfbConnexion = new Button();
            swftbMDP = new TextBox();
            swftbLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label5 = new Label();
            swfnudLive = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            swfnudKill = new NumericUpDown();
            swfnudGridSize = new NumericUpDown();
            swfbStop = new Button();
            swfbStart = new Button();
            swfbSendMessage = new Button();
            swftbMessage = new TextBox();
            swftbChat = new TextBox();
            swfdgvDataGrid = new DataGridView();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)swfnudLive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)swfnudKill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)swfnudGridSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)swfdgvDataGrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, -24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1308, 640);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(swfbInscription);
            tabPage1.Controls.Add(swfbConnexion);
            tabPage1.Controls.Add(swftbMDP);
            tabPage1.Controls.Add(swftbLogin);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1300, 607);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // swfbInscription
            // 
            swfbInscription.Anchor = AnchorStyles.Top;
            swfbInscription.Location = new Point(1173, 349);
            swfbInscription.Name = "swfbInscription";
            swfbInscription.Size = new Size(121, 55);
            swfbInscription.TabIndex = 5;
            swfbInscription.Text = "Inscription";
            swfbInscription.UseVisualStyleBackColor = true;
            swfbInscription.Click += swfbInscription_Click;
            // 
            // swfbConnexion
            // 
            swfbConnexion.Anchor = AnchorStyles.Top;
            swfbConnexion.Location = new Point(644, 387);
            swfbConnexion.Name = "swfbConnexion";
            swfbConnexion.Size = new Size(121, 55);
            swfbConnexion.TabIndex = 4;
            swfbConnexion.Text = "Connexion";
            swfbConnexion.UseVisualStyleBackColor = true;
            swfbConnexion.Click += swfbConnexion_Click;
            // 
            // swftbMDP
            // 
            swftbMDP.Anchor = AnchorStyles.Top;
            swftbMDP.Location = new Point(578, 309);
            swftbMDP.Name = "swftbMDP";
            swftbMDP.PasswordChar = '*';
            swftbMDP.Size = new Size(235, 27);
            swftbMDP.TabIndex = 3;
            // 
            // swftbLogin
            // 
            swftbLogin.Anchor = AnchorStyles.Top;
            swftbLogin.Location = new Point(578, 220);
            swftbLogin.Name = "swftbLogin";
            swftbLogin.Size = new Size(235, 27);
            swftbLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(392, 312);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "MDP";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(392, 223);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(swfnudLive);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(swfnudKill);
            tabPage2.Controls.Add(swfnudGridSize);
            tabPage2.Controls.Add(swfbStop);
            tabPage2.Controls.Add(swfbStart);
            tabPage2.Controls.Add(swfbSendMessage);
            tabPage2.Controls.Add(swftbMessage);
            tabPage2.Controls.Add(swftbChat);
            tabPage2.Controls.Add(swfdgvDataGrid);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1300, 607);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 581);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 11;
            label5.Text = "NB Cells To Live";
            // 
            // swfnudLive
            // 
            swfnudLive.Location = new Point(121, 577);
            swfnudLive.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            swfnudLive.Name = "swfnudLive";
            swfnudLive.Size = new Size(150, 27);
            swfnudLive.TabIndex = 10;
            swfnudLive.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 555);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 9;
            label4.Text = "NB Cells To Kill";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 569);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 8;
            label3.Text = "Grid Size";
            // 
            // swfnudKill
            // 
            swfnudKill.Location = new Point(121, 553);
            swfnudKill.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            swfnudKill.Name = "swfnudKill";
            swfnudKill.Size = new Size(150, 27);
            swfnudKill.TabIndex = 7;
            swfnudKill.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // swfnudGridSize
            // 
            swfnudGridSize.Location = new Point(412, 567);
            swfnudGridSize.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            swfnudGridSize.Name = "swfnudGridSize";
            swfnudGridSize.Size = new Size(150, 27);
            swfnudGridSize.TabIndex = 6;
            swfnudGridSize.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // swfbStop
            // 
            swfbStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            swfbStop.Location = new Point(812, 558);
            swfbStop.Name = "swfbStop";
            swfbStop.Size = new Size(238, 43);
            swfbStop.TabIndex = 5;
            swfbStop.Text = "Stop";
            swfbStop.UseVisualStyleBackColor = true;
            swfbStop.Click += swfbStop_Click;
            // 
            // swfbStart
            // 
            swfbStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            swfbStart.Location = new Point(568, 558);
            swfbStart.Name = "swfbStart";
            swfbStart.Size = new Size(238, 43);
            swfbStart.TabIndex = 4;
            swfbStart.Text = "Start";
            swfbStart.UseVisualStyleBackColor = true;
            swfbStart.Click += swfbStart_Click;
            // 
            // swfbSendMessage
            // 
            swfbSendMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            swfbSendMessage.Location = new Point(1056, 558);
            swfbSendMessage.Name = "swfbSendMessage";
            swfbSendMessage.Size = new Size(238, 43);
            swfbSendMessage.TabIndex = 3;
            swfbSendMessage.Text = "Envoyer";
            swfbSendMessage.UseVisualStyleBackColor = true;
            swfbSendMessage.Click += swfbSendMessage_Click;
            // 
            // swftbMessage
            // 
            swftbMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            swftbMessage.Location = new Point(1056, 502);
            swftbMessage.Multiline = true;
            swftbMessage.Name = "swftbMessage";
            swftbMessage.Size = new Size(238, 50);
            swftbMessage.TabIndex = 2;
            // 
            // swftbChat
            // 
            swftbChat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            swftbChat.Location = new Point(1056, 7);
            swftbChat.Multiline = true;
            swftbChat.Name = "swftbChat";
            swftbChat.Size = new Size(238, 489);
            swftbChat.TabIndex = 1;
            // 
            // swfdgvDataGrid
            // 
            swfdgvDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            swfdgvDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            swfdgvDataGrid.Location = new Point(6, 7);
            swfdgvDataGrid.Name = "swfdgvDataGrid";
            swfdgvDataGrid.RowHeadersWidth = 51;
            swfdgvDataGrid.Size = new Size(1044, 545);
            swfdgvDataGrid.TabIndex = 0;
            swfdgvDataGrid.CellClick += swfdgvDataGrid_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(277, 565);
            button1.Name = "button1";
            button1.Size = new Size(45, 29);
            button1.TabIndex = 12;
            button1.Text = "Ask";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // k
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 628);
            Controls.Add(tabControl1);
            Name = "k";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)swfnudLive).EndInit();
            ((System.ComponentModel.ISupportInitialize)swfnudKill).EndInit();
            ((System.ComponentModel.ISupportInitialize)swfnudGridSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)swfdgvDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button swfbConnexion;
        private TextBox swftbMDP;
        private TextBox swftbLogin;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Button swfbStop;
        private Button swfbStart;
        private Button swfbSendMessage;
        private TextBox swftbMessage;
        private TextBox swftbChat;
        private DataGridView swfdgvDataGrid;
        private Label label5;
        private NumericUpDown swfnudLive;
        private Label label4;
        private Label label3;
        private NumericUpDown swfnudKill;
        private NumericUpDown swfnudGridSize;
        private Button swfbInscription;
        private Button button1;
    }
}
