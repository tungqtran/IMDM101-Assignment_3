using UnityEngine;

public class Human_Swim_Anim : MonoBehaviour
{
    public float moveSpeed = 5f;      // Forward/backward speed
    public float turnSpeed = 60f;    // Degrees per second
    public bool turning = false;

    private Animator anim;             


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        anim = GetComponent<Animator>();
        if (anim != null)
        {
            anim.SetBool("isWalking", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }
}
