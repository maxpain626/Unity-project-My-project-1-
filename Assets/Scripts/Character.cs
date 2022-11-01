using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Персонаж, создание, характеристики
/// </summary>
public class Character
{
    public string name;
    public int exp = 0;

    public Character(string name)
    {
        this.name = name;
    }

    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1}exp", name, exp);
    }
}
