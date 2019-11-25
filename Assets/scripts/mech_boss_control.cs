using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class mech_boss_control : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isDestroyed = false;
    private Animator anim;
    public float lookRadius = 10f;
    public GameObject firepoint;
    public GameObject grenade;
    Transform target;
    public Transform spawnloc;
    public Rigidbody grenade1;
    
    NavMeshAgent agent;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    public bool isClose = false;
    public float count = 0f;
    
    void Start()
    {
        target = player_manager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        anim = gameObject.GetComponent<Animator>();
        //spawnloc = firepoint.transform;


    }

    void Update()
    {
        if (count <= 1f)
        {
            count += Time.deltaTime;
        }
        else if (count > 1f)
        {
            count = 0f;
            float distance = Vector3.Distance(target.position, transform.position);
            if (distance <= lookRadius)
            {
                Shoot();
            }
            else
            {
                anim.SetBool("isClose", false);
            }
            if (fireCountdown <= 0f)
            {
                Shoot();
                fireCountdown = 1f / fireRate;
            }
            fireCountdown -= Time.deltaTime;
        }
        




    }

    void Shoot()
    {
        isClose = true;
        agent.SetDestination(target.position);
        anim.SetBool("isClose", true);

        GameObject BulletGo = (GameObject)Instantiate(grenade, firepoint.transform.position, spawnloc.rotation);
        bullet bullet = BulletGo.GetComponent<bullet>();
        
        if (bullet != null)
        {
            bullet.Seek(target);
        }

        //clone.velocity = spawnloc.TransformDirection(Vector3.forward * 10);
        
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            
            isDestroyed = true;
            Destroy(gameObject);
        }
        
    }
}
