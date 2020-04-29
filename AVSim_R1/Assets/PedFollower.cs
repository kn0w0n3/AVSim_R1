using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class PedFollower : MonoBehaviour{
    public PathCreator pathCreator;
    public float speed = 1.5f;
    float distanceTravelled;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        /*
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        transform.Rotate(0, 0, 90);
        */
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
