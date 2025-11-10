using UnityEngine;

public class lb_Bird : MonoBehaviour
{
    public float flySpeed = 5f;
    public float turnSpeed = 60f;
    public bool turning = false;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

        if (anim != null)
        {
            anim.SetBool("flying", true);
        }
    }

    void Update()
    {
        transform.Translate(Vector3.forward * flySpeed * Time.deltaTime);

        if (turning)
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
    }
}