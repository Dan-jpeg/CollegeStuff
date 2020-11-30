using UnityEngine;
public class DelExample : MonoBehaviour
{
    delegate void Message(string a);

    delegate float Operation(float x, float y);
    delegate int OperationFactorial(int x);
    
    delegate string StringSum(string a, string b);

    public string message1;
    public string message2;
    public int factorial;

    private void Start()
    {
        Operation op1 = (x, y) => x + y;
        Debug.Log(op1(0, 1));

        Operation op2 = (x, y) => x - y;
        Debug.Log(op2(0, 1));

        OperationFactorial opFactorial = (x) => Factorial(x);
        Debug.Log(opFactorial(factorial));

        OperationFactorial operationFactorial = delegate (int x)
        {
            //не знаю, что не 
            Factorial(factorial);
            return (factorial);
        };
        Debug.Log(operationFactorial(factorial));

        StringSum stringSum = (a, b) => message1 + message2;
        Debug.Log(stringSum(message1, message2));

        Message message;
        message = MyMessage;
        message("Делегаты");
        message("это круто");
        message("Делегаты это круто");
    }
    private static void MyMessage(string a)
    {
        Debug.Log($"{a}");
    }
    #region Second Task
    static int Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }
    #endregion
}