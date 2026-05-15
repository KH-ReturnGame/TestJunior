using UnityEngine;

public class CardAttack : MonoBehaviour
{
    public DummyEnemy dummy;

    public void UseFireCard()
    {
        if (dummy == null)
        {
            Debug.Log("더미가 이미 사라짐!");
            return;
        }

        dummy.TakeDamage(5);
        Debug.Log("불 카드 사용! 더미에게 5 데미지");
    }
}