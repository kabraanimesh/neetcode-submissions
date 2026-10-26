public class TimeMap {
    private Dictionary<string, List<(string Val, int Timestamp)>> timeMap = new();

    public TimeMap() {
        
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!timeMap.TryGetValue(key, out var list)) {
            list = new ();
            timeMap[key] = list;
        }
        list.Add((value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        if (timeMap.TryGetValue(key, out var timeMapValue)) {
            int left = 0, right = timeMapValue.Count - 1;
            while (left <= right) {
                int mid = left + (right - left) / 2;

                if (timestamp == timeMapValue[mid].Timestamp) {
                    return timeMapValue[mid].Val;
                }
                else if (timestamp > timeMapValue[mid].Timestamp) {
                    left = mid + 1;
                }
                else {
                    right = mid - 1;
                }
            }
            return right >= 0 ? timeMapValue[right].Val : "";
        }
        return "";
    }
}
