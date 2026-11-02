public class Twitter {
    int count = 0;
    Dictionary<int, HashSet<int>> follows = new ();
    Dictionary<int, List<(int, int)>> tweets = new ();
    public Twitter() {
        
    }
    
    public void PostTweet(int userId, int tweetId) {
        if (!tweets.ContainsKey(userId)) tweets[userId] = new List<(int, int)>();

        tweets[userId].Add((tweetId, count));
        if (tweets[userId].Count > 10) tweets[userId].RemoveAt(0);
        count--;
    }
    
    public List<int> GetNewsFeed(int userId) {
        
        var res = new List<int>();
        Follow(userId, userId);
        var users = follows[userId].ToList();
        var heap = new PriorityQueue<int, int>();
        foreach (var user in users) {
            if (!tweets.ContainsKey(user)) {
                continue;
            }
            var allTweets = tweets[user];
            if (!allTweets.Any()) {
                continue;
            }

            foreach (var (tweetId, counter) in allTweets) {
                heap.Enqueue(tweetId, counter);
            }
        }

        for (int i = 0; i < 10; i++) {
            if (heap.Count > 0) {
                res.Add(heap.Dequeue());
            }
            else {
                break;
            }
        }
        return res;
    }
    
    public void Follow(int followerId, int followeeId) {
        if (!follows.ContainsKey(followerId)) follows[followerId] = new HashSet<int>();

        follows[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
        follows[followerId].Remove(followeeId);
    }
}
