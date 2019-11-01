using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ranger_boss : MonoBehaviour
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
    private float speed = 10;

    NavMeshAgent agent;
    public bool isClose = false;

    void Start()
    {
        target = player_manager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        anim = gameObject.GetComponent<Animator>();
        //spawnloc = firepoint.transform;


    }

    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        Vector3 targetDir = target.position - transform.position;
        float step = speed * Time.deltaTime;
        if (distance <= lookRadius)
        {
            isClose = true;
            //agent.SetDestination(target.position);
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDir);
            anim.SetBool("isClose", true);
            Rigidbody clone;
            clone = Instantiate(grenade1, firepoint.transform.position, spawnloc.rotation);
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

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            isDestroyed = true;
            Destroy(gameObject);
        }

    }
}
