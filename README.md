# ClockGoblin

**This project is developed from the [Tai](https://github.com/Planshit/Tai.git) project**

**The purpose of this project is to track the usage time of `software` and `websites` on Windows**

## Getting Started

#### Prerequisites

Before using, your computer may need to have [.NET Framework](https://dotnet.microsoft.com/en-us/download/dotnet-framework) version `4.8` or higher installed (usually not required for systems above Windows 10).

#### Usage

1. You can download the pre-compiled executable file in the releases section. It is recommended to choose the version marked as `Latest` and download the `CLockGoblin.x.x.zip` file under the `Assets` section.
2. After downloading the zip file, extract it to a suitable location. Find `CLockGoblin.exe` and run it as an administrator to start the Tai program (otherwise, it may not be able to track certain programs). Once successfully started, you will see the 👻 icon in the system tray.
3. To use the `Website Usage Tracking` feature, you need to install the corresponding browser extension and enable it in the Settings > General > Features.

#### Uninstall

1. Disable the startup on boot in the settings (if enabled).
2. Delete all files to complete the uninstallation.

#### Basic Operations

Double-click the icon to enter the main interface of the program, right-click to display the menu.

## Learn More

#### Application Whitelist

Supports tracking only the software in the whitelist. You can enable this feature in the Settings > Behavior.

#### Associated Processes

If you want to track the usage time of software used on multiple screens simultaneously, you can add the corresponding software processes to an associated list in the settings. Once added, the usage time will be synchronized to other software in the list whenever any software in the list is used, provided that the other software is running (even in the background or without focus). A software can only be associated once and cannot be associated with other software.

#### Filtering Applications and Websites

You can filter out software/websites that do not need to be tracked by process name/URL or regular expressions in the Settings > Behavior.

#### Data Storage and Export

Tai uses an unencrypted `SQLite` database to store the tracking data locally in the `运行目录\Data\data.db` file. You can export the tracking data in two file formats: `.xlsx` and `.csv` in the settings.

#### Sleep Monitoring

Tai can detect when the user leaves the computer to stop tracking to some extent. You can disable this feature in the Settings > Behavior to achieve uninterrupted tracking.

#### Automatic Categorization

You can automatically categorize software based on the running directory. When adding/editing categories in the category management, you can enable or disable directory matching. For example, if you enable and add a directory `C:\` in `Category A`, all software under the C drive will be automatically categorized into `Category A`.

#### Networking and Privacy

Apart from checking for software updates/upgrades (which requires manually checking for updates in the settings), there are no other network requests. ClockGoblin does not collect or upload any of your information.

## Acknowledgements

If this software has helped you, please consider buying a cup of coffee for the author of Tai.

#### Buy Me a ☕

<img src="https://github.com/noberumotto/noberumotto/raw/master/wechat.jpg" width="256px"/> <img src="https://github.com/noberumotto/noberumotto/raw/master/alipay.jpg" width="256px" />
