namespace WinForms
{
    partial class Matrix
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
            this.labelRowCount = new System.Windows.Forms.Label();
            this.labelColumnCount = new System.Windows.Forms.Label();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.numericUpDownRowCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColumnCount = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerateMatrix = new System.Windows.Forms.Button();
            this.buttonCountPositiveElements = new System.Windows.Forms.Button();
            this.buttonMoreOneMaximumNumbers = new System.Windows.Forms.Button();
            this.buttonCountRowsWithoutZeros = new System.Windows.Forms.Button();
            this.buttonCountRowsWithZeros = new System.Windows.Forms.Button();
            this.buttonNumberRowMaxIdenticalElements = new System.Windows.Forms.Button();
            this.buttonMultiplicationRowsWithoutNegativeElements = new System.Windows.Forms.Button();
            this.buttonMaxSumsDiagonalsParallelMain = new System.Windows.Forms.Button();
            this.buttonSumColumnsDoNotNegativeElements = new System.Windows.Forms.Button();
            this.buttonMinSumsModulesElementsDiagonalsParallelLateral = new System.Windows.Forms.Button();
            this.buttonCalculateSumColumnsNegativeElement = new System.Windows.Forms.Button();
            this.buttonTransposeMatrix = new System.Windows.Forms.Button();
            this.labelCountPositiveElements = new System.Windows.Forms.Label();
            this.labelMoreOneMaximumNumbers = new System.Windows.Forms.Label();
            this.labelCountColumnsWithoutZeros = new System.Windows.Forms.Label();
            this.labelCountRowsWithZeros = new System.Windows.Forms.Label();
            this.labelNumberRowMaxIdenticalElements = new System.Windows.Forms.Label();
            this.labelMultiplicationRowsWithoutNegativeElements = new System.Windows.Forms.Label();
            this.labelMaxSumsDiagonalsParallelMain = new System.Windows.Forms.Label();
            this.labelSumColumnsDoNotNegativeElements = new System.Windows.Forms.Label();
            this.labelMinSumsModulesElementsDiagonalsParallelLateral = new System.Windows.Forms.Label();
            this.labelCalculateSumColumnsNegativeElement = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRowCount
            // 
            this.labelRowCount.AutoSize = true;
            this.labelRowCount.Location = new System.Drawing.Point(35, 20);
            this.labelRowCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRowCount.Name = "labelRowCount";
            this.labelRowCount.Size = new System.Drawing.Size(188, 17);
            this.labelRowCount.TabIndex = 0;
            this.labelRowCount.Text = "Кількість рядків у матриці:";
            // 
            // labelColumnCount
            // 
            this.labelColumnCount.AutoSize = true;
            this.labelColumnCount.Location = new System.Drawing.Point(10, 55);
            this.labelColumnCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColumnCount.Name = "labelColumnCount";
            this.labelColumnCount.Size = new System.Drawing.Size(218, 17);
            this.labelColumnCount.TabIndex = 1;
            this.labelColumnCount.Text = "Кількість стовпчиків у матриці:";
            this.labelColumnCount.Click += new System.EventHandler(this.labelColumnCount_Click);
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix.AllowUserToOrderColumns = true;
            this.dataGridViewMatrix.AllowUserToResizeRows = false;
            this.dataGridViewMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(10, 85);
            this.dataGridViewMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersWidth = 51;
            this.dataGridViewMatrix.RowTemplate.Height = 24;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(1080, 230);
            this.dataGridViewMatrix.TabIndex = 2;
            // 
            // numericUpDownRowCount
            // 
            this.numericUpDownRowCount.Location = new System.Drawing.Point(225, 18);
            this.numericUpDownRowCount.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownRowCount.Name = "numericUpDownRowCount";
            this.numericUpDownRowCount.Size = new System.Drawing.Size(77, 25);
            this.numericUpDownRowCount.TabIndex = 3;
            this.numericUpDownRowCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownRowCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDownColumnCount
            // 
            this.numericUpDownColumnCount.Location = new System.Drawing.Point(225, 53);
            this.numericUpDownColumnCount.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownColumnCount.Name = "numericUpDownColumnCount";
            this.numericUpDownColumnCount.Size = new System.Drawing.Size(77, 25);
            this.numericUpDownColumnCount.TabIndex = 4;
            this.numericUpDownColumnCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownColumnCount.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // buttonGenerateMatrix
            // 
            this.buttonGenerateMatrix.Location = new System.Drawing.Point(336, 18);
            this.buttonGenerateMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateMatrix.Name = "buttonGenerateMatrix";
            this.buttonGenerateMatrix.Size = new System.Drawing.Size(146, 60);
            this.buttonGenerateMatrix.TabIndex = 5;
            this.buttonGenerateMatrix.Text = "Згенерувати матрицю";
            this.buttonGenerateMatrix.UseVisualStyleBackColor = true;
            this.buttonGenerateMatrix.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonCountPositiveElements
            // 
            this.buttonCountPositiveElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCountPositiveElements.Location = new System.Drawing.Point(10, 330);
            this.buttonCountPositiveElements.Name = "buttonCountPositiveElements";
            this.buttonCountPositiveElements.Size = new System.Drawing.Size(650, 30);
            this.buttonCountPositiveElements.TabIndex = 6;
            this.buttonCountPositiveElements.Text = "Порахувати кількість додатних елементів";
            this.buttonCountPositiveElements.UseVisualStyleBackColor = true;
            this.buttonCountPositiveElements.Click += new System.EventHandler(this.buttonCountPositiveElements_Click);
            // 
            // buttonMoreOneMaximumNumbers
            // 
            this.buttonMoreOneMaximumNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMoreOneMaximumNumbers.Location = new System.Drawing.Point(10, 370);
            this.buttonMoreOneMaximumNumbers.Name = "buttonMoreOneMaximumNumbers";
            this.buttonMoreOneMaximumNumbers.Size = new System.Drawing.Size(650, 30);
            this.buttonMoreOneMaximumNumbers.TabIndex = 7;
            this.buttonMoreOneMaximumNumbers.Text = "Знайти максимальне із чисел, що зустрічається в заданій матриці більше одного раз" +
    "у";
            this.buttonMoreOneMaximumNumbers.UseVisualStyleBackColor = true;
            this.buttonMoreOneMaximumNumbers.Click += new System.EventHandler(this.buttonMoreOneMaximumNumbers_Click);
            // 
            // buttonCountRowsWithoutZeros
            // 
            this.buttonCountRowsWithoutZeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCountRowsWithoutZeros.Location = new System.Drawing.Point(10, 410);
            this.buttonCountRowsWithoutZeros.Name = "buttonCountRowsWithoutZeros";
            this.buttonCountRowsWithoutZeros.Size = new System.Drawing.Size(650, 30);
            this.buttonCountRowsWithoutZeros.TabIndex = 8;
            this.buttonCountRowsWithoutZeros.Text = "Порахувати кількість рядків, які не містять жодного нульового елемента";
            this.buttonCountRowsWithoutZeros.UseVisualStyleBackColor = true;
            this.buttonCountRowsWithoutZeros.Click += new System.EventHandler(this.buttonCountRowsWithoutZeros_Click);
            // 
            // buttonCountRowsWithZeros
            // 
            this.buttonCountRowsWithZeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCountRowsWithZeros.Location = new System.Drawing.Point(10, 450);
            this.buttonCountRowsWithZeros.Name = "buttonCountRowsWithZeros";
            this.buttonCountRowsWithZeros.Size = new System.Drawing.Size(650, 30);
            this.buttonCountRowsWithZeros.TabIndex = 9;
            this.buttonCountRowsWithZeros.Text = "Порахувати кількість стовпців, які містять хоча б один нульовий елемент";
            this.buttonCountRowsWithZeros.UseVisualStyleBackColor = true;
            this.buttonCountRowsWithZeros.Click += new System.EventHandler(this.buttonCountRowsWithZeros_Click);
            // 
            // buttonNumberRowMaxIdenticalElements
            // 
            this.buttonNumberRowMaxIdenticalElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNumberRowMaxIdenticalElements.Location = new System.Drawing.Point(10, 490);
            this.buttonNumberRowMaxIdenticalElements.Name = "buttonNumberRowMaxIdenticalElements";
            this.buttonNumberRowMaxIdenticalElements.Size = new System.Drawing.Size(650, 30);
            this.buttonNumberRowMaxIdenticalElements.TabIndex = 10;
            this.buttonNumberRowMaxIdenticalElements.Text = "Знайти номер рядка, в якому знаходиться найдовша серія однакових елементів";
            this.buttonNumberRowMaxIdenticalElements.UseVisualStyleBackColor = true;
            this.buttonNumberRowMaxIdenticalElements.Click += new System.EventHandler(this.buttonNumberRowMaxIdenticalElements_Click);
            // 
            // buttonMultiplicationRowsWithoutNegativeElements
            // 
            this.buttonMultiplicationRowsWithoutNegativeElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMultiplicationRowsWithoutNegativeElements.Location = new System.Drawing.Point(10, 530);
            this.buttonMultiplicationRowsWithoutNegativeElements.Name = "buttonMultiplicationRowsWithoutNegativeElements";
            this.buttonMultiplicationRowsWithoutNegativeElements.Size = new System.Drawing.Size(650, 30);
            this.buttonMultiplicationRowsWithoutNegativeElements.TabIndex = 11;
            this.buttonMultiplicationRowsWithoutNegativeElements.Text = "Обчислити добуток елементів в тих рядках, які не містять від’ємних елементів";
            this.buttonMultiplicationRowsWithoutNegativeElements.UseVisualStyleBackColor = true;
            this.buttonMultiplicationRowsWithoutNegativeElements.Click += new System.EventHandler(this.buttonMultiplicationRowsWithoutNegativeElements_Click);
            // 
            // buttonMaxSumsDiagonalsParallelMain
            // 
            this.buttonMaxSumsDiagonalsParallelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMaxSumsDiagonalsParallelMain.Location = new System.Drawing.Point(10, 570);
            this.buttonMaxSumsDiagonalsParallelMain.Name = "buttonMaxSumsDiagonalsParallelMain";
            this.buttonMaxSumsDiagonalsParallelMain.Size = new System.Drawing.Size(650, 30);
            this.buttonMaxSumsDiagonalsParallelMain.TabIndex = 12;
            this.buttonMaxSumsDiagonalsParallelMain.Text = "Знайти максимум серед сум елементів діагоналей, паралельних головній діагоналі ма" +
    "триці";
            this.buttonMaxSumsDiagonalsParallelMain.UseVisualStyleBackColor = true;
            this.buttonMaxSumsDiagonalsParallelMain.Click += new System.EventHandler(this.buttonMaxSumsDiagonalsParallelMain_Click);
            // 
            // buttonSumColumnsDoNotNegativeElements
            // 
            this.buttonSumColumnsDoNotNegativeElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSumColumnsDoNotNegativeElements.Location = new System.Drawing.Point(10, 610);
            this.buttonSumColumnsDoNotNegativeElements.Name = "buttonSumColumnsDoNotNegativeElements";
            this.buttonSumColumnsDoNotNegativeElements.Size = new System.Drawing.Size(650, 30);
            this.buttonSumColumnsDoNotNegativeElements.TabIndex = 13;
            this.buttonSumColumnsDoNotNegativeElements.Text = "Обчислити суму елементів в тих стовпцях, які не містять від’ємних елементів";
            this.buttonSumColumnsDoNotNegativeElements.UseVisualStyleBackColor = true;
            this.buttonSumColumnsDoNotNegativeElements.Click += new System.EventHandler(this.buttonSumColumnsDoNotNegativeElements_Click);
            // 
            // buttonMinSumsModulesElementsDiagonalsParallelLateral
            // 
            this.buttonMinSumsModulesElementsDiagonalsParallelLateral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMinSumsModulesElementsDiagonalsParallelLateral.Location = new System.Drawing.Point(10, 650);
            this.buttonMinSumsModulesElementsDiagonalsParallelLateral.Name = "buttonMinSumsModulesElementsDiagonalsParallelLateral";
            this.buttonMinSumsModulesElementsDiagonalsParallelLateral.Size = new System.Drawing.Size(650, 30);
            this.buttonMinSumsModulesElementsDiagonalsParallelLateral.TabIndex = 14;
            this.buttonMinSumsModulesElementsDiagonalsParallelLateral.Text = "Знайти мінімум серед сум модулів елементів діагоналей, паралельних побічній діаго" +
    "налі матриці";
            this.buttonMinSumsModulesElementsDiagonalsParallelLateral.UseVisualStyleBackColor = true;
            this.buttonMinSumsModulesElementsDiagonalsParallelLateral.Click += new System.EventHandler(this.buttonMinSumsModulesElementsDiagonalsParallelLateral_Click);
            // 
            // buttonCalculateSumColumnsNegativeElement
            // 
            this.buttonCalculateSumColumnsNegativeElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCalculateSumColumnsNegativeElement.Location = new System.Drawing.Point(10, 690);
            this.buttonCalculateSumColumnsNegativeElement.Name = "buttonCalculateSumColumnsNegativeElement";
            this.buttonCalculateSumColumnsNegativeElement.Size = new System.Drawing.Size(650, 30);
            this.buttonCalculateSumColumnsNegativeElement.TabIndex = 15;
            this.buttonCalculateSumColumnsNegativeElement.Text = "Обчислити суму елементів в тих стовпцях, які  містять хоча б один від’ємний елеме" +
    "нт";
            this.buttonCalculateSumColumnsNegativeElement.UseVisualStyleBackColor = true;
            this.buttonCalculateSumColumnsNegativeElement.Click += new System.EventHandler(this.buttonCalculateSumColumnsNegativeElement_Click);
            // 
            // buttonTransposeMatrix
            // 
            this.buttonTransposeMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTransposeMatrix.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonTransposeMatrix.Location = new System.Drawing.Point(10, 741);
            this.buttonTransposeMatrix.Name = "buttonTransposeMatrix";
            this.buttonTransposeMatrix.Size = new System.Drawing.Size(650, 30);
            this.buttonTransposeMatrix.TabIndex = 16;
            this.buttonTransposeMatrix.Text = "Транспонувати матрицю";
            this.buttonTransposeMatrix.UseVisualStyleBackColor = false;
            this.buttonTransposeMatrix.Click += new System.EventHandler(this.buttonTransposeMatrix_Click);
            // 
            // labelCountPositiveElements
            // 
            this.labelCountPositiveElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountPositiveElements.AutoSize = true;
            this.labelCountPositiveElements.Location = new System.Drawing.Point(667, 337);
            this.labelCountPositiveElements.Name = "labelCountPositiveElements";
            this.labelCountPositiveElements.Size = new System.Drawing.Size(173, 17);
            this.labelCountPositiveElements.TabIndex = 17;
            this.labelCountPositiveElements.Text = "= CountPositiveElements";
            this.labelCountPositiveElements.Visible = false;
            // 
            // labelMoreOneMaximumNumbers
            // 
            this.labelMoreOneMaximumNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMoreOneMaximumNumbers.AutoSize = true;
            this.labelMoreOneMaximumNumbers.Location = new System.Drawing.Point(667, 377);
            this.labelMoreOneMaximumNumbers.Name = "labelMoreOneMaximumNumbers";
            this.labelMoreOneMaximumNumbers.Size = new System.Drawing.Size(204, 17);
            this.labelMoreOneMaximumNumbers.TabIndex = 18;
            this.labelMoreOneMaximumNumbers.Text = "= MoreOneMaximumNumbers";
            this.labelMoreOneMaximumNumbers.Visible = false;
            this.labelMoreOneMaximumNumbers.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCountColumnsWithoutZeros
            // 
            this.labelCountColumnsWithoutZeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountColumnsWithoutZeros.AutoSize = true;
            this.labelCountColumnsWithoutZeros.Location = new System.Drawing.Point(666, 417);
            this.labelCountColumnsWithoutZeros.Name = "labelCountColumnsWithoutZeros";
            this.labelCountColumnsWithoutZeros.Size = new System.Drawing.Size(206, 17);
            this.labelCountColumnsWithoutZeros.TabIndex = 19;
            this.labelCountColumnsWithoutZeros.Text = "= CountColumnsWithoutZeros";
            this.labelCountColumnsWithoutZeros.Visible = false;
            // 
            // labelCountRowsWithZeros
            // 
            this.labelCountRowsWithZeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountRowsWithZeros.AutoSize = true;
            this.labelCountRowsWithZeros.Location = new System.Drawing.Point(667, 457);
            this.labelCountRowsWithZeros.Name = "labelCountRowsWithZeros";
            this.labelCountRowsWithZeros.Size = new System.Drawing.Size(165, 17);
            this.labelCountRowsWithZeros.TabIndex = 20;
            this.labelCountRowsWithZeros.Text = "= CountRowsWithZeros";
            this.labelCountRowsWithZeros.Visible = false;
            // 
            // labelNumberRowMaxIdenticalElements
            // 
            this.labelNumberRowMaxIdenticalElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNumberRowMaxIdenticalElements.AutoSize = true;
            this.labelNumberRowMaxIdenticalElements.Location = new System.Drawing.Point(667, 497);
            this.labelNumberRowMaxIdenticalElements.Name = "labelNumberRowMaxIdenticalElements";
            this.labelNumberRowMaxIdenticalElements.Size = new System.Drawing.Size(244, 17);
            this.labelNumberRowMaxIdenticalElements.TabIndex = 21;
            this.labelNumberRowMaxIdenticalElements.Text = "= NumberRowMaxIdenticalElements";
            this.labelNumberRowMaxIdenticalElements.Visible = false;
            this.labelNumberRowMaxIdenticalElements.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelMultiplicationRowsWithoutNegativeElements
            // 
            this.labelMultiplicationRowsWithoutNegativeElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMultiplicationRowsWithoutNegativeElements.AutoSize = true;
            this.labelMultiplicationRowsWithoutNegativeElements.Location = new System.Drawing.Point(667, 537);
            this.labelMultiplicationRowsWithoutNegativeElements.Name = "labelMultiplicationRowsWithoutNegativeElements";
            this.labelMultiplicationRowsWithoutNegativeElements.Size = new System.Drawing.Size(309, 17);
            this.labelMultiplicationRowsWithoutNegativeElements.TabIndex = 22;
            this.labelMultiplicationRowsWithoutNegativeElements.Text = "= MultiplicationRowsWithoutNegativeElements";
            this.labelMultiplicationRowsWithoutNegativeElements.Visible = false;
            // 
            // labelMaxSumsDiagonalsParallelMain
            // 
            this.labelMaxSumsDiagonalsParallelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMaxSumsDiagonalsParallelMain.AutoSize = true;
            this.labelMaxSumsDiagonalsParallelMain.Location = new System.Drawing.Point(667, 577);
            this.labelMaxSumsDiagonalsParallelMain.Name = "labelMaxSumsDiagonalsParallelMain";
            this.labelMaxSumsDiagonalsParallelMain.Size = new System.Drawing.Size(229, 17);
            this.labelMaxSumsDiagonalsParallelMain.TabIndex = 23;
            this.labelMaxSumsDiagonalsParallelMain.Text = "= MaxSumsDiagonalsParallelMain";
            this.labelMaxSumsDiagonalsParallelMain.Visible = false;
            // 
            // labelSumColumnsDoNotNegativeElements
            // 
            this.labelSumColumnsDoNotNegativeElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSumColumnsDoNotNegativeElements.AutoSize = true;
            this.labelSumColumnsDoNotNegativeElements.Location = new System.Drawing.Point(667, 617);
            this.labelSumColumnsDoNotNegativeElements.Name = "labelSumColumnsDoNotNegativeElements";
            this.labelSumColumnsDoNotNegativeElements.Size = new System.Drawing.Size(270, 17);
            this.labelSumColumnsDoNotNegativeElements.TabIndex = 24;
            this.labelSumColumnsDoNotNegativeElements.Text = "= SumColumnsDoNotNegativeElements";
            this.labelSumColumnsDoNotNegativeElements.Visible = false;
            // 
            // labelMinSumsModulesElementsDiagonalsParallelLateral
            // 
            this.labelMinSumsModulesElementsDiagonalsParallelLateral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMinSumsModulesElementsDiagonalsParallelLateral.AutoSize = true;
            this.labelMinSumsModulesElementsDiagonalsParallelLateral.Location = new System.Drawing.Point(667, 657);
            this.labelMinSumsModulesElementsDiagonalsParallelLateral.Name = "labelMinSumsModulesElementsDiagonalsParallelLateral";
            this.labelMinSumsModulesElementsDiagonalsParallelLateral.Size = new System.Drawing.Size(355, 17);
            this.labelMinSumsModulesElementsDiagonalsParallelLateral.TabIndex = 25;
            this.labelMinSumsModulesElementsDiagonalsParallelLateral.Text = "= MinSumsModulesElementsDiagonalsParallelLateral";
            this.labelMinSumsModulesElementsDiagonalsParallelLateral.Visible = false;
            // 
            // labelCalculateSumColumnsNegativeElement
            // 
            this.labelCalculateSumColumnsNegativeElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCalculateSumColumnsNegativeElement.AutoSize = true;
            this.labelCalculateSumColumnsNegativeElement.Location = new System.Drawing.Point(667, 697);
            this.labelCalculateSumColumnsNegativeElement.Name = "labelCalculateSumColumnsNegativeElement";
            this.labelCalculateSumColumnsNegativeElement.Size = new System.Drawing.Size(282, 17);
            this.labelCalculateSumColumnsNegativeElement.TabIndex = 26;
            this.labelCalculateSumColumnsNegativeElement.Text = "= CalculateSumColumnsNegativeElement";
            this.labelCalculateSumColumnsNegativeElement.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonExit.Location = new System.Drawing.Point(1015, 741);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 30);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Matrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 783);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelCalculateSumColumnsNegativeElement);
            this.Controls.Add(this.labelMinSumsModulesElementsDiagonalsParallelLateral);
            this.Controls.Add(this.labelSumColumnsDoNotNegativeElements);
            this.Controls.Add(this.labelMaxSumsDiagonalsParallelMain);
            this.Controls.Add(this.labelMultiplicationRowsWithoutNegativeElements);
            this.Controls.Add(this.labelNumberRowMaxIdenticalElements);
            this.Controls.Add(this.labelCountRowsWithZeros);
            this.Controls.Add(this.labelCountColumnsWithoutZeros);
            this.Controls.Add(this.labelMoreOneMaximumNumbers);
            this.Controls.Add(this.labelCountPositiveElements);
            this.Controls.Add(this.buttonTransposeMatrix);
            this.Controls.Add(this.buttonCalculateSumColumnsNegativeElement);
            this.Controls.Add(this.buttonMinSumsModulesElementsDiagonalsParallelLateral);
            this.Controls.Add(this.buttonSumColumnsDoNotNegativeElements);
            this.Controls.Add(this.buttonMaxSumsDiagonalsParallelMain);
            this.Controls.Add(this.buttonMultiplicationRowsWithoutNegativeElements);
            this.Controls.Add(this.buttonNumberRowMaxIdenticalElements);
            this.Controls.Add(this.buttonCountRowsWithZeros);
            this.Controls.Add(this.buttonCountRowsWithoutZeros);
            this.Controls.Add(this.buttonMoreOneMaximumNumbers);
            this.Controls.Add(this.buttonCountPositiveElements);
            this.Controls.Add(this.buttonGenerateMatrix);
            this.Controls.Add(this.numericUpDownColumnCount);
            this.Controls.Add(this.numericUpDownRowCount);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.labelColumnCount);
            this.Controls.Add(this.labelRowCount);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1120, 830);
            this.Name = "Matrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Робота з матрицею";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRowCount;
        private System.Windows.Forms.Label labelColumnCount;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.NumericUpDown numericUpDownRowCount;
        private System.Windows.Forms.NumericUpDown numericUpDownColumnCount;
        private System.Windows.Forms.Button buttonGenerateMatrix;
        private System.Windows.Forms.Button buttonCountPositiveElements;
        private System.Windows.Forms.Button buttonMoreOneMaximumNumbers;
        private System.Windows.Forms.Button buttonCountRowsWithoutZeros;
        private System.Windows.Forms.Button buttonCountRowsWithZeros;
        private System.Windows.Forms.Button buttonNumberRowMaxIdenticalElements;
        private System.Windows.Forms.Button buttonMultiplicationRowsWithoutNegativeElements;
        private System.Windows.Forms.Button buttonMaxSumsDiagonalsParallelMain;
        private System.Windows.Forms.Button buttonSumColumnsDoNotNegativeElements;
        private System.Windows.Forms.Button buttonMinSumsModulesElementsDiagonalsParallelLateral;
        private System.Windows.Forms.Button buttonCalculateSumColumnsNegativeElement;
        private System.Windows.Forms.Button buttonTransposeMatrix;
        private System.Windows.Forms.Label labelCountPositiveElements;
        private System.Windows.Forms.Label labelMoreOneMaximumNumbers;
        private System.Windows.Forms.Label labelCountColumnsWithoutZeros;
        private System.Windows.Forms.Label labelCountRowsWithZeros;
        private System.Windows.Forms.Label labelNumberRowMaxIdenticalElements;
        private System.Windows.Forms.Label labelMultiplicationRowsWithoutNegativeElements;
        private System.Windows.Forms.Label labelMaxSumsDiagonalsParallelMain;
        private System.Windows.Forms.Label labelSumColumnsDoNotNegativeElements;
        private System.Windows.Forms.Label labelMinSumsModulesElementsDiagonalsParallelLateral;
        private System.Windows.Forms.Label labelCalculateSumColumnsNegativeElement;
        private System.Windows.Forms.Button buttonExit;
    }
}

