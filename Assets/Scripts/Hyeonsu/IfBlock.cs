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
        bool? Bool = argBlocks[0].GetValue() as bool?;
        if (Bool.HasValue)
        {
            
            if (Bool.Value)
            {
                Block curBlock = subBlocks[0];
                while (curBlock is not null)
                {
                    curBlock.Function();
                    curBlock = curBlock.nextBlock;
                }
            }
        }
        if (nextBlock is not null)
            nextBlock = nextBlock.nextBlock;
        Return:
            Debug.Log("이프종료");
    }
}
