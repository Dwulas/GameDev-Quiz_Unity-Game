using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace PointsGame
{
    public class AnswerData : MonoBehaviour
    {
        [Header("UI Elements")]
        [SerializeField] TextMeshProUGUI infoTextObject;
        [SerializeField] Image toggle;

        [Header("Textures")]
        [SerializeField] Sprite unchackedToggle;
        [SerializeField] Sprite checkedToggle;

        private int _answerIndex = -1;
        public int AnswerIndex { get { return _answerIndex; } }
    }
}
