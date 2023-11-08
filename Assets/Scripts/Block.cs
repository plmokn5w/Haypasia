using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Block<T> : MonoBehaviour
{
    public T returnValue { get; private set; }
    private Type[] parameterTypes;
    public void AddArgument<X>(GameObject block, int index)
    {
        Block<X> argument = block.GetComponent<Block<X>>();
        if (argument.GetType() == parameterTypes[index])
        {
            block.transform.SetParent(transform);
            block.transform.SetSiblingIndex(index);
        }
    }
    public void AddSubBlock(GameObject block, int index)
    {
        block.transform.SetParent(transform);
        block.transform.SetSiblingIndex(parameterTypes.Length + index);
    }
    public virtual void Function()
    {
        Debug.Log("ºí·°ÀÇ Function");
    }
}
