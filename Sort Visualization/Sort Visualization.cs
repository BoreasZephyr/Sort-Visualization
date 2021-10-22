using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;

namespace Sort_Visualization
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private const int MAXCOL = 10;
        private List<string> dulieu = new List<string>();
        private ToolTip toolTip = new ToolTip();

        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            TaoCot();
            AddRandomDataToTB();
            HienThiCot();
            
        }

        private void btEnterData_Click(object sender, EventArgs e)
        {
            AddRandomDataToTB();
            HienThiCot();
        }

        private Thread threadBubble;
        private Thread threadSelect;
        private Thread threadInsert;
        private Thread threadEnable;

        private void btSort_Click(object sender, EventArgs e)
        {
            HienThiCot();
            DisableControl();
            threadBubble = new Thread(() => SortControl.BubbleSort(dulieu, lbCol));
            threadSelect = new Thread(() => SortControl.SelectionSort(dulieu, lbCol));
            threadInsert = new Thread(() => SortControl.InsertionSort(dulieu, lbCol));

            if (rdbtBubbleSort.Checked)
            {
                rdbtBubbleSort.Enabled = true;
                rdbtInsertionSort.Enabled = false;
                rdbtSlectionSort.Enabled = false;

                threadBubble.IsBackground = true;
                threadBubble.Start();
            }
            else if (rdbtSlectionSort.Checked)
            {
                rdbtBubbleSort.Enabled = false;
                rdbtInsertionSort.Enabled = false;
                rdbtSlectionSort.Enabled = true;

                threadSelect.IsBackground = true;
                threadSelect.Start();
            }
            else if (rdbtInsertionSort.Checked)
            {
                rdbtBubbleSort.Enabled = false;
                rdbtInsertionSort.Enabled = true;
                rdbtSlectionSort.Enabled = false;

                threadInsert.IsBackground = true;
                threadInsert.Start();
            }

            threadEnable = new Thread(EnableControl);
            threadEnable.IsBackground = true;
            threadEnable.Start();

        }

        private void DisableControl()
        {
            tbSortData.Enabled = false;
            btEnterData.Enabled = false;
            btSort.Enabled = false;
            btStopSort.Enabled = true;
        }

        private void EnableControl()
        {
            while (true)
            {
                if (threadBubble.IsAlive == false && threadSelect.IsAlive == false && threadInsert.IsAlive == false)
                {
                    tbSortData.Enabled = true;
                    btEnterData.Enabled = true;
                    btSort.Enabled = true;
                    btStopSort.Enabled = true;
                    rdbtBubbleSort.Enabled = true;
                    rdbtInsertionSort.Enabled = true;
                    rdbtSlectionSort.Enabled = true;
                    break;
                }
            }
        }

        private void stopSort_Click(object sender, EventArgs e)
        {

            if (rdbtBubbleSort.Checked)
                threadBubble.Abort();
            else if (rdbtSlectionSort.Checked)
                threadSelect.Abort();
            else if (rdbtInsertionSort.Checked)
                threadInsert.Abort();
        }

        private void TaoCot()
        {
            for (int i = 0; i < MAXCOL; i++)
            {
                lbCol[i] = new MetroFramework.Controls.MetroLabel();
                panelAnimationArea.Controls.Add(lbCol[i]);
                lbCol[i].BackColor = Color.Teal;
                lbCol[i].FontWeight = MetroLabelWeight.Bold;
                lbCol[i].ForeColor = SystemColors.ControlText;
                lbCol[i].Theme = MetroThemeStyle.Dark;
                lbCol[i].TabIndex = 1;
                lbCol[i].TextAlign = ContentAlignment.MiddleCenter;
                lbCol[i].UseCustomBackColor = true;
                lbCol[i].UseCustomForeColor = true;
                lbCol[i].Visible = false;
            }
        }

        private void HienThiCot()
        {
            int khoangCachCot = 20;
            int chieuRongCot;
            int chieuDaiMotDV = 7;
            int chieuRongKhung = 1053;
            int chieuCaoKhung = 400;

            dulieu = tbSortData.Text.Split(',').ToList();
            int soCot = dulieu.Count;
            int y, chieuCaoCot;
            for (int i = 0; i < MAXCOL; i++)
            {
                lbCol[i].Visible = false;
                lbCol[i].BackColor = Color.Teal;
            }
            chieuCaoCot = 20 + chieuDaiMotDV * 8;
            chieuRongCot = chieuCaoCot;
            y = (chieuCaoKhung / 2) - (chieuCaoCot / 2);
            int x = chieuRongKhung / 2 - (chieuRongCot * soCot + khoangCachCot * (soCot - 1)) / 2 - chieuRongCot - khoangCachCot;
            // hien thi o
            for (int i = 0; i < soCot; i++)
            {
                x += chieuRongCot + khoangCachCot;
                lbCol[i].Location = new Point(x, y);
                lbCol[i].Size = new Size(chieuRongCot, chieuCaoCot);
                lbCol[i].Text = dulieu[i];
                lbCol[i].Visible = true;
            }
        }

        private void AddRandomDataToTB()
        {
            List<int> list = new List<int>();
            RandomList.CreateRandom(list, 1, 50);
            Random rand = new Random();
            int soCot = rand.Next(5, MAXCOL);
            tbSortData.Text = "";
            for (int i = 1; i <= soCot; i++)
            {
                if (i == soCot)
                    tbSortData.Text = tbSortData.Text + Convert.ToString(list[i]);
                else
                    tbSortData.Text = tbSortData.Text + Convert.ToString(list[i]) + ",";
            }
        }

        private void tbSortData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            int t;
            dulieu = tbSortData.Text.Split(',').ToList();
            int soCot = dulieu.Count;

            for (int i = 0; i < soCot; i++)
            {
                if (!int.TryParse(dulieu[i], out t) || int.Parse(dulieu[i]) > 50 || soCot > MAXCOL || soCot < 5)
                {
                    MetroMessageBox.Show(this, "Lỗi nhập liệu\n- Dữ liệu là các con số được phân tách bằng dấu phẩy\n- Mỗi con số không được lớn hơn 50\n- Số lượng các con số tối thiểu là 5 và lớn nhất là 10", "Sort Visualization", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            HienThiCot();
        }

        private void toggleTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (!toggleTheme.Checked)
            {
                this.Theme = MetroThemeStyle.Light;
                rdbtBubbleSort.Theme = MetroThemeStyle.Light;
                rdbtInsertionSort.Theme = MetroThemeStyle.Light;
                rdbtSlectionSort.Theme = MetroThemeStyle.Light;
                panelAnimationArea.Theme = MetroThemeStyle.Light;
                tbSortData.Theme = MetroThemeStyle.Light;
                btSort.Theme = MetroThemeStyle.Light;
                btEnterData.Theme = MetroThemeStyle.Light;
                lbTextAuthor.Theme = MetroThemeStyle.Light;
                lbTextTheme.Theme = MetroThemeStyle.Light;
                toggleTheme.Theme = MetroThemeStyle.Light;
            }
            else
            {
                this.Theme = MetroThemeStyle.Dark;
                rdbtBubbleSort.Theme = MetroThemeStyle.Dark;
                rdbtInsertionSort.Theme = MetroThemeStyle.Dark;
                rdbtSlectionSort.Theme = MetroThemeStyle.Dark;
                panelAnimationArea.Theme = MetroThemeStyle.Dark;
                tbSortData.Theme = MetroThemeStyle.Dark;
                btSort.Theme = MetroThemeStyle.Dark;
                btEnterData.Theme = MetroThemeStyle.Dark;
                lbTextAuthor.Theme = MetroThemeStyle.Dark;
                lbTextTheme.Theme = MetroThemeStyle.Dark;
                toggleTheme.Theme = MetroThemeStyle.Dark;

            }
            this.Refresh();
        }



    }
}
