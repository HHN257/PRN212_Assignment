using Candidate_BusinessObject;
using Candidate_Services;
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
using System.Windows.Shapes;

namespace PRN211PE_FA24_TrialTest_HuuNam
{
    /// <summary>
    /// Interaction logic for CandidateProfileWindow.xaml
    /// </summary>
    public partial class CandidateProfileWindow : Window
    {
        private int? RoleID = 0;
        private CandidateProfileService profileService;
        private IJobPostingService jobPostingService;
        public CandidateProfileWindow()
        {
            InitializeComponent();
            profileService = new CandidateProfileService();
            jobPostingService = new JobPostingService();
        }

        public CandidateProfileWindow(int? roleID)
        {
            InitializeComponent();
            profileService = new CandidateProfileService();
            jobPostingService = new JobPostingService();
            this.RoleID = roleID;
            switch (roleID) 
            {
                case 1:
                    break;
                case 2:
                    this.btnAdd.IsEnabled = false;
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataInit();
        }

        private void LoadDataInit()
        {
            this.dtgCandidateProfile.ItemsSource = profileService.GetCandidateProfiles();
            this.cmbPostID.ItemsSource = jobPostingService.GetJobPostings();
			this.cmbPostID.DisplayMemberPath = "JobPostingTitle";
			this.cmbPostID.SelectedValuePath = "PostingId";
			//this.cmbPostID.SelectedValue = "PostingId";


			txtCandidateID.Text = "";
            txtFullname.Text = "";
            txtBirthday.Text = "";
            txtImageURL.Text = "";
            cmbPostID.SelectedValue = "";
            txtDescription.Text = "";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CandidateProfile candidate = new CandidateProfile();
                candidate.CandidateId = txtCandidateID.Text;
                candidate.Fullname = txtFullname.Text;
                candidate.Birthday = DateTime.Parse(txtBirthday.Text);
                candidate.ProfileUrl = txtImageURL.Text;
                candidate.PostingId = cmbPostID.SelectedValue.ToString();
                candidate.ProfileShortDescription = txtDescription.Text;
                if (profileService.AddCandidateProfile(candidate))
                {
                    MessageBox.Show("Added successfully !");
                    LoadDataInit();
                }
                else
                {
                    MessageBox.Show("Added failed !");
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgCandidateProfile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator
                                                    .ContainerFromIndex(dataGrid.SelectedIndex);
            if (row != null)
            {
                DataGridCell column = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
                string id = ((TextBlock)column.Content).Text;
                CandidateProfile candidateProfile = profileService.GetCandidateProfile(id);
                if (candidateProfile != null)
                {
                    txtCandidateID.IsEnabled = false;
                    txtCandidateID.IsReadOnly = true;
                    ForceCursor = true;
                    txtCandidateID.Cursor = Cursors.No;
                    txtCandidateID.Text = candidateProfile.CandidateId;
                    txtFullname.Text = candidateProfile.Fullname;
                    txtBirthday.Text = candidateProfile.Birthday.ToString();
                    txtImageURL.Text = candidateProfile.ProfileUrl;
                    cmbPostID.SelectedValue = candidateProfile.PostingId;
                    txtDescription.Text = candidateProfile.ProfileShortDescription;
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (txtCandidateID.Text.Length > 0 && profileService.DeleteCandidateProfile(txtCandidateID.Text))
            {
                string name = txtFullname.Text;
                MessageBox.Show($"Delete {name} successfull");
                LoadDataInit();
            }
            else
            {
                MessageBox.Show("Delete failed");
            }
        }


		private bool updateCandidateProfile(string id)
		{
			CandidateProfile candidateProfile = profileService.GetCandidateProfile(id);
			if (candidateProfile == null)
			{
				return false;
			}
			candidateProfile.Fullname = txtFullname.Text;
			candidateProfile.Birthday = DateTime.Parse(txtBirthday.Text);
			candidateProfile.ProfileUrl = txtImageURL.Text;
			candidateProfile.PostingId = cmbPostID.SelectedValue.ToString();
			candidateProfile.ProfileShortDescription = txtDescription.Text;
			return profileService.UpdateCandidateProfile(candidateProfile);

		}

		private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile candidate = new CandidateProfile();
            if(txtCandidateID.Text.Length > 0 && updateCandidateProfile(txtCandidateID.Text))
            {
                MessageBox.Show("Update Successfully !");
                LoadDataInit();
            } else 
            {
                MessageBox.Show("Update Failed !");
            }
        }
    }
}
