using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dropable : MonoBehaviour, IDropHandler
{

    private void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(100, 40); // 원하는 크기로 조절
    }
    public void OnDrop(PointerEventData eventData){
        GameObject dropped = eventData.pointerDrag;
        Draggable draggable = dropped.GetComponent<Draggable>();
        draggable.transform.position = transform.position;
        draggable.parrentAfterDrag = transform;

        
    }
}
