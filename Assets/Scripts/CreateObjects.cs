using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    public GameObject obj;

    private void Start()
    {
        GameObject newObject = Instantiate(obj, gameObject.GetComponent<Transform>().position, Quaternion.identity) as GameObject;
    }
}
