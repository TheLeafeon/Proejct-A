using UnityEngine;


namespace ProjectA.Enemy
{
    public class EnemyAnimation : MonoBehaviour
    {
        Animator animator;
        Enemy enemy;

        static readonly int IsMove = Animator.StringToHash("IsMove");
        static readonly int IsAttack = Animator.StringToHash("IsAttack");

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        public void Init(Enemy enemy)
        {
            this.enemy = enemy;
        }

        public void PlayMove()
        {
            animator.SetBool(IsMove, true);
            animator.SetBool(IsAttack, false);
        }
        public void PlayAttack()
        {
            animator.SetBool(IsMove, false);
            animator.SetBool(IsAttack, true);
        }

        public void AttackHit() => enemy.m_Attack.AttackHit();
        public void Shootting() => enemy.m_Attack.Shootting();
    }
}

