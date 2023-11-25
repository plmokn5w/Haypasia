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
        argBlocks[0].DebugFunc();
        argBlocks[1].DebugFunc();
        argBlocks[2].DebugFunc();
        string key = argBlocks[0].GetValue() as string;
        int First = 0, Second = 0;

        int? first = argBlocks[1].GetValue() as int?;
        if (first.HasValue)First = first.Value;

        int? second = argBlocks[2].GetValue() as int?;
        if (second.HasValue) Second = second.Value;

        Variable.SetVariable(key,First);
        while (Variable.GetVariable(key)<Second)
        {
            Block curBlock = subBlocks[0];
            while (curBlock is not null)
            {
                curBlock.DebugFunc();
                curBlock = curBlock.nextBlock;
            }
            Variable.SetVariable(key, Variable.GetVariable(key)+1);
            Debug.Log(Variable.GetVariable(key));
        }
        Return:
            Debug.Log("포종료");
    }
}
