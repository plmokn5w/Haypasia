using System;
using UnityEngine;

public class Variable
{
    //������ ��ġ
	private static int index;
    //������ �� �迭
	private static int[] array;
    //���� �������ִ� ��
    private static int haveItem;
    //���� ����
	private static bool finish;
    //���� ��
	private static int ans;
    //����ſ� ����� ���� �۵����� �ڵ��
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
    //���ڸ� �����ϰ� ä����
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
            Debug.Log("������ ���� �Դϴ�.");
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
            Debug.Log("ù ���� �Դϴ�.");
        }
        else
        {
            index--;
        }
    }

}

