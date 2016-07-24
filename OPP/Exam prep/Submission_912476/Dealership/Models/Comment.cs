namespace Dealership.Models
{

    using Dealership.Common;
    using Dealership.Contracts;

    public class Comment : IComment
    {
        private string content;
        private string author;

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                this.author = value;
            }
        }

        public string Content
        {
            get { return this.content; }
            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CommentCannotBeNull));
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxCommentLength, Constants.MinCommentLength, string.Format(Constants.StringMustBeBetweenMinAndMax, this.GetType().Name, Constants.MinCommentLength, Constants.MaxCommentLength));
                this.content = value;
            }
        }
    }
}
