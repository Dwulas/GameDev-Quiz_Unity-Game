using UnityEngine;
using System.Collections.Generic;

namespace PointsGame
{
    [System.Serializable]
    public struct Answer
    {
        [SerializeField]
        string _info;
        public string Info { get { return _info; } }

        [SerializeField]
        private bool _isCorrect;
        public bool IsCorrect { get { return _isCorrect; } }
    }

    [CreateAssetMenu(fileName = "New Question", menuName = "Quiz/new Question")]
    public class Questions : ScriptableObject
    {
        public enum AnswerType { Multi, Single }

        [SerializeField]
        string _info = string.Empty;
        public string Info { get { return _info; } }

        [SerializeField]
        Answer[] _answers = null;
        public Answer[] Answers {get {return _answers;} }

        //parameters

        [SerializeField]
        bool _useTimer = false;
        public bool UseTimer { get { return _useTimer; } }

        [SerializeField]
        int _timer = 0;
        public int Timer { get { return _timer; } }

        [SerializeField]
        AnswerType _answerType = AnswerType.Multi;
        public AnswerType GetAnswerType { get { return _answerType; } }

        [SerializeField]
        int _addScore = 10;
        public int AddScore { get { return _addScore; } }

        public List<int> GetCorrectAnswers()
        {
            List<int> CorrectAnswers = new List<int>();
            for (int i = 0; i < Answers.Length; i++)
            {
                if (Answers[i].IsCorrect)
                {
                    CorrectAnswers.Add(i);
                }
            }
            return CorrectAnswers;
        }
    }
}