using UnityEngine;

public class VelociraptorController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // A Button → Idle Animation
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            animator.SetTrigger("IdleTrigger");
        }

        // B Button → Roar Animation
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            animator.SetTrigger("RoarTrigger");
        }

        // Thumbstick Press → Run Animation
        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick))
        {
            animator.SetTrigger("RunTrigger");
        }

        // Grip Button (Hand Trigger) → Attack Animation
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            animator.SetTrigger("AttackTrigger");
        }

        // Index Trigger → Death Animation
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            animator.SetTrigger("DeathTrigger");
        }
    }
}