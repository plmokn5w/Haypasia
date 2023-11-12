using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForBlock : GenericBlock<Procedure>
{
    public override void Function()
    {
        Debug.Log("포실행");
        if (subBlocks.Count == 0)
            goto Return;
        argBlocks[0].Function();
        argBlocks[1].Function();
        while (argBlocks[1].GetValue() as bool? is true)
        {
            Block curBlock = subBlocks[0];
            while (curBlock is not null)
            {
                curBlock.Function();
                curBlock = curBlock.nextBlock;
            }
            argBlocks[2].Function();
            argBlocks[1].Function();
        }
        Return:
            Debug.Log("포종료");
    }
}
