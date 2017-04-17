﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleLine3 : MonoBehaviour
{

    private LineRenderer lineRenderer;
    private float moveStrength = 0.5f;
    public GameObject go1;
    public GameObject go2;
    public GameObject go3;


    // Use this for initialization
    void Start()
    {
        //go1 = GameObject.Find("cubeYel3");
        //go2 = GameObject.Find("cubeYel4");
        //go3 = GameObject.Find("cubeYel5");

        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 4;

        SetLine();
    }

    // Update is called once per frame
    void Update()
    {
        SetLine();
    }

    void SetLine()
    {
        lineRenderer.SetPosition(0, go1.transform.position);
        lineRenderer.SetPosition(1, go2.transform.position);
        lineRenderer.SetPosition(2, go3.transform.position);
        lineRenderer.SetPosition(3, go1.transform.position);
    }

}