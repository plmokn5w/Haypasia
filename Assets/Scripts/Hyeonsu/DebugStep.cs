using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugStep : MonoBehaviour
{
    public void MoveToBlock(Block block)
    {
        transform.position = block.transform.position + new Vector3(-30, 0, 0);
    }
}
