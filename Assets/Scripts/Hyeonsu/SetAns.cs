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

        tmpText.text = "현재 가장 큰 값은 ";
    }

    // Update is called once per frame
    void Update()
    {
        if (tmpText.text != "Ans: " + ItemBlock.GetHaveItem())
            tmpText.text = "Ans: " + ItemBlock.GetHaveItem();
    }
}
