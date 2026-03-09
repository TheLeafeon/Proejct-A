using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/EnemyData")]
public class EnemyData : ScriptableObject
{
    [Header("# 몬스터 기본 정보")]
    public string enemyName;

    [Header("# 몬스터 그래픽 정보")]
    public GameObject graphicsPrefab;

    [Header("# 몬스터 체력 정보")]
    public float maxHealth;

    [Header("# 몬스터 이동 정보")]
    public float moveSpeed;

    [Header("# 몬스터 공격 정보")]
    public float attackRange;
    public float attackPower;
    public float attackRate;
    public float attackSpeed;

    [Header("# 몬스터 총알 정보")]
    public GameObject bulletPrefab;

}
