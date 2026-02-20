using UnityEngine;

public class AvatarInteraction : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void OnMouseDown()
    {
        animator.SetTrigger("Die");
    }
}
