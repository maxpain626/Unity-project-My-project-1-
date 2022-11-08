using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Vector3 camOffset = new Vector3(0, 0, -2.5f);

    private Transform target;

    void Start()
    {
        target = GameObject.Find("SamuraiHero").transform;
    }

    void LateUpdate()
    {
        this.transform.position = target.TransformPoint(camOffset);
        this.transform.LookAt(target);
    }


    //[SerializeField] private GameObject target;
    //[SerializeField] private Vector3 distanceFromObject;

    //private void LateUpdate()
    //{
    //    Vector3 positionToGo = target.transform.position + distanceFromObject;
    //    Vector3 smoothPosition = Vector3.Lerp(a: transform.position, b: positionToGo, t: 0.125f);
    //    transform.position = smoothPosition;
    //}

}
