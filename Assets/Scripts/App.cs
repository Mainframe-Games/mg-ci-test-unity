using Mainframe.CI.Runtime;
using TMPro;
using UnityEngine;

public class App : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _txtVersion;
    
    private void Start()
    {
        _txtVersion.text = $"Version: {AppVersion.Instance.DisplayString}";
    }
}
