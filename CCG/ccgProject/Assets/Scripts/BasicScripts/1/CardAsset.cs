using UnityEngine;

[CreateAssetMenu]

public class CardAsset : ScriptableObject
{
    [SerializeField] private string cardName;
    [SerializeField] private CardType cardType;
    [SerializeField] private Color color;
    [SerializeField] private Texture2D cardImage;
    public enum CardType
    {
        Spell,
        Creature
    }
}
