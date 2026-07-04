using UnityEngine;

public class CalendarTick : MonoBehaviour
{
    [SerializeField] private Data playerData;
    private float timer;
    [SerializeField] private float tickInterval = 1.0f;
    public static bool isPaused = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (isPaused) return;

        timer += Time.deltaTime;
        if (timer >= tickInterval)
        {
            timer -= tickInterval;
            DayPassed(1);
        }
    }

    public void DayPassed(int dayPassed)
    {
        playerData.TimeDay += dayPassed;
    }
}
