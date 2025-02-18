﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMyLoyalFriends : Form
    {
        private readonly FormMain r_FormMain;
        
        public FormMyLoyalFriends(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void buttonSearchLoyalFriends_Click(object sender, EventArgs e)
        {
            try
            {
                r_FormMain.ResetListAndPhoto(m_ListBoxLoyalFriends, m_PictureBoxLoyalFriends);
                r_FormMain.ResetListAndPhoto(m_ListBoxMostComments, m_PictureBoxSelectedFriendComment);
                r_FormMain.ResetListAndPhoto(m_ListBoxMostLikesPhotos, m_PictureBoxSelectedFriendPhoto);
                fetchLoyalFriends();
            }
            catch (Exception)
            {
                MessageBox.Show(r_FormMain.ErrorMessageSupported, r_FormMain.TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            fetchUserPhotos();
            fetchUserComments();
        }

        private void listBoxLoyalFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.UpdatePhotoAsUser(m_ListBoxLoyalFriends, m_PictureBoxLoyalFriends);
        }

        private void listBoxMostLikesPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.UpdatePhotoAsUser(m_ListBoxMostLikesPhotos, m_PictureBoxSelectedFriendPhoto);
        }

        private void listBoxMostComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.UpdatePhotoAsUser(m_ListBoxMostComments, m_PictureBoxSelectedFriendComment);
        }

        private void fetchLoyalFriends()
        {
            const string errorMessage = "No loyal friends to retrieve :(";
            ICollection<User> usersToShow = r_FormMain.ManagerLogic.GetMyLoyalFriends(r_FormMain.LoggedInUser);

            r_FormMain.ResetListAndPhoto(m_ListBoxLoyalFriends, m_PictureBoxLoyalFriends);
            r_FormMain.FetchUserData(m_ListBoxLoyalFriends, usersToShow, errorMessage);
        }

        private void fetchUserPhotos()
        {
            const string errorMessage = "No User to retrieve :(";
            ICollection<User> usersToShow = r_FormMain.ManagerLogic.GetMostLikesOnPhotosByUsers();

            r_FormMain.ResetListAndPhoto(m_ListBoxMostLikesPhotos, m_PictureBoxSelectedFriendPhoto);
            r_FormMain.FetchUserData(m_ListBoxMostLikesPhotos, usersToShow, errorMessage);
        }

        private void fetchUserComments()
        {
            const string errorMessage = "No User to retrieve :(";
            ICollection<User> usersToShow = r_FormMain.ManagerLogic.GetMostCommentsOnPhotosByUsers();

            r_FormMain.ResetListAndPhoto(m_ListBoxMostComments, m_PictureBoxSelectedFriendComment);
            r_FormMain.FetchUserData(m_ListBoxMostComments, usersToShow, errorMessage);
        }
    }
}
