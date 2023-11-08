using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour
{
    public startBlock startBlock;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        startBlock.Execute(startBlock.transform);
        Debug.Log(Variable.getAns());
        Variable.init();
    }
}
