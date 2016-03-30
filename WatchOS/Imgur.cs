using System;
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

namespace WatchOS
{
    public partial class Imgur : Form
    {
        new LinkedList LinkedList<Post> posts 

        public void loadPosts()
        {
            var client = new ImgurClient("749421e4eed8f22", "87f3637908d8c0fa86c567db9e447ad166a9abdb");
            var endpoint = new GalleryEndpoint(client);
            var task = endpoint.GetGalleryAsync();
            Task.WaitAll(task);
            var images = task.Result;
            Console.WriteLine("is geladen");
            foreach (var image in images)
            {
                imgurScreen.Image = image.
                Console.WriteLine(image.Score);
            }
        }

        private void Imgur_Load(object sender, EventArgs e)
        {
            loadPosts();
        }

        public Imgur()
        {
            loadPosts();
        }
    }
}
