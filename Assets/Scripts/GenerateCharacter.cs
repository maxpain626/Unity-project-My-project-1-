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
            Debug.Log("В кошельке больше 50 монет");
        }
        else if(currentGold < 15)
        {
            Debug.Log("В кошельке меньше 15 монет");
        }
        else
        {
            Debug.Log("В кошельке среднее количество монет");
        }
        Debug.Log(nextSkillLevel);
        Debug.Log(generateHero("Spike", characterLevel));
        if(!hasDungeonKey)
        {
            Debug.Log("Ты не можешь войти без ключа.");
        }
        if (weaponType != "Longsword")
        {
            Debug.Log("Неподходящее оружие.");
        }

}
    /// <summary>
    /// Создает героя по 2-м параметрам
    /// </summary>
    /// <param name="name"></param> имя
    /// <param name="level"></param> уровень
    

    //void Update()
    //{
        
    //}
}
