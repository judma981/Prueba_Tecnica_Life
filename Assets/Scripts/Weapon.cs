using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Weapon : ScriptableObject
{
    public enum GunsType {Parabolic,Magnetic,Bouncy};
    public GunsType gunsType;
    public GameObject bulletprefab;
    public float firerate;
    public float Reloadtime;
    [Range(12f, 30f)]
    public int Ammunition;
    [Range(10f, 30f)]
    public float BulletSpeed;

    


}
