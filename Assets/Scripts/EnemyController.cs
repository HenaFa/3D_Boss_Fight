using UnityEngine;
using System.Collections;
using UnityEngine.AI;


public class EnemyController: MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target;

    [SerializeField] private float timer = 5;
    private float bulletTime;

    public GameObject enemyBullet;
    public Transform spawnPoint;
    public float enemySpeed; 


    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        agent.SetDestination(target.transform.position);
        ShootAtPlayer();
       
    }

    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;
        bulletTime = timer;

        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);
        Destroy(bulletObj, 5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject, 5f);
        }

    }

}
