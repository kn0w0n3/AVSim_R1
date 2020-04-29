using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour {
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;
    float theDistance;
    bool detected = false;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);

        RaycastHit hit;
       
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 20;
        Debug.DrawRay(transform.position,forward,Color.green);

        if (Physics.Raycast(transform.position,(forward),out hit)){
            detected = true;
            theDistance = hit.distance;
            print(theDistance + " " + hit.collider.gameObject.name);
            print("Detected object");
            if (detected == true && theDistance < 15)
            {
                speed = 0;
             
            }

        }
        else
        {
            detected = false;
            print("Object Not Detected");
            if (speed < 15)
            {
                for (int i = 0; i != 60; i++)
                {
                    speed += 0.025f;
                }         
            }                          
        }      
    }
}
