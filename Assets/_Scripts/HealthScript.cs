using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public float health = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damagedealt)
    {

        health -= damagedealt;

        if (health <= 0)
        {

            Destroy(gameObject);

        }

    }



}
