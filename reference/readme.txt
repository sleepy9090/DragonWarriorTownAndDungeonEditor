DragonWarriorTownAndDungeonEditor 1.0.0.28734 + Source
Coded by: Shawn M. Crawford [sleepy9090]
January 8, 2018

-Requires .NET Framework 3.5
-Source is included and can be opened/built with Visual Studio 2013.
-Latest version can be found on github. https://github.com/sleepy9090

January 8, 2018 Version 1.0.0.28734
-Edit dungeon, castle, and town map data for all maps in the game.
-Tested with headered Dragon Warrior (U) (PRG0) [!].nes ROM.
-Tested with headered Dragon Warrior (U) (PRG1) [!].nes ROM.

Notes:
-This utility currently supports visual changes only. For example, if a chest or a set of stairs is added, the chest will not have any contents and stairs will not go anywhere.
-Tiles with a yellow border and cross means the data for this tile has more than one purpose. When changing this tile, it is recommended to use another tile with a yellow border and cross. These tiles, aside from what is shown on the screen, also correspond to roof placement and possibly other data/data pointers. Changing these tiles to regular tiles (and vice versa) could have unexpected results.
-Overworld editing is not supported yet.
-Loading of some of the larger maps may take some time. On my intel i7 first generation processor, loading time was ~8 seconds for a 30x30 map.
-Backup your existing ROM in case something breaks.
-Feel free to report bugs to sleepy3d@gmail.com.
