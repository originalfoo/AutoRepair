# AutoRepair

A mod for Cities: Skylines that helps clean up bad workshop subscriptions such as outdated mods and broken assets.

* Automatically remove game-breaking mods on startup
    * After restart, alternatives will be suggested where possible
* Subscribes and enables LSM, can auto-manage safe mode
* Check compatibility between active mods
* Replace outdated/broken mods with better alternatives
* Notify if required items are missing and subscribe them

## Note for modders

The mod can help users avoid incompatible subscriptions, it can help them subscribe required items, etc.

If you have any issues, please let me know in issues tab above.

## Log files, etc

AutoRepair maintains a number of files as follows:

* `AutoRepair.log` - log file for current session, resets each game restart
* `AutoRepair.Options.xml` - mod settings
* `AutoRepair.Audit.xml` - long-term audit of changes made to workshop subscriptions
* `AutoRepair.Archive.xml` - lists of mods that were recently removed or disabled
