using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntArrayBlock : GenericBlock<int[]>
{
    public ref int GetValue(int index) { return ref Value[index]; }

    public override void Function() { }
}
