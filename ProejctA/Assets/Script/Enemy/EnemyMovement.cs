using UnityEngine;

namespace ProjectA.Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        EnemyState m_State;

        bool isStop;
        EnemyAnimation m_Animation;

        public void MovementInit(EnemyState m_State)
        {
            this.m_State = m_State;
            m_Animation = GetComponent<EnemyAnimation>();
        }

        private void FixedUpdate()
        {
            if (isStop) return;

            Move();
        }

        void Move()
        {
            transform.position += Vector3.down * m_State.moveSpeed * Time.deltaTime;
        }

        public void StopMove()
        {
            isStop = true;
        }
        public void ResumeMove()
        {
            isStop = false;
            m_Animation.IsMove();
        }
    }
}

