using UnityEngine;

namespace Welog.Data
{
    [CreateAssetMenu(fileName = "Settings Profile", menuName = "Welog/Settings Profile")]
    internal sealed class SettingsProfile : ScriptableObject
    {
        #region Inspector
        [SerializeField, Min(1)] private int maximumLogsAllowed = 1;
        public int MaximumLogsAllowed => maximumLogsAllowed;

        [SerializeField, Min(1.0f)] private float logLifeTime = 1.0f;
        public float LogLifeTime => logLifeTime;

        [SerializeField] private bool displayLogTag = false;
        public bool DisplayLogTag => displayLogTag;

        [SerializeField] private bool displayTimeInformation = false;
        public bool DisplayTimeInformation => displayTimeInformation;

        [SerializeField] private LogType[] logTypes = null;
        public LogType[] LogTypes => logTypes;
        #endregion
    }
}