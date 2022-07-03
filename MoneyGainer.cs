using UnityEngine;
using TMPro;

public class MoneyGainer : MonoBehaviour
{
    public float CollectedMoney = 0;

    [SerializeField] private TMP_Text CollectedMoneyCounter;

    [SerializeField] private Resources ResourcesScript;

    private void Start()
    {
        InvokeRepeating(nameof(EarnMoney), 5f, 5f);
    }
    private void Update()
    {
        CollectedMoneyCounter.text = CollectedMoney + "$";
    }
    private void EarnMoney()
    {
        CollectedMoney += Random.Range(0.01f, 1f) + (ResourcesScript.Respect * 0.25f);
        CollectedMoney = Mathf.Round(CollectedMoney * 100f) * 0.01f;
    }
}
