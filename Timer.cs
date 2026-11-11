using UnityEngine;

public class Timer
{
    private float _time = 0f;
    private float _endTime = 0f;

    public Timer(float time = 0f, float endTime = 0f)
    {
        _time = time;
        _endTime = endTime;
    }

    public void SetTime(float time) => _time = time;
    public void SetEndTime(float time) => _endTime = time;
    public float GetNowTime() => _time;
    public void ResetAllTimer() => (_time, _endTime) = (0f, 0f);

    public void RestartTimer() => _time = 0f;
    public void UpdateTimer(float? timeStep = null) => UpdateTimer(ref _time, timeStep);
    public void UpdateTimer(ref float time, float? timeStep = null) => time += timeStep ?? Time.deltaTime;
    public bool CheckEndTimer(float? time = null, float? endTime = null) => (time ?? _time) >= (endTime ?? _endTime);
}