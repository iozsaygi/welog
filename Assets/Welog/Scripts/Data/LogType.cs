using UnityEngine;

namespace Welog.Data
{
    [CreateAssetMenu(fileName = "Log Type", menuName = "Welog/Log Type")]
    internal sealed class LogType : ScriptableObject
    {
        #region Inspector
        [SerializeField] private string tag = string.Empty;
        public string Tag => tag;

        [SerializeField] private Color color = Color.white;
        public Color Color => color;
        #endregion
    }
}