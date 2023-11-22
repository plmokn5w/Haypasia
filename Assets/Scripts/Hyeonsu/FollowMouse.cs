using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private bool isFollowing = false;

    void Update()
    {
        // 마우스 왼쪽 버튼이 클릭되었을 때
        if (Input.GetMouseButtonDown(0))
        {
            // 클릭된 경우 따라가기를 시작하거나 중지합니다.
            isFollowing = !isFollowing;
        }

        // 만약 따라가기가 활성화되어 있다면
        if (isFollowing)
        {
            // 현재 마우스 포인터의 위치를 가져옵니다.
            Vector3 mousePosition = Input.mousePosition;

            // 마우스 포인터의 화면 좌표를 월드 좌표로 변환합니다.
            //Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10f));

            // 텍스트 상자의 위치를 마우스 포인터 위치로 설정합니다.
            transform.position = mousePosition;
        }
    }
}
