using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
  [SerializeField] Canvas canvas;
  RectTransform rectTransform;
  CanvasGroup canvasGroup;

  void Awake()
  {
    rectTransform = GetComponent<RectTransform>();
    canvasGroup = GetComponent<CanvasGroup>();
  }

  public void OnPointerDown(PointerEventData eventData)
  {
    Debug.Log("OnPointerDown");
  }

  public void OnBeginDrag(PointerEventData eventData)
  {
    Debug.Log("OnBeginDrag");
    canvasGroup.alpha = .7f;
    canvasGroup.blocksRaycasts = false;
  }

  public void OnDrag(PointerEventData eventData)
  {
    Debug.Log("OnDrag");
    rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
  }

  public void OnEndDrag(PointerEventData eventData)
  {
    Debug.Log("OnEndDrag");
    canvasGroup.alpha = 1f;
    canvasGroup.blocksRaycasts = true;
  }

}
