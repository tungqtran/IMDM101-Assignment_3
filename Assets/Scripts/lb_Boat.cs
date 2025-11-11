using UnityEngine;

public class lb_Boat : MonoBehaviour
{
    public float driveSpeed = 5f;
    public float turnSpeed = 60f;
    public bool turning = false;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

        if (anim != null)
        {
            anim.SetBool("driving", true);
        }
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        transform.Translate(-transform.right * moveInput * driveSpeed * Time.deltaTime);

        if (turning)
        {
            transform.Rotate(Vector3.up * turnInput * turnSpeed * Time.deltaTime);
        }
    }
}
