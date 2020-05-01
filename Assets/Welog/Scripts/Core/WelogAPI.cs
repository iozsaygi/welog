namespace Welog.Core
{
    internal static class WelogAPI
    {
        #region Delegates
        public delegate void OnLogReceivedHandler(int logTypeIndex, string message);
        #endregion

        #region Events
        public static event OnLogReceivedHandler OnLogReceived;
        #endregion

        #region Public Static Methods
        public static void Log(int logTypeIndex, string message)
        {
            if (OnLogReceived != null)
                OnLogReceived.Invoke(logTypeIndex, message);
        }
        #endregion
    }
}