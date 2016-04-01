using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchOS
{
    public class Post
    {
        private string id;
        private int voteStatus;
        private bool isFavourite;

        public Post(string id)
        {
            this.id = id;
        }

        public string getUrl()
        {
            return "http://i.imgur.com/" + id + ".png";
        }

        public void upvote()
        {
            voteStatus = voteStatus == 1 ? 0 : 1;
        }

        public void downvote()
        {
            voteStatus = voteStatus == -1 ? 0 : -1;
        }

        public void favourite()
        {
            isFavourite = !isFavourite;
        }

        public int getVoteStatus()
        {
            return voteStatus;
        }

        public bool getIsFavourite()
        {
            return isFavourite;
        }
    }
}
