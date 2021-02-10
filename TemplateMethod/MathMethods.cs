using UnityEngine;

public abstract class MathMethods : MonoBehaviour
{
    public int TemplateMethod(string s, int a, int b, int c) 
    {
        return
            (int)Mathf.Pow(AbstractA(s), AbstractB()) 
            + 
            (VirtualA(a, b) * VirtualB(c));
    }

    public abstract int AbstractA(string s);
    public abstract int AbstractB();

    public virtual int VirtualA(int a, int b)
    {
        Debug.Log(a + b);
        return (a + b);
    }

    public virtual int VirtualB(int c)
    {
        Debug.Log((int)Mathf.Pow(c, 2));
        return (int)Mathf.Pow(c, 2);
    }
}