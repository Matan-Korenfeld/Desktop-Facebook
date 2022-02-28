﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FaceBookAppLogic;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "507070034420577";
        private const string k_ErrorMessage = "You need to be logged in";
        private const string k_TypeOfMessage = "Error";
        private static readonly string[] sr_Permissions = { "public_profile", "user_birthday", "user_friends", "user_gender", "user_likes", "user_link", "user_location", "user_photos", "user_posts", "groups_access_member_info" };

        public LogicManager ManagerLogic { get; }

        public User LoggedInUser { get; set; }

        public LoginResult LoginResult { get; set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;

            ManagerLogic = new LogicManager();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                FacebookService.LogoutWithUI();
                resetWhenLogout();
            }
            else
            {
                MessageBox.Show(k_ErrorMessage, k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBestMatch_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormBestMatch(this).ShowDialog();
            }
            else
            {
                MessageBox.Show(k_ErrorMessage, k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMostLikesFromFriends_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormMostLikesFromFriends(this).ShowDialog();
            }
            else
            {
                MessageBox.Show(k_ErrorMessage, k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFindMyFriendsCities_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormLocations(this).ShowDialog();
            }
            else
            {
                MessageBox.Show(k_ErrorMessage, k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPopularPhotos_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormPopularPhotos(this).ShowDialog();
            }
            else
            {
                MessageBox.Show(k_ErrorMessage, k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxPopularPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxPopularPhotos.SelectedItems.Count == 1)
            {
                Photo selectedPhoto = m_ListBoxPopularPhotos.SelectedItem as Photo;

                m_PictureBoxSelectedPopularPhoto.LoadAsync(selectedPhoto.PictureNormalURL);
                m_LabelNumberOfLikes.Text = string.Format("Likes: {0}", selectedPhoto.LikedBy.Count);
            }
        }

        private void fetchPhotos()
        {
            ICollection<Photo> photos = ManagerLogic.FetchSortedPhotos(LoggedInUser.Albums);

            m_ListBoxPopularPhotos.Items.Clear();
            m_ListBoxPopularPhotos.DisplayMember = "Name";

            foreach (Photo photo in photos)
            {
                m_ListBoxPopularPhotos.Items.Add(photo);
            }
        }

        private void resetWhenLogout()
        {
            LoggedInUser = null;
            LoginResult = null;
            m_ButtonLogin.Text = "Login";

            m_PictureBoxProfilePhoto.Image = null;
            m_LabelFullName.Text = "Full name";
            m_LabelBirthday.Text = "Birthday";
            m_LabelGender.Text = "Gender";
            m_LabelMyCity.Text = "My city";

            m_PictureBoxSelectedPopularPhoto.Image = null;
            m_LabelNumberOfLikes.Text = "Likes:";
            m_ListBoxPopularPhotos.Items.Clear();
        }

        private void fetchUserInfo()
        {
            m_PictureBoxProfilePhoto.LoadAsync(LoggedInUser.PictureLargeURL);
            m_LabelFullName.Text = LoggedInUser.Name;
            m_LabelBirthday.Text = LoggedInUser.Birthday;
            m_LabelGender.Text = LoggedInUser.Gender.ToString();
            m_LabelMyCity.Text = LoggedInUser.Location.ToString();
        }

        private void loginAndInit()
        {
            LoginResult = FacebookService.Login(k_AppId, sr_Permissions);

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;

                m_ButtonLogin.Text = $"Logged in";
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show("Login Failed", k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
