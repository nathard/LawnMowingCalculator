using System;
public class MowingCalculator
{
    public static float GetFloat(string message)
    {
        float data;
        do Console.Write(message);
        while (float.TryParse(Console.ReadLine(), out data) == false || data < 0F); // END WHILE
        return data;
    }

    public static void Main()
    {


        string answer;
        do
        {
            float BlockLength = GetFloat("Enter the Block Length in metres (>= 0, e.g. 70.6)): ");
            float BlockWidth = GetFloat("Enter the Block Width in metres (>= 0, e.g. 15.2)): ");

            float HouseLength;
            do
            {
                HouseLength = GetFloat("Enter the House Length in metres (>= 0, e.g. 60.6)): ");
                if (HouseLength > BlockLength)
                    Console.WriteLine("Check the input should be less than the block");
            } while (HouseLength > BlockLength);

            float HouseWidth;
            do
            {
                HouseWidth = GetFloat("Enter the House Width in metres (>= 0, e.g. 12.6)): ");
                if (HouseWidth > BlockWidth) Console.WriteLine("Check the input should be less than the block");
            } while (HouseWidth > BlockWidth);

            Console.WriteLine("The mowing time: " + (BlockLength * BlockWidth - HouseLength * HouseWidth) / 2F + " in second(s).");

            Console.Write("More calculation (y/n)? ");
            answer = Console.ReadLine();
        } while (answer.ToLower() == "y");
    }
}
