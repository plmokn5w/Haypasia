using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintBlock : GenericBlock<Procedure>
{
    public override void Function()
    {
        Debug.Log("����Ʈ����");
        //string massage = argBlocks[0].GetValue() as string;
        //Debug.Log(massage);
        Debug.Log("����Ʈ");
        Debug.Log("����Ʈ����");
    }
}
