using LinePaint;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageButton : MonoBehaviour
{
    [SerializeField] private UIManager_paint uIManager;
    public void buttonLanguage()
    {
        uIManager.TotalDiamonds.text = "" + GameManager_paint.totalDiamonds;
        uIManager.LevelText.text += (GameManager_paint.currentLevel + 1);
    }
}
