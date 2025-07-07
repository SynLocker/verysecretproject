using UnityEngine;

public class SpinSpriteButton : MonoBehaviour
{
    void OnMouseDown()
    {
        if (ColorSlotMachine.Instance != null)
            ColorSlotMachine.Instance.StartSpin();
    }
}
