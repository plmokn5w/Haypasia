using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBlock : GenericBlock<int>
{
    private static int HaveItem=0;
    public static int GetHaveItem() { return HaveItem; }
    public override void Function()
    {
        Debug.Log("대입실행");
        if (argBlocks[0] is null)
        {
            this.Value = HaveItem;
        }
        else
        {
            Debug.Log("대입할 값은: ");
            int? value = argBlocks[0].GetValue() as int?;
            if (value.HasValue)
            {
                int Int = value.Value;
                HaveItem = Int;
                this.Value = HaveItem;
            }
            
        }
        Debug.Log("대입종료");
    }
}
