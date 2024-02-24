using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponontroller : MonoBehaviour
{
    public Shootguns[] weapons;
    private int currentWeaponIndex = 0;

    private void Start()
    {
        EquipWeapon(currentWeaponIndex);
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EquipWeapon(0);
            Debug.Log("CurrentWeapon" + currentWeaponIndex);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EquipWeapon(1);
            Debug.Log("CurrentWeapon" + currentWeaponIndex);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EquipWeapon(2);
            Debug.Log("CurrentWeapon" + currentWeaponIndex);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void EquipWeapon(int index)
    {
        foreach (Shootguns weapon in weapons)
        {
           // weapon.gameObject.SetActive(false);
        }

        weapons[index].gameObject.SetActive(true);
        currentWeaponIndex = index;
    }

    private void Shoot()
    {
        weapons[currentWeaponIndex].Shoot();
    }
}


