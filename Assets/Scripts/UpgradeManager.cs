using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using BreakInfinity;

public class UpgradeManager : MonoBehaviour
{
    public Controller controller;

    public Upgrades clickUpgrade;

    public string clickUpgradeName; 

    public BigDouble clickUpgradeBaseCost; 
    public BigDouble clickUpgradeBaseMulti;

    public void StartUpgradeManager()
    {
        clickUpgradeName = "Currency per Click"; 
        clickUpgradeBaseCost = 10; 
        clickUpgradeBaseMulti = 1.5;
        UpdateUpgradeUI(); 
    }

    public void Update()
    {
     
    }

    public void UpdateUpgradeUI()
    {
        clickUpgrade.LevelText.text = "Your level: " + controller.data.clickUpgradeLevel.ToString();
        clickUpgrade.CostText.text = "Cost: " + Cost().ToString("F2") + " Currency"; //zrobic moze tak zeby z bomby nie bylo decimal F2 tylko 10 a potem dopiero np 22.5
        clickUpgrade.PerClickText.text = "+1 " + clickUpgradeName;
    }

    public BigDouble Cost() => clickUpgradeBaseCost* BigDouble.Pow(clickUpgradeBaseMulti, controller.data.clickUpgradeLevel);

    public void BuyUpgrade()
    {
        if (controller.data.currency >= Cost())
        {
            controller.data.currency -= Cost();
            controller.data.clickUpgradeLevel += 1; 
        }

        UpdateUpgradeUI();
    }
}
