using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private List<Post> posts = new List<Post>();
        private Post currentPost;
        private bool favauritesModeOn;

        public void loadPosts()
        {
            //hip hip horray!
            //1: alle id's verzamelen
            //2: http://i.imgur.com/id.png
            var client = new ImgurClient("749421e4eed8f22", "87f3637908d8c0fa86c567db9e447ad166a9abdb");
            var endpoint = new GalleryEndpoint(client);
            var task = endpoint.GetGalleryAsync();
            Task.WaitAll(task);
            var images = task.Result;
            Console.WriteLine("is geladen");
            foreach (var image in images)
            {
                if (image.GetType() == typeof (GalleryImage))
                {
                    var img = (GalleryImage) image;
                    posts.Add(new Post(img.Id));
                    Console.WriteLine(img.Id.ToString());

                }
                else
                {
                    var album = (GalleryAlbum) image;
                    foreach (var albm in album.Images)
                    {
                        posts.Add(new Post(albm.Id));
                        Console.WriteLine("Album image found:" + albm.Id);

                    }
                }

            }

            currentPost = posts[0];
            updatePicture();

        }

        private void Imgur_Load(object sender, EventArgs e)
        {
            loadPosts();
        }

        public Imgur()
        {
            loadPosts();
            var test = currentPost.getUrl();
            MessageBox.Show(currentPost.getUrl());
        }

        public void viewFavouritePosts()
        {
            //itereren over elke post, favourite? dan showen in een form ofzo.
        }

        public void nextPost()
        {
            //note check of niet laatste element.
            if (posts.IndexOf(currentPost) < posts.Count)
            {
                currentPost = posts[posts.IndexOf(currentPost) + 1];
            }
        }

        public void previousPost()
        {
            if (posts.IndexOf(currentPost) > 0)
            {
                currentPost = posts[posts.IndexOf(currentPost) - 1];
            }
        }

        public void updatePicture()
        {
            //pictureBoxImage.Load(currentPost.getUrl());
            pictureBoxImage.Load("http://i.imgur.com/qHRX6.png");
        }

        public Post getCurrentPost()
        {
            return currentPost;
        }

        public void upvoteCurrentPost()
        {
            currentPost.upvote();
        }

        public void downvoteCurrentPost()
        {
            currentPost.downvote();
        }
        public void favouriteCurrentPost()
        {
         currentPost.favourite();   
        }
    }
}
