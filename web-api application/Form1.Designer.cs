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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.Get = new System.Windows.Forms.TabPage();
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
            this.Put = new System.Windows.Forms.TabPage();
            this.dataVeranderenButton = new System.Windows.Forms.Button();
            this.PutVerwijderd = new System.Windows.Forms.TextBox();
            this.PutVerhaal = new System.Windows.Forms.TextBox();
            this.PutDate = new System.Windows.Forms.TextBox();
            this.PutAuteur = new System.Windows.Forms.TextBox();
            this.PutTitel = new System.Windows.Forms.TextBox();
            this.PutID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.TabPage();
            this.dataDeleteButton = new System.Windows.Forms.Button();
            this.DeleteVerwijderd = new System.Windows.Forms.TextBox();
            this.DeleteVerhaal = new System.Windows.Forms.TextBox();
            this.DeleteDate = new System.Windows.Forms.TextBox();
            this.DeleteAuteur = new System.Windows.Forms.TextBox();
            this.DeleteTitel = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.DeleteID = new System.Windows.Forms.TextBox();
            this.mainTabControl.SuspendLayout();
            this.Get.SuspendLayout();
            this.Post.SuspendLayout();
            this.Put.SuspendLayout();
            this.Delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.Get);
            this.mainTabControl.Controls.Add(this.Post);
            this.mainTabControl.Controls.Add(this.Put);
            this.mainTabControl.Controls.Add(this.Delete);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(481, 323);
            this.mainTabControl.TabIndex = 0;
            // 
            // Get
            // 
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
            // dataOphalenButton
            // 
            this.dataOphalenButton.Location = new System.Drawing.Point(6, 221);
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
            this.GetVerhaal.ReadOnly = true;
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
            this.GetAuteur.ReadOnly = true;
            this.GetAuteur.Size = new System.Drawing.Size(100, 20);
            this.GetAuteur.TabIndex = 9;
            // 
            // GetTitel
            // 
            this.GetTitel.Location = new System.Drawing.Point(345, 51);
            this.GetTitel.Name = "GetTitel";
            this.GetTitel.ReadOnly = true;
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
            // Put
            // 
            this.Put.Controls.Add(this.dataVeranderenButton);
            this.Put.Controls.Add(this.PutVerwijderd);
            this.Put.Controls.Add(this.PutVerhaal);
            this.Put.Controls.Add(this.PutDate);
            this.Put.Controls.Add(this.PutAuteur);
            this.Put.Controls.Add(this.PutTitel);
            this.Put.Controls.Add(this.PutID);
            this.Put.Controls.Add(this.label13);
            this.Put.Controls.Add(this.label14);
            this.Put.Controls.Add(this.label15);
            this.Put.Controls.Add(this.label16);
            this.Put.Controls.Add(this.label17);
            this.Put.Controls.Add(this.label18);
            this.Put.Location = new System.Drawing.Point(4, 22);
            this.Put.Name = "Put";
            this.Put.Padding = new System.Windows.Forms.Padding(3);
            this.Put.Size = new System.Drawing.Size(473, 297);
            this.Put.TabIndex = 2;
            this.Put.Text = "Put";
            this.Put.UseVisualStyleBackColor = true;
            // 
            // dataVeranderenButton
            // 
            this.dataVeranderenButton.Location = new System.Drawing.Point(6, 220);
            this.dataVeranderenButton.Name = "dataVeranderenButton";
            this.dataVeranderenButton.Size = new System.Drawing.Size(107, 23);
            this.dataVeranderenButton.TabIndex = 27;
            this.dataVeranderenButton.Text = "Data veranderen";
            this.dataVeranderenButton.UseVisualStyleBackColor = true;
            this.dataVeranderenButton.Click += new System.EventHandler(this.dataVeranderenButton_Click);
            // 
            // PutVerwijderd
            // 
            this.PutVerwijderd.Location = new System.Drawing.Point(345, 223);
            this.PutVerwijderd.Name = "PutVerwijderd";
            this.PutVerwijderd.ReadOnly = true;
            this.PutVerwijderd.Size = new System.Drawing.Size(100, 20);
            this.PutVerwijderd.TabIndex = 25;
            // 
            // PutVerhaal
            // 
            this.PutVerhaal.Location = new System.Drawing.Point(345, 175);
            this.PutVerhaal.Name = "PutVerhaal";
            this.PutVerhaal.Size = new System.Drawing.Size(100, 20);
            this.PutVerhaal.TabIndex = 24;
            // 
            // PutDate
            // 
            this.PutDate.Location = new System.Drawing.Point(345, 129);
            this.PutDate.Name = "PutDate";
            this.PutDate.ReadOnly = true;
            this.PutDate.Size = new System.Drawing.Size(100, 20);
            this.PutDate.TabIndex = 23;
            // 
            // PutAuteur
            // 
            this.PutAuteur.Location = new System.Drawing.Point(345, 91);
            this.PutAuteur.Name = "PutAuteur";
            this.PutAuteur.Size = new System.Drawing.Size(100, 20);
            this.PutAuteur.TabIndex = 22;
            // 
            // PutTitel
            // 
            this.PutTitel.Location = new System.Drawing.Point(345, 51);
            this.PutTitel.Name = "PutTitel";
            this.PutTitel.Size = new System.Drawing.Size(100, 20);
            this.PutTitel.TabIndex = 21;
            // 
            // PutID
            // 
            this.PutID.Location = new System.Drawing.Point(345, 13);
            this.PutID.Name = "PutID";
            this.PutID.Size = new System.Drawing.Size(100, 20);
            this.PutID.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(184, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Auteur";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(184, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "is verwijderd";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(184, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Verhaal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(184, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Gemaakt op";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(184, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Titel";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(184, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "ID";
            // 
            // Delete
            // 
            this.Delete.Controls.Add(this.dataDeleteButton);
            this.Delete.Controls.Add(this.DeleteVerwijderd);
            this.Delete.Controls.Add(this.DeleteVerhaal);
            this.Delete.Controls.Add(this.DeleteDate);
            this.Delete.Controls.Add(this.DeleteAuteur);
            this.Delete.Controls.Add(this.DeleteTitel);
            this.Delete.Controls.Add(this.DeleteID);
            this.Delete.Controls.Add(this.label19);
            this.Delete.Controls.Add(this.label20);
            this.Delete.Controls.Add(this.label21);
            this.Delete.Controls.Add(this.label22);
            this.Delete.Controls.Add(this.label23);
            this.Delete.Controls.Add(this.label24);
            this.Delete.Location = new System.Drawing.Point(4, 22);
            this.Delete.Name = "Delete";
            this.Delete.Padding = new System.Windows.Forms.Padding(3);
            this.Delete.Size = new System.Drawing.Size(473, 297);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // dataDeleteButton
            // 
            this.dataDeleteButton.Location = new System.Drawing.Point(6, 220);
            this.dataDeleteButton.Name = "dataDeleteButton";
            this.dataDeleteButton.Size = new System.Drawing.Size(88, 23);
            this.dataDeleteButton.TabIndex = 27;
            this.dataDeleteButton.Text = "log verwijderen";
            this.dataDeleteButton.UseVisualStyleBackColor = true;
            this.dataDeleteButton.Click += new System.EventHandler(this.dataDeleteButton_Click);
            // 
            // DeleteVerwijderd
            // 
            this.DeleteVerwijderd.Location = new System.Drawing.Point(342, 223);
            this.DeleteVerwijderd.Name = "DeleteVerwijderd";
            this.DeleteVerwijderd.ReadOnly = true;
            this.DeleteVerwijderd.Size = new System.Drawing.Size(100, 20);
            this.DeleteVerwijderd.TabIndex = 25;
            // 
            // DeleteVerhaal
            // 
            this.DeleteVerhaal.Location = new System.Drawing.Point(342, 175);
            this.DeleteVerhaal.Name = "DeleteVerhaal";
            this.DeleteVerhaal.ReadOnly = true;
            this.DeleteVerhaal.Size = new System.Drawing.Size(100, 20);
            this.DeleteVerhaal.TabIndex = 24;
            // 
            // DeleteDate
            // 
            this.DeleteDate.Location = new System.Drawing.Point(342, 129);
            this.DeleteDate.Name = "DeleteDate";
            this.DeleteDate.ReadOnly = true;
            this.DeleteDate.Size = new System.Drawing.Size(100, 20);
            this.DeleteDate.TabIndex = 23;
            // 
            // DeleteAuteur
            // 
            this.DeleteAuteur.Location = new System.Drawing.Point(342, 91);
            this.DeleteAuteur.Name = "DeleteAuteur";
            this.DeleteAuteur.ReadOnly = true;
            this.DeleteAuteur.Size = new System.Drawing.Size(100, 20);
            this.DeleteAuteur.TabIndex = 22;
            // 
            // DeleteTitel
            // 
            this.DeleteTitel.Location = new System.Drawing.Point(342, 51);
            this.DeleteTitel.Name = "DeleteTitel";
            this.DeleteTitel.ReadOnly = true;
            this.DeleteTitel.Size = new System.Drawing.Size(100, 20);
            this.DeleteTitel.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(181, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Auteur";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(181, 230);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "is verwijderd";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(181, 182);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Verhaal";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(181, 136);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Gemaakt op";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(181, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "Titel";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(181, 13);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(18, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "ID";
            // 
            // DeleteID
            // 
            this.DeleteID.Location = new System.Drawing.Point(342, 13);
            this.DeleteID.Name = "DeleteID";
            this.DeleteID.Size = new System.Drawing.Size(100, 20);
            this.DeleteID.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 347);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form1";
            this.Text = "Web-api applicatie";
            this.mainTabControl.ResumeLayout(false);
            this.Get.ResumeLayout(false);
            this.Get.PerformLayout();
            this.Post.ResumeLayout(false);
            this.Post.PerformLayout();
            this.Put.ResumeLayout(false);
            this.Put.PerformLayout();
            this.Delete.ResumeLayout(false);
            this.Delete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage Get;
        private System.Windows.Forms.TabPage Post;
        private System.Windows.Forms.TabPage Put;
        private System.Windows.Forms.TabPage Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboGet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GetVerwijderd;
        private System.Windows.Forms.TextBox GetVerhaal;
        private System.Windows.Forms.TextBox GetDate;
        private System.Windows.Forms.TextBox GetAuteur;
        private System.Windows.Forms.TextBox GetTitel;
        private System.Windows.Forms.TextBox GetID;
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
        private System.Windows.Forms.TextBox PutVerwijderd;
        private System.Windows.Forms.TextBox PutVerhaal;
        private System.Windows.Forms.TextBox PutDate;
        private System.Windows.Forms.TextBox PutAuteur;
        private System.Windows.Forms.TextBox PutTitel;
        private System.Windows.Forms.TextBox PutID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox DeleteVerwijderd;
        private System.Windows.Forms.TextBox DeleteVerhaal;
        private System.Windows.Forms.TextBox DeleteDate;
        private System.Windows.Forms.TextBox DeleteAuteur;
        private System.Windows.Forms.TextBox DeleteTitel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button dataOphalenButton;
        private System.Windows.Forms.Button dataOpslaanButton;
        private System.Windows.Forms.Button dataVeranderenButton;
        private System.Windows.Forms.Button dataDeleteButton;
        private System.Windows.Forms.TextBox DeleteID;
    }
}

