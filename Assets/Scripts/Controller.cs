using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public Data data;

    public TMP_Text currencyText;

    private void Start()
    {
        data = new Data(); 
    }

    private void Update()
    {
        currencyText.text = "Currency: " + data.currency;
    }

    public void GenerateCurrency()
    {
        data.currency += 1; 
        
    }
}
