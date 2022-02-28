﻿using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormAccountInfo : Form
    {
        private readonly FormMain r_FormMain;

        public FormAccountInfo(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void buttonShowFriends_Click(object sender, EventArgs e)
        {
            const string errorMessage = "No Friends to retrieve :(";

            r_FormMain.resetListAndPhoto(m_ListBoxFriends,m_PictureBoxFriends);
            r_FormMain.fetchUserData(m_ListBoxFriends, r_FormMain.LoggedInUser.Friends, errorMessage);
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            const string errorMessage = "No Albums to retrieve :(";

            r_FormMain.resetListAndPhoto(m_ListBoxAlbums, m_PictureBoxAlbums);
            r_FormMain.fetchUserData(m_ListBoxAlbums, r_FormMain.LoggedInUser.Albums, errorMessage);
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            const string errorMessage = "No Liked Pages to retrieve :(";

            r_FormMain.resetListAndPhoto(m_ListBoxLikedPages, m_PictureBoxLikedPages);
            r_FormMain.fetchUserData(m_ListBoxLikedPages, r_FormMain.LoggedInUser.LikedPages, errorMessage);
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            const string errorMessage = "No Events to retrieve :(";

            r_FormMain.resetListAndPhoto(m_ListBoxEvents, m_PictureBoxEvents);
            r_FormMain.fetchUserData(m_ListBoxEvents, r_FormMain.LoggedInUser.Events, errorMessage);
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = m_ListBoxFriends.SelectedItem as User;
                m_PictureBoxFriends.LoadAsync(selectedFriend.PictureNormalURL);
            }
            else
            {
                m_PictureBoxFriends.Image = m_PictureBoxFriends.ErrorImage;
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxLikedPages.SelectedItems.Count == 1)
            {
                Page selectedPage = m_ListBoxLikedPages.SelectedItem as Page;
                m_PictureBoxLikedPages.LoadAsync(selectedPage.PictureNormalURL);
            }
            else
            {
                m_PictureBoxLikedPages.Image = m_PictureBoxLikedPages.ErrorImage;
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = m_ListBoxEvents.SelectedItem as Event;
                m_PictureBoxEvents.LoadAsync(selectedEvent.Cover.SourceURL);
            }
            else
            {
                m_PictureBoxEvents.Image = m_PictureBoxLikedPages.ErrorImage;
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = m_ListBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    m_PictureBoxAlbums.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    m_PictureBoxAlbums.Image = m_PictureBoxAlbums.ErrorImage;
                }
            }
        }

        // WE HAVE THIS METHOD TWICE !!!
        // private void fetchUserData<T>(ListBox i_ListBoxToFill,
        //     FacebookObjectCollection<T> i_Collection, string i_ErrorMessage)
        // {
        //     i_ListBoxToFill.Items.Clear();
        //     i_ListBoxToFill.DisplayMember = "Name";
        //
        //     foreach (T itemToAdd in i_Collection)
        //     {
        //         i_ListBoxToFill.Items.Add(itemToAdd);
        //     }
        //
        //     if (i_ListBoxToFill.Items.Count == 0)
        //     {
        //         MessageBox.Show(i_ErrorMessage);
        //     }
        // }
    }
}