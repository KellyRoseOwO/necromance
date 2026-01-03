using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIButtonHoverLift : MonoBehaviour,
    IPointerEnterHandler,
    IPointerExitHandler
{
    public RectTransform top;
    public RectTransform basePart;
    public Image topImage;

    public Vector2 hoverOffset = new Vector2(0, 6);
    public Color hoverColor = new Color(0.63f, 0.69f, 0.56f); // #A0B090

    private Vector2 topStart;
    private Vector2 baseStart;
    private Color normalColor;

    void Start()
    {
        topStart = top.anchoredPosition;
        baseStart = basePart.anchoredPosition;
        normalColor = topImage.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        top.anchoredPosition = topStart + hoverOffset;
        basePart.anchoredPosition = baseStart + hoverOffset;
        topImage.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        top.anchoredPosition = topStart;
        basePart.anchoredPosition = baseStart;
        topImage.color = normalColor;
    }
}
