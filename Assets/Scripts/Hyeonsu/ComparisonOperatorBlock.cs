using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonOperatorBlock : GenericBlock<bool>
{
    public override void Function()
    {
        Debug.Log("�񱳿����ڽ���");
        argBlocks[0].Function();
        argBlocks[1].Function();
        int? left = argBlocks[0].GetValue() as int?;
        int? right = argBlocks[1].GetValue() as int?;
        Value = left > right;
        Debug.Log("�񱳿���������");
    }
}
