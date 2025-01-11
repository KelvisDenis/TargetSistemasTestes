


public static class StringInvert{
    public static string InvertMethod(string word){
        int caracter = word.Length;
        string invert = null;
        for(int i=1; i<word.Length; i++){
            var charcarcter = word[caracter-i];            
            invert += charcarcter.ToString();
        }   
        return invert;
    }
}