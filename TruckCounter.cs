using UnityEngine;
using TMPro;

public class TruckCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text CapacityText;
    [SerializeField] private TMP_Text RespectRewardText;

    [SerializeField] private MarketScript Market;

    private float capacity;
    private float respectReward;

    private void Update()
    {
        capacity = 0;
        respectReward = 0;

        foreach (BuyableData data in Market.BuyableCatalog)
        {
            capacity += data.Weight * data.Count;
            respectReward += data.RespectCost * data.Count;
        }

        CapacityText.text = "You filled " + capacity + "/50 places";
        RespectRewardText.text = "You will get " + respectReward + " respect";
    }
}
