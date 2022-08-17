using TMPro;
using UnityEngine;

namespace Comibast
{
    /// <summary>
    /// ���ƺ޲z
    /// </summary>
    public class ScoreManager : MonoBehaviour
    {
        public static int addScore = 2;

        private string nameBasketball = "�x�y";
        private TextMeshProUGUI textScore;
        private int totalScore;

        private void Awake()
        {
            textScore = GameObject.Find("����").GetComponent<TextMeshProUGUI>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameBasketball))
            {
                AddScore();
            }
        }

        private void AddScore()
        {
            totalScore += addScore;
            textScore.text = "SCORE " + totalScore;
        }

        /// <summary>
        /// �ܧ����
        /// </summary>
        /// <param name="scoreToChange">�n�ܧ󪺤���</param>
        private void ChangeScore(int scoreToChange)
        {
            addScore = scoreToChange;
        }
    }

}
