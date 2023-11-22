using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectBlock : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Right")) {
            Transform parentTransform = collision.transform.parent;
            Vector3 parentPosition = parentTransform.position;
            float parentWidth = parentTransform.localScale.x;

            Vector3 newPosition = new Vector3(parentPosition.x + parentWidth, parentPosition.y, 0);
            transform.position = newPosition;
        }
        else if(collision.gameObject.CompareTag("Down")) {
            Transform parentTransform = collision.transform.parent;
            Vector3 parentPosition = parentTransform.position;
            float parentHeight = parentTransform.localScale.y;

            Vector3 newPosition = new Vector3(parentPosition.x, parentPosition.y - parentHeight, 0);
            transform.position = newPosition;
        }
    }
}
