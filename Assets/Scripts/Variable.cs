using System;
using UnityEngine;

public class Variable
{
    //상자의 위치
	private static int index;
    //상자의 값 배열
	private static int[] array;
    //현재 가지고있는 값
    private static int haveItem;
    //종료 변수
	private static bool finish;
    //최종 값
	private static int ans;
    //디버거에 사용할 현재 작동중인 코드블럭
    private static Block1 currentBlock;

	public Variable()
    {
        index = 0;
        array = new int[10];
        randomfill();
        finish = false;
        ans = 0;
    }
    public static void init()
    {
        index = 0;
        finish = false;
        ans = 0;
    }
    //상자를 랜덤하게 채워줌
    private void randomfill()
    {
        System.Random rand = new System.Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 101);
        }
    }

    public static void setIndex(int Index) { index = Index; }

    public static int getIndex() { return index; }

    public static void setHaveItem(int item) { haveItem = item; }

    public static int getHaveItem() { return haveItem; }

    public static void setFinish() { finish = true; }

    public static bool getFinish() { return finish; }

    public static void setAns(int item) { ans = item; }

    public static int getAns() { return ans; }

    public static int getArrayItem()
    {
        if (0 <= index && index < 10)
            return array[index];
        return -1;
    }

    public static void setCurrentBlock(Block1 block){currentBlock = block;}

    public static Block1 getCurrentBlock(){return currentBlock;}

    public static bool isFirstIndex(){return index == 0;}

    public static bool isEndIndex(){return index == 10 - 1;}
    
    public static void plusIndex()
    {
        if (isEndIndex())
        {
            Debug.Log("마지막 상자 입니다.");
        }
        else
        {
            index++;
        }
    }

    public static void minusIndex()
    {
        if (isFirstIndex())
        {
            Debug.Log("첫 상자 입니다.");
        }
        else
        {
            index--;
        }
    }

}

