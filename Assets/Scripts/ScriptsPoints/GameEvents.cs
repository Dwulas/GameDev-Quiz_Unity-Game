using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PointsGame
{
    [CreateAssetMenu(fileName = "GameEvents", menuName = "Quiz/new GameEvents")]

    public class GameEvents : ScriptableObject
    {
        public delegate void UpdateQuestionUICallback(Question question);
        public UpdateQuestionUICallback updateQuestionUI;

        public delegate void UpdateQuestionAnswerCallback(AnswerData pickedAnswer);
        public UpdateQuestionAnswerCallback GetUpdateQuestionAnswer;

        public delegate void DisplayResolutionScreenCallback(UIManager.ResolutionScreenType type, int score);
        public DisplayResolutionScreenCallback DisplayResolutionScreen;

        public delegate void ScoreUpdateCallback();
        public ScoreUpdateCallback ScoreUpdate;

        public int CurrentFinalScore;
    }
}
