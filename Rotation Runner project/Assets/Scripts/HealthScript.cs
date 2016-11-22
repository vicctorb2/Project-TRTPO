using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

    public int hp;

    public void Damage(int damageCount)
    {
        hp -= damageCount;
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
        if(shot != null)
        {
            Damage(shot.damage);
            Destroy(shot.gameObject);
        }

    }
}
