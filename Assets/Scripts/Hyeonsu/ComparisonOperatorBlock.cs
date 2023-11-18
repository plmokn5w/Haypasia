using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonOperatorBlock : GenericBlock<bool>
{
    public override void Function()
    {
        Debug.Log("비교연산자실행");
        argBlocks[0].Function();
        argBlocks[1].Function();
        int Left=0, Right=0;

        int? left = argBlocks[0].GetValue() as int?;
        if (left.HasValue) Left = left.Value;

        int? right = argBlocks[1].GetValue() as int?;
        if (right.HasValue) Right = right.Value;

        Value = Left > Right;
        //Debug.Log("Left: " + Left+ "Right: "+Right + "Value:" + Value);
        Debug.Log("비교연산자종료");
    }
}
