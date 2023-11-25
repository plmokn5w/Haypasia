using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Variable
{
    private static Dictionary<string, int> map = new Dictionary<string, int>();
    //상자의 값 배열
    private static int[] array = new int[10];

    public static void init()
    {
        randomfill();
        map.Add("i", 0);
    }
    //상자를 랜덤하게 채워줌
    private static void randomfill()
    {
        System.Random rand = new System.Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 101);
        }
    }

    public static int GetVariable(string s)
    {
        return map[s];
    }
    public static void SetVariable(string s, int value)
    {
        map[s] = value;
    }

    public static int GetArrayItem(int index)
    {
        if (0 <= index && index < 10)
            return array[index];
        return 0;
    }
}

