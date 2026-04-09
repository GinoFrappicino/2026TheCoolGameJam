using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Slider hpSlider;

    public void SetHUD(Unit unit)
    {
    }

    public void SetHP(int hp)
    {
        hpSlider.value = hp;
    }
}
