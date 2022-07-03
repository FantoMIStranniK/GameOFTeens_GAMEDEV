using UnityEngine;
using TMPro;

public class GoodsCounter : MonoBehaviour
{
    [SerializeField] private BuyableData GoodsData;

    private TMP_Text CounterText;

    private void Start()
    {
        CounterText = gameObject.GetComponent<TMP_Text>();
    }
    void Update()
    {
        CounterText.text = "Count: " + GoodsData.Count;
    }
}
