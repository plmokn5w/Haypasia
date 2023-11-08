using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * void를 반환하는 함수를 통괄하는 코드
 */
public class voidBlock : Block1
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame



    private void OnMouseUp()
    {
        this.isDragging = false;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y += 3;
        Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition);
        if (hitCollider != null)
        {
            Block1 hitBlock = hitCollider.GetComponent<Block1>();
            if (hitBlock != null)
            {
                transform.SetParent(hitBlock.transform);
                transform.position = hitBlock.transform.position + new Vector3(0, -3, 0);
            }

            startBlock startBlock = hitCollider.GetComponent<startBlock>();
            if (startBlock != null)
            {
                transform.SetParent(startBlock.transform);
                transform.position = startBlock.transform.position + new Vector3(0, -3, 0);
            }
        }
    }

    public int Execute(Transform parentTransform)
    {
        string blockName = parentTransform.name;
        if (blockName.Contains(")"))
            blockName = blockName.Substring(0, blockName.Length - 4);

        Debug.Log("current: " + blockName);
        Variable.setCurrentBlock(this);
        Function.voidBlock(blockName);
        Debug.Log("Index: " + Variable.getIndex());
        if (parentTransform.childCount >= 2)
        {
            Execute(parentTransform.GetChild(1));
        }

        return Variable.getAns();
    }
}
