using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��������, ��������, ��������������
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

/// <summary>
/// ������, ��������, ��������������
/// </summary>
public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon: {0} - {1}dmg", name, damage);
    }
}
