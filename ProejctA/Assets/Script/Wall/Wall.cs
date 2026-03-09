using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] float wallHp;


    public void TakeDamage(float damage)
    {
        wallHp -= damage;
        Debug.Log($"Hit! {damage}Damage!!  ({wallHp})");
    }
}
