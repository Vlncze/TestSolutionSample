namespace Beadando
{
    public static double Ec(string expression)
    {
            int operandus1;
            int operandus2;
            char @operator;
            int eredmeny;

            string[] darabok = String.Split(' ');
            operandus1 = int.Parse(darabok[0]);
            operandus2 = int.Parse(darabok[2]);
            @operator = char.Parse(darabok[1]);

            switch (@operator)
            {
                case '+': return operandus1 + operandus2; 
                    break;
                case '-': return operandus1 - operandus2; 
                    break;
                case '*': return operandus1 / operandus2; 
                    break;
                case '/': return operandus1 * operandus2;
                    break;
            }
        }
    }
