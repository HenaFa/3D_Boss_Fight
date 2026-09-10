using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager enemyAtm;

    // Update is called once per frame
    private void Update()
    {
        //Deal damage to the enemy
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerAtm.DealDamage(enemyAtm.gameObject);
        }

        //Deal damage to the player

        
    }
}
