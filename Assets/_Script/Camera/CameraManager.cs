using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraManager : MonoBehaviour
{

    float rotX;
    float rotY;

    [SerializeField] float minRot;
    [SerializeField] float maxRot;

    [SerializeField] Transform targetTransform;


    [SerializeField] float distanceFromTarget;
    [SerializeField] float heightOffset;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotX += Input.GetAxis("Mouse Y");
        rotX = Mathf.Clamp(rotX, minRot, maxRot);
        rotY += Input.GetAxis("Mouse X");

        var cameraRotation = Quaternion.Euler(rotX, rotY, 0);

        transform.position = targetTransform.position - cameraRotation * new Vector3(0, heightOffset, distanceFromTarget);
        transform.rotation = cameraRotation;

    }


    public Quaternion flatRotation => Quaternion.Euler(0, rotY, 0); //property
    

}
