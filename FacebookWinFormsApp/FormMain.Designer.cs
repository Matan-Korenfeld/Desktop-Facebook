﻿using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain
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
            this.m_ButtonLogin = new System.Windows.Forms.Button();
            this.m_ButtonLogout = new System.Windows.Forms.Button();
            this.m_PictureBoxProfilePhoto = new System.Windows.Forms.PictureBox();
            this.m_LabelFullName = new System.Windows.Forms.Label();
            this.m_LabelBirthday = new System.Windows.Forms.Label();
            this.m_ButtonBestMatch = new System.Windows.Forms.Button();
            this.m_ButtonMostLikesFromFriends = new System.Windows.Forms.Button();
            this.m_ButtonPopularPhotos = new System.Windows.Forms.Button();
            this.m_ButtonFindMyFriendsCities = new System.Windows.Forms.Button();
            this.m_LabelGender = new System.Windows.Forms.Label();
            this.m_LabelMyCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ButtonLogin
            // 
            this.m_ButtonLogin.BackColor = System.Drawing.Color.White;
            this.m_ButtonLogin.Location = new System.Drawing.Point(820, 49);
            this.m_ButtonLogin.Margin = new System.Windows.Forms.Padding(6);
            this.m_ButtonLogin.Name = "m_ButtonLogin";
            this.m_ButtonLogin.Size = new System.Drawing.Size(358, 44);
            this.m_ButtonLogin.TabIndex = 36;
            this.m_ButtonLogin.Text = "Login";
            this.m_ButtonLogin.UseVisualStyleBackColor = false;
            this.m_ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // m_ButtonLogout
            // 
            this.m_ButtonLogout.BackColor = System.Drawing.Color.White;
            this.m_ButtonLogout.Location = new System.Drawing.Point(820, 112);
            this.m_ButtonLogout.Margin = new System.Windows.Forms.Padding(6);
            this.m_ButtonLogout.Name = "m_ButtonLogout";
            this.m_ButtonLogout.Size = new System.Drawing.Size(358, 44);
            this.m_ButtonLogout.TabIndex = 52;
            this.m_ButtonLogout.Text = "Logout";
            this.m_ButtonLogout.UseVisualStyleBackColor = false;
            this.m_ButtonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // m_PictureBoxProfilePhoto
            // 
            this.m_PictureBoxProfilePhoto.BackColor = System.Drawing.Color.White;
            this.m_PictureBoxProfilePhoto.Location = new System.Drawing.Point(22, 23);
            this.m_PictureBoxProfilePhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_PictureBoxProfilePhoto.Name = "m_PictureBoxProfilePhoto";
            this.m_PictureBoxProfilePhoto.Size = new System.Drawing.Size(316, 250);
            this.m_PictureBoxProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxProfilePhoto.TabIndex = 53;
            this.m_PictureBoxProfilePhoto.TabStop = false;
            // 
            // m_LabelFullName
            // 
            this.m_LabelFullName.AutoSize = true;
            this.m_LabelFullName.BackColor = System.Drawing.Color.White;
            this.m_LabelFullName.Location = new System.Drawing.Point(372, 45);
            this.m_LabelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LabelFullName.Name = "m_LabelFullName";
            this.m_LabelFullName.Size = new System.Drawing.Size(106, 25);
            this.m_LabelFullName.TabIndex = 54;
            this.m_LabelFullName.Text = "Full name";
            // 
            // m_LabelBirthday
            // 
            this.m_LabelBirthday.AutoSize = true;
            this.m_LabelBirthday.BackColor = System.Drawing.Color.White;
            this.m_LabelBirthday.Location = new System.Drawing.Point(372, 96);
            this.m_LabelBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LabelBirthday.Name = "m_LabelBirthday";
            this.m_LabelBirthday.Size = new System.Drawing.Size(91, 25);
            this.m_LabelBirthday.TabIndex = 55;
            this.m_LabelBirthday.Text = "Birthday";
            // 
            // m_ButtonBestMatch
            // 
            this.m_ButtonBestMatch.BackColor = System.Drawing.Color.White;
            this.m_ButtonBestMatch.Location = new System.Drawing.Point(833, 348);
            this.m_ButtonBestMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_ButtonBestMatch.Name = "m_ButtonBestMatch";
            this.m_ButtonBestMatch.Size = new System.Drawing.Size(228, 88);
            this.m_ButtonBestMatch.TabIndex = 56;
            this.m_ButtonBestMatch.Text = "Find best match";
            this.m_ButtonBestMatch.UseVisualStyleBackColor = false;
            this.m_ButtonBestMatch.Click += new System.EventHandler(this.buttonBestMatch_Click);
            // 
            // m_ButtonMostLikesFromFriends
            // 
            this.m_ButtonMostLikesFromFriends.BackColor = System.Drawing.Color.White;
            this.m_ButtonMostLikesFromFriends.Location = new System.Drawing.Point(110, 482);
            this.m_ButtonMostLikesFromFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_ButtonMostLikesFromFriends.Name = "m_ButtonMostLikesFromFriends";
            this.m_ButtonMostLikesFromFriends.Size = new System.Drawing.Size(228, 88);
            this.m_ButtonMostLikesFromFriends.TabIndex = 57;
            this.m_ButtonMostLikesFromFriends.Text = "My loyal friend";
            this.m_ButtonMostLikesFromFriends.UseVisualStyleBackColor = false;
            this.m_ButtonMostLikesFromFriends.Click += new System.EventHandler(this.buttonMostLikesFromFriends_Click);
            // 
            // m_ButtonPopularPhotos
            // 
            this.m_ButtonPopularPhotos.BackColor = System.Drawing.Color.White;
            this.m_ButtonPopularPhotos.Location = new System.Drawing.Point(833, 482);
            this.m_ButtonPopularPhotos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_ButtonPopularPhotos.Name = "m_ButtonPopularPhotos";
            this.m_ButtonPopularPhotos.Size = new System.Drawing.Size(236, 88);
            this.m_ButtonPopularPhotos.TabIndex = 60;
            this.m_ButtonPopularPhotos.Text = "My popular photos";
            this.m_ButtonPopularPhotos.UseVisualStyleBackColor = false;
            this.m_ButtonPopularPhotos.Click += new System.EventHandler(this.buttonPopularPhotos_Click);
            // 
            // m_ButtonFindMyFriendsCities
            // 
            this.m_ButtonFindMyFriendsCities.BackColor = System.Drawing.Color.White;
            this.m_ButtonFindMyFriendsCities.Location = new System.Drawing.Point(110, 348);
            this.m_ButtonFindMyFriendsCities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_ButtonFindMyFriendsCities.Name = "m_ButtonFindMyFriendsCities";
            this.m_ButtonFindMyFriendsCities.Size = new System.Drawing.Size(228, 88);
            this.m_ButtonFindMyFriendsCities.TabIndex = 62;
            this.m_ButtonFindMyFriendsCities.Text = "Where all my friends";
            this.m_ButtonFindMyFriendsCities.UseVisualStyleBackColor = false;
            this.m_ButtonFindMyFriendsCities.Click += new System.EventHandler(this.buttonFindMyFriendsCities_Click);
            // 
            // m_LabelGender
            // 
            this.m_LabelGender.AutoSize = true;
            this.m_LabelGender.Location = new System.Drawing.Point(372, 146);
            this.m_LabelGender.Name = "m_LabelGender";
            this.m_LabelGender.Size = new System.Drawing.Size(83, 25);
            this.m_LabelGender.TabIndex = 63;
            this.m_LabelGender.Text = "Gender";
            // 
            // m_LabelMyCity
            // 
            this.m_LabelMyCity.AutoSize = true;
            this.m_LabelMyCity.Location = new System.Drawing.Point(372, 195);
            this.m_LabelMyCity.Name = "m_LabelMyCity";
            this.m_LabelMyCity.Size = new System.Drawing.Size(80, 25);
            this.m_LabelMyCity.TabIndex = 64;
            this.m_LabelMyCity.Text = "My city";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 727);
            this.Controls.Add(this.m_LabelMyCity);
            this.Controls.Add(this.m_LabelGender);
            this.Controls.Add(this.m_ButtonFindMyFriendsCities);
            this.Controls.Add(this.m_ButtonPopularPhotos);
            this.Controls.Add(this.m_ButtonMostLikesFromFriends);
            this.Controls.Add(this.m_ButtonBestMatch);
            this.Controls.Add(this.m_LabelBirthday);
            this.Controls.Add(this.m_LabelFullName);
            this.Controls.Add(this.m_PictureBoxProfilePhoto);
            this.Controls.Add(this.m_ButtonLogout);
            this.Controls.Add(this.m_ButtonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacebookApp";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_ButtonLogin;
        private System.Windows.Forms.Button m_ButtonLogout;
        private System.Windows.Forms.PictureBox m_PictureBoxProfilePhoto;
        private System.Windows.Forms.Label m_LabelFullName;
        private System.Windows.Forms.Label m_LabelBirthday;
        private System.Windows.Forms.Button m_ButtonBestMatch;
        private System.Windows.Forms.Button m_ButtonMostLikesFromFriends;
        private System.Windows.Forms.Button m_ButtonPopularPhotos;
        private Button m_ButtonFindMyFriendsCities;
        private Label m_LabelGender;
        private Label m_LabelMyCity;
    }
}