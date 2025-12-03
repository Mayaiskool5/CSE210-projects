public class Comments
{
    private Dictionary<string, string> CommentsList = new Dictionary<string, string>();

    // Adds comments
    public void addComment(string username, string commentText)
    {
        if (CommentsList.ContainsKey(username) == false)
        {
            CommentsList[username] = commentText;
        }
        else
        {
            CommentsList[username] += "\n" + commentText;
        }
    }

    public string returnComments()
    {
        string allComments = "";
        foreach (var comment in CommentsList)
        {
            allComments += $"{comment.Key}: {comment.Value}\n";
        }
        // Removes the last newline character
        return allComments.TrimEnd('\n');
    }
}