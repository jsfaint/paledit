namespace PalEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemMain = new System.Windows.Forms.MenuItem();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItemSave = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonMagic = new System.Windows.Forms.Button();
            this.textBoxExp = new System.Windows.Forms.TextBox();
            this.textBoxNowRank = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLuck = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxDefence = new System.Windows.Forms.TextBox();
            this.textBoxWakan = new System.Windows.Forms.TextBox();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.textBoxMaxMp = new System.Windows.Forms.TextBox();
            this.textBoxMp = new System.Windows.Forms.TextBox();
            this.textBoxMaxHp = new System.Windows.Forms.TextBox();
            this.textBoxHp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonGoods = new System.Windows.Forms.Button();
            this.labelGoods = new System.Windows.Forms.Label();
            this.textBoxGoods = new System.Windows.Forms.TextBox();
            this.checkBoxGoods = new System.Windows.Forms.CheckBox();
            this.dataGridGoods = new System.Windows.Forms.DataGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxSaveTime = new System.Windows.Forms.CheckBox();
            this.textBoxSaveTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCalabash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemMain);
            this.mainMenu1.MenuItems.Add(this.menuItemAbout);
            // 
            // menuItemMain
            // 
            this.menuItemMain.MenuItems.Add(this.menuItemOpen);
            this.menuItemMain.MenuItems.Add(this.menuItemSave);
            this.menuItemMain.MenuItems.Add(this.menuItem5);
            this.menuItemMain.MenuItems.Add(this.menuItemExit);
            this.menuItemMain.Text = "菜单(&M)";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.MenuItems.Add(this.menuItem1);
            this.menuItemOpen.MenuItems.Add(this.menuItem2);
            this.menuItemOpen.MenuItems.Add(this.menuItem3);
            this.menuItemOpen.MenuItems.Add(this.menuItem4);
            this.menuItemOpen.MenuItems.Add(this.menuItem6);
            this.menuItemOpen.Text = "打开(&O)";
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "进度 1";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "进度 2";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "进度 3";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "进度 4";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "进度 5";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Text = "保存(&S)";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "-";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Text = "退出(&X)";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Text = "关于(&A)";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 268);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonMagic);
            this.tabPage1.Controls.Add(this.textBoxExp);
            this.tabPage1.Controls.Add(this.textBoxNowRank);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBoxLuck);
            this.tabPage1.Controls.Add(this.textBoxSpeed);
            this.tabPage1.Controls.Add(this.textBoxDefence);
            this.tabPage1.Controls.Add(this.textBoxWakan);
            this.tabPage1.Controls.Add(this.textBoxPower);
            this.tabPage1.Controls.Add(this.textBoxMaxMp);
            this.tabPage1.Controls.Add(this.textBoxMp);
            this.tabPage1.Controls.Add(this.textBoxMaxHp);
            this.tabPage1.Controls.Add(this.textBoxHp);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 245);
            this.tabPage1.Text = "人物";
            // 
            // buttonMagic
            // 
            this.buttonMagic.Location = new System.Drawing.Point(143, 209);
            this.buttonMagic.Name = "buttonMagic";
            this.buttonMagic.Size = new System.Drawing.Size(69, 22);
            this.buttonMagic.TabIndex = 46;
            this.buttonMagic.Text = "仙术";
            this.buttonMagic.Click += new System.EventHandler(this.buttonMagic_Click);
            // 
            // textBoxExp
            // 
            this.textBoxExp.Location = new System.Drawing.Point(143, 43);
            this.textBoxExp.Name = "textBoxExp";
            this.textBoxExp.Size = new System.Drawing.Size(68, 21);
            this.textBoxExp.TabIndex = 33;
            this.textBoxExp.TextChanged += new System.EventHandler(this.textBoxExp_TextChanged);
            this.textBoxExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxExp.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // textBoxNowRank
            // 
            this.textBoxNowRank.Location = new System.Drawing.Point(69, 43);
            this.textBoxNowRank.Name = "textBoxNowRank";
            this.textBoxNowRank.Size = new System.Drawing.Size(25, 21);
            this.textBoxNowRank.TabIndex = 32;
            this.textBoxNowRank.TextChanged += new System.EventHandler(this.textBoxNowRank_TextChanged);
            this.textBoxNowRank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxNowRank.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label15.Location = new System.Drawing.Point(127, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 19);
            this.label15.Text = "/";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(126, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 19);
            this.label7.Text = "/";
            // 
            // textBoxLuck
            // 
            this.textBoxLuck.Location = new System.Drawing.Point(173, 179);
            this.textBoxLuck.Name = "textBoxLuck";
            this.textBoxLuck.Size = new System.Drawing.Size(40, 21);
            this.textBoxLuck.TabIndex = 28;
            this.textBoxLuck.TextChanged += new System.EventHandler(this.textBoxLuck_TextChanged);
            this.textBoxLuck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxLuck.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(173, 152);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(40, 21);
            this.textBoxSpeed.TabIndex = 17;
            this.textBoxSpeed.TextChanged += new System.EventHandler(this.textBoxSpeed_TextChanged);
            this.textBoxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxSpeed.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // textBoxDefence
            // 
            this.textBoxDefence.Location = new System.Drawing.Point(71, 206);
            this.textBoxDefence.Name = "textBoxDefence";
            this.textBoxDefence.Size = new System.Drawing.Size(40, 21);
            this.textBoxDefence.TabIndex = 16;
            this.textBoxDefence.TextChanged += new System.EventHandler(this.textBoxDefence_TextChanged);
            this.textBoxDefence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxDefence.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // textBoxWakan
            // 
            this.textBoxWakan.Location = new System.Drawing.Point(71, 179);
            this.textBoxWakan.Name = "textBoxWakan";
            this.textBoxWakan.Size = new System.Drawing.Size(40, 21);
            this.textBoxWakan.TabIndex = 15;
            this.textBoxWakan.TextChanged += new System.EventHandler(this.textBoxWakan_TextChanged);
            this.textBoxWakan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxWakan.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // textBoxPower
            // 
            this.textBoxPower.Location = new System.Drawing.Point(71, 152);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(40, 21);
            this.textBoxPower.TabIndex = 14;
            this.textBoxPower.TextChanged += new System.EventHandler(this.textBoxPower_TextChanged);
            this.textBoxPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxPower.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // textBoxMaxMp
            // 
            this.textBoxMaxMp.Location = new System.Drawing.Point(142, 111);
            this.textBoxMaxMp.Name = "textBoxMaxMp";
            this.textBoxMaxMp.Size = new System.Drawing.Size(40, 21);
            this.textBoxMaxMp.TabIndex = 13;
            this.textBoxMaxMp.TextChanged += new System.EventHandler(this.textBoxMaxMp_TextChanged);
            this.textBoxMaxMp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxMaxMp.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // textBoxMp
            // 
            this.textBoxMp.Location = new System.Drawing.Point(82, 111);
            this.textBoxMp.Name = "textBoxMp";
            this.textBoxMp.Size = new System.Drawing.Size(40, 21);
            this.textBoxMp.TabIndex = 12;
            this.textBoxMp.TextChanged += new System.EventHandler(this.textBoxMp_TextChanged);
            this.textBoxMp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxMp.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // textBoxMaxHp
            // 
            this.textBoxMaxHp.Location = new System.Drawing.Point(142, 83);
            this.textBoxMaxHp.Name = "textBoxMaxHp";
            this.textBoxMaxHp.Size = new System.Drawing.Size(40, 21);
            this.textBoxMaxHp.TabIndex = 11;
            this.textBoxMaxHp.TextChanged += new System.EventHandler(this.textBoxMaxHp_TextChanged);
            this.textBoxMaxHp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxMaxHp.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // textBoxHp
            // 
            this.textBoxHp.Location = new System.Drawing.Point(82, 84);
            this.textBoxHp.Name = "textBoxHp";
            this.textBoxHp.Size = new System.Drawing.Size(40, 21);
            this.textBoxHp.TabIndex = 10;
            this.textBoxHp.TextChanged += new System.EventHandler(this.textBoxHp_TextChanged);
            this.textBoxHp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxHp.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(27, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.Text = "真气:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(27, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.Text = "体力:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(127, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.Text = "吉运:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(127, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.Text = "身法:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(18, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.Text = "防御:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(18, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.Text = "灵力:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.Text = "武力:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(107, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.Text = "经验:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(27, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.Text = "修行:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(39, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.Text = "人物:";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.Add("李逍遥");
            this.comboBox1.Items.Add("赵灵儿");
            this.comboBox1.Items.Add("林月如");
            this.comboBox1.Items.Add("巫后");
            this.comboBox1.Items.Add("阿奴");
            this.comboBox1.Location = new System.Drawing.Point(92, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 22);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.GotFocus += new System.EventHandler(this.comboBox1_GotFocus);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonGoods);
            this.tabPage2.Controls.Add(this.labelGoods);
            this.tabPage2.Controls.Add(this.textBoxGoods);
            this.tabPage2.Controls.Add(this.checkBoxGoods);
            this.tabPage2.Controls.Add(this.dataGridGoods);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 245);
            this.tabPage2.Text = "物品";
            // 
            // buttonGoods
            // 
            this.buttonGoods.Location = new System.Drawing.Point(98, 10);
            this.buttonGoods.Name = "buttonGoods";
            this.buttonGoods.Size = new System.Drawing.Size(38, 25);
            this.buttonGoods.TabIndex = 16;
            this.buttonGoods.Text = "修改";
            this.buttonGoods.Click += new System.EventHandler(this.buttonGoods_Click);
            // 
            // labelGoods
            // 
            this.labelGoods.Location = new System.Drawing.Point(4, 15);
            this.labelGoods.Name = "labelGoods";
            this.labelGoods.Size = new System.Drawing.Size(68, 20);
            // 
            // textBoxGoods
            // 
            this.textBoxGoods.Location = new System.Drawing.Point(73, 12);
            this.textBoxGoods.MaxLength = 2;
            this.textBoxGoods.Name = "textBoxGoods";
            this.textBoxGoods.Size = new System.Drawing.Size(24, 21);
            this.textBoxGoods.TabIndex = 14;
            this.textBoxGoods.TextChanged += new System.EventHandler(this.textBoxGoods_TextChanged);
            this.textBoxGoods.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            // 
            // checkBoxGoods
            // 
            this.checkBoxGoods.Location = new System.Drawing.Point(140, 13);
            this.checkBoxGoods.Name = "checkBoxGoods";
            this.checkBoxGoods.Size = new System.Drawing.Size(95, 20);
            this.checkBoxGoods.TabIndex = 13;
            this.checkBoxGoods.Text = "全物品99个";
            this.checkBoxGoods.CheckStateChanged += new System.EventHandler(this.checkBoxGoods_CheckStateChanged);
            // 
            // dataGridGoods
            // 
            this.dataGridGoods.BackgroundColor = System.Drawing.Color.White;
            this.dataGridGoods.ColumnHeadersVisible = false;
            this.dataGridGoods.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridGoods.Location = new System.Drawing.Point(0, 45);
            this.dataGridGoods.Name = "dataGridGoods";
            this.dataGridGoods.RowHeadersVisible = false;
            this.dataGridGoods.Size = new System.Drawing.Size(240, 200);
            this.dataGridGoods.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBoxSaveTime);
            this.tabPage3.Controls.Add(this.textBoxSaveTime);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBoxCalabash);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBoxMoney);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(240, 245);
            this.tabPage3.Text = "其他";
            // 
            // checkBoxSaveTime
            // 
            this.checkBoxSaveTime.Location = new System.Drawing.Point(128, 61);
            this.checkBoxSaveTime.Name = "checkBoxSaveTime";
            this.checkBoxSaveTime.Size = new System.Drawing.Size(69, 20);
            this.checkBoxSaveTime.TabIndex = 7;
            this.checkBoxSaveTime.Text = "清零";
            // 
            // textBoxSaveTime
            // 
            this.textBoxSaveTime.Location = new System.Drawing.Point(97, 62);
            this.textBoxSaveTime.Name = "textBoxSaveTime";
            this.textBoxSaveTime.Size = new System.Drawing.Size(26, 21);
            this.textBoxSaveTime.TabIndex = 6;
            this.textBoxSaveTime.TextChanged += new System.EventHandler(this.textBoxSaveTime_TextChanged);
            this.textBoxSaveTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxSaveTime.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(41, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.Text = "存盘数:";
            // 
            // textBoxCalabash
            // 
            this.textBoxCalabash.Location = new System.Drawing.Point(96, 39);
            this.textBoxCalabash.Name = "textBoxCalabash";
            this.textBoxCalabash.Size = new System.Drawing.Size(76, 21);
            this.textBoxCalabash.TabIndex = 4;
            this.textBoxCalabash.TextChanged += new System.EventHandler(this.textBoxCalabash_TextChanged);
            this.textBoxCalabash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxCalabash.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(41, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.Text = "灵葫值:";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(96, 14);
            this.textBoxMoney.MaxLength = 9;
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(76, 21);
            this.textBoxMoney.TabIndex = 1;
            this.textBoxMoney.Text = "99999999999999999";
            this.textBoxMoney.TextChanged += new System.EventHandler(this.textBoxMoney_TextChanged);
            this.textBoxMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_Handle);
            this.textBoxMoney.LostFocus += new System.EventHandler(this.textBox_LostFocus);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.Text = "金钱:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "仙剑存档修改器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemMain;
        private System.Windows.Forms.MenuItem menuItemOpen;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuItem menuItemSave;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCalabash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSaveTime;
        private System.Windows.Forms.TextBox textBoxSaveTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxDefence;
        private System.Windows.Forms.TextBox textBoxWakan;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.TextBox textBoxMaxMp;
        private System.Windows.Forms.TextBox textBoxMp;
        private System.Windows.Forms.TextBox textBoxMaxHp;
        private System.Windows.Forms.TextBox textBoxHp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLuck;
        private System.Windows.Forms.TextBox textBoxExp;
        private System.Windows.Forms.TextBox textBoxNowRank;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGrid dataGridGoods;
        private System.Windows.Forms.CheckBox checkBoxGoods;
        private System.Windows.Forms.Label labelGoods;
        private System.Windows.Forms.TextBox textBoxGoods;
        private System.Windows.Forms.Button buttonGoods;
        private System.Windows.Forms.Button buttonMagic;
    }
}

