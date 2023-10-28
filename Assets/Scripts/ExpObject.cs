using UnityEngine;

public class ExpObject : MonoBehaviour
{
    #region 資料
    [SerializeField, Header("飛行速度"), Range(0, 30)]
	private float speed = 3.5f;
	[SerializeField, Header("吃掉的距離"), Range(0, 30)]
	private float eatDistance = 3f;

	private string namePlayer = "黑貓";
	private Transform playerPoint;
    #endregion

    #region 事件
    private void Awake()
	{
		playerPoint = GameObject.Find(namePlayer).transform;
	}

    private void Update()
    {
		FlyToPlayer();
		EatExp();
    }
    #endregion

    #region 方法
    private void FlyToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPoint.position, speed * Time.deltaTime);
    }

    private void EatExp()
    {
        float dis = Vector3.Distance(transform.position, playerPoint.position);

        if (dis < eatDistance)
        {
            Destroy(gameObject);
        }
    } 
    #endregion
}
