using System;

namespace Bonus_Homework_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise_01

            //1. Write a C# Sharp program to find the sum of first 10 natural numbers
            // *Hint: The first 10 natural number are: 1 2 3 4 5 6 7 8 9 10

            //int[] naturalNumbers = new int [10]{1,2,3,4,5,6,7,8,9,10 };
            //int sum = 0;
            //Console.WriteLine("Press Enter To See The First 10 Natural Numbers");
            //Console.ReadLine();

            //for (int i = 1; i <= naturalNumbers.Length; i++)
            //{
            //    sum += i;
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("Press Enter Again To See The Sum Of The First 10 Natural Numbers");

            //Console.ReadLine();

            //Console.WriteLine("The Sum of the first 10 natural numbers is :" + sum);
            //Console.ReadLine();
            #endregion

            #region Exercise_02
            //2.Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
            //Console.WriteLine("Enter Any Ten Numbers: ");
            //int[] inputArray = new int[10];
            //int numberSum = 0;
            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    inputArray[i] = int.Parse(Console.ReadLine());
            //    numberSum += inputArray[i];

            //}
            //Console.WriteLine("The Sum Of The Numbers Is :" + numberSum);

            //int average;
            //average = numberSum / 10;
            //Console.WriteLine("The Average Of The Input Numbers is:" + average);
            #endregion

            #region
            //3.Declare and init array of 10 integers by your choise. 
            //Find maximum and minimum element in that array and their indexes.

            //int[] someNumbers = new int[10] { 31, 15, 17, 20, 18, 47, 54, 14, 20, 45 };
            //int min ;
            //int max ;

            //min = someNumbers[0];
            //max = someNumbers[0];

            //for (int i = 1; i < someNumbers.Length; i++)
            //{
            //    if (min > someNumbers[i])
            //    {
            //        min = someNumbers[i];
            //    }
            //    else if (max < someNumbers[i])
            //    {
            //        max = someNumbers[i];
            //    }

            //}
            //Console.WriteLine("The Minium Element In The Array is : " + min + " and it's index is "  + Array.IndexOf(someNumbers, min));
            //Console.WriteLine("The Maximum Element In The Array is : " + max + " and it's index is " + Array.IndexOf(someNumbers,max));
            //Console.ReadLine();
            #endregion


            #region Exercise_04
            //4. arrayWithDuplicates = [1, 4, 6, 3, 4, 5, 9, 3, 2, 9]
            // Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates

            //int[] arrayWithDuplicates = new int[]{ 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };
            //int duplicate = 0;
            //for (int i = 0; i < arrayWithDuplicates.Length; i++)
            //{
            //    for (int j = i +1; j < arrayWithDuplicates.Length; j++)
            //    {
            //        if (arrayWithDuplicates[i] == arrayWithDuplicates[j])
            //        {
            //            duplicate++;
            //            Console.WriteLine("The Duplicate Elements are: " + arrayWithDuplicates[i]);
            //        }
            //    }
            //}
            //Console.WriteLine($"There are {duplicate} duplicate elements in the array");
            //Console.ReadLine();

            #endregion

            #region Exercise_05
            // 5. oddEvenArray = [10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49]
            // Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays

            //int[] oddEvenArray = { 10, 23, 44, 123, 52, 55, 98, 99, 102, 103, 152, 49 };
            //int[] oddArray = new int[10];
            //int[] evenArray = new int[10];

            //int l = 0;
            //int k = 0;

            //for (int i = 0; i < oddEvenArray.Length; i++)
            //{
            //    if (oddEvenArray[i] % 2 == 0)
            //    {
            //        evenArray[l] = oddEvenArray[i];
            //        Console.WriteLine("The Even Numbers are " + evenArray[l]);


            //    }


            //    else

            //    {
            //        oddArray[k] = oddEvenArray[i];
            //        Console.WriteLine("The Odd Numbers are :" + oddArray[k]);
            //    }
            //}

            #endregion

            #region exercise_06

            //6.Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            // the day with strings.Example: user enters 1, you should print Monday.

            // Console.WriteLine("Please Enter A Number From 1 - 7");
            //string userInput = Console.ReadLine();
            // int input;
            // bool convertedInput = int.TryParse(userInput, out input);
            // switch (input)
            // {
            //     case 1:
            //         Console.WriteLine("Monday");
            //         break;
            //     case 2:
            //         Console.WriteLine("Tuesday");
            //         break;
            //     case 3:
            //         Console.WriteLine("Wednesday");
            //         break;
            //     case 4:
            //         Console.WriteLine("Thursday");
            //         break;
            //     case 5:
            //         Console.WriteLine("Friday");
            //         break;
            //     case 6:
            //         Console.WriteLine("Saturday");
            //         break;
            //     case 7:
            //         Console.WriteLine("Sunday");
            //         break;

            //     default:
            //         Console.WriteLine("Invalid Input. Pleae Enter A Number From 1-7");
            //         break;
            // }
            // Console.ReadLine();
            #endregion

            #region Exercise_07
            // 7.userNames = ["user1", "user2", "user3"]
            // passwords = ["first", "second", "third"]
            //Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //Create a logic when user enters specific username to provide a correct password for that user, and when that
            //happens you should print on the screen "You are logged in successfully".
            //If username or password are invalid or don't correspond "Incorrect username or password" should be print on the screen and 
            //repeat the proccess from begining while he / she doesn't input correct username and password.


            //Note: Every element in userNames corresponds with the element in passwords at same index.
            //Example: password for "user1" is "first", password for "user2" is "second", password for "user3" is "third".
            #endregion

            string[] userNames = { "user1", "user2", "user3" };
            string[] passwords =  {"first", "second", "third"};


            

            while (true)
            {

                Console.WriteLine("Please Enter Your Username: ");
                var userName = Console.ReadLine();
                Console.WriteLine("Please Enter Your Password");
                var userPassword = Console.ReadLine();

            if (userName == userNames[0] && userPassword == passwords[0])
            {
                Console.WriteLine("You are logged in successfully");
                    break;
            }
            
            if (userName == userNames[1] && userPassword == passwords[1])
            {
                Console.WriteLine("You are logged in successfully");
                    break;
                }

            if (userName == userNames[2] && userPassword == passwords[2])
            {
                Console.WriteLine("You are logged in successfully");
                    break;
                }
            else
            {
                Console.WriteLine("Incorrect username or password");

            }
        }
                
        }
    }
        }
    