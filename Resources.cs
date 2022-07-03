using UnityEngine;
using TMPro;

public class Resources : MonoBehaviour
{
    public float Respect = 0;
    public float Money = 0;

    [SerializeField] private TMP_Text MoneyCounter;
    [SerializeField] private TMP_Text RespectCounter;

    private void Update()
    {
        MoneyCounter.text = Money + "$";
        RespectCounter.text = Respect + "R";
    }
}
