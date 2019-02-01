﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamV2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 distance;
    private float smooth = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + distance;
    }
}
