using UnityEngine;

public class MoneyCollector : MonoBehaviour
{
    [SerializeField] private MoneyGainer GainedMoney;
    [SerializeField] private Resources ResourcesScript;

    public void GetMoney()
    {
        ResourcesScript.Money += GainedMoney.CollectedMoney;
        GainedMoney.CollectedMoney = 0;
    }
}
