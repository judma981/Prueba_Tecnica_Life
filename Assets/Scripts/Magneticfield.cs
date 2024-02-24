using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magneticfield : MonoBehaviour
{
    [Range(5f, 50f)]
    public float AtractionRadius = 5f;
    [Range(10f,50f)]
    public float AtrationForce = 10f;
    private SphereCollider Espherecollider;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Espherecollider = GetComponent<SphereCollider>();
        //Invoke("ActivateMagneticField", 0.2f);
        //ActivateMagneticField();
    }

    private void FixedUpdate()
    {
        Atraction();
    }
    //method for make the magneticfield with the bullet Collider
    public void Atraction()
    {
       
        Collider[] AttachedObjects = Physics.OverlapSphere(transform.position, AtractionRadius);

        foreach (Collider Object in AttachedObjects)
        {
            Rigidbody objectRb = Object.GetComponent<Rigidbody>();
            if (objectRb != null)
            {
             
                Vector3 Atractionface = transform.position - Object.transform.position;
                objectRb.AddForce(Atractionface * AtrationForce * Time.deltaTime);
            }
        }
    }
   /* public void ActivateMagneticField()
    {
        
        Espherecollider.enabled = true;
    }*/

   
}
