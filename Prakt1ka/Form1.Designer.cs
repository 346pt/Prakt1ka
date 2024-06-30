namespace Prakt1ka
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ParkingSpotsView = new DataGridView();
            AddButton = new Button();
            DeleteButton = new Button();
            CalculateCostBtn = new Button();
            SaveBtn = new Button();
            LoadBtn = new Button();
            Numbertxt = new TextBox();
            Brandtxt = new TextBox();
            Modeltxt = new TextBox();
            Colourtxt = new TextBox();
            ArriveTimetxt = new TextBox();
            DeportureTimetxt = new TextBox();
            ParkingSpottxt = new TextBox();
            Costtxt = new TextBox();
            NumberLabel = new Label();
            BrandLabel = new Label();
            ModelLaberl = new Label();
            ArrivalLabel = new Label();
            DepartureLabel = new Label();
            ParkingLabel = new Label();
            ColorLabel = new Label();
            CostLabel = new Label();
            ArriveTimepicker = new DateTimePicker();
            DepartureTimepicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            WholeCost = new Button();
            ((System.ComponentModel.ISupportInitialize)ParkingSpotsView).BeginInit();
            SuspendLayout();
            // 
            // ParkingSpotsView
            // 
            ParkingSpotsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ParkingSpotsView.Location = new Point(12, 70);
            ParkingSpotsView.Name = "ParkingSpotsView";
            ParkingSpotsView.Size = new Size(295, 440);
            ParkingSpotsView.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.BackgroundImage = (Image)resources.GetObject("AddButton.BackgroundImage");
            AddButton.Location = new Point(373, 70);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(97, 41);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackgroundImage = (Image)resources.GetObject("DeleteButton.BackgroundImage");
            DeleteButton.Location = new Point(496, 70);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(97, 41);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CalculateCostBtn
            // 
            CalculateCostBtn.BackgroundImage = Properties.Resources.hed;
            CalculateCostBtn.Location = new Point(622, 70);
            CalculateCostBtn.Name = "CalculateCostBtn";
            CalculateCostBtn.Size = new Size(97, 41);
            CalculateCostBtn.TabIndex = 3;
            CalculateCostBtn.Text = "Стоимость";
            CalculateCostBtn.UseVisualStyleBackColor = true;
            CalculateCostBtn.Click += CalculateCostBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = SystemColors.ActiveBorder;
            SaveBtn.BackgroundImage = Properties.Resources.red;
            SaveBtn.Location = new Point(575, 483);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(80, 27);
            SaveBtn.TabIndex = 4;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.BackgroundImage = Properties.Resources.red;
            LoadBtn.Location = new Point(661, 483);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(80, 27);
            LoadBtn.TabIndex = 5;
            LoadBtn.Text = "Загрузить";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // Numbertxt
            // 
            Numbertxt.Location = new Point(496, 149);
            Numbertxt.Name = "Numbertxt";
            Numbertxt.Size = new Size(223, 23);
            Numbertxt.TabIndex = 6;
            // 
            // Brandtxt
            // 
            Brandtxt.Location = new Point(496, 192);
            Brandtxt.Name = "Brandtxt";
            Brandtxt.Size = new Size(223, 23);
            Brandtxt.TabIndex = 7;
            // 
            // Modeltxt
            // 
            Modeltxt.Location = new Point(496, 236);
            Modeltxt.Name = "Modeltxt";
            Modeltxt.Size = new Size(223, 23);
            Modeltxt.TabIndex = 8;
            // 
            // Colourtxt
            // 
            Colourtxt.Location = new Point(496, 283);
            Colourtxt.Name = "Colourtxt";
            Colourtxt.Size = new Size(223, 23);
            Colourtxt.TabIndex = 9;
            // 
            // ArriveTimetxt
            // 
            ArriveTimetxt.Location = new Point(760, 265);
            ArriveTimetxt.Name = "ArriveTimetxt";
            ArriveTimetxt.Size = new Size(223, 23);
            ArriveTimetxt.TabIndex = 10;
            ArriveTimetxt.Visible = false;
            // 
            // DeportureTimetxt
            // 
            DeportureTimetxt.Location = new Point(760, 309);
            DeportureTimetxt.Name = "DeportureTimetxt";
            DeportureTimetxt.Size = new Size(223, 23);
            DeportureTimetxt.TabIndex = 11;
            DeportureTimetxt.Visible = false;
            // 
            // ParkingSpottxt
            // 
            ParkingSpottxt.Location = new Point(496, 421);
            ParkingSpottxt.Name = "ParkingSpottxt";
            ParkingSpottxt.Size = new Size(223, 23);
            ParkingSpottxt.TabIndex = 12;
            // 
            // Costtxt
            // 
            Costtxt.Location = new Point(791, 368);
            Costtxt.Name = "Costtxt";
            Costtxt.Size = new Size(223, 23);
            Costtxt.TabIndex = 13;
            Costtxt.Visible = false;
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.BackColor = Color.Transparent;
            NumberLabel.Font = new Font("MV Boli", 9.75F);
            NumberLabel.Location = new Point(399, 150);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(80, 17);
            NumberLabel.TabIndex = 14;
            NumberLabel.Text = "Номер ТС:";
            NumberLabel.Click += NumberLabel_Click;
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.BackColor = Color.Transparent;
            BrandLabel.Font = new Font("MV Boli", 9.75F);
            BrandLabel.Location = new Point(419, 192);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(55, 17);
            BrandLabel.TabIndex = 15;
            BrandLabel.Text = "Марка:";
            // 
            // ModelLaberl
            // 
            ModelLaberl.AutoSize = true;
            ModelLaberl.BackColor = Color.Transparent;
            ModelLaberl.Font = new Font("MV Boli", 9.75F);
            ModelLaberl.Location = new Point(411, 236);
            ModelLaberl.Name = "ModelLaberl";
            ModelLaberl.Size = new Size(63, 17);
            ModelLaberl.TabIndex = 16;
            ModelLaberl.Text = "Модель:";
            // 
            // ArrivalLabel
            // 
            ArrivalLabel.AutoSize = true;
            ArrivalLabel.BackColor = Color.Transparent;
            ArrivalLabel.Font = new Font("MV Boli", 9.75F);
            ArrivalLabel.Location = new Point(399, 330);
            ArrivalLabel.Name = "ArrivalLabel";
            ArrivalLabel.Size = new Size(79, 17);
            ArrivalLabel.TabIndex = 17;
            ArrivalLabel.Text = "Прибытие:";
            // 
            // DepartureLabel
            // 
            DepartureLabel.AutoSize = true;
            DepartureLabel.BackColor = Color.Transparent;
            DepartureLabel.Font = new Font("MV Boli", 9.75F);
            DepartureLabel.Location = new Point(423, 379);
            DepartureLabel.Name = "DepartureLabel";
            DepartureLabel.Size = new Size(55, 17);
            DepartureLabel.TabIndex = 18;
            DepartureLabel.Text = "Выезд:";
            // 
            // ParkingLabel
            // 
            ParkingLabel.AutoSize = true;
            ParkingLabel.BackColor = Color.Transparent;
            ParkingLabel.Font = new Font("MV Boli", 9.75F);
            ParkingLabel.Location = new Point(338, 421);
            ParkingLabel.Name = "ParkingLabel";
            ParkingLabel.Size = new Size(147, 17);
            ParkingLabel.TabIndex = 19;
            ParkingLabel.Text = "Парковочное место:";
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.BackColor = Color.Transparent;
            ColorLabel.Font = new Font("MV Boli", 9.75F);
            ColorLabel.Location = new Point(430, 283);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(45, 17);
            ColorLabel.TabIndex = 20;
            ColorLabel.Text = "Цвет:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Font = new Font("Segoe UI", 9.75F);
            CostLabel.Location = new Point(791, 438);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(74, 17);
            CostLabel.TabIndex = 21;
            CostLabel.Text = "Стоимость:";
            CostLabel.Visible = false;
            // 
            // ArriveTimepicker
            // 
            ArriveTimepicker.Location = new Point(496, 330);
            ArriveTimepicker.Name = "ArriveTimepicker";
            ArriveTimepicker.Size = new Size(223, 23);
            ArriveTimepicker.TabIndex = 22;
            // 
            // DepartureTimepicker
            // 
            DepartureTimepicker.Location = new Point(496, 379);
            DepartureTimepicker.Name = "DepartureTimepicker";
            DepartureTimepicker.Size = new Size(223, 23);
            DepartureTimepicker.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS PGothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 7);
            label1.Name = "label1";
            label1.Size = new Size(656, 35);
            label1.TabIndex = 24;
            label1.Text = "Парковочная стоянка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MV Boli", 9.75F);
            label2.Location = new Point(338, 459);
            label2.Name = "label2";
            label2.Size = new Size(197, 17);
            label2.TabIndex = 25;
            label2.Text = "Общая стоимость парковки:";
            // 
            // WholeCost
            // 
            WholeCost.BackColor = SystemColors.ActiveBorder;
            WholeCost.BackgroundImage = Properties.Resources.red;
            WholeCost.Location = new Point(338, 483);
            WholeCost.Name = "WholeCost";
            WholeCost.Size = new Size(80, 27);
            WholeCost.TabIndex = 26;
            WholeCost.Text = "Вычислить";
            WholeCost.UseVisualStyleBackColor = false;
            WholeCost.Click += WholeCost_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(753, 522);
            Controls.Add(WholeCost);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DepartureTimepicker);
            Controls.Add(ArriveTimepicker);
            Controls.Add(CostLabel);
            Controls.Add(ColorLabel);
            Controls.Add(ParkingLabel);
            Controls.Add(DepartureLabel);
            Controls.Add(ArrivalLabel);
            Controls.Add(ModelLaberl);
            Controls.Add(BrandLabel);
            Controls.Add(NumberLabel);
            Controls.Add(Costtxt);
            Controls.Add(ParkingSpottxt);
            Controls.Add(DeportureTimetxt);
            Controls.Add(ArriveTimetxt);
            Controls.Add(Colourtxt);
            Controls.Add(Modeltxt);
            Controls.Add(Brandtxt);
            Controls.Add(Numbertxt);
            Controls.Add(LoadBtn);
            Controls.Add(SaveBtn);
            Controls.Add(CalculateCostBtn);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(ParkingSpotsView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Парковочная стоянка";
            ((System.ComponentModel.ISupportInitialize)ParkingSpotsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ParkingSpotsView;
        private Button AddButton;
        private Button DeleteButton;
        private Button CalculateCostBtn;
        private Button SaveBtn;
        private Button LoadBtn;
        private TextBox Numbertxt;
        private TextBox Brandtxt;
        private TextBox Modeltxt;
        private TextBox Colourtxt;
        private TextBox ArriveTimetxt;
        private TextBox DeportureTimetxt;
        private TextBox ParkingSpottxt;
        private TextBox Costtxt;
        private Label NumberLabel;
        private Label BrandLabel;
        private Label ModelLaberl;
        private Label ArrivalLabel;
        private Label DepartureLabel;
        private Label ParkingLabel;
        private Label ColorLabel;
        private Label CostLabel;
        private DateTimePicker ArriveTimepicker;
        private DateTimePicker DepartureTimepicker;
        private Label label1;
        private Label label2;
        private Button WholeCost;
    }
}
