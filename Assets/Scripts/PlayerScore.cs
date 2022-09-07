using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class PlayerScore : MonoBehaviour
    {
        public int playersScore { get; private set; }
        public Text PlayersScore;

        public void PlaScore(int score)
        {
            this.playersScore = score;
            PlayersScore.text = score.ToString();
        }
    }
}