### **Class `MyCoolWorkingRulesetModAutoplay`**

This class implements the "Autoplay" mod for your ruleset. This mod allows the game to automatically play a map without player intervention.

---

#### **Inheritance**

```csharp
public class MyCoolWorkingRulesetModAutoplay : ModAutoplay
```

- Inherits from `ModAutoplay`, which provides a base implementation for autopilot mods.
- **`ModAutoplay`:**
    - Includes basic logic for mods that generate replay data simulating perfect inputs to complete a map.

---

#### **Methods**

1. **`CreateReplayData`**:
    
    ```csharp
    public override ModReplayData CreateReplayData(IBeatmap beatmap, IReadOnlyList<Mod> mods)
        => new ModReplayData(new MyCoolWorkingRulesetAutoGenerator(beatmap).Generate(), new ModCreatedUser { Username = "sample" });
    ```
    
    - **Purpose:**
        - Creates the replay data that will be used to simulate an automatic run of the map.
    - **Details:**
        - Uses `MyCoolWorkingRulesetAutoGenerator` to generate the replay input data.
        - Creates a fictional user (`ModCreatedUser`) with the name "sample".
    - **Dependencies:**
        - `IBeatmap`: Represents the map that will be played automatically.
        - `MyCoolWorkingRulesetAutoGenerator`: Class that automatically generates the inputs needed to complete the map.

---

#### **Dependencies and References**

1. **Related classes:**
    
    - **`ModAutoplay`:**
        - Base class defining how an autopilot mod is implemented.
    - **`MyCoolWorkingRulesetAutoGenerator`:**
        - Generates the perfect inputs to simulate an automatic run in this ruleset.
2. **Frameworks:**
    
    - **`osu.Game.Rulesets.Mods.ModReplayData`:**
        - Encapsulates the generated replay data for the mod.
    - **`osu.Game.Beatmaps.IBeatmap`:**
        - Provides access to map objects and data.
    - **`osu.Game.Rulesets.Mods.ModCreatedUser`:**
        - Represents a fictional user associated with the mod.

---

### **How the "Autoplay" mod works**

1. **Replay generation:**
    
    - When the "Autoplay" mod is selected, the game calls `CreateReplayData` to generate the necessary data.
    - `MyCoolWorkingRulesetAutoGenerator` analyzes the map and creates a replay simulating perfect inputs.
2. **Automatic execution:**
    
    - The generated replay is played back automatically, showing how the map would be completed without errors.

---

### **How to extend this class**


1. **Change the fictional user:**
    
    - Change the name of the user associated with the mod:
        
        ```csharp
        new ModCreatedUser { Username = "AutoPlayer" }
        ```
        
2. **Customize the replay generator:**
    
    - Modify `MyCoolWorkingRulesetAutoGenerator` to generate inputs that reflect specific characteristics of the ruleset, such as unique movements or complex patterns.

3. **Add visual elements:**
    
    - Add visual effects indicating that the mod is active during execution.

---

### **Example of a custom implementation**

If you want to change the appearance of the fictional user or add more data to the mod:

```csharp
public override ModReplayData CreateReplayData(IBeatmap beatmap, IReadOnlyList<Mod> mods)
{
    var autoGenerator = new MyCoolWorkingRulesetAutoGenerator(beatmap);
    var replayData = autoGenerator.Generate();

    return new ModReplayData(replayData, new ModCreatedUser
    {
        Username = "MyCoolBot",
        ProfileImage = "bot_avatar.png" // Custom image for the fictional profile
    });
}
```

---

### **Summary**

`MyCoolWorkingRulesetModAutoplay` implements a mod that allows the game to automatically complete any map in this ruleset. It uses an automatic generator (`MyCoolWorkingRulesetAutoGenerator`) to create replay data with perfect inputs.

To customize the mod:

- Change the fictional user data.
- Modify how automatic inputs are generated.