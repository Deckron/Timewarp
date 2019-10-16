using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class mech_boss_control : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator anim;
    public float lookRadius = 10f;
    public GameObject firepoint;
    public GameObject grenade;
    Transform target;
    public Transform spawnloc;
    public Rigidbody grenade1;
    
    NavMeshAgent agent;
    public bool isClose = false;
    
    void Start()
    {
        target = player_manager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        anim = gameObject.GetComponent<Animator>();
        spawnloc = firepoint.transform;


    }

    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadius)
        {
            isClose = true;
            agent.SetDestination(target.position);
            anim.SetBool("isClose", true);
            Rigidbody clone;
            clone = Instantiate(grenade1, spawnloc.position, spawnloc.rotation);
            clone.velocity = spawnloc.TransformDirection(Vector3.forward * 10);
        }
        else
        {
            anim.SetBool("isClose", false);
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
