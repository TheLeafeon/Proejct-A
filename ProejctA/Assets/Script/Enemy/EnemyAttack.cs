using UnityEngine;

namespace ProjectA.Enemy
{
    public class EnemyAttack : MonoBehaviour
    {

        EnemyState m_State;
        EnemyMovement m_Movement;
        EnemyAnimation m_Animation;

        public LayerMask WallLayer;

        bool isAttack;

        public void AttackInit(EnemyState m_State)
        {
            this.m_State = m_State;
            m_Movement = GetComponent<EnemyMovement>();
            m_Animation = GetComponent<EnemyAnimation>();
        }

        private void FixedUpdate()
        {

            CheckWall();

        }

        void CheckWall()
        {
            RaycastHit2D hit = Physics2D.Raycast(
                transform.position,
                Vector2.down,
                m_State.attackRange,
                WallLayer
            );

            Debug.DrawRay(
                transform.position,
                Vector2.down * m_State.attackRange,
                Color.red
            );

            if (hit.collider != null)
            {
                if(!isAttack)
                {
                    StartAttack();
                }
            }
            else
            {
                if(isAttack)
                {
                    StopAttack();
                }
            }
        }

        void StartAttack()
        {
            Debug.Log("Start Attack!");
            isAttack = true;
            m_Animation.IsAttack();
            m_Movement.StopMove();
        }

        void StopAttack()
        {
            Debug.Log("Stop Attack!");
            isAttack = false;
            m_Movement.ResumeMove();
        }
    }
}

