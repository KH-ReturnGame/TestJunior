using UnityEngine;
using UnityEngine.UI;

public class DummyEnemy : MonoBehaviour
{
    public int hp = 20;

    public Slider hpBar;

    public GameObject damageText;

    void Start()
    {
        hpBar.maxValue = hp;
        hpBar.value = hp;

        damageText.SetActive(false);
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        hpBar.value = hp;

        damageText.SetActive(true);
        Invoke("HideDamageText", 1f);

        Debug.Log("현 더미 체력 : " + hp);

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    void HideDamageText()
{
    damageText.SetActive(false);
}
}