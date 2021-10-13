using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;


    //create a public method which reduces hitpoints by damage amount
    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints<=0)
        {
            Destroy(this.gameObject);
        }
    }
}
