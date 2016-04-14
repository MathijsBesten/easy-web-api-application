namespace web_api_application
{
    partial class Form1
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
            this.Post = new System.Windows.Forms.TabPage();
            this.dataOpslaanButton = new System.Windows.Forms.Button();
            this.PostVerwijderd = new System.Windows.Forms.TextBox();
            this.PostVerhaal = new System.Windows.Forms.TextBox();
            this.PostDate = new System.Windows.Forms.TextBox();
            this.PostAuteur = new System.Windows.Forms.TextBox();
            this.PostTitel = new System.Windows.Forms.TextBox();
            this.PostID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Get = new System.Windows.Forms.TabPage();
            this.LogAanpassenButton = new System.Windows.Forms.Button();
            this.verwijderLogButton = new System.Windows.Forms.Button();
            this.dataOphalenButton = new System.Windows.Forms.Button();
            this.GetVerwijderd = new System.Windows.Forms.TextBox();
            this.GetVerhaal = new System.Windows.Forms.TextBox();
            this.GetDate = new System.Windows.Forms.TextBox();
            this.GetAuteur = new System.Windows.Forms.TextBox();
            this.GetTitel = new System.Windows.Forms.TextBox();
            this.GetID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboGet = new System.Windows.Forms.ComboBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.OpenMapButton = new System.Windows.Forms.Button();
            this.Post.SuspendLayout();
            this.Get.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Post
            // 
            this.Post.Controls.Add(this.dataOpslaanButton);
            this.Post.Controls.Add(this.PostVerwijderd);
            this.Post.Controls.Add(this.PostVerhaal);
            this.Post.Controls.Add(this.PostDate);
            this.Post.Controls.Add(this.PostAuteur);
            this.Post.Controls.Add(this.PostTitel);
            this.Post.Controls.Add(this.PostID);
            this.Post.Controls.Add(this.label7);
            this.Post.Controls.Add(this.label8);
            this.Post.Controls.Add(this.label9);
            this.Post.Controls.Add(this.label10);
            this.Post.Controls.Add(this.label11);
            this.Post.Controls.Add(this.label12);
            this.Post.Location = new System.Drawing.Point(4, 22);
            this.Post.Name = "Post";
            this.Post.Padding = new System.Windows.Forms.Padding(3);
            this.Post.Size = new System.Drawing.Size(473, 297);
            this.Post.TabIndex = 1;
            this.Post.Text = "Post";
            this.Post.UseVisualStyleBackColor = true;
            // 
            // dataOpslaanButton
            // 
            this.dataOpslaanButton.Location = new System.Drawing.Point(6, 220);
            this.dataOpslaanButton.Name = "dataOpslaanButton";
            this.dataOpslaanButton.Size = new System.Drawing.Size(82, 23);
            this.dataOpslaanButton.TabIndex = 26;
            this.dataOpslaanButton.Text = "Data opslaan";
            this.dataOpslaanButton.UseVisualStyleBackColor = true;
            this.dataOpslaanButton.Click += new System.EventHandler(this.dataOpslaanButton_Click);
            // 
            // PostVerwijderd
            // 
            this.PostVerwijderd.Location = new System.Drawing.Point(345, 223);
            this.PostVerwijderd.Name = "PostVerwijderd";
            this.PostVerwijderd.ReadOnly = true;
            this.PostVerwijderd.Size = new System.Drawing.Size(100, 20);
            this.PostVerwijderd.TabIndex = 25;
            // 
            // PostVerhaal
            // 
            this.PostVerhaal.Location = new System.Drawing.Point(345, 175);
            this.PostVerhaal.Name = "PostVerhaal";
            this.PostVerhaal.Size = new System.Drawing.Size(100, 20);
            this.PostVerhaal.TabIndex = 24;
            // 
            // PostDate
            // 
            this.PostDate.Location = new System.Drawing.Point(345, 129);
            this.PostDate.Name = "PostDate";
            this.PostDate.ReadOnly = true;
            this.PostDate.Size = new System.Drawing.Size(100, 20);
            this.PostDate.TabIndex = 23;
            // 
            // PostAuteur
            // 
            this.PostAuteur.Location = new System.Drawing.Point(345, 91);
            this.PostAuteur.Name = "PostAuteur";
            this.PostAuteur.Size = new System.Drawing.Size(100, 20);
            this.PostAuteur.TabIndex = 22;
            // 
            // PostTitel
            // 
            this.PostTitel.Location = new System.Drawing.Point(345, 51);
            this.PostTitel.Name = "PostTitel";
            this.PostTitel.Size = new System.Drawing.Size(100, 20);
            this.PostTitel.TabIndex = 21;
            // 
            // PostID
            // 
            this.PostID.Location = new System.Drawing.Point(345, 13);
            this.PostID.Name = "PostID";
            this.PostID.ReadOnly = true;
            this.PostID.Size = new System.Drawing.Size(100, 20);
            this.PostID.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Auteur";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "is verwijderd";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Verhaal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Gemaakt op";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Titel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "ID";
            // 
            // Get
            // 
            this.Get.Controls.Add(this.LogAanpassenButton);
            this.Get.Controls.Add(this.verwijderLogButton);
            this.Get.Controls.Add(this.dataOphalenButton);
            this.Get.Controls.Add(this.GetVerwijderd);
            this.Get.Controls.Add(this.GetVerhaal);
            this.Get.Controls.Add(this.GetDate);
            this.Get.Controls.Add(this.GetAuteur);
            this.Get.Controls.Add(this.GetTitel);
            this.Get.Controls.Add(this.GetID);
            this.Get.Controls.Add(this.label6);
            this.Get.Controls.Add(this.label5);
            this.Get.Controls.Add(this.label4);
            this.Get.Controls.Add(this.label3);
            this.Get.Controls.Add(this.label2);
            this.Get.Controls.Add(this.label1);
            this.Get.Controls.Add(this.ComboGet);
            this.Get.Location = new System.Drawing.Point(4, 22);
            this.Get.Name = "Get";
            this.Get.Padding = new System.Windows.Forms.Padding(3);
            this.Get.Size = new System.Drawing.Size(473, 297);
            this.Get.TabIndex = 0;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            // 
            // LogAanpassenButton
            // 
            this.LogAanpassenButton.Location = new System.Drawing.Point(6, 249);
            this.LogAanpassenButton.Name = "LogAanpassenButton";
            this.LogAanpassenButton.Size = new System.Drawing.Size(100, 23);
            this.LogAanpassenButton.TabIndex = 15;
            this.LogAanpassenButton.Text = "Log aanpassen";
            this.LogAanpassenButton.UseVisualStyleBackColor = true;
            this.LogAanpassenButton.Click += new System.EventHandler(this.LogAanpassenButton_Click);
            // 
            // verwijderLogButton
            // 
            this.verwijderLogButton.Location = new System.Drawing.Point(6, 220);
            this.verwijderLogButton.Name = "verwijderLogButton";
            this.verwijderLogButton.Size = new System.Drawing.Size(75, 23);
            this.verwijderLogButton.TabIndex = 14;
            this.verwijderLogButton.Text = "Verwijder log";
            this.verwijderLogButton.UseVisualStyleBackColor = true;
            this.verwijderLogButton.Click += new System.EventHandler(this.verwijderLogButton_Click);
            // 
            // dataOphalenButton
            // 
            this.dataOphalenButton.Location = new System.Drawing.Point(6, 33);
            this.dataOphalenButton.Name = "dataOphalenButton";
            this.dataOphalenButton.Size = new System.Drawing.Size(82, 23);
            this.dataOphalenButton.TabIndex = 13;
            this.dataOphalenButton.Text = "Data ophalen";
            this.dataOphalenButton.UseVisualStyleBackColor = true;
            this.dataOphalenButton.Click += new System.EventHandler(this.dataOphalenButton_Click);
            // 
            // GetVerwijderd
            // 
            this.GetVerwijderd.Location = new System.Drawing.Point(345, 223);
            this.GetVerwijderd.Name = "GetVerwijderd";
            this.GetVerwijderd.ReadOnly = true;
            this.GetVerwijderd.Size = new System.Drawing.Size(100, 20);
            this.GetVerwijderd.TabIndex = 12;
            // 
            // GetVerhaal
            // 
            this.GetVerhaal.Location = new System.Drawing.Point(345, 175);
            this.GetVerhaal.Name = "GetVerhaal";
            this.GetVerhaal.Size = new System.Drawing.Size(100, 20);
            this.GetVerhaal.TabIndex = 11;
            // 
            // GetDate
            // 
            this.GetDate.Location = new System.Drawing.Point(345, 129);
            this.GetDate.Name = "GetDate";
            this.GetDate.ReadOnly = true;
            this.GetDate.Size = new System.Drawing.Size(100, 20);
            this.GetDate.TabIndex = 10;
            // 
            // GetAuteur
            // 
            this.GetAuteur.Location = new System.Drawing.Point(345, 91);
            this.GetAuteur.Name = "GetAuteur";
            this.GetAuteur.Size = new System.Drawing.Size(100, 20);
            this.GetAuteur.TabIndex = 9;
            // 
            // GetTitel
            // 
            this.GetTitel.Location = new System.Drawing.Point(345, 51);
            this.GetTitel.Name = "GetTitel";
            this.GetTitel.Size = new System.Drawing.Size(100, 20);
            this.GetTitel.TabIndex = 8;
            // 
            // GetID
            // 
            this.GetID.Location = new System.Drawing.Point(345, 13);
            this.GetID.Name = "GetID";
            this.GetID.ReadOnly = true;
            this.GetID.Size = new System.Drawing.Size(100, 20);
            this.GetID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Auteur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "is verwijderd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Verhaal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gemaakt op";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // ComboGet
            // 
            this.ComboGet.FormattingEnabled = true;
            this.ComboGet.Location = new System.Drawing.Point(6, 6);
            this.ComboGet.Name = "ComboGet";
            this.ComboGet.Size = new System.Drawing.Size(121, 21);
            this.ComboGet.TabIndex = 0;
            this.ComboGet.SelectedIndexChanged += new System.EventHandler(this.CombGet_SelectedIndexChanged);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.Get);
            this.mainTabControl.Controls.Add(this.Post);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(481, 323);
            this.mainTabControl.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(517, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Foto upload";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(517, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Selecteer een map om te synchroniseren";
            // 
            // OpenMapButton
            // 
            this.OpenMapButton.Location = new System.Drawing.Point(520, 92);
            this.OpenMapButton.Name = "OpenMapButton";
            this.OpenMapButton.Size = new System.Drawing.Size(75, 23);
            this.OpenMapButton.TabIndex = 3;
            this.OpenMapButton.Text = "Open map";
            this.OpenMapButton.UseVisualStyleBackColor = true;
            this.OpenMapButton.Click += new System.EventHandler(this.OpenMapButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 353);
            this.Controls.Add(this.OpenMapButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form1";
            this.Text = "Web-api applicatie";
            this.Post.ResumeLayout(false);
            this.Post.PerformLayout();
            this.Get.ResumeLayout(false);
            this.Get.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage Post;
        private System.Windows.Forms.Button dataOpslaanButton;
        private System.Windows.Forms.TextBox PostVerwijderd;
        private System.Windows.Forms.TextBox PostVerhaal;
        private System.Windows.Forms.TextBox PostDate;
        private System.Windows.Forms.TextBox PostAuteur;
        private System.Windows.Forms.TextBox PostTitel;
        private System.Windows.Forms.TextBox PostID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage Get;
        private System.Windows.Forms.Button verwijderLogButton;
        private System.Windows.Forms.Button dataOphalenButton;
        private System.Windows.Forms.TextBox GetVerwijderd;
        private System.Windows.Forms.TextBox GetVerhaal;
        private System.Windows.Forms.TextBox GetDate;
        private System.Windows.Forms.TextBox GetAuteur;
        private System.Windows.Forms.TextBox GetTitel;
        private System.Windows.Forms.TextBox GetID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboGet;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.Button LogAanpassenButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button OpenMapButton;
    }
}

