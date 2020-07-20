## Events
* **OnLogReceived** </br>
    Subscribe to this event to get notified when new log request is received by the API.
    
    ```csharp 
      [Access Modifier] void MethodName(int, string)
    ```
    
* **OnClearRequestReceived** </br>
   Subscribe to this event to get notified when clear request received by the API.

## Static Methods
* **Log(int, string)** </br>
    Use this function to create a new Log request.
   
    ```csharp
    using UnityEngine;
    using Welog.Core;

    public class Player : MonoBehaviour
    {
        private void Start()
        {
            // Use the available Log Type with "0" index and print given message
            WelogAPI.Log(0, "Initializing the Player!");
        }
    
        private void Update()
        {
            if (Input.GetKeyDown(Keycode.Space))
            {
                // Use the available Log Type with "1" index and print given message
                WelogAPI.Log(1, "Space Bar input received from Player!");
            }
        }
    }
  ```

* **Clear()** </br>
   Use this function clear logs from screen.
   
    ```csharp
    using UnityEngine;
    using Welog.Core;

    public class Player : MonoBehaviour
    {
        private void Start()
        {
            // Clear the console
            WelogAPI.Clear();    
        }
    }
  ```
