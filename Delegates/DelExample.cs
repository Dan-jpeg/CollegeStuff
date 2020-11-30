using UnityEngine;
public class DelExample : MonoBehaviour
{
    delegate void Message();
    delegate float Operation(float x, float y);
    delegate int OperationFactorial(int x);
    delegate string StringSum(string a, string b);

    public string message1;
    public string message2;

    private void Start()
    {
        Message mes;

        Operation op1 = (x, y) => x + y;
        Debug.Log(op1(0, 1));

        Operation op2 = (x, y) => x - y;
        Debug.Log(op2(0, 1));

        OperationFactorial opFactorial = (x) => Factorial(x);
        Debug.Log(opFactorial(5));

        StringSum stringSum = (a, b) => message1 + message2;
        Debug.Log(stringSum(message1, message2));

        mes = FirstMessage;
        mes();

        mes = SecondMessage;
        mes();

        mes = FinalMessage;
        mes();
    }
    #region First Task
    private static void FirstMessage()
    {
        string message1 = "Делегаты";
        Debug.Log($"{message1}");
    }
    private static void SecondMessage()
    {
        string message2 = "это круто";
        Debug.Log($"{message2}");
    }
    private static void FinalMessage()
    {
        string message3 = "Делегаты это круто";
        Debug.Log($"{message3}");
    }
    #endregion

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
    #region Third Task
    //private static string StringSum(string a, string b)
    //{
    //    return (a + b);
    //}
    #endregion
}