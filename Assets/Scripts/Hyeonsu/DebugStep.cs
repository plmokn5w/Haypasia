using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugStep : MonoBehaviour
{
    Queue<Vector3> dir = new Queue<Vector3>();
    float debugDelay = 1f;
    public void MoveToBlock(Block block)
    {
        dir.Enqueue(block.transform.position + new Vector3(-30, 0, 0));
    }

    public void Update()
    {
        if (debugDelay <= 0)
        {
            if (dir.Count > 0)
            {
                transform.position = dir.Peek();
                dir.Dequeue();
                debugDelay = 1f;
            }
        }
        else
            debugDelay -= Time.deltaTime;

    }
}
