using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintBlock : GenericBlock<Procedure>
{
    public override void Function()
    {
        Debug.Log("프린트실행");
        //string massage = argBlocks[0].GetValue() as string;
        //Debug.Log(massage);
        Debug.Log("프린트");
        Debug.Log("프린트종료");
    }
}
