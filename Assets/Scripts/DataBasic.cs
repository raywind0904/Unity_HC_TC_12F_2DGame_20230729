using UnityEngine;

[CreateAssetMenu(menuName = "KID/Data Basic", fileName = "Data Basic")]
public class DataBasic : ScriptableObject
{
    [Header("移動速度"), Range(0, 30)]
    public float speed = 2.5f;
    [Header("血量"), Range(0, 10000)]
    public float hp = 100;
}
