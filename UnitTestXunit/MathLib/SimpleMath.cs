namespace MathLib
{
    public class SimpleMath
    {
        // static public int Add(int a, int b) 
        // {
        //     return a + b;
        // }
        // Thay vì viết đầy đủ như trên, có thể dùng syntax ngắn gọn hơn
        static public int Add(int a, int b)
        {
            if(a < 0)
            {
                a++;
            }
           return a + b;
        }
        static public int Subtract(int a, int b) => a - b; // expression-bodied function in C# 6.0
        static public int Multiply(int a, int b) => a * b;
        static public int Divide(int a, int b) => a / b;
        static public int Remainder(int a, int b) => a % b;
    }

}