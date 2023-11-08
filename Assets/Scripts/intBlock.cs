using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * int를 반환하는 함수를 통괄하는 코드
 */
public class intBlock : Block1
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseUp()
    {
        this.isDragging = false;
        
    }

    public int Execute(Transform parentTransform)
    {
        string blockName = parentTransform.name;
        if (blockName.Contains(")"))
            blockName = blockName.Substring(0, blockName.Length - 4);
        Debug.Log(blockName);
        Variable.setCurrentBlock(this);
        int returnValue = Function.intBlock(blockName);
        return returnValue;
    }
}
