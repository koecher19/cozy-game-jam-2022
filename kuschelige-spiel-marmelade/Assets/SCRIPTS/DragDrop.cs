using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    // Refer to the Canvas Group put into one Item
    [SerializeField] 
    private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector3 bigScale, smallScale;
    private bool isBig;
    public float newScale = 1f;
    private Vector3 scaleVector;

        void Start()
    {
        scaleVector.Set(newScale, newScale, 1);
        this.transform.localScale = scaleVector;
        
        bigScale = new Vector3(2f, 2f, 2f);
        smallScale = new Vector3(1f, 1f, 1f);
        isBig = true;
    }

    // So that Canvas and Slot actually works with one another
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Begin to Drag the Item, so you can click on it and have it attached to ur mouse
   public void OnBeginDrag(PointerEventData eventData)
   {
    Debug.Log("OnBeginDrag");
    canvasGroup.blocksRaycasts = false;
   }
   
   // So you can Drag the Item everywhere
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    // Snatching to the Canvas made easy
   public void OnEndDrag(PointerEventData eventDate)
   {
        Debug.Log("OnEndDrag");
        canvasGroup.blocksRaycasts = true;
   }
   
    // Press mouse Button
    public void OnPointerDown(PointerEventData eventData)
    {
        transform.localScale = isBig ? smallScale : bigScale;
        isBig = !isBig;
        Debug.Log("OnPointerDown");
    }
}
