/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK

*/
using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }


        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            // looping to check for vowels present in string

            // Also we form a string without vowels by concatenating
            try
            {
                string final_string = "";  //output varaible
                foreach (char ch in s)
                {
                    // comparing character with vowel.
                    if (ch != 'a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u' && ch != 'A' && ch != 'E' && ch != 'I' && ch != 'O' && ch != 'U')
                    {
                        final_string += ch;
                    }
                }
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /*<summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
        Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
        Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
        Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {  //Here we use Concat function to combine the strings in array to form a string.
            try
            {
                string bulls_string1_tot1 = string.Concat(bulls_string1); //Concatenating  elements of bulls_string1
                string bulls_string2_tot2 = string.Concat(bulls_string2); //Concatenating  elements of bulls_string2
                if (bulls_string1_tot1 == bulls_string2_tot2) //checking for equality
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */
        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {

                int[] arr = new int[100]; //secondary array to store the counts of corresponding elements.
                int pos = 0; //temporary variable that mimicks the actual element. 
                int sum = 0;  //output variable
                foreach (int i in bull_bucks)
                {
                    arr[i - 1] = arr[i - 1] + 1; //storing the counts of each element by running a loop
                }
                foreach (int i in arr)
                {
                    pos += 1;
                    if (i == 1)  //filter unique elements
                    {
                        sum = sum + pos;
                    }

                }
                return sum;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
       <summary>
      Given a square matrix bulls_grid, return the sum of the matrix diagonals.
      Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
      Example 1:
      Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
      Output: 25
      Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
      Notice that element mat[1][1] = 5 is counted only once.
      Example 2:
      Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
      Output: 8
      Example 3:
      Input: bulls_grid = [[5]]
      Output: 5
      </summary>
       */

        private static int DiagonalSum(int[,] bulls_grid)
        {

            //finding the diagonal elements of 1st diagonal by using i==j condition where i represents rows and j represent the columns

            //The second diagonal elements is found by using i+j == size-1 

            try
            {
                int sum = 0;
                int size = bulls_grid.GetLength(0);

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (i == j)
                        {
                            sum = sum + bulls_grid[i, j]; //  sum of first diagonal elements
                        }
                        if (i + j == size - 1 && i != j) // filter second diagonal elements && we use i!=j to remove duplicate element
                        {
                            sum = sum + bulls_grid[i, j];  //sum of first and second diagonal elements
                        }
                    }
                }
                return sum;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        /* <summary>
         Given a string bulls_string  and an integer array indices of the same length.
         The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
         Return the shuffled string.
         Example 3:
         Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
         Output: "nihao"
         */
        private static string RestoreString(string bulls_string, int[] indices)
        { //Array.IndexOf() method is used to get the index and this index will be used in the string.
            try
            {
                string temp = "";  // output variable
                for (int i = 0; i < indices.Length; i++) //runs from 0 to length-1
                {  //Array.IndexOf() gives the index present at i.that index is used to access the character in bulls_string which goes in
                   ////the increasing order so that we form the string accordingly
                    temp += bulls_string[Array.IndexOf(indices, i)];
                }

                return temp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        /*
        <summary>
       Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
       For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
       Return the resulting string.
       Example 1:
       Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
       Output: "camumollegeofbusiness"
       Explanation: The first occurrence of "c" is at index 4. 
       Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
       Example 2:
       Input: bulls_string   = "xyxzxe", ch = "z"
       Output: "zxyxxe"
       Explanation: The first and only occurrence of "z" is at index 3.
       Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
       Example 3:
       Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
       Output: "zimmermanschoolofadvertising"
       Explanation: "x" does not exist in word.
       You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
       */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                int i = 0;
                string prefix_string = ""; //output string varaiable
                for (int k = 0; k < bulls_string6.Length; k++) // checking for the given character in the string 
                {

                    if (ch == bulls_string6[k])
                    {
                        i = k;
                        break; //only first occurence 
                    }

                }

                for (int j = i; j >= 0; j--)  //running loop in decremental order to form a reverse string
                {
                    prefix_string = prefix_string + bulls_string6[j];

                }
                for (int j = i + 1; j < bulls_string6.Length; j++) //joining the reverse string with the rest of string
                {
                    prefix_string = prefix_string + bulls_string6[j];
                }

                return prefix_string; //reversed string


            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}



