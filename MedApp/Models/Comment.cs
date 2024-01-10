using System;


namespace Project.Models
{
    public class Comment
    {
        public string comment;
        public bool isDisplayed;

        public Comment(string comment_)
        {
            edit(comment);
        }
        public Comment()
        {
            edit("");
        }

        void edit(string comment_)
        {
            comment = comment_;
            if (comment_ != "")
                isDisplayed = true;
            else
                isDisplayed = false;
        }

    }

}