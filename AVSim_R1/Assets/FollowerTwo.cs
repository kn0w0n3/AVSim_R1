﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class FollowerTwo : MonoBehaviour{
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        transform.Rotate(180, 90, 90);
    }
}
