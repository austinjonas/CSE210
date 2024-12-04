
class Video
{
    private string _title = "";
    private string _author = "";
    private int _videoLength;
    public List <Comment> _comments = new List<Comment>();
    public List <Video> _videos = new List<Video>();
    //Getter and setter for title
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    //Getter and setter for author
    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetVideoLength()
    {
        return _videoLength;
    }
    public void SetVideoLength(int videoLength)
    {
        _videoLength = videoLength;
    }
    public int NumberComments()
    {
        return _comments.Count;
    }

    //add comments
    public void AddComments(string commentor, string commentText)
    {
        Comment comment = new Comment();
        comment.SetCommentor(commentor);
        comment.SetCommentText(commentText);
        _comments.Add(comment);
    }

    public List<string> GetComment()
    {
    List<string> commentTexts = new List<string>();
    foreach (Comment comment in _comments)
    {
        commentTexts.Add(comment.BuildComment());
    }
    return commentTexts;
    }

    public void AddVideo(string title, string author, int videoLength)
    {
        Video video = new Video();
        video.SetTitle(title);
        video.SetAuthor(author);
        video.SetVideoLength(videoLength);
        _videos.Add(video);
    }
    private string BuildVideo(string title, string author, string videoLength)
    {
        return $"Video: {title}, by {author}, {videoLength} seconds long.";
    }
    public List<string> GetVideo()
    {
        List<string> videoText = new List<string>();
        foreach (Video video in _videos)
        {
            videoText.Add(BuildVideo(video.GetTitle(), video.GetAuthor(), video.GetVideoLength().ToString()));
        }
        return videoText;
    }

   
}