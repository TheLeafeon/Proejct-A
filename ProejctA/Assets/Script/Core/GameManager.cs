using ProjectA.Core;
using System.Xml;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("# Manager")]
    public PoolManager EnemyPool;
    public BulletPool BulletPool;

    [Header("# Wall")]
    public Wall m_Wall;

    private void Awake()
    {
        instance = this;

        
    }
}
