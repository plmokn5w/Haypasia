using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementOperatorBlock : GenericBlock<Procedure>
{
    public override void Function()
    {
        Debug.Log("���������ڽ���");
        //  (argBlocks[0] as IntBlock).SetValue((argBlocks[0].GetValue() as int?) + 1);
        Debug.Log("��������������");
    }
}
