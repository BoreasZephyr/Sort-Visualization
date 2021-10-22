namespace Sort_Visualization
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rdbtBubbleSort = new MetroFramework.Controls.MetroRadioButton();
            this.rdbtSlectionSort = new MetroFramework.Controls.MetroRadioButton();
            this.rdbtInsertionSort = new MetroFramework.Controls.MetroRadioButton();
            this.panelAnimationArea = new MetroFramework.Controls.MetroPanel();
            this.tbSortData = new MetroFramework.Controls.MetroTextBox();
            this.btEnterData = new MetroFramework.Controls.MetroButton();
            this.btSort = new MetroFramework.Controls.MetroButton();
            this.lbTextAuthor = new MetroFramework.Controls.MetroLabel();
            this.toggleTheme = new MetroFramework.Controls.MetroToggle();
            this.lbTextTheme = new MetroFramework.Controls.MetroLabel();
            this.btStopSort = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // rdbtBubbleSort
            // 
            this.rdbtBubbleSort.AutoSize = true;
            this.rdbtBubbleSort.Checked = true;
            this.rdbtBubbleSort.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdbtBubbleSort.Location = new System.Drawing.Point(239, 31);
            this.rdbtBubbleSort.Name = "rdbtBubbleSort";
            this.rdbtBubbleSort.Size = new System.Drawing.Size(103, 20);
            this.rdbtBubbleSort.TabIndex = 4;
            this.rdbtBubbleSort.TabStop = true;
            this.rdbtBubbleSort.Text = "Bubble Sort";
            this.rdbtBubbleSort.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rdbtBubbleSort.UseSelectable = true;
            // 
            // rdbtSlectionSort
            // 
            this.rdbtSlectionSort.AutoSize = true;
            this.rdbtSlectionSort.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdbtSlectionSort.Location = new System.Drawing.Point(389, 31);
            this.rdbtSlectionSort.Name = "rdbtSlectionSort";
            this.rdbtSlectionSort.Size = new System.Drawing.Size(117, 20);
            this.rdbtSlectionSort.TabIndex = 5;
            this.rdbtSlectionSort.Text = "Selection Sort";
            this.rdbtSlectionSort.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rdbtSlectionSort.UseSelectable = true;
            // 
            // rdbtInsertionSort
            // 
            this.rdbtInsertionSort.AutoSize = true;
            this.rdbtInsertionSort.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdbtInsertionSort.Location = new System.Drawing.Point(545, 31);
            this.rdbtInsertionSort.Name = "rdbtInsertionSort";
            this.rdbtInsertionSort.Size = new System.Drawing.Size(113, 20);
            this.rdbtInsertionSort.TabIndex = 6;
            this.rdbtInsertionSort.Text = "Insertion Sort";
            this.rdbtInsertionSort.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rdbtInsertionSort.UseSelectable = true;
            // 
            // panelAnimationArea
            // 
            this.panelAnimationArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAnimationArea.HorizontalScrollbarBarColor = true;
            this.panelAnimationArea.HorizontalScrollbarHighlightOnWheel = false;
            this.panelAnimationArea.HorizontalScrollbarSize = 10;
            this.panelAnimationArea.Location = new System.Drawing.Point(21, 92);
            this.panelAnimationArea.Name = "panelAnimationArea";
            this.panelAnimationArea.Size = new System.Drawing.Size(1053, 400);
            this.panelAnimationArea.TabIndex = 100;
            this.panelAnimationArea.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelAnimationArea.VerticalScrollbarBarColor = true;
            this.panelAnimationArea.VerticalScrollbarHighlightOnWheel = false;
            this.panelAnimationArea.VerticalScrollbarSize = 10;
            // 
            // tbSortData
            // 
            // 
            // 
            // 
            this.tbSortData.CustomButton.Image = null;
            this.tbSortData.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.tbSortData.CustomButton.Name = "";
            this.tbSortData.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSortData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSortData.CustomButton.TabIndex = 3;
            this.tbSortData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSortData.CustomButton.UseSelectable = true;
            this.tbSortData.CustomButton.Visible = false;
            this.tbSortData.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbSortData.Lines = new string[0];
            this.tbSortData.Location = new System.Drawing.Point(21, 523);
            this.tbSortData.MaxLength = 32767;
            this.tbSortData.Name = "tbSortData";
            this.tbSortData.PasswordChar = '\0';
            this.tbSortData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSortData.SelectedText = "";
            this.tbSortData.SelectionLength = 0;
            this.tbSortData.SelectionStart = 0;
            this.tbSortData.ShortcutsEnabled = true;
            this.tbSortData.Size = new System.Drawing.Size(281, 23);
            this.tbSortData.TabIndex = 0;
            this.tbSortData.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSortData.UseSelectable = true;
            this.tbSortData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSortData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSortData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSortData_KeyDown);
            // 
            // btEnterData
            // 
            this.btEnterData.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btEnterData.Location = new System.Drawing.Point(308, 523);
            this.btEnterData.Name = "btEnterData";
            this.btEnterData.Size = new System.Drawing.Size(75, 23);
            this.btEnterData.TabIndex = 1;
            this.btEnterData.Text = "Random";
            this.btEnterData.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btEnterData.UseSelectable = true;
            this.btEnterData.Click += new System.EventHandler(this.btEnterData_Click);
            // 
            // btSort
            // 
            this.btSort.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSort.Location = new System.Drawing.Point(389, 523);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(75, 23);
            this.btSort.TabIndex = 2;
            this.btSort.Text = "Sort";
            this.btSort.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btSort.UseSelectable = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // lbTextAuthor
            // 
            this.lbTextAuthor.AutoSize = true;
            this.lbTextAuthor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbTextAuthor.Location = new System.Drawing.Point(773, 559);
            this.lbTextAuthor.Name = "lbTextAuthor";
            this.lbTextAuthor.Size = new System.Drawing.Size(299, 20);
            this.lbTextAuthor.TabIndex = 100;
            this.lbTextAuthor.Text = "Nhóm 12: Phạm Ngọc Đức - Mai Thanh Nhã";
            this.lbTextAuthor.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleTheme
            // 
            this.toggleTheme.Checked = true;
            this.toggleTheme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleTheme.Location = new System.Drawing.Point(999, 523);
            this.toggleTheme.Name = "toggleTheme";
            this.toggleTheme.Size = new System.Drawing.Size(73, 20);
            this.toggleTheme.TabIndex = 101;
            this.toggleTheme.Text = "On";
            this.toggleTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleTheme.UseSelectable = true;
            this.toggleTheme.CheckedChanged += new System.EventHandler(this.toggleTheme_CheckedChanged);
            // 
            // lbTextTheme
            // 
            this.lbTextTheme.AutoSize = true;
            this.lbTextTheme.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbTextTheme.Location = new System.Drawing.Point(904, 523);
            this.lbTextTheme.Name = "lbTextTheme";
            this.lbTextTheme.Size = new System.Drawing.Size(89, 20);
            this.lbTextTheme.TabIndex = 102;
            this.lbTextTheme.Text = "Dark Theme";
            this.lbTextTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btStopSort
            // 
            this.btStopSort.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btStopSort.Location = new System.Drawing.Point(470, 523);
            this.btStopSort.Name = "btStopSort";
            this.btStopSort.Size = new System.Drawing.Size(75, 23);
            this.btStopSort.TabIndex = 103;
            this.btStopSort.Text = "Stop";
            this.btStopSort.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btStopSort.UseSelectable = true;
            this.btStopSort.Click += new System.EventHandler(this.stopSort_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 599);
            this.Controls.Add(this.btStopSort);
            this.Controls.Add(this.lbTextTheme);
            this.Controls.Add(this.toggleTheme);
            this.Controls.Add(this.lbTextAuthor);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btEnterData);
            this.Controls.Add(this.tbSortData);
            this.Controls.Add(this.panelAnimationArea);
            this.Controls.Add(this.rdbtInsertionSort);
            this.Controls.Add(this.rdbtSlectionSort);
            this.Controls.Add(this.rdbtBubbleSort);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(18, 64, 18, 21);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Sort Visualization";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton rdbtBubbleSort;
        private MetroFramework.Controls.MetroRadioButton rdbtSlectionSort;
        private MetroFramework.Controls.MetroRadioButton rdbtInsertionSort;
        private MetroFramework.Controls.MetroTextBox tbSortData;
        private MetroFramework.Controls.MetroButton btEnterData;
        private MetroFramework.Controls.MetroButton btSort;
        private MetroFramework.Controls.MetroLabel lbTextAuthor;
        private MetroFramework.Controls.MetroPanel panelAnimationArea;
        private MetroFramework.Controls.MetroLabel[] lbCol = new MetroFramework.Controls.MetroLabel[MAXCOL];
        private MetroFramework.Controls.MetroToggle toggleTheme;
        private MetroFramework.Controls.MetroLabel lbTextTheme;
        private MetroFramework.Controls.MetroButton btStopSort;
    }
}

