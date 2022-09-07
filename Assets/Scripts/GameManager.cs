using Scripts;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] public StatsContainer _statsConPlayer1;
    [SerializeField] private Cube _cube1, _cube2, _cube3, _cube4, _cube5;
    
    public int push { get; private set; }
    public Text pushText;
    
    private int _one, _two, _three, _four, _five, _six, _bonus, _triple, 
        _quadro, _fullHouse, _sS, _bS, _yatzy, _chance;

    private void Update()
    {
        if (push <= 0) {
            NewGame();
        }
        ScoreYatzyNum();
        ScoreNum();
    }

    public void PushGo()
    {
        SetPush(push - 1);
    }
    
    public void NewGame()
    {
        SetPush(3);
    }
    
    private void SetPush(int push)
    {
        this.push = push;
        pushText.text = push.ToString();
    }

    [ContextMenu("ScoreNum")]
    public void ScoreNum()
    {
        int[] num = {_cube1._cubeScore, _cube2._cubeScore, _cube3._cubeScore, 
            _cube4._cubeScore,  _cube5._cubeScore};
        for (var i = 0; i < num.Length; i++)
        {
            if (num[i] < 2)
            {
                _one += 1;
            }
            else if (num[i] < 3 && num[i] > 1)
            {
                _two += 2;
            }
            else if (num[i] < 4 && num[i] > 2)
            {
                _three += 3;
            }
            else if (num[i] < 5 && num[i] > 3)
            {
                _four += 4;
            }
            else if (num[i] < 6 && num[i] > 4)
            {
                _five += 5;
            }
            else if (num[i] < 7 && num[i] > 5)
            {
                _six += 6;
            }
        }
        ScoreYatzyNum();
        ScoreSpecialNum();
        SetScore(_one, _two, _three, _four, _five, _six,
            _triple, _quadro, _fullHouse,_sS, _bS, _yatzy, _chance);
        _one=_two=_three=_four=_five=_six=_triple=_quadro=_fullHouse=_sS=_bS=_yatzy=_chance =  0;
    }

    private void ScoreYatzyNum()
    {
        
        if (_one == 1 && _two == 2 && _three == 3 && _four == 4 && _five == 5)
            _sS = 30;
        if (_two == 2 && _three == 3 && _four == 4 && _five == 5 && _six ==6)
            _bS = 40;
        if (_one == 5 || _two == 10 || _three == 15 || _four == 20 || _five == 25 || _six == 30)
            _yatzy = 50;
        _chance = _one + _two + _three + _four + _five + _six;
    }

    private void ScoreSpecialNum()
    {
        
    }

    private void SetScore(int score1, int score2, int score3, int score4, int score5, int score6,
        int triple, int quadro, int fh, int ss, int bs, int yatzy, int chance)
    {
        _statsConPlayer1.SetFullScore(score1, score2, score3, score4, score5, score6,
            triple, quadro, fh, ss, bs, yatzy, chance);
    }
}