using Candidate_BusinessObject;
using Candidate_Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRN211PE_FA24_TrialTest_HuuNam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private IHRAccountService hRAccountService;
        public MainWindow()
        {
            InitializeComponent();
            hRAccountService = new HRAccountService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            Hraccount hraccount = hRAccountService.getHRAccountByEmail(txtEmail.Text);
            if (hraccount != null && txtPassword.Password.Equals(hraccount.Password))
            {
                int? roleID = hraccount.MemberRole;
                CandidateProfileWindow profileWindow = new CandidateProfileWindow(roleID);
                profileWindow.Show();
                this.Close();

            } else
            {
                MessageBox.Show("Nuh uh");
            }

         }
    }
}