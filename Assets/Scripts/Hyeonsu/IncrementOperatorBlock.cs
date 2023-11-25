using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementOperatorBlock : GenericBlock<Procedure>
{
    public override void Function()
    {
        Debug.Log("증가연산자실행");
        //  (argBlocks[0] as IntBlock).SetValue((argBlocks[0].GetValue() as int?) + 1);
        Debug.Log("증가연산자종료");
    }
}
