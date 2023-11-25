using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StringBlock : GenericBlock<string>
{
    public override void Function()
    {
        Transform child = this.GetComponent<Transform>().GetChild(0);
        string text = child.GetComponent<TMP_InputField>().text;
        this.Value = text;
        Debug.Log(this.Value);
    }
}
