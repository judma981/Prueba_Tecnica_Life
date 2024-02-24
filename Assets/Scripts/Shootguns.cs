using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootguns : MonoBehaviour
{
    [SerializeField] Weapon weapon;
    [SerializeField] Transform ShootPoint;
    public enum GunType { Parabolic, Magnetic, Bouncy };
    public GunType gunType;
    GameObject proyectilPrefab; 
    float InitialSpeed; 
    public float Inclination = 45f;
    private Rigidbody projectileRigidbody;
    int Ammunition;
    private float reloadTime;
    private float lastShootTime, firerate;
    
    void Start()
    {
        proyectilPrefab = weapon.bulletprefab;
        Ammunition = weapon.Ammunition;
        reloadTime = weapon.Reloadtime;
        firerate = weapon.firerate;
        InitialSpeed = weapon.BulletSpeed;
    }

    public void Shoot()
    {
        if (Time.time - lastShootTime < firerate)
            return;


        switch (gunType)
        {
            case GunType.Parabolic: 
                ParabolicShoot();
                break;
            case GunType.Magnetic: 
                Magnetic();
                break;
            case GunType.Bouncy: 
                Bouncy();
                break;
            default:
                break;
        }

        lastShootTime = Time.time;
        Debug.Log("firerate" + firerate);
    }


    public void ParabolicShoot()
    {

        Ammunition -= 1;
  
        GameObject projectil = Instantiate(proyectilPrefab, ShootPoint.position, Quaternion.identity);
        float anguloRadianes = Inclination * Mathf.Deg2Rad;
        float velocidadInicialX = InitialSpeed * Mathf.Cos(anguloRadianes);
        float velocidadInicialY = InitialSpeed * Mathf.Sin(anguloRadianes);

       
        Rigidbody rb = projectil.GetComponent<Rigidbody>();

        
        if (rb != null)
        {

            Vector3 direccion = ShootPoint.forward;
            rb.velocity = direccion * InitialSpeed;
        }

    }
    public void Magnetic()
    {      
       
      Ammunition--; // Reduce ammunition
      GameObject projectileObject = Instantiate(proyectilPrefab, ShootPoint.position, Quaternion.identity);
        projectileRigidbody = projectileObject.GetComponent<Rigidbody>();
        if (projectileRigidbody != null)
        {
            Vector3 direction = ShootPoint.forward * InitialSpeed;
            projectileRigidbody.velocity = direction;
        }
       
        Destroy(projectileObject, 3f);
    }
  
    public void Bouncy()
    {
        Ammunition -= 1;

        GameObject projectileObject = Instantiate(proyectilPrefab, ShootPoint.position, Quaternion.identity);
        projectileRigidbody = projectileObject.GetComponent<Rigidbody>(); 
        if (projectileRigidbody != null)
        {
            Vector3 direction = ShootPoint.forward * InitialSpeed;
            projectileRigidbody.velocity = direction;
        }
        Destroy(projectileObject, 5f);

    }



}
  

