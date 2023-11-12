using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number_right : MonoBehaviour
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
        if (isDragging && collision.gameObject.CompareTag("Number"))
        {
            // 여기에 충돌했을 때의 로직 추가
            collision.gameObject.GetComponent<Drag>().isConnect = true;
            Debug.Log(gameObject.transform.parent.transform.localPosition);
            collision.transform.localPosition = gameObject.transform.parent.transform.localPosition + new Vector3(105, 0, 0);
            Debug.Log("Collision with another block: " + collision.gameObject.name);
        }
        
    }
}
