using UnityEngine;
using TMPro;
using BreakInfinity;

public class Controller : MonoBehaviour
{
    public Data data;

    public UpgradeManager upgradeManager; 

    public TMP_Text currencyText;
    public TMP_Text currencyClickPowerText;

    public BigDouble clickPower() => 1 + data.clickUpgradeLevel;


    private void Start()
    {
        data = new Data();
        data.currency = 1;

        upgradeManager.StartUpgradeManager(); 

    }

    private void Update()
    {
        currencyText.text = "Currency: " + data.currency;
        currencyClickPowerText.text = "+ " + clickPower() + " currency";  
    }

    public void GenerateCurrency()
    {
        data.currency += clickPower(); 
        
    }
}
