using UnityEngine;

public class IdleAnimation : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator.Play("Idle");
    }
}
