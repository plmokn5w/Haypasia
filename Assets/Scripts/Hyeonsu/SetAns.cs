using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetAns : MonoBehaviour
{
    public TMPro.TextMeshProUGUI tmpText;
    // Start is called before the first frame update
    void Start()
    {

        tmpText.text = "���� ���� ū ���� ";
    }

    // Update is called once per frame
    void Update()
    {
        if (tmpText.text != "Ans: " + ItemBlock.GetHaveItem())
            tmpText.text = "Ans: " + ItemBlock.GetHaveItem();
    }
}
