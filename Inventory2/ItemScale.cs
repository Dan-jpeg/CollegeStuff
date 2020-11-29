using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(CanvasGroup))]

public class ItemScale : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    public RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    public AudioSource click;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        click.Play();
        Debug.Log("Click");
    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        rectTransform.sizeDelta *= 1.5f;
        Debug.Log("Cursor on our Image!");
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        rectTransform.sizeDelta /= 1.5f;
        Debug.Log("We lost the Cursor!");
    }

}
