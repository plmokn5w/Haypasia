using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlockDragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x + offset.x, mousePosition.y + offset.y, 0);
        }
    }

    void OnMouseDown()
    {
        isDragging = true;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - mousePosition;
    }

    void OnMouseUp()
    {
        isDragging = false;
        CheckAndSnapToOtherBlocks();
    }

    void CheckAndSnapToOtherBlocks()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero);

        if (hit.collider != null && hit.collider.CompareTag("Function"))
        {
            // 여기에 붙이기 로직 추가
            SnapToOtherBlock(hit.collider.transform);
        }
    }

    void SnapToOtherBlock(Transform otherBlock)
    {
        // 여기에 블록을 다른 블록에 맞추는 로직 추가
        // 예를 들어, 다른 블록의 위치에 맞추거나 다른 블록의 자식으로 넣는 등의 동작을 수행할 수 있습니다.
    }
}