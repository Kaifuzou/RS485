
namespace GUI_RS485
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
            this.components = new System.ComponentModel.Container();
            this.serCom = new System.IO.Ports.SerialPort(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.picsl2 = new System.Windows.Forms.PictureBox();
            this.picsl1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pic4sl2 = new System.Windows.Forms.PictureBox();
            this.pic3sl2 = new System.Windows.Forms.PictureBox();
            this.pic2sl2 = new System.Windows.Forms.PictureBox();
            this.pic1sl2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pic4sl1 = new System.Windows.Forms.PictureBox();
            this.pic3sl1 = new System.Windows.Forms.PictureBox();
            this.pic2sl1 = new System.Windows.Forms.PictureBox();
            this.pic1sl1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.butConnect = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbau = new System.Windows.Forms.ComboBox();
            this.cbport = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.txtsl2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buton1sl1 = new System.Windows.Forms.Button();
            this.txtsl1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picsl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsl1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic4sl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3sl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2sl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1sl2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic4sl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3sl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2sl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1sl1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serCom
            // 
            this.serCom.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCom_DataReceived);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.button11);
            this.groupBox7.Controls.Add(this.picsl2);
            this.groupBox7.Controls.Add(this.picsl1);
            this.groupBox7.Controls.Add(this.button9);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Brown;
            this.groupBox7.Location = new System.Drawing.Point(889, 349);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(337, 229);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "STATUS SLAVE";
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(217, 189);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(105, 34);
            this.button11.TabIndex = 29;
            this.button11.Text = "Reset";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // picsl2
            // 
            this.picsl2.BackColor = System.Drawing.Color.Red;
            this.picsl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picsl2.Location = new System.Drawing.Point(157, 135);
            this.picsl2.Name = "picsl2";
            this.picsl2.Size = new System.Drawing.Size(29, 28);
            this.picsl2.TabIndex = 28;
            this.picsl2.TabStop = false;
            // 
            // picsl1
            // 
            this.picsl1.BackColor = System.Drawing.Color.Red;
            this.picsl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picsl1.Location = new System.Drawing.Point(157, 67);
            this.picsl1.Name = "picsl1";
            this.picsl1.Size = new System.Drawing.Size(29, 28);
            this.picsl1.TabIndex = 27;
            this.picsl1.TabStop = false;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(22, 189);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(164, 34);
            this.button9.TabIndex = 2;
            this.button9.Text = "Check";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(33, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 20);
            this.label20.TabIndex = 1;
            this.label20.Text = "SLAVE 2:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(30, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "SLAVE 1:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Brown;
            this.groupBox4.Location = new System.Drawing.Point(410, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 488);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "STATUS LED";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.pic4sl2);
            this.groupBox6.Controls.Add(this.pic3sl2);
            this.groupBox6.Controls.Add(this.pic2sl2);
            this.groupBox6.Controls.Add(this.pic1sl2);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.ForeColor = System.Drawing.Color.Brown;
            this.groupBox6.Location = new System.Drawing.Point(23, 252);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(415, 222);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SLAVE 2";
            // 
            // pic4sl2
            // 
            this.pic4sl2.BackColor = System.Drawing.Color.Red;
            this.pic4sl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic4sl2.Location = new System.Drawing.Point(349, 114);
            this.pic4sl2.Name = "pic4sl2";
            this.pic4sl2.Size = new System.Drawing.Size(29, 28);
            this.pic4sl2.TabIndex = 26;
            this.pic4sl2.TabStop = false;
            // 
            // pic3sl2
            // 
            this.pic3sl2.BackColor = System.Drawing.Color.Red;
            this.pic3sl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic3sl2.Location = new System.Drawing.Point(244, 114);
            this.pic3sl2.Name = "pic3sl2";
            this.pic3sl2.Size = new System.Drawing.Size(29, 28);
            this.pic3sl2.TabIndex = 25;
            this.pic3sl2.TabStop = false;
            // 
            // pic2sl2
            // 
            this.pic2sl2.BackColor = System.Drawing.Color.Red;
            this.pic2sl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic2sl2.Location = new System.Drawing.Point(147, 114);
            this.pic2sl2.Name = "pic2sl2";
            this.pic2sl2.Size = new System.Drawing.Size(29, 28);
            this.pic2sl2.TabIndex = 24;
            this.pic2sl2.TabStop = false;
            // 
            // pic1sl2
            // 
            this.pic1sl2.BackColor = System.Drawing.Color.Red;
            this.pic1sl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1sl2.Location = new System.Drawing.Point(37, 114);
            this.pic1sl2.Name = "pic1sl2";
            this.pic1sl2.Size = new System.Drawing.Size(29, 28);
            this.pic1sl2.TabIndex = 23;
            this.pic1sl2.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(336, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "LED 4";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(230, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "LED 3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(127, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "LED 2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "LED 1";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.pic4sl1);
            this.groupBox5.Controls.Add(this.pic3sl1);
            this.groupBox5.Controls.Add(this.pic2sl1);
            this.groupBox5.Controls.Add(this.pic1sl1);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Brown;
            this.groupBox5.Location = new System.Drawing.Point(23, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(415, 205);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SLAVE 1";
            // 
            // pic4sl1
            // 
            this.pic4sl1.BackColor = System.Drawing.Color.Red;
            this.pic4sl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic4sl1.Location = new System.Drawing.Point(349, 104);
            this.pic4sl1.Name = "pic4sl1";
            this.pic4sl1.Size = new System.Drawing.Size(29, 28);
            this.pic4sl1.TabIndex = 25;
            this.pic4sl1.TabStop = false;
            // 
            // pic3sl1
            // 
            this.pic3sl1.BackColor = System.Drawing.Color.Red;
            this.pic3sl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic3sl1.Location = new System.Drawing.Point(244, 104);
            this.pic3sl1.Name = "pic3sl1";
            this.pic3sl1.Size = new System.Drawing.Size(29, 28);
            this.pic3sl1.TabIndex = 24;
            this.pic3sl1.TabStop = false;
            // 
            // pic2sl1
            // 
            this.pic2sl1.BackColor = System.Drawing.Color.Red;
            this.pic2sl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic2sl1.Location = new System.Drawing.Point(147, 104);
            this.pic2sl1.Name = "pic2sl1";
            this.pic2sl1.Size = new System.Drawing.Size(29, 28);
            this.pic2sl1.TabIndex = 23;
            this.pic2sl1.TabStop = false;
            // 
            // pic1sl1
            // 
            this.pic1sl1.BackColor = System.Drawing.Color.Red;
            this.pic1sl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1sl1.Location = new System.Drawing.Point(37, 104);
            this.pic1sl1.Name = "pic1sl1";
            this.pic1sl1.Size = new System.Drawing.Size(29, 28);
            this.pic1sl1.TabIndex = 22;
            this.pic1sl1.TabStop = false;
            this.pic1sl1.Click += new System.EventHandler(this.pic1sl1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "LED 4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(230, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "LED 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(127, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "LED 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "LED 1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.butConnect);
            this.groupBox3.Controls.Add(this.txtdata);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbbau);
            this.groupBox3.Controls.Add(this.cbport);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Brown;
            this.groupBox3.Location = new System.Drawing.Point(889, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 229);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONNECT";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(217, 192);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 29);
            this.button10.TabIndex = 26;
            this.button10.Text = "Exit";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // butConnect
            // 
            this.butConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConnect.Location = new System.Drawing.Point(22, 192);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(164, 29);
            this.butConnect.TabIndex = 25;
            this.butConnect.Text = "Connect";
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(148, 141);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(174, 30);
            this.txtdata.TabIndex = 23;
            this.txtdata.TextChanged += new System.EventHandler(this.txtdata_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Data:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Serial Port:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Baudgate:";
            // 
            // cbbau
            // 
            this.cbbau.FormattingEnabled = true;
            this.cbbau.Location = new System.Drawing.Point(148, 41);
            this.cbbau.Name = "cbbau";
            this.cbbau.Size = new System.Drawing.Size(174, 33);
            this.cbbau.TabIndex = 14;
            // 
            // cbport
            // 
            this.cbport.FormattingEnabled = true;
            this.cbport.Location = new System.Drawing.Point(148, 92);
            this.cbport.Name = "cbport";
            this.cbport.Size = new System.Drawing.Size(174, 33);
            this.cbport.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.button16);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.button17);
            this.groupBox2.Controls.Add(this.button18);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.txtsl2);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Brown;
            this.groupBox2.Location = new System.Drawing.Point(60, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 236);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SLAVE 2";
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(87, 152);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 33);
            this.button15.TabIndex = 37;
            this.button15.Text = "ON";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(20, 120);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 20);
            this.label23.TabIndex = 33;
            this.label23.Text = "LED 3";
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(200, 152);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 33);
            this.button16.TabIndex = 38;
            this.button16.Text = "OFF";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(20, 158);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 20);
            this.label24.TabIndex = 34;
            this.label24.Text = "LED 4";
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(87, 114);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 33);
            this.button17.TabIndex = 35;
            this.button17.Text = "ON";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(200, 114);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 33);
            this.button18.TabIndex = 36;
            this.button18.Text = "OFF";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Data:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(87, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 24;
            this.button5.Text = "ON";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "LED 1";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(200, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 25;
            this.button6.Text = "OFF";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "LED 2";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(87, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 33);
            this.button7.TabIndex = 22;
            this.button7.Text = "ON";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(200, 38);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 33);
            this.button8.TabIndex = 23;
            this.button8.Text = "OFF";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtsl2
            // 
            this.txtsl2.Cursor = System.Windows.Forms.Cursors.No;
            this.txtsl2.Location = new System.Drawing.Point(87, 198);
            this.txtsl2.Name = "txtsl2";
            this.txtsl2.Size = new System.Drawing.Size(188, 30);
            this.txtsl2.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buton1sl1);
            this.groupBox1.Controls.Add(this.txtsl1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(60, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 246);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SLAVE 1";
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(87, 162);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 33);
            this.button13.TabIndex = 27;
            this.button13.Text = "ON";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(200, 162);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 33);
            this.button14.TabIndex = 28;
            this.button14.Text = "OFF";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(20, 168);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 20);
            this.label22.TabIndex = 26;
            this.label22.Text = "LED 4";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(87, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "ON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(200, 123);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 33);
            this.button12.TabIndex = 25;
            this.button12.Text = "OFF";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(20, 129);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 20);
            this.label21.TabIndex = 23;
            this.label21.Text = "LED 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Data:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(87, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 20;
            this.button3.Text = "ON";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(200, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 21;
            this.button4.Text = "OFF";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "LED 2";
            // 
            // buton1sl1
            // 
            this.buton1sl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton1sl1.Location = new System.Drawing.Point(87, 44);
            this.buton1sl1.Name = "buton1sl1";
            this.buton1sl1.Size = new System.Drawing.Size(75, 33);
            this.buton1sl1.TabIndex = 0;
            this.buton1sl1.Text = "ON";
            this.buton1sl1.UseVisualStyleBackColor = true;
            this.buton1sl1.Click += new System.EventHandler(this.buton1sl1_Click);
            // 
            // txtsl1
            // 
            this.txtsl1.Cursor = System.Windows.Forms.Cursors.No;
            this.txtsl1.Location = new System.Drawing.Point(87, 207);
            this.txtsl1.Name = "txtsl1";
            this.txtsl1.Size = new System.Drawing.Size(188, 30);
            this.txtsl1.TabIndex = 18;
            this.txtsl1.TextChanged += new System.EventHandler(this.txtsl1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(200, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "LED 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(478, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(377, 55);
            this.label8.TabIndex = 35;
            this.label8.Text = "LED CONTROL";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1304, 653);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picsl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsl1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic4sl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3sl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2sl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1sl2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic4sl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3sl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2sl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1sl1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serCom;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.PictureBox picsl2;
        private System.Windows.Forms.PictureBox picsl1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pic4sl2;
        private System.Windows.Forms.PictureBox pic3sl2;
        private System.Windows.Forms.PictureBox pic2sl2;
        private System.Windows.Forms.PictureBox pic1sl2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pic4sl1;
        private System.Windows.Forms.PictureBox pic3sl1;
        private System.Windows.Forms.PictureBox pic2sl1;
        private System.Windows.Forms.PictureBox pic1sl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbau;
        private System.Windows.Forms.ComboBox cbport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtsl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buton1sl1;
        private System.Windows.Forms.TextBox txtsl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

