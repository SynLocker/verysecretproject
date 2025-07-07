using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSlotMachine : MonoBehaviour
{
    public ColorSlotWheel[] wheels;
    public Button spinButton;
    public AchievementModal achievementModal;

    private List<Sprite[]> combos = new List<Sprite[]>();
    private int comboIndex = 0;
    private int wheelsStopped = 0;

    private Sprite shoeB;
    private Sprite shoeP;
    private Sprite shoeR;
    private Sprite shoeW;

    public static ColorSlotMachine Instance;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        shoeB = Resources.Load<Sprite>("Shoes_B");
        shoeP = Resources.Load<Sprite>("Shoes_P");
        shoeR = Resources.Load<Sprite>("Shoes_R");
        shoeW = Resources.Load<Sprite>("Shoes_W");

        foreach (var wheel in wheels)
        {
            wheel.cycleSprites = new[] { shoeB, shoeP, shoeR, shoeW };
        }

        combos.Add(new[] { shoeB, shoeR, shoeW });
        combos.Add(new[] { shoeP, shoeB, shoeR });

        if (spinButton != null)
            spinButton.onClick.AddListener(StartSpin);
    }

    public void StartSpin()
    {
        if (spinButton != null)
            spinButton.interactable = false;

        wheelsStopped = 0;
        var combo = combos[comboIndex];
        for (int i = 0; i < wheels.Length; i++)
        {
            wheels[i].StartSpin(combo[i]);
        }
        comboIndex = (comboIndex + 1) % combos.Count;
    }

    public void OnWheelStopped()
    {
        wheelsStopped++;
        if (wheelsStopped >= wheels.Length)
        {
            if (spinButton != null)
                spinButton.interactable = true;

            if (achievementModal != null)
                achievementModal.Show("perchè non blu?");
        }
    }
}
