using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Magazine : MonoBehaviour
{
    public int maxBullets = 30;
    public int chargingTime = 3f;

    private int currentBullets;
    private int currentBullets
    {
        get => currentBullets;
        set
        {
            if (value < 0)
                currentBullets = 0;
            else if (value > maxBullets)
                currentBullets = maxBullets;
            else
                currentBullets = value;
            
            OnBulletsChanged?.Invoke(currentBullets);
            OnChargeChanged?.Invoke((float)currentBullets / maxBullets);
        }
    }

    public UnityEvent OnReloadStart;
    public UnityEvent OnReloadEnd;

    public UnityEvent<int> OnBulletsChanged;
    public UnityEvent<float> OnChargeChanged;
}
