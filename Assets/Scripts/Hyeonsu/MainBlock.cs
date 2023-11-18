using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBlock : GenericBlock<Procedure>
{
    public override void Function()
    {
        Debug.Log("메인실행");
        Variable.init();
        if (subBlocks.Count == 0)
            goto Return;
        Block curBlock = subBlocks[0];
        while (curBlock is not null)
        {
            curBlock.Function();
            curBlock = curBlock.nextBlock;
        }
    Return:
        Debug.Log("결과는:"+ItemBlock.GetHaveItem());
        Debug.Log("메인종료");
    }
}
