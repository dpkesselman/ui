using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    [SerializeField] public float HPAmount;
    [SerializeField] private float MaxHP;
    [SerializeField] private HPBar hpbar;
    [SerializeField] private GameObject gameOver;


    private void Start()
    {
        HPAmount = MaxHP;
        HPBar.Instance.InitializeHPBar(HPAmount);
    }


    public void TakeDamage(int damage)
    {
        HPAmount -= damage;
        HPBar.Instance.ChangeCurrentHP(HPAmount);
        if (HPAmount <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }

    public void Heal(int damage)
    {
        HPAmount += damage;
        HPBar.Instance.ChangeCurrentHP(HPAmount);
    }
}
