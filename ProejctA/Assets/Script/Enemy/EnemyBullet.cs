using UnityEngine;

namespace ProjectA.Enemy
{
    public class EnemyBullet : MonoBehaviour
    {
        [SerializeField] private float attackPower;
        [SerializeField] private float attackSpeed;

        CapsuleCollider2D capsuleCollider;

        public void Init(float attackPower, float attackSpeed)
        {
            this.attackPower=attackPower;
            this.attackSpeed=attackSpeed;
            capsuleCollider = GetComponent<CapsuleCollider2D>();
        }

        private void FixedUpdate()
        {
            transform.Translate(Vector3.down * attackSpeed * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Arrow Hit!");
            if (!collision.CompareTag("Wall"))
                return;

            GameManager.instance.m_Wall.TakeDamage(attackPower);

            gameObject.SetActive(false);
        }

    }
}

