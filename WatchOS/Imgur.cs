using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using Imgur.API.Models.Impl;

namespace WatchOS
{
    public partial class Imgur : Form
    {
        private LinkedList<Post> posts = new LinkedList<Post>();
        private LinkedListNode<Post> currentPost;
        private bool favauritesModeOn = false;

        public Imgur()
        {
            InitializeComponent();
        }

        public async void LoadPosts()
        {
            var client = new ImgurClient("749421e4eed8f22", "87f3637908d8c0fa86c567db9e447ad166a9abdb");
            var endpoint = new GalleryEndpoint(client);
            var images = await endpoint.GetGalleryAsync();

            foreach (var image in images)
            {
                if (image.GetType() == typeof(GalleryImage))
                {
                    var img = (GalleryImage)image;
                    var post = new Post(img.Id);
                    posts.AddLast(post);
                }
                else
                {
                    var album = (GalleryAlbum)image;
                    foreach (var albm in album.Images)
                    {
                        posts.AddLast(new Post(albm.Id));
                        Console.WriteLine("Album image found:" + albm.Id);

                    }
                }

            }
            currentPost = posts.First;

            updatePicture();
        }

        public void viewFavouritePosts()
        {
            favauritesModeOn = !favauritesModeOn;

            currentPost = posts.First;
            updatePicture();
        }

        public void nextPost()
        {
            currentPost = currentPost.Next ?? posts.First;

            updatePicture();
        }

        public void previousPost()
        {
            currentPost = currentPost.Previous ?? posts.Last;

            updatePicture();
        }

        public void updatePicture()
        {
            if (favauritesModeOn && !currentPost.Value.getIsFavourite())
            {
                if (posts.Count(post => post.getIsFavourite()) > 0)
                {
                    nextPost();
                }
                return;
            }

            pictureBoxImage.Image = null;
            pictureBoxImage.LoadAsync(currentPost.Value.getUrl());

            switch (currentPost.Value.getVoteStatus())
            {
                case 1:
                    lblVote.Text = "Status: Upvoted!";
                    break;
                case -1:
                    lblVote.Text = "Status: Downvoted!";
                    break;
                default:
                    lblVote.Text = "Status: neutral";
                    break;
            }

            lblFavourite.Text = currentPost.Value.getIsFavourite() ? "This post is \r\nin your favourites" : "";

            Console.WriteLine(currentPost.Value.getUrl());
        }
        
        public void upvoteCurrentPost()
        {
            currentPost.Value.upvote();

            switch (currentPost.Value.getVoteStatus())
            {
                case 1:
                    lblVote.Invoke((MethodInvoker) (() => lblVote.Text = "Status: Upvoted!"));
                    break;
                default:
                    lblVote.Invoke((MethodInvoker)(() => lblVote.Text = "Status: neutral"));
                    break;
            }
        }

        public void downvoteCurrentPost()
        {
            currentPost.Value.downvote();

            switch (currentPost.Value.getVoteStatus())
            {
                case -1:
                    lblVote.Invoke((MethodInvoker)(() => lblVote.Text = "Status: Downvoted!"));
                    break;
                default:
                    lblVote.Invoke((MethodInvoker)(() => lblVote.Text = "Status: neutral"));
                    break;
            }
        }

        public void favouriteCurrentPost()
        {
            currentPost.Value.favourite();
            lblFavourite.Invoke(
                (MethodInvoker)
                    (() =>
                        lblFavourite.Text = currentPost.Value.getIsFavourite() ? "This post is \r\nin your favourites" : ""));
        }
    }
}
