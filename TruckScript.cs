using UnityEngine;
using UnityEngine.UI;

public class TruckScript : MonoBehaviour
{
    public float TruckCapacity = 50f;
    public float RespectReward;

    public bool sentTruck = false;

    [SerializeField] private Resources ResourcesScript;

    [SerializeField] private Slider ProgressSlider;

    private float progress;

    private void Update()
    {
        if(sentTruck)
        {
            ProgressSlider.value += 1f * Time.deltaTime;
        }
    }
    public void SendTruck()
    {
        if(!sentTruck && TruckCapacity != 50f)
        {
            sentTruck = true;
            Invoke(nameof(GiveReward), 10f);
        }
    }
    private void GiveReward()
    {
        ResourcesScript.Respect += RespectReward;       
        sentTruck = false;

        //Return values to normal
        ProgressSlider.value = 0;
        RespectReward = 0;
        TruckCapacity = 50f;
    }
}
