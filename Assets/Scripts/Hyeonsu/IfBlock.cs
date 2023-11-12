using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfBlock : GenericBlock<Procedure>
{
    public override void Function()
    {
        Debug.Log("이프실행");
        if (subBlocks.Count == 0)
            goto Return;
        argBlocks[0].Function();
        if (argBlocks[0].GetValue() as bool? is true)
        {
            Block curBlock = subBlocks[0];
            while (curBlock is not null)
            {
                curBlock.Function();
                curBlock = curBlock.nextBlock;
            }
        }
        nextBlock = nextBlock.nextBlock;
        Return:
            Debug.Log("이프종료");
    }
}
