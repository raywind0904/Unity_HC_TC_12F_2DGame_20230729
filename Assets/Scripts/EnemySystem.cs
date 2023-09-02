using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    [Header("敵人資料")]
    public DataEnemy data;

    public Transform playerPoint;

    private void Awake()
    {
        playerPoint = GameObject.Find("黑貓").transform;
    }

    private void Update()
    {
        TrackPlayer();
        Flip();
    }

    private void TrackPlayer()
    {
        // 如果 敵人 與 玩家 距離 小於 3 就 跳出
        if (Vector2.Distance(transform.position, playerPoint.position) < 3) return;
        
        transform.position = Vector2.MoveTowards(transform.position, playerPoint.position, data.speed * Time.deltaTime);
    }

    private void Flip()
    {
        if (transform.position.x > playerPoint.position.x) transform.eulerAngles = Vector2.zero;
        else if (transform.position.x < playerPoint.position.x) transform.eulerAngles = new Vector2(0, 180);
    }
}
