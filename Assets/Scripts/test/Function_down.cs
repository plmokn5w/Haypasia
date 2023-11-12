using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function_down : MonoBehaviour
{
    private bool isDragging = false;

    void Start()
    {
        // Collider2D 추가
        if (GetComponent<Collider2D>() == null)
        {
            gameObject.AddComponent<BoxCollider2D>();
        }
    }

    void Update(){
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
        } 
        if (Input.GetMouseButtonUp(0)) {
            isDragging = false;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDragging && collision.gameObject.CompareTag("Function"))
        {
            // 여기에 충돌했을 때의 로직 추가
            collision.gameObject.GetComponent<Drag>().isConnect = true;
            Debug.Log(collision.transform.localPosition);
            collision.transform.localPosition =gameObject.transform.parent.transform.localPosition + new Vector3(0, -45, 0);
            Debug.Log("Collision with another block: " + collision.gameObject.name);
        }
        
    }
}
