using System;

namespace StackOverflowPost
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _created;
        private int _votes;

        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _created = DateTime.Now;
            _votes = 0;
        }

        public void UpVote() { _votes++; }
        public void DownVote() { _votes--; }
        public int GetVotes() { return _votes; }

        public override string ToString()
        {
            return _title + "\n" + _description + "\nCreated On: " + _created + "\nNum Votes: " + _votes;
        }

    }
}
