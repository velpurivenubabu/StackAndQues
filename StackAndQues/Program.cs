namespace StackAndQues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome To DataStructures(Stack And Ques!)");
            Stack stack = new Stack();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.DisplayStack();
            stack.Peek_Pop();
            stack.DisplayStack();
          
        }
    }
}