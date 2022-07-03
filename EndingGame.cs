using UnityEngine;

public class EndingGame : MonoBehaviour
{
    [SerializeField] private GameObject EndingImage;

    [SerializeField] private Resources ResourcesScript;

    [SerializeField] private BuyableData BFBData;

    public void EndGame()
    {
        if (ResourcesScript.Money >= BFBData.Price)
        {
            EndingImage.SetActive(true);
        }
    }
}
