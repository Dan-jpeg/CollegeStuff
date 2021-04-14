using UnityEngine;
public class CardView : MonoBehaviour
{
    public CardInstance cardInstance;

    public void Init(CardInstance cardInstance)
    {
        this.cardInstance = cardInstance;
    }
}
