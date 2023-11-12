using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Block : MonoBehaviour
{
    public Block nextBlock;
    public Block[] argBlocks;
    protected Type[] paramTypes;
    public List<Block> subBlocks;
    public abstract void Function();
    public abstract object GetValue();
}

public abstract class GenericBlock<T> : Block
{
    public T Value { get; set; }
    public override object GetValue() { return Value; }
}

public class Procedure : object { }
