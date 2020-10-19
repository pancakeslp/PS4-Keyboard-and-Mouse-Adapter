# PS4 Keyboard and Mouse Adapter 

## How to use

1. Make sure you've enabled remote play from your PS4's settings menu. To do that:
  * Go to your PS4, select (Settings) -> [Remote Play Connection Settings], and then select the checkbox for [Enable Remote Play].
  * To activate it as your primary PS4, select  (Settings) -> [Account Management] -> [Activate as Your Primary PS4] -> [Activate].
2. Download and run the setup from the download link above. It will automatically do all the configuration stuff for you
3. If you want 0 lag, connect your PS4 to your TV or PC monitor and watch the game from there, not from the Remote Play app
4. That's it 

Do NOT plug your DS4 controller into your PC while using this tool. If it is plugged already, unplug it because it interferes with the device emulator.

If you think something doesn't work or is not good enough, don't get too mad at me and create an issue [here](https://github.com/starshinata/PS4-Keyboard-and-Mouse-Adapter/issues/new/choose)


## Setup
visual studio 2019

Workloads ?
* .net Development
* Windows and web develoment
  (Specifically "ClickOnce Publishing Tools"

## Build
run ` build.sh `

## Gotchas
* "Could not copy \Squirrel.exe"
you need to set "SquirrelToolsPath" in your project properties

eg if you have your project as 'D:\workspace\pancakeslp\PS4-Keyboard-and-Mouse-Adapter\'

then your squirrel tools will be at  'D:\workspace\pancakeslp\PS4-Keyboard-and-Mouse-Adapter\packages\squirrel.windows.1.9.1\tools'

so then  ` SquirrelToolsPath = packages\squirrel.windows.1.9.1\tools `


## To-do list
- Create and switch between multiple mapping profiles to make configuration easy when playing multiple games
- Map multiple keys to the same button
- Option to map mouse movement to left analog stick

## Credits

- [PS4Macro](https://github.com/komefai/PS4Macro) - Big thanks to komefai for making and open-sourcing this tool. Komefai is MIA for 2 years and his repo is not supported anymore but you can still write pretty good bots with it, definitely check it out if you are into that kind of stuff
- [EasyHook](https://easyhook.github.io) - The best tool for Windows API hooking. Works flawlessly - from the assembly injection, to the hook trampoline code. ~~I haven't had a single problem with it~~ I had one but that doesn't make EasyHook any less cool
- [Jays2Kings/DS4Windows](https://github.com/Jays2Kings/DS4Windows) - don't need to explain that one
