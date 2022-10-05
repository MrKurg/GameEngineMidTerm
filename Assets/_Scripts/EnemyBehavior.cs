using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public HealthScript enemyHealth;
    public GameObject playerMarker = null;
    public float walkSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        if ( playerMarker != null)
        {
            playerMarker = GameObject.Find("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed, Space.Self);
        transform.LookAt(playerMarker.transform);

     }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            {
                other.collider.GetComponent<PlayerController>().playerHealth.TakeDamage(25);
            }
        }
    }



}
