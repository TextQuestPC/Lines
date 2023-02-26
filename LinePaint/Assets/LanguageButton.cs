using LinePaint;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class LanguageButton : MonoBehaviour
{
    [SerializeField] private UIManager_paint uIManager;

    [SerializeField] private LanguageYG[] languageYG;

    public string lang1;
    public string lang2;
    bool activ = false;
    private void Update()
    {
        languageYG = FindObjectsOfType<LanguageYG>();
        if (activ)
        {
            for (int i = 0; i < languageYG.Length; i++)
            {
                languageYG[i].SwitchLanguage(lang1);
            }
            uIManager.TotalDiamonds.text = "" + GameManager_paint.totalDiamonds;
            uIManager.LevelText.text += (GameManager_paint.currentLevel + 1);
        }
        if (!activ)
        {
            for (int i = 0; i < languageYG.Length; i++)
            {
                languageYG[i].SwitchLanguage(lang2);
            }
            uIManager.TotalDiamonds.text = "" + GameManager_paint.totalDiamonds;
            uIManager.LevelText.text += (GameManager_paint.currentLevel + 1);
        }
    }
    public void buttonLanguage()
    {
        activ = !activ;

    }
}
