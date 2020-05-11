<p align="center">
  <a href="#"><img src="https://github.com/iozsaygi/welog/blob/master/Media/v1.0%20Showcase.gif"/></a>
</p>

</br>

## About
**Welog** is fully customizable on screen logger tool for **Unity Engine**.

## Features
* Easily customize the behaviour of the tool by manipulating attached **Settings Profile** object.
* Create your own log types and give them any **tag** or **color**.
* Works both in **Editor** and **Runtime**.
* Supports mobile devices.

## Installation
1. Importing **Welog** to your awesome Unity project.
    * Download any version you want from **[Distributions](https://github.com/iozsaygi/welog/tree/master/Distributions)** page.
    * Import the package to your awesome Unity project.
    
2. Adding **Welog** prefab to your scene.
    * Find **Welog** in your **Assets** folder.
    * Navigate to **"Welog/Prefabs"** and add **Tools Canvas (Scale With Screen Size)** prefab to your scene.
    
## Usage
1. Managing default **Settings Profiles** and **Log Types**.
    * As default **Welog** comes with **1 Settings Profile** and **3 Log Types** that you can use immediately.
        * You can find them in **"Welog/Data"** directory.
    * You can change any exposed property of default **Settings Profile** and **Log Type** from Unity inspector.

2. Creating your own **Settings Profile** and attaching it to the **Welog** behaviour.
    * To create **Settings Profile, right** click on your assets browser and navigate to **"Create/Welog/Settings Profile"**. 
        * You can change any exposed property  **(Such as Log Life Time and Available Log Types)** of **Settings Profile** from Unity inspector.
    * Find the **Tools Canvas (Scale With Screen Size)** object in your scene and find **Welog** child object.
    * Find the **WelogUI** script on **Welog** object.
    * Drag and drop the **Settings Profile** that you just created on **WelogUI** script.
    
3. Creating your own **Log Type** and attaching it to the **Settings Profile**.
    * To create **Log Type, right** click on your assets browser and navigate to **"Create/Welog/Log Type"**.
        * You can change any exposed property **(such as Tag and Color)** of **Log Type** from Unity inspector.
    * Find the **Settings Profile** that you want to add your **Log Type** on.
    * Add new element to the **Log Types** array of **Settings Profile**.
    * Drag and drop your own **Log Type** to the new slot in array.

4. Using **Welog API** in your code.
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

## Additional Information
* Navigate to the **[Changelog](https://github.com/iozsaygi/welog/blob/master/Documents/Changelog.md)** page to see general timeline of **Welog**.
* Navigate to the **[WelogAPI](https://github.com/iozsaygi/welog/blob/master/Documents/WelogAPI.md)** page to get detailed information about API.
* The assets used in **Demo** scene is provided by this cool **[package](https://assetstore.unity.com/packages/2d/characters/bandits-pixel-art-104130)** in **Asset Store**.

## License
**[MIT License](https://github.com/iozsaygi/welog/blob/master/LICENSE)**
