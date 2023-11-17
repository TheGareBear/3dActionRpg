using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarUI : MonoBehaviour
{
    public Image fill;
    public static HealthbarUI instance;

    private void Awake() {
        instance = this;
    }
    public void UpdateHealth (int curHp, int maxHp) {
        fill.fillAmount = (float)curHp / (float)maxHp;
    }
}
