using UnityEngine;

[CreateAssetMenu(fileName = "Buyable Data", menuName = "ScriptableObjects/Buyable Data", order = 1)]
public class BuyableData : ScriptableObject
{
    public string Name;
    public float Weight;
    public float Price;
    public float RespectCost;
    public float Count;
    public BuyableType Type;
}
