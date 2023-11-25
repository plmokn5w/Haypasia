using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentOperatorBlock : GenericBlock<Procedure>
{
    public override void Function()
    {
        Debug.Log("대입연산자실행");

        argBlocks[0].DebugFunc();
        argBlocks[1].DebugFunc();
        Debug.Log("대입연산자종료");
    }
}
