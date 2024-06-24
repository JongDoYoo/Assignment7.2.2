namespace Assignment7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "discombobulate";
            string output = ReverseVowels(input); 

            Console.WriteLine(output);   //why did he do it like this?
        }

        static string ReverseVowels(string input)
        {           
            int i = 0;
            int j = input.Length-1;
            char[] str1 = input.ToCharArray();              //convert string to characters of ARRAY bc its easier to manipulate

            while (i < j)      //it will start itierating and stop until the i's index is greater than j's index (in this case, it'll stop in the middle)
            {
                if (!IsVowel(str1[i]))    //condition if the first index of input is a vowel
                {
                    i++;
                    continue;
                }

                if (!IsVowel(str1[j]))    //condition if the first index of input is a vowel
                {
                    j--;
                    continue;
                }        
                
                //3 way swap.. swap vowels
                char temp = str1[i];
                str1[i] = str1[j];
                str1[j] = temp; 

                i++;
                j--;
                
            }
            String str2 = String.Join("", str1);      //convert back to a string
            return str2;


            static Boolean IsVowel(char c)                  //we packaged up the vowel finder by making a separate method
                                                            // not really necessary but just looks neater..
                                                            //you can always input this inside the reversevowel method if statements
            {
                return (c == 'A' || c == 'a' || c == 'E' || c == 'e' || c == 'I' || c == 'i' || c == 'O' || c == 'o' || c == 'U' || c == 'u');
            }
        }
    }
}
