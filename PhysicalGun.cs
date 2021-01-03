using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalGun : MonoBehaviour
{
    public GameObject ShootingAnchor;
    public GameObject Projectile;
    public float ProjectileInitSpeed;
    void Start(){
        
    }

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            GameObject projectile;
            projectile = Instantiate(Projectile, ShootingAnchor.transform.position, ShootingAnchor.transform.rotation);
            projectile.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * ProjectileInitSpeed);
            Destroy(projectile, 5);
        }
    }
}
