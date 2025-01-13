// String Matching in an Array
public class Solution {
    public IList<string> StringMatching(string[] words) {
        List<string> output = new List<string>();
        for(int i = 0; i < words.Length; i++){
            for(int j = 0; j < words.Length; j++){
                if(j == i) continue;
                if(words[j].Contains(words[i]) && !output.Contains(words[i])){
                    output.Add(words[i]);
                }
            }
        }
        return output;
    }
}