﻿namespace BasicFacebookFeatures
{
    public partial class FormAccountInfo
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
            this.m_ListBoxFriends = new System.Windows.Forms.ListBox();
            this.m_ButtonShowFriends = new System.Windows.Forms.Button();
            this.m_PictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.m_PictureBoxLikedPages = new System.Windows.Forms.PictureBox();
            this.m_ButtonLikedPages = new System.Windows.Forms.Button();
            this.m_ListBoxLikedPages = new System.Windows.Forms.ListBox();
            this.m_PictureBoxEvents = new System.Windows.Forms.PictureBox();
            this.m_ButtonEvents = new System.Windows.Forms.Button();
            this.m_ListBoxEvents = new System.Windows.Forms.ListBox();
            this.m_PictureBoxAlbums = new System.Windows.Forms.PictureBox();
            this.m_ButtonAlbums = new System.Windows.Forms.Button();
            this.m_ListBoxAlbums = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxLikedPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ListBoxFriends
            // 
            this.m_ListBoxFriends.FormattingEnabled = true;
            this.m_ListBoxFriends.ItemHeight = 16;
            this.m_ListBoxFriends.Location = new System.Drawing.Point(41, 62);
            this.m_ListBoxFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ListBoxFriends.Name = "m_ListBoxFriends";
            this.m_ListBoxFriends.Size = new System.Drawing.Size(219, 196);
            this.m_ListBoxFriends.TabIndex = 1;
            this.m_ListBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // m_ButtonShowFriends
            // 
            this.m_ButtonShowFriends.Location = new System.Drawing.Point(80, 26);
            this.m_ButtonShowFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ButtonShowFriends.Name = "m_ButtonShowFriends";
            this.m_ButtonShowFriends.Size = new System.Drawing.Size(137, 28);
            this.m_ButtonShowFriends.TabIndex = 0;
            this.m_ButtonShowFriends.Text = "See My Friends";
            this.m_ButtonShowFriends.UseVisualStyleBackColor = true;
            this.m_ButtonShowFriends.Click += new System.EventHandler(this.buttonShowFriends_Click);
            // 
            // m_PictureBoxFriends
            // 
            this.m_PictureBoxFriends.Location = new System.Drawing.Point(149, 170);
            this.m_PictureBoxFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_PictureBoxFriends.Name = "m_PictureBoxFriends";
            this.m_PictureBoxFriends.Size = new System.Drawing.Size(112, 89);
            this.m_PictureBoxFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxFriends.TabIndex = 3;
            this.m_PictureBoxFriends.TabStop = false;
            // 
            // m_PictureBoxLikedPages
            // 
            this.m_PictureBoxLikedPages.Location = new System.Drawing.Point(652, 170);
            this.m_PictureBoxLikedPages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_PictureBoxLikedPages.Name = "m_PictureBoxLikedPages";
            this.m_PictureBoxLikedPages.Size = new System.Drawing.Size(112, 89);
            this.m_PictureBoxLikedPages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxLikedPages.TabIndex = 6;
            this.m_PictureBoxLikedPages.TabStop = false;
            // 
            // m_ButtonLikedPages
            // 
            this.m_ButtonLikedPages.Location = new System.Drawing.Point(564, 26);
            this.m_ButtonLikedPages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ButtonLikedPages.Name = "m_ButtonLikedPages";
            this.m_ButtonLikedPages.Size = new System.Drawing.Size(179, 28);
            this.m_ButtonLikedPages.TabIndex = 2;
            this.m_ButtonLikedPages.Text = "See My Liked Pages";
            this.m_ButtonLikedPages.UseVisualStyleBackColor = true;
            this.m_ButtonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // m_ListBoxLikedPages
            // 
            this.m_ListBoxLikedPages.FormattingEnabled = true;
            this.m_ListBoxLikedPages.ItemHeight = 16;
            this.m_ListBoxLikedPages.Location = new System.Drawing.Point(532, 62);
            this.m_ListBoxLikedPages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ListBoxLikedPages.Name = "m_ListBoxLikedPages";
            this.m_ListBoxLikedPages.Size = new System.Drawing.Size(231, 196);
            this.m_ListBoxLikedPages.TabIndex = 3;
            this.m_ListBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // m_PictureBoxEvents
            // 
            this.m_PictureBoxEvents.Location = new System.Drawing.Point(168, 481);
            this.m_PictureBoxEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_PictureBoxEvents.Name = "m_PictureBoxEvents";
            this.m_PictureBoxEvents.Size = new System.Drawing.Size(112, 89);
            this.m_PictureBoxEvents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxEvents.TabIndex = 9;
            this.m_PictureBoxEvents.TabStop = false;
            // 
            // m_ButtonEvents
            // 
            this.m_ButtonEvents.Location = new System.Drawing.Point(80, 337);
            this.m_ButtonEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ButtonEvents.Name = "m_ButtonEvents";
            this.m_ButtonEvents.Size = new System.Drawing.Size(151, 28);
            this.m_ButtonEvents.TabIndex = 4;
            this.m_ButtonEvents.Text = "See My Events";
            this.m_ButtonEvents.UseVisualStyleBackColor = true;
            this.m_ButtonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // m_ListBoxEvents
            // 
            this.m_ListBoxEvents.FormattingEnabled = true;
            this.m_ListBoxEvents.ItemHeight = 16;
            this.m_ListBoxEvents.Location = new System.Drawing.Point(41, 373);
            this.m_ListBoxEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ListBoxEvents.Name = "m_ListBoxEvents";
            this.m_ListBoxEvents.Size = new System.Drawing.Size(237, 196);
            this.m_ListBoxEvents.TabIndex = 5;
            this.m_ListBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // m_PictureBoxAlbums
            // 
            this.m_PictureBoxAlbums.Location = new System.Drawing.Point(652, 481);
            this.m_PictureBoxAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_PictureBoxAlbums.Name = "m_PictureBoxAlbums";
            this.m_PictureBoxAlbums.Size = new System.Drawing.Size(112, 89);
            this.m_PictureBoxAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxAlbums.TabIndex = 15;
            this.m_PictureBoxAlbums.TabStop = false;
            // 
            // m_ButtonAlbums
            // 
            this.m_ButtonAlbums.Location = new System.Drawing.Point(568, 337);
            this.m_ButtonAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ButtonAlbums.Name = "m_ButtonAlbums";
            this.m_ButtonAlbums.Size = new System.Drawing.Size(164, 28);
            this.m_ButtonAlbums.TabIndex = 6;
            this.m_ButtonAlbums.Text = "See My Albums";
            this.m_ButtonAlbums.UseVisualStyleBackColor = true;
            this.m_ButtonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // m_ListBoxAlbums
            // 
            this.m_ListBoxAlbums.FormattingEnabled = true;
            this.m_ListBoxAlbums.ItemHeight = 16;
            this.m_ListBoxAlbums.Location = new System.Drawing.Point(532, 373);
            this.m_ListBoxAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ListBoxAlbums.Name = "m_ListBoxAlbums";
            this.m_ListBoxAlbums.Size = new System.Drawing.Size(231, 196);
            this.m_ListBoxAlbums.TabIndex = 7;
            this.m_ListBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // FormAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.MostLikesForm;
            this.ClientSize = new System.Drawing.Size(815, 596);
            this.Controls.Add(this.m_PictureBoxAlbums);
            this.Controls.Add(this.m_ButtonAlbums);
            this.Controls.Add(this.m_ListBoxAlbums);
            this.Controls.Add(this.m_PictureBoxEvents);
            this.Controls.Add(this.m_ButtonEvents);
            this.Controls.Add(this.m_ListBoxEvents);
            this.Controls.Add(this.m_PictureBoxLikedPages);
            this.Controls.Add(this.m_ButtonLikedPages);
            this.Controls.Add(this.m_ListBoxLikedPages);
            this.Controls.Add(this.m_PictureBoxFriends);
            this.Controls.Add(this.m_ButtonShowFriends);
            this.Controls.Add(this.m_ListBoxFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account info";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxLikedPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxAlbums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox m_ListBoxFriends;
        private System.Windows.Forms.Button m_ButtonShowFriends;
        private System.Windows.Forms.PictureBox m_PictureBoxFriends;
        private System.Windows.Forms.PictureBox m_PictureBoxLikedPages;
        private System.Windows.Forms.Button m_ButtonLikedPages;
        private System.Windows.Forms.ListBox m_ListBoxLikedPages;
        private System.Windows.Forms.PictureBox m_PictureBoxEvents;
        private System.Windows.Forms.Button m_ButtonEvents;
        private System.Windows.Forms.ListBox m_ListBoxEvents;
        private System.Windows.Forms.PictureBox m_PictureBoxAlbums;
        private System.Windows.Forms.Button m_ButtonAlbums;
        private System.Windows.Forms.ListBox m_ListBoxAlbums;
    }
}