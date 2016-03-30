using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchOS
{
    class Imgur
    {
        private LinkedList<Post> posts;
        private LinkedListNode<Post> currentPost;
        private bool favoritesModeOn;

        //Constructor
        public Imgur()
        {
            posts = new LinkedList<Post>();
            currentPost = new LinkedListNode<Post>(new Post());
            favoritesModeOn = new bool();

        }


        public void loadPosts()
        {

        }

        public void viewFavoritePosts()
        {

        }

        public void nextPost()
        {

        }

        public void previousPost()
        {

        }

        public Post getCurrentPost()
        {
            return null;
        }

        public void upvoteCurrentPost()
        {

        }

        public void downvoteCurrentPost()
        {

        }

        public void favoriteCurrentPost()
        {

        }

    }
}
