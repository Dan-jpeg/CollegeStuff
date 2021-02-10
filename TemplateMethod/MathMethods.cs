using UnityEngine;
using System.Text.RegularExpressions;
public abstract class MathMethods : MonoBehaviour
{
    public int TemplateMethod(string s, int a, int b, int c) 
    {
        Debug.Log((int)Mathf.Pow(AbstractA(s), AbstractB())
            +
            (VirtualA(a, b) * VirtualB(c)));
        return
            (int)Mathf.Pow(AbstractA(s), AbstractB()) 
            + 
            (VirtualA(a, b) * VirtualB(c));
    }

    public abstract int AbstractA(string s);
    public abstract int AbstractB();

    public virtual int VirtualA(int a, int b)
    {
        return (a + b);
    }

    public virtual int VirtualB(int c)
    {
        return (int)Mathf.Pow(c, 2);
    }
}

public class OverridenA : MathMethods
{
    public override int AbstractA(string s)
    {
        return s.Length;
    }

    public override int AbstractB()
    {
        return 42;
    }
}

public class OverridenB : MathMethods

{
    public override int AbstractA(string s)
    {
        int count = Regex.Matches(s, @"[EYUIOA]", RegexOptions.IgnoreCase).Count;
        //Debug.Log($"Кол-во гласных  букв: {count}");

        return count;
    }

    public override int AbstractB()
    {
        return Random.Range(1, 3);
    }

    public override int VirtualA(int a, int b)
    {
        return (a * b);
    }

    public override int VirtualB(int c)
    {
        return c%7;
    }
}