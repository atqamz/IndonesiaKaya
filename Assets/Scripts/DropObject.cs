using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropObject : MonoBehaviour, IDropHandler
{
  RectTransform rectTransform;
  void Awake()
  {
    rectTransform = GetComponent<RectTransform>();
  }

  public void OnDrop(PointerEventData eventData)
  {
    Debug.Log("OnDrop");

    if (eventData.pointerDrag != null)
    {
      eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = rectTransform.anchoredPosition;
    }
  }
}
