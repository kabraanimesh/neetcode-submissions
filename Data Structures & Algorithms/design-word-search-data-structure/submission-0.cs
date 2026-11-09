public class WordDictionary {
    private WordDictionary[] chars = new WordDictionary[26];
    private bool isEnd = false;
    public WordDictionary() {
        
    }
    
    public void AddWord(string word) {
        var current = this;

        for (int i = 0; i < word.Length; i++) {
            var j = word[i] - 'a';
            if (current.chars[j] is null) current.chars[j] = new WordDictionary();
            current = current.chars[j];
        }
        current.isEnd = true;
    }
    
    public bool Search(string word) {
        var current = this;

        for (int i = 0; i < word.Length; i++) {
            if (word[i] == '.') {
                foreach (var child in current.chars) {
                    if (child != null && child.Search(word.Substring(i + 1))) {
                        return true;
                    }
                }
                return false;   
            }
            
            var j = word[i] - 'a';

            if (current.chars[j] is null) return false;
            current = current.chars[j];
        }
        return current.isEnd;
    }

    
}
