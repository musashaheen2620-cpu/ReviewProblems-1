Console.WriteLine("Enter words of a sentence one by one including punctuation:");
string sentence = "";          
string word = Console.ReadLine();

while (word != "")
{ 
    sentence = sentence + word + " ";  
    word = Console.ReadLine();         
}
Console.WriteLine(sentence);   
    
