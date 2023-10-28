using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getEnemy : MonoBehaviour
{
    public AudioSource CollectEnemy;
    private void OnCollisionEnter(Collision enemy)
    {
        if (enemy.collider.name == "police")
        {
            Coins.Score0 += 1;
            Destroy(this.gameObject);
            CollectEnemy.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
