## Subscribing to OnLogReceived Event
You can subscribe your methods to the **OnLogReceived** event of **WelogAPI** class. </br>
Your method will be notified when the new log request received by the API.

**Required method signature**
```csharp 
[Access Modifier] void MethodName(int, string);
```

**Full example**
```csharp
using Welog.Core;

public class Controller
{
    public Controller()
    {
        // Subscribe to the "OnLogReceived" event.
        WelogAPI.OnLogReceived += CheckLog;
    }
    
    ~Controller()
    {
        // Unsubscribe from "OnLogReceived" event.
        WelogAPI.OnLogReceived -= CheckLog;
    }
    
    public bool CheckLog(int logTypeIndex, string message)
    {
        if (message == "Controller")
            return true;
            
        return false;
    }
}
```

## Logging Basic Messages
**Full example**
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
