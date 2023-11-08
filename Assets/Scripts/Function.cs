using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function
{

    public static void voidBlock(string blockName)
    {
        switch (blockName)
        {
            case "plusIndex": plusIndex(); break;
            case "minusIndex": minusIndex(); break;
            case "setHaveItem":setHaveItem(); break;
            default: break;
        }
    }

    public static int intBlock(string blockName)
    {
        int returnValue;
        switch (blockName)
        {
            case "MaxValue": returnValue = MaxValue(); break;
            case "isFirstIndex": returnValue = isFirstIndex(); break;
            case "isEndIndex": returnValue = isEndIndex(); break;
            default: returnValue = 0; break;
        }
        return returnValue;
    }
    public static void plusIndex()
    {
        Variable.plusIndex();
    }

    private static void minusIndex()
    {
        Variable.minusIndex();
    }

    private static void setHaveItem()
    {
        Variable.setHaveItem(Variable.getArrayItem());
    }

    private static int isFirstIndex() 
    {
        if (Variable.isFirstIndex())
            return 1;
        else
            return 0;
    }

    private static int isEndIndex() 
    {
        if (Variable.isEndIndex())
            return 1;
        else
            return 0;
    }

    private static int MaxValue()
    {
        if (Variable.getHaveItem() > Variable.getArrayItem())
            return Variable.getHaveItem();
        else
            return Variable.getArrayItem();
    }

}


