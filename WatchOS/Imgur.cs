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
                    posts.AddFirst(new Post(img.Id));
                    Console.WriteLine(img.Id.ToString());

                }
                else
                {
                    var album = (GalleryAlbum) image;
                    foreach (var albm in album.Images)
                    {
                        posts.AddFirst(new Post(albm.Id));
                        Console.WriteLine("Album image found:" + albm.Id);

                    }
                }

            }
            currentPost = new LinkedListNode<Post>(posts.First.Value);

            Debug.WriteLine("1e value in de linkedlist: " + posts.First.Value.getUrl());
            Debug.WriteLine("current value in de linkedlistnode: " + currentPost.Value.getUrl());

            updatePicture();

        }

        private void Imgur_Load(object sender, EventArgs e)
        {
            loadPosts();
        }

        public Imgur()
        {
            loadPosts();
            Debug.WriteLine(currentPost.Value.getUrl());
        }

        public void viewFavouritePosts()
        {
            //itereren over elke post, favourite? dan showen in een form ofzo.
        }

        public void nextPost()
        {
            currentPost = currentPost.Next;
            Debug.WriteLine(currentPost);
            updatePicture();
        }

        public void previousPost()
        {
            currentPost = currentPost.Previous;
            updatePicture();
        }

        public void updatePicture()
        {
            //pictureBoxImage.Load(currentPost.getUrl());
            //pictureBoxImage.Load("http://i.imgur.com/qHRX6.png"); //note: dit geeft al een error
            this.Controls.Clear();
            PictureBox p = new PictureBox();
            p.Location = new Point(0, 0);
            p.Width = 473;
            p.Height = 301;
            p.SizeMode = PictureBoxSizeMode.Zoom;
            Debug.WriteLine(currentPost.Value.getUrl());
            //p.Load(currentPost.Value.getUrl());
            this.Controls.Add(p);
        }

        public Post getCurrentPost()
        {
            return currentPost.Value;
        }

        public void upvoteCurrentPost()
        {
            currentPost.Value.upvote();
        }

        public void downvoteCurrentPost()
        {
            currentPost.Value.downvote();
        }
        public void favouriteCurrentPost()
        {
         currentPost.Value.favourite();   
        }
    }
}
