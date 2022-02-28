﻿using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPopularPhotos : Form
    {
        private readonly FormMain r_FormMain;

        public FormPopularPhotos(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void buttonPopularPhotos_Click(object sender, EventArgs e)
        {
            const string errorMessage = "No photos to ...";
            ICollection<Photo> photos = r_FormMain.ManagerLogic.FetchSortedPhotos(r_FormMain.LoggedInUser.Albums);

            r_FormMain.resetListAndPhoto(m_ListBoxPopularPhotos,m_PictureBoxSelectedPopularPhoto);
            r_FormMain.fetchUserData(m_ListBoxPopularPhotos, photos, errorMessage);

        }

        private void listBoxPopularPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxPopularPhotos.SelectedItems.Count == 1)
            {
                Photo selectedPhoto = m_ListBoxPopularPhotos.SelectedItem as Photo;

                m_PictureBoxSelectedPopularPhoto.LoadAsync(selectedPhoto.PictureNormalURL);
                m_LabelNumberOfLikes.Text = $"Likes: {selectedPhoto.LikedBy.Count}";
            }
        }

    }
}
