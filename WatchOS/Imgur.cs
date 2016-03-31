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
        private bool favauritesModeOn;

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
            //itereren over elke post, favourite? dan showen in een form ofzo.
        }

        public void nextPost()
        {
            currentPost = currentPost.Next;

            if (currentPost == null)
            {
                currentPost = posts.First;
            }

            updatePicture();
        }

        public void previousPost()
        {
            currentPost = currentPost.Previous;

            if (currentPost == null)
            {
                currentPost = posts.Last;
            }
            updatePicture();
        }

        public void updatePicture()
        {
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

            Console.WriteLine(currentPost.Value.getUrl());
        }

        public Post getCurrentPost()
        {
            return currentPost.Value;
        }

        public void upvoteCurrentPost()
        {
            currentPost.Value.upvote();

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
        }

        public void downvoteCurrentPost()
        {
            currentPost.Value.downvote();

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
        }

        public void favouriteCurrentPost()
        {
            currentPost.Value.favourite();
        }
    }
}
