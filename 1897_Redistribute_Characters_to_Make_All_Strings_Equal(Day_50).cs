public class Solution {
    public bool MakeEqual(string[] words) {
        int[] frequencyArray = new int[26];

        // Count the frequency of each character across all words
        foreach (var word in words) {
            foreach (var ch in word) {
                int idx = ch - 'a';
                frequencyArray[idx]++;
            }
        }

        // Check if all frequencies are divisible by words.Length
        foreach (var freq in frequencyArray) {
            if (freq % words.Length != 0) {
                return false;
            }
        }

        return true;
    }
}
