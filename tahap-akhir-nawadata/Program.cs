namespace TesNawadata
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Counting words on a sentence");
                Console.WriteLine("2. Find Largest Number in array");
                Console.WriteLine("3. Sorting Array from minimum value");
                Console.WriteLine("4. Find most freq char in a word");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        wordCount();
                        break;
                    case "2":
                        findLargestNumber();
                        break;
                    case "3":
                        sortingNumber();
                        break;
                    case "4":
                        findMostChar();
                        break;
                    case "5":
                        Console.WriteLine("Ex1iting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        //menghitung jumlah kata pada kalimat
        static void wordCount()
        {
            String sentence = "Halo, nama saya John Doe";
            int wordCounting = 0;
            int indexStart = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ' || i == sentence.Length - 1)
                {
                    String word = sentence.Substring(indexStart, i - indexStart);
                    Console.WriteLine(word);
                    wordCounting++;
                    indexStart = i + 1;
                }
            }

            Console.WriteLine($"Jumlah kata : {wordCounting}");
            Console.WriteLine(
                "=========================================================================================");
        }

        //mencari angka terbesar pada array
        static void findLargestNumber()
        {
            int[] numbers = { 1, 5, 3, 7, 2 };
            int largestNum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largestNum)
                {
                    largestNum = numbers[i];
                }
            }

            Console.WriteLine($"Angka terbesar pada array adalah : {largestNum}");
            Console.WriteLine(
                "=========================================================================================");
        }
        //mengurutkan angka dari yang terkecil
        static void sortingNumber()
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            int temporary;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++) 
                {
                    if (numbers[i] > numbers[j]) 
                    {
                        temporary = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temporary;
                    }
                }
            }

            Console.WriteLine("Urutan angka dari yang terkecil adalah:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
        }

        

        //mencari huruf paling sering keluar di sebuah kata
        static void findMostChar()
        {
            String word = "Hello";
            int[] charCount = new int [26];

            foreach (char chars in word.ToLower())
            {
                if (chars >= 'a' && chars <= 'z')
                {
                    charCount[chars - 'a']++;
                }
            }

            int maxCount = 0;
            char mostChar = 'a';
            for (int i = 0; i < 26; i++)
            {
                if (charCount[i] > maxCount)
                {
                    maxCount = charCount[i];
                    mostChar = (char)(i + 'a');
                }
            }

            Console.WriteLine($"Huruf paling banyak keluar dalam kata {word} adalah {mostChar}");
            Console.WriteLine(
                "=========================================================================================");
        }
    }
}