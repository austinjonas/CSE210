using System.Dynamic;

class Comment
{
    private string _commentor = "";
    private string _commentText = "";

    // getting and setting commentor
    public string GetCommentor()
    {
        return _commentor;
    }
    public void SetCommentor(string commentor)
    {
        _commentor = commentor;
    }
    
    //getting and setting comment text
    public string GetCommentText()
    {
        return _commentText;
    }
    public void SetCommentText(string commentText)
    {
        _commentText = commentText;
    }

    //
    public string BuildComment()
    {
        return $"{_commentor}{_commentText}";
    }
}