using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchOS
{
    public partial class Post
    {
        private string id;
        private int voteStatus;
        private bool isFavourite;

        public Post(String id)
        {
            this.id = id;
        }

        public string getUrl()
        {
            return "http://i.imgur.com/" + id + ".png";
        }

        public string getFilePath()
        {
            //wat is dit?
            return "404";
        }

        public void upvote()
        {
            voteStatus = 1;
        }

        public void downvote()
        {
            voteStatus = -1;
        }

        public void favourite()
        {

        }

        public int getVoteStatus()
        {
            return voteStatus;
        }


    }
}
