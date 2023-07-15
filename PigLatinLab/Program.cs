using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

Console.WriteLine("Welcome to the Pig Latin Translator!");
bool runProgram = true;
while (runProgram)
{
    PigLatin();

    int x = 0;
    while (x == 0)
    {
        Console.WriteLine("Would you like to translate another word? (y/n)");
        string yesNo = Console.ReadLine().ToLower().Trim();
        if (yesNo == "y")
        {
            runProgram = true;
            x++;
        }
        else if (yesNo == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid Response.");
        }
    }
}
   


//////////////////     Methods    --------------
//static string Puncuation(string input)
//{
//    if (input.EndsWith().IsPunctuation() == true)
//    if (x == ".")
//        return '.';
//}


//static string RemovePunctuation(string input) 
//{
//    string result = "";
//    foreach(char c in input)
//    {
//        if (!Regex.IsMatch(c.ToString(),@"[.,\/#!$%\^&\*;:{}=\-_~()@?]"))
//    }
//    return "";
//}


static void PigLatin()
{
    //ask for word
    Console.WriteLine("Please enter a word.");
    string input1 = Console.ReadLine();
    bool containsNumber =input1.Any(char.IsDigit);
    if (containsNumber == false)
    {
        // make lower case                             
        string input = input1.ToLower();
        string[] splitWords = input.Split(' ').ToArray();
        foreach (string struggling in splitWords)



            //for (int i = 0; i < (input.Length); i++)    
            if (VowelFirst(struggling) == true)           //(input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
            {
                string s = Regex.Replace(struggling, @"[^A-Za-z]", string.Empty);
                //if it starts with a vowel add way onto the ending,
                Console.WriteLine($"{(s)}way");
            }
            else
            {
                string s = Regex.Replace(struggling, @"[^A-Za-z]", string.Empty);
                //two substrings to build the word ------- result = second half of word + first half + ay ( get those halfs with substrings)
                Console.WriteLine($"{Consonant(s)}");
            }
    }    
    else
    {
        Console.WriteLine(input1);
        Console.WriteLine("No numbers please.");
    }
}

static string Punctuation(string input) 
{
    foreach(char c in input)
    {
        for (int i = 0; i < (input.Length); i++)
        {
            if (input[i] == '.' || input[i] == ',' || input[i] == '!' || input[i] == '?' || input[i] == '"' || input[i] == '@' || input[i] == '#' || input[i] == '<' || input[i] == '@')
            {
                string translation = input.Substring(input[i], 1);
                return translation;
            }
            else
            {
                return "";
            }
        }
    }
    return "";
}


static string Consonant(string input)
{

   

    for (int i = 0; i < (input.Length); i++)
    {
        if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
        {
            //call back the letters from the array 
            string half1 = input.Substring(0, i);
            string half2 = input.Substring(i, input.Length - i);
            string translation = half2 + half1 + "ay";
            return translation;
        }
    }
    return input + "ay";
}


    
static bool VowelFirst(string input)
{
    string vowel = input.Substring(0, 1);
    if (input[0] == 'a' || input[0] == 'e' || input[0] == 'i' || input[0] == 'o' || input[0] == 'u')
    {
        return true;
    }
    else 
    {
        return false;
    }
}





//4 bonus points
//1. keep the case of the word whether is all UPPERCASE, lower case, or Title Case
//2. allow punctation in the input string.
//3. translate words with contractions ------ can't =an'tcay
//4. dont translate words that have numbers or symbols. Example --- 189 = 189 
                           //4. continued hello@GrandCircus.com = hello@GrandCircus.com
//
//
//use a for each and a split together for extra credit for each ------(string word in Sentence.Split("")){
//}                                                                         use word instead of input variable

