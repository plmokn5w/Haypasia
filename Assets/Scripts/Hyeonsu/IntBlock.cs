using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class IntBlock : GenericBlock<int>  
{
    public override void Function()
    {

        Transform child = this.GetComponent<Transform>().GetChild(0);
        string text = child.GetComponent<TMP_InputField>().text;
        int convert;
        if (int.TryParse(text, out convert))
            this.Value = convert;
        Debug.Log(this.Value);
    }
}
