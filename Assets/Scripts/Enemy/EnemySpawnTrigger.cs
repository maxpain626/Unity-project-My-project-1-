using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Тригер для спавна противников
/// </summary>
public class EnemySpawnTrigger : MonoBehaviour
{
    public GameObject[] Enemies;
    public Transform[] EnemySpawnerPosition;
    private int _randomSpawnPoints;
    private int _randomEnemy;
    public float repeatRate = 3f;
    public int destroySpawner = 20;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            InvokeRepeating("EnemySpawner", 0.5f, repeatRate);
            //Destroy(gameObject, DestroySpawner);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    public void OnClickFight()
    {
        InvokeRepeating("EnemySpawner", 0.5f, repeatRate);
        this.gameObject.SetActive(false);
    }

    private void EnemySpawner()
    {
        _randomSpawnPoints = Random.Range(0, EnemySpawnerPosition.Length);
        _randomEnemy = Random.Range(0, Enemies.Length);
        Instantiate(Enemies[_randomEnemy], EnemySpawnerPosition[_randomSpawnPoints].position, Quaternion.identity);
    }
}
