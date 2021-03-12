using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource _bulletAudioSource;
    public AudioClip _bulletAudioClip;
    public Rigidbody objectRamp;
    public Transform cannonPosition;
    public float bulletSpeed = 5.0f;
    public float range = 10.0f;
    void Start()
    {
        _bulletAudioSource.clip = _bulletAudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            MegaLaser();
        }
    }
    void MegaLaser()
    {
        Rigidbody bullet = Instantiate(objectRamp, cannonPosition.position, Quaternion.Euler(Vector3.zero)) as Rigidbody;
        bullet.AddForce(cannonPosition.forward * bulletSpeed);


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //if(Physics.Raycast(ray, out hit, range)) // позицията на мишката според камерата
        if(Physics.Raycast(cannonPosition.position, cannonPosition.forward, out hit, range)) // позицията на оръжието
            {
            if(hit.collider.tag == "Enemy")
            {
                Destroy(hit.collider.gameObject);
            }
        }
        _bulletAudioSource.Play(0);
    }
}
