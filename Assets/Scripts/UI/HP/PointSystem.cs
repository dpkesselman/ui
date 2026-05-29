using UnityEngine;
using TMPro;


public class PointSytem : MonoBehaviour
{
    public static PointSytem Instance;
    public TextMeshProUGUI textPoints;
    private int points = 100;


    public void AddingPoints(int quantity)
    {
        points += quantity;
        UpdateUI();
    }


    public void RemovingPoints(int quantity)
    {
        points -= quantity;
        UpdateUI();
    }


    private void UpdateUI()
    {
        if (points < 0)
        {
            points = 0;
        }
        if (points > 100)
        {
            points = 100;
        }


        textPoints.text = "HP: " + points.ToString();
    }


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
