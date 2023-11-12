using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    public Transform parrentAfterDrag;

    private bool isDragging = false;
    public bool isConnect = false;
    void Start()
    {
        // Collider2D 추가
        if (GetComponent<Collider2D>() == null)
        {
            gameObject.AddComponent<BoxCollider2D>();
        }
    }


    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("start");
        isDragging = true;
        //parrentAfterDrag = transform.parent;
        //transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }
    public void OnDrag(PointerEventData eventData) {
        Debug.Log("ing");
        if(!isConnect) transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("end");
        isDragging = false;
        //transform.SetParent(parrentAfterDrag);
        image.raycastTarget = true;
    }
    /*
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDragging && collision.gameObject.CompareTag("Function_right"))
        {
            // 여기에 충돌했을 때의 로직 추가
            Debug.Log(collision.transform.localPosition);
            gameObject.transform.localPosition = collision.transform.localPosition + new Vector3(105, 0, 0);
            Debug.Log("Collision with another block: " + collision.gameObject.name);
        }
        else if (isDragging && collision.gameObject.CompareTag("Function_down"))
        {
            // 여기에 충돌했을 때의 로직 추가
            Debug.Log(collision.transform.localPosition);
            gameObject.transform.localPosition = collision.transform.localPosition + new Vector3(0, 40, 0);
            Debug.Log("Collision with another block: " + collision.gameObject.name);
        }
    }
    */
    
}
