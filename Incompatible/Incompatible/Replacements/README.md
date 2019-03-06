# Replacements

Rather than just unsubbing broken mods, we try to replace them with better equivalents so the user doesn't lose functionality they had become accustomed to.

By default, users will only be prompted to "upgrade" to a replacement mod if a mod they are currently using is known to be broken. This ensures we don't unnecessarily cull "working" (from user perspective) mods. The user can override the default behaviour in the mod options.

## Choosing replacements

For a given broken mod, there are sometimes multiple equivalents to choose from. In such cases, we have to determine which mod(s) are going to be best for the end-user based on a number of criteria, such as:

* Is it reliable?
* Is it easy to use?
* Is the source code available? (without resorting to tools like ILSpy)
* Does it affect frame rate?
* Does it use detours, harmony, etc? (we generally avoid mods that use detours)
* Does it play well with other mods?

## Scripts

Each replacement suggestion is defined by a "script", which is essentially a C# file containing several fields describing which mods are deprecated for the specified replacements.

To ensure the scripts remain largely consistent, and provide the required information, an interface `IReplacement` and an extension base `ReplacementBase` have been provided.

**Properties:**

* `Always` - determines what causes the replacement suggestion to be shown to users:
    * `false`: A suggestion will only be made if the user has a known broken mod that can be replaced
    * `true`: The ssuggestion will be shown if tehuser has any of the mods listed by `Deprecates` property
* `Mode` - defines the selection mode in cases where more than one replacement mod 'group' is applicable:
    * `Selection.Any`: User can choose one or more of the replacements (you musst ensure they are compatible when enabled)
    * `Selection.All`: User must choose all replacements (for example, if it requires several mods to replace functionality of broken mod)
    * `Selection.OnlyOne` (default): User can only choose one 'group' from the available replacement mods
* `Replacements` - a dictionary of mods the user can "upgrade" to when replacing older/broken mods
    * The `ulong` should be a workshop id, but can also be `Helper.CitiesSkylinesFeature` (more on that later)
    * The `byte` is a grouping value (again, more on that later)
* `Notes` - a dictionary of strings that can be displayed to the user depending on which replacement mods they select
    * The `byte` is a grouping value
    * The `string` contains the text to display to the user (not yet localised, but planned in future version)
* `Deprecates` - dictionary defining the mods that the replacements will, uhm, replace :)
    * The `ulong` is the workshop id
    * The `byte` is a grouping value

**Methods:**

* `OnBeforeRemove(PluginInfo)` - this is called prior to removing a deprecated mod, and is often used to determine whether the mod was enabled and/or extract settings from the mod:
    * It is called for each mod that will be removed
    * The `PluginInfo` might be null, if the user selected a `Helper.CitiesSkylinesFeature` replacement
    * After the method is called, the mod will be disabled and unsubscribed
* `OnAfterRemove(PluginInfo)` - this is called after removing a deprecated mod, and could be used to perform any clean up (eg. deleting old settings files or whatever)
    * _The parameter will likely be changed to just a workhop id_
* `OnAfterSubscribe(PluginInfo)` - this is called after a replacement mod is subscribed, and can be used to enable the mod
    * If the replacement mod was already subscribed, this method will still be called

Note: See `IReplacement.cs` for some additional notes.

**Groups:**

The `byte` elements of dictionary properties can be used as a simplistic grouping mechanism. For example, if you have two individual replacement mods you an number them `1` and `2`. If you had a third, it could be numbered `4` (think bitwise flags).

This allows you to group replacements (eg. you could put two replacements in group `1` and a third in group `2`). The `Mode` property takes account of this - if the user selectes a mod in group `1`, both mods in that group would be selected.

The user interface will reflect user selections accordingly, showing applicable `Notes` and replacing associated `Deprecates` mods.

**CitiesSkylinesFeature**

The `Helper.CitiesSkylinesFeature` value can be used to indicate that a replacement is part of the vanilla game. The user will see the Cities: Skylines logo as the "mod image" for the replacement. If they choose it, bear in mind that the `PluginInfo` parameter to `OnAfterSubscribe()` will be `null`, so always check for that in scripts that use this feature.

> **Important:** `ReplacementBase` does not handle this situation, you will have to override `OnAfterSubscription()` and provide a custom implementation. You can use `Helper.GetBundledMod(string modName)` to get the `PluginInfo` for a bundled mod.
