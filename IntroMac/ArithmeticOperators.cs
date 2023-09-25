namespace ArithmeticExercises
{
    public class ArithmeticExercises
    {
        public static double CircleCircumference(double radius)
        {
            Console.WriteLine(Math.Round(Math.PI * radius * 2, 2));
            return Math.PI * radius * 2;
        }

        public static double CircleArea(double radius)
        {
            Console.WriteLine(Math.Round(Math.PI * Math.Pow(radius, 2), 2));
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void Division(int num1, int num2)
        {
            bool hasRemainder = (num1 % num2) != 0;
            Console.WriteLine(hasRemainder);
        }

        public static void CalculateHypotenouse(double side1, double side2)
        {
            double side3 = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
            Console.WriteLine($"The length of the hypotenouse is {Math.Round(side3, 2)}");
        }

        public static void GetBooksDistribution()
        {
            Console.Write("Enter the number of students: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfStudents) && numberOfStudents > 0)

                Console.Write("Enter the number of books: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfBooks) && numberOfBooks > 0)
            {
                int booksPerStudent = numberOfBooks / numberOfStudents;
                int booksLeftOver = numberOfBooks % numberOfStudents;

                Console.WriteLine($"Each student will get {booksPerStudent} book(s).");
                Console.WriteLine($"There will be {booksLeftOver} book(s) left over.");
            }




        }
    }
}