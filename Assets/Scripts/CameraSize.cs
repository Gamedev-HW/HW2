using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class MinimapUIController : MonoBehaviour
{
    [Range(0.1f, 0.5f)]
    public float widthPercent = 0.25f;

    public float margin = 15f;

    private RectTransform rect;
    private RectTransform canvasRect;

    void Awake()
    {
        rect = GetComponent<RectTransform>();

        Canvas canvas = GetComponentInParent<Canvas>();
        canvasRect = canvas.GetComponent<RectTransform>();

        rect.anchorMin = new Vector2(1, 1);
        rect.anchorMax = new Vector2(1, 1);
        rect.pivot = new Vector2(1, 1);

        rect.localScale = Vector3.one;
    }

    void LateUpdate()
    {
        float width = canvasRect.rect.width * widthPercent;

        // Preserve the minimap's rectangular aspect ratio
        float height = width * 1.1f;

        rect.sizeDelta = new Vector2(width, height);
        rect.anchoredPosition = new Vector2(-margin, -margin);
    }
}