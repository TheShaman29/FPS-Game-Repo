using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayGun : MonoBehaviour
{
    public GameObject ShootingAnchor;
    public float GunRange;
    void Start(){
        
    }

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            if (Physics.Raycast(ShootingAnchor.transform.position, ShootingAnchor.transform.TransformDirection(Vector3.forward), out hit, GunRange)){
                //do sth with hit
            }
        }
    }
}
