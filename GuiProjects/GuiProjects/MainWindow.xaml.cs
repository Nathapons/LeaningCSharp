using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GuiProjects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double money;
            if (txtIncome.Text == "")
            {
                MessageBox.Show("กรุณากรอกรายรับในรูปแบบตัวเลข");
                txtIncome.Text = "";
                txtIncome.Focus();
                return;
            }
            if (txtOutcome.Text == "")
            {
                MessageBox.Show("กรุณากรอกรายจ่ายในรูปแบบตัวเลข");
                txtOutcome.Text = "";
                txtOutcome.Focus();
                return;
            }
            if (txtNeedPrice.Text == "")
            {
                MessageBox.Show("กรุณากรอกรายการที่อยากได้ในรูปแบบตัวเลข");
                txtNeedPrice.Text = "";
                txtNeedPrice.Focus();
                return;
            }
            int income;
            income = int.Parse(txtIncome.Text);
            int outcome;
            outcome = int.Parse(txtOutcome.Text);
            int needPrice;
            needPrice = int.Parse(txtNeedPrice.Text);
            int remainMoney = income - outcome;
            int collectDate = needPrice / remainMoney;
            txtCollectMoney.Text = collectDate.ToString();
        }

        private void txtIncome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int money;
                if (int.TryParse(txtIncome.Text, out money) == false)
                {
                    MessageBox.Show("กรุณากรอกรายรับในรูปแบบตัวเลข");
                    txtIncome.Text = "";
                    txtIncome.Focus();
                }
                else
                {
                    txtOutcome.Focus();
                }
            }
        }

        private void txtOutcome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int money;
                if (int.TryParse(txtOutcome.Text, out money) == false)
                {
                    MessageBox.Show("กรุณากรอกรายจ่ายในรูปแบบตัวเลข");
                    txtOutcome.Text = "";
                    txtOutcome.Focus();
                }
                else
                {
                    txtNeedPrice.Focus();
                }
            }
        }

        private void txtNeedPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int money;
                if (int.TryParse(txtNeedPrice.Text, out money) == false)
                {
                    MessageBox.Show("กรุณากรอกรายารที่ต้องการในรูปแบบตัวเลข");
                    txtNeedPrice.Text = "";
                    txtNeedPrice.Focus();
                }
            }
        }
    }
}
