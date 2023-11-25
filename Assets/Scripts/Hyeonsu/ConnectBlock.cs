using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectBlock : MonoBehaviour
{
    private bool isConnected = false;
    private void OnTriggerStay2D(Collider2D collision) {
        
        if(!this.gameObject.GetComponent<FollowMouse>().isDown&&!isConnected) {
            if(collision.gameObject.CompareTag("Right")) {
                Transform parentTransform = collision.transform.parent;
                Vector3 parentPosition = parentTransform.position;
                float parentWidth = 100f;
                Debug.Log(parentPosition.x);

                Vector3 newPosition = new Vector3(parentPosition.x + parentWidth-990f, parentPosition.y-115.84f, 0);
                GetComponent<RectTransform>().anchoredPosition = newPosition;
                Debug.Log("right");
            }
            else if(collision.gameObject.CompareTag("Down")) {
                Transform parentTransform = collision.transform.parent;
                Vector3 parentPosition = parentTransform.position;
                float parentHeight = parentTransform.localScale.y;

                Vector3 newPosition = new Vector3(parentPosition.x-1000f, parentPosition.y - parentHeight-125, 0);
                transform.position = newPosition;
                Debug.Log("Down");
            }
            isConnected = true;
        }
    }
}
