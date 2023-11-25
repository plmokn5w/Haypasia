using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Block : MonoBehaviour
{
    public Block nextBlock;
    public Block funcBlock;
    public Block[] argBlocks;
    protected Type[] paramTypes;
    public Block superiorBlock;
    public List<Block> subBlocks;
    public abstract void Function();
    public abstract object GetValue();
    public void DebugOneStep()
    {
        MainBlock.redOne.MoveToBlock(this);
    }
    public void DebugFunc()
    {
        Invoke("DebugOneStep", 1f);
        Invoke("Function", 1f);
    }

}

public abstract class GenericBlock<T> : Block
{
    protected T Value { get; set; }
    public override object GetValue() { return Value; }
    public void SetValue(T value) { Value = value; }
}

public class Procedure : object { }
