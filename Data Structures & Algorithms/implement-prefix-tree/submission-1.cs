public class PrefixTree {
    private PrefixTree[] chars= new PrefixTree[26];
    private bool isEnd = false;

    public PrefixTree() {
        
    }
    
    public void Insert(string word) {
        var current = this;

        for (int i = 0; i < word.Length; i++) {
            var j = word[i] - 'a';
            if (current.chars[j] is null) current.chars[j] = new PrefixTree();
            current = current.chars[j];
        }
        current.isEnd = true;
    }
    
    public bool Search(string word) {
        var current = this;
        for (int i = 0; i < word.Length; i++) {
            var j = word[i] - 'a';
            if (current.chars[j] is null) return false;
            current = current.chars[j];
        }
        return current.isEnd;
    }
    
    public bool StartsWith(string prefix) {
        var current = this;

        for (int i = 0; i < prefix.Length; i++) {
            var j = prefix[i] - 'a';
            if (current.chars[j] is null) return false;
            current = current.chars[j];
        }
        return true;
    }
}
