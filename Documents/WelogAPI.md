## Logging Basic Messages
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
