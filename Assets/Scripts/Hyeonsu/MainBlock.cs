using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBlock : GenericBlock<Procedure>
{
    public override void Function()
    {
        Debug.Log("���ν���");
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
        Debug.Log("�����:"+ItemBlock.GetHaveItem());
        Debug.Log("��������");
    }
}
