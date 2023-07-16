internal class Program
{
    private static void Main(string[] args)
    {
       Console.WriteLine($"the parentheses order is: {isInOrder("){})")}");
    }
    
    public static bool isInOrder(string input)
    {
        
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < input.Length; i++)
        {
            char character = input[i];
            if (character == '[' || character == '{' || character == '(')
                stack.Push(character);
            else if (character == ']' || character == '}' || character == ')')
            {
                if (!stack.Any()) 
                    return false;
                switch (character)
                {
                    case ']':
                        if (stack.Pop() != '[')
                            return false;
                        break;
                    case '}':
                        if (stack.Pop() != '{')
                            return false;
                        break;
                    case ')':
                        if (stack.Pop() != '(')
                            return false;
                        break;
                    default:
                        break;
                }
            }
        }
       
        if (!stack.Any())
            return true;
        return false;
    }
}

