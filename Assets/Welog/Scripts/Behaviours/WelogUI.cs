using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using Welog.Core;
using Welog.Data;
using LogType = UnityEngine.LogType;

namespace Welog.Behaviours
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(TextMeshProUGUI))]
    internal sealed class WelogUI : MonoBehaviour
    {
        #region Inspector
        [SerializeField] private SettingsProfile settingsProfile = null;
        #endregion

        #region Non-Inspector
        private TextMeshProUGUI textMeshProUGUI = null;
        private WaitForSeconds waitForSeconds = null;
        #endregion

        #region Unity Callbacks
        private void Awake() => waitForSeconds = new WaitForSeconds(settingsProfile.LogLifeTime);
        private void Start() => TryGetComponent(out textMeshProUGUI);
        private void OnEnable() => Enable();
        private void OnDisable() => Disable();
        #endregion

        #region Private Methods
        private void Enable()
        {
            WelogAPI.OnLogReceived += ViewLog;
            WelogAPI.OnClearRequestReceived += Clear;
        }

        private void Disable()
        {
            WelogAPI.OnLogReceived -= ViewLog;
            WelogAPI.OnClearRequestReceived -= Clear;
        }

        private void ViewLog(int logTypeIndex, string message)
        {
            Debug.Assert(logTypeIndex >= 0 && logTypeIndex < settingsProfile.LogTypes.Length);
            Debug.Assert(settingsProfile.LogTypes[logTypeIndex] != null);

            string[] lineSplittedText = textMeshProUGUI.text.Split('\n');
            int rowCount = lineSplittedText.Length - 1;
            string builtLog = BuildLog(logTypeIndex, message);

            if (rowCount < settingsProfile.MaximumLogsAllowed)
            {
                textMeshProUGUI.text += builtLog;
                textMeshProUGUI.text += System.Environment.NewLine;
            }
            else
            {
                RemoveFirstLine();
                textMeshProUGUI.text += builtLog;
                textMeshProUGUI.text += System.Environment.NewLine;
            }

            StartCoroutine(RemoveRoutine(builtLog));
        }

        private string BuildLog(int logTypeIndex, string message)
        {
            string builtMessage = string.Empty;

            if (settingsProfile.DisplayTimeInformation)
                builtMessage += System.DateTime.Now.ToString("h:mm:ss" + " ");

            if (settingsProfile.DisplayLogTag)
                builtMessage += settingsProfile.LogTypes[logTypeIndex].Tag + " ";

            builtMessage += message;
            return string.Format("<color=#{0}>{1}</color>", ColorUtility.ToHtmlStringRGBA(settingsProfile.LogTypes[logTypeIndex].Color), builtMessage);
        }

        private void RemoveFirstLine()
        {
            int index = textMeshProUGUI.text.IndexOf(System.Environment.NewLine);
            textMeshProUGUI.text = textMeshProUGUI.text.Substring(index + System.Environment.NewLine.Length);
        }

        private System.Collections.IEnumerator RemoveRoutine(string message)
        {
            yield return waitForSeconds;

            string firstLine = textMeshProUGUI.text.Split(new[] { '\r', '\n' }).FirstOrDefault();

            if (firstLine == message)
                RemoveFirstLine();
        }

        private void Clear()
        {
            textMeshProUGUI.text = string.Empty;
        }
        #endregion
    }
}