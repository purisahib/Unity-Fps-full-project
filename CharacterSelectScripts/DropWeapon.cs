using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropWeapon : MonoBehaviour
{
    public GameObject Gun;
    public void weaponDrop()
    {
        Instantiate(Gun, transform.position, Quaternion.identity);
    }

    
}
