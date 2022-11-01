using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCharacter : MonoBehaviour
{
    public bool hasDungeonKey = false;

    public string weaponType = "Arcane Staff";

    public int generateHero(string name, int level)
    {
        //Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level + 5;
    }

    void Start()
    {
        int characterLevel = 32;
        int nextSkillLevel = generateHero("Spike", characterLevel);
        int currentGold = 50;
        if (currentGold > 50)
        {
            Debug.Log("� �������� ������ 50 �����");
        }
        else if(currentGold < 15)
        {
            Debug.Log("� �������� ������ 15 �����");
        }
        else
        {
            Debug.Log("� �������� ������� ���������� �����");
        }
        Debug.Log(nextSkillLevel);
        Debug.Log(generateHero("Spike", characterLevel));
        if(!hasDungeonKey)
        {
            Debug.Log("�� �� ������ ����� ��� �����.");
        }
        if (weaponType != "Longsword")
        {
            Debug.Log("������������ ������.");
        }

}
    /// <summary>
    /// ������� ����� �� 2-� ����������
    /// </summary>
    /// <param name="name"></param> ���
    /// <param name="level"></param> �������
    

    //void Update()
    //{
        
    //}
}
