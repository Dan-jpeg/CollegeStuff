using UnityEngine;

public class MathDebuger : MonoBehaviour
{
    private OverridenA overridenA = null;
    private OverridenB overridenB = null;
    private void OnEnable()
    {
        if (overridenA == null)
            overridenA = new OverridenA();
        if (overridenB == null)
            overridenB = new OverridenB();
    }
    private void Start()
    {
        //overridenA.TemplateMethod("Z",2,4,8); можно раскомментировать
        overridenB.TemplateMethod("ZOO",2,4,8);
    }
}