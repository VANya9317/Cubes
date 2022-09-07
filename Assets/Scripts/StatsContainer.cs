using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class StatsContainer : MonoBehaviour
    {
        public int oneScore { get; private set; }
        public Text Player1OneScore;
        public int twoScore { get; private set; }
        public Text Player1TwoScore;
        public int threeScore { get; private set; }
        public Text Player1ThreeScore;
        public int fourScore { get; private set; }
        public Text Player1FourScore;
        public int fiveScore { get; private set; }
        public Text Player1FiveScore;
        public int sixScore { get; private set; }
        public Text Player1SixScore;
        public int tripleScore { get; private set; }
        public Text Player1TripleScore;
        public int quadroScore { get; private set; }
        public Text Player1QuadroScore;
        public int fhScore { get; private set; }
        public Text Player1FHScore;
        public int sScore { get; private set; }
        public Text Player1SScore;
        public int bScore { get; private set; }
        public Text Player1BScore;
        public int yatzyScore { get; private set; }
        public Text Player1YatzyScore;
        public int chanceScore { get; private set; }
        public Text Player1ChanceScore;

        public void SetFullScore(int score1, int score2, int score3, int score4, int score5, int score6,
            int triple, int quadro, int fh, int ss, int bs, int yatzy, int chance)
        {
            this.oneScore = score1;
            Player1OneScore.text = score1.ToString();
        
            this.twoScore = score2;
            Player1TwoScore.text = score2.ToString();
        
            this.threeScore = score3;
            Player1ThreeScore.text = score3.ToString();
        
            this.fourScore = score4;
            Player1FourScore.text = score4.ToString();
        
            this.fiveScore = score5;
            Player1FiveScore.text = score5.ToString();
        
            this.sixScore = score6;
            Player1SixScore.text = score6.ToString();
            
            this.tripleScore = triple;
            Player1TripleScore.text = triple.ToString();
            
            this.quadroScore = quadro;
            Player1QuadroScore.text = quadro.ToString();
            
            this.fhScore = fh;
            Player1FHScore.text = fh.ToString();
            
            this.sScore = ss;
            Player1SScore.text = ss.ToString();
            
            this.bScore = bs;
            Player1BScore.text = bs.ToString();
            
            this.yatzyScore = yatzy;
            Player1YatzyScore.text = yatzy.ToString();
            
            this.chanceScore = chance;
            Player1ChanceScore.text = chance.ToString();
        }
    }
}