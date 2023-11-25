using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntArrayBlock : GenericBlock<int>
{

    public override void Function()
    {
        Debug.Log("�ε�������");
        Transform child = this.GetComponent<Transform>().GetChild(0);
        string text = child.GetComponent<TMP_InputField>().text;

        int index = Variable.GetVariable(text);
        this.Value = Variable.GetArrayItem(index);
        Debug.Log("�ε�������");
    }


}
