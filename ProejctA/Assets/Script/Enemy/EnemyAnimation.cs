using UnityEngine;


namespace ProjectA.Enemy
{
    public class EnemyAnimation : MonoBehaviour
    {
        Animator animator;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }


        public void IsMove()
        {
            animator.SetBool("IsMove", true);
            animator.SetBool("IsAttack", false);
        }

        public void IsAttack()
        {
            animator.SetBool("IsMove", false);
            animator.SetBool("IsAttack", true);
        }
    }
}

