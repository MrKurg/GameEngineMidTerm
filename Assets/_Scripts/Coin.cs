using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameObject spawnedObj;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            //if (spawnedObj.GetComponent<Renderer>().materials[0].color == Color.blue)
            //{
            //    Debug.Log("Speedup!");
            //}
            //else
            //{
            //    ScoreManager.instance.ChangeScore(1);
            //}
            ScoreManager.instance.ChangeScore(1);
            Destroy(gameObject);
        }
    }
}
