## Events
* **OnLogReceived**
    * Subscribe to this event to get notified when new log request is received by the API
    * Subscribed method must meet the requirements of the signature below
    
    ```csharp 
      [Access Modifier] void MethodName(int, string)
    ```

## Static Methods
* **Log(int, string)**
    * Use this function to create a new Log request
   
    ```csharp
    using UnityEngine;
    using Welog.Core;

    public class Player : MonoBehaviour
    {
        private void Start()
        {
            // Use the available Log Type with "0" index and print given message.
            WelogAPI.Log(0, "Initializing the Player!");
        }
    
        private void Update()
        {
            if (Input.GetKeyDown(Keycode.Space))
            {
                // Use the available Log Type with "1" index and print given message.
                WelogAPI.Log(1, "Space Bar input received from Player!");
            }
        }
    }
  ```
