using System.Collections.Generic;
using UnityEngine;

public enum BuyableType
{
    Chocolate,
    ToiletPaper,
    Water,
    Chips,
    Cigarettes,
    Binoculars,
    BodyArmor,
    NVD,
    Car,
    Bayraktar
}
public class MarketScript : MonoBehaviour
{
    public List<BuyableData> BuyableCatalog;

    [SerializeField] private Resources ResourcesScript;
    [SerializeField] private TruckScript Truck;

    private float totalWeight;
    private float totalCost;
    private float totalRespect;

    private void Awake()
    {
        foreach (BuyableData data in BuyableCatalog)
        {
            data.Count = 0;
        }
    }
    public void AddToCart(int TypeNumber)
    {
        BuyableType type = (BuyableType)TypeNumber;

        foreach (BuyableData data in BuyableCatalog)
        {
            if (data.Type == type)
            {
                data.Count++;
                break;
            }
        }
    }
    public void RemoveFromCart(int TypeNumber)
    {
        BuyableType type = (BuyableType)TypeNumber;

        foreach (BuyableData data in BuyableCatalog)
        {
            if (data.Type == type && data.Count > 0)
            {
                data.Count--;
                break;
            }
        }
    }
    public void ClearAll()
    {
        foreach (BuyableData data in BuyableCatalog)
        {
            data.Count = 0;
        }
    }
    public void PreviewBuy()
    {
        //Set values to zero
        totalCost = 0;
        totalWeight = 0;
        totalRespect = 0;

        //Got all the values from catalog
        foreach (BuyableData data in BuyableCatalog)
        {
            totalCost += data.Price * data.Count;
            totalWeight += data.Weight * data.Count;
            totalRespect += data.RespectCost * data.Count;
        }

        Truck.RespectReward = totalRespect;

        TryToBuy(totalCost, totalWeight);
    }
    private void TryToBuy(float price, float weight)
    {
        if (price <= ResourcesScript.Money && weight <= Truck.TruckCapacity)
        {
            foreach(BuyableData data in BuyableCatalog)
            {
                data.Count = 0;
            }
            Buy(price, weight);
        }
    }
    private void Buy(float price, float weight)
    {
        ResourcesScript.Money -= price;
        Truck.TruckCapacity -= weight;
        Truck.SendTruck();
    }
}
