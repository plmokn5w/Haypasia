using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntBlock : GenericBlock<int?>
{
    public override void Function() { }
    public void SetValue(int? value) { Value = value; }
}
