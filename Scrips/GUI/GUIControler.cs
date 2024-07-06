using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GUIControler : MonoBehaviour
{ 

    [Header("Image")]
    public Image hpPlayer;

    [Header("Text")]
    [SerializeField] private TMP_Text _aroowNumbersText;
    [SerializeField] private TMP_Text _cointNumbersText;
    [SerializeField] private TMP_Text _diamantNumbersText;
    [SerializeField] private TMP_Text _cointNumbersWinPanelText;
    [SerializeField] private TMP_Text _diamantNumbersWinPanelText;

    [Header("Panel")]
    [SerializeField] GameObject _panelWin;
    [SerializeField] GameObject _panelLose;

    [Header("Scrips")]
    [SerializeField] HpCharacter _hpCharacter;
    [SerializeField] Atacken _atacken;

    private BonusItems _bonusItems;
    private void Awake()
    {
        _bonusItems = GetComponent<BonusItems>();
        VariableInitialization();
    }

    private void Update()
    {
        VariableInitialization();
        Lose();
    }

    private void VariableInitialization() 
    {
        _aroowNumbersText.text = _atacken.countArrow.ToString();
        _cointNumbersText.text = _bonusItems.coinNumber.ToString();
        _diamantNumbersText.text = _bonusItems.diamontNumber.ToString();
        _cointNumbersWinPanelText.text = _bonusItems.coinNumber.ToString();
        _diamantNumbersWinPanelText.text = _bonusItems.diamontNumber.ToString();
    }

    public void IsWin()
    {
       _panelWin.SetActive(true);
    }

    private void Lose()
    {
        if(_hpCharacter.playerHp <= 0)
        {
            _panelLose.SetActive(true);
        }
    }
} 

