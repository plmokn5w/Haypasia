using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentOperatorBlock : GenericBlock<Procedure>
{
    public override void Function()
    {
        Debug.Log("���Կ����ڽ���");
        argBlocks[0].Function();
        argBlocks[1].Function();
        Debug.Log("���Կ���������");
    }
}
