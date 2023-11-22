using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private bool isFollowing = false;

    void Update()
    {
        // 마우스 왼쪽 버튼을 누르면
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 위치에 대한 Ray를 생성
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            // Ray가 어떤 Collider와 충돌했는지 확인
            if (hit.collider != null)
            {
                
                if (hit.collider.gameObject.CompareTag("Block"))
                {
                    // 여기에 원하는 동작을 추가

            
                    transform.localPosition = mousePosition;
                }
            }
        }
    
    /*
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;

            
            transform.position = mousePosition;
        }

        */
    }
}
