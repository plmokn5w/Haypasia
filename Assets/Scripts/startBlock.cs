using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBlock : Block1
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Execute(Transform parentTransform)
    {
        Variable.setCurrentBlock(this);
        if (parentTransform.childCount >= 2)
        {
            voidBlock child = parentTransform.GetChild(1).GetComponent<voidBlock>();
            child.Execute(parentTransform.GetChild(1));
        }

        return Variable.getAns();
    }
}
