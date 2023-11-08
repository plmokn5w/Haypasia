using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    public Transform parrentAfterDrag;
    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("start");
        parrentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }
    public void OnDrag(PointerEventData eventData) {
        Debug.Log("ing");
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("end");
        transform.SetParent(parrentAfterDrag);
        image.raycastTarget = true;
    }
    
    
}
