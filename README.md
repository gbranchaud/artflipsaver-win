# artflipsaver-win [![Build status](https://ci.appveyor.com/api/projects/status/uxxv0xdud2juspgx?svg=true)](https://ci.appveyor.com/project/gbranchaud/artflipsaver-win)
It's like the iTunes album art screensaver, but for Rdio.

## What?
This is a Windows screensaver that displays your top Rdio albums.

## Thanks
* This project is a wrapper around endenizen/artflip#head . Thanks to his hard work.
* A few refs that proved very useful:
  * [Creating a Screen Saver with C#](http://www.harding.edu/fmccown/screensaver/screensaver.html)
  * [Web Browser Control – Specifying the IE Version](http://weblog.west-wind.com/posts/2011/May/21/Web-Browser-Control-Specifying-the-IE-Version)

## TODO
* [x] show the web page in a form
* [ ] render the web page using IE11 engine (both when debugging in VS & standalone)
* [ ] show config dialog (with rdio username only?)
* [ ] save the config to the registry (or appdata?)
* [ ] support multi-monitor setup (no blank screens)
* [ ] write required + build instructions in readme.md (C#, min Win ver., one-command build process, etc.)
* [ ] add screenshot of working screensaver in readme.md
* [ ] figure out distribution (where is the .scr file hosted? appveyor?)
* [ ] produce installation .gif (i.e. shows a drag&drop of the .scr in the /windows folder)
