namespace Welog.Core
{
    internal static class WelogAPI
    {
        #region Delegates
        public delegate void OnLogReceivedHandler(int logTypeIndex, string message);
        public delegate void OnClearRequestReceivedHandler();
        #endregion

        #region Events
        public static event OnLogReceivedHandler OnLogReceived;
        public static event OnClearRequestReceivedHandler OnClearRequestReceived;
        #endregion

        #region Public Static Methods
        public static void Log(int logTypeIndex, string message)
        {
            if (OnLogReceived != null)
                OnLogReceived.Invoke(logTypeIndex, message);
        }

        public static void Clear()
        {
            if (OnClearRequestReceived != null)
                OnClearRequestReceived.Invoke();
        }
        #endregion
    }
}