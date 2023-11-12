using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntBlock : GenericBlock<int>
{
    public override void Function()
    {
        count++;
        Debug.Log("°ª = " + count);
        Value = count;
    }

    public static int count = 0;
}
