********************
Must read section!!!
********************

(1) You need the .NET framework 3.5 installed to run this program. It may or may not prompt you to install it. If not, download it from this link -- 

http://www.microsoft.com/downloads/details.aspx?familyid=ab99342f-5d1a-413d-8319-81da479ab0d7&displaylang=en


****
Tips
****

You have two options to search for YouTube videos using this program.

(1) You can use the "Built-in YouTube Search" search feature that is initially presented to you when the program first loads. In this instance, you simply search using the Search bar. When the results load, right click on the thumbnails of the video(s) that you wish to download/convert, and press "Add to Queue"

(2) You can search/browse the YouTube website itself by clicking on the "YouTube Website Search" tab on the right of the screen. When you get to the page of the video you wish to download, press the "Add to Queue" button.

By default, videos are temporarily stored in the same directory as the TubeQueue.exe executable, in a folder called "temp". "Processed" videos (those that have been converted, etc) are stored in the same directory, under a folder called "processed_videos". The locations of these folders can be changed in the settings.

For hands-on help, see the tutorial video.

******
Issues
******

(1) The ffmpeg dos window is not supressed and no progress bar is given to indicate it's status. Support for this will come in a future update.

(2) You must scroll in the preview window to see the entire YouTube video. This may or may not be fixable.

(3) The downloading progress indication box isn't scrollable as it constantly reverts to the top. This will be fixed in a future update.

(4) No feedback is returned from FFMPEG if it experiences an error (ffmpeg just closes). This will be fixed in a future update.


*****************************
Contact with Bug Reports, etc
*****************************

andrew1stein@gmail.com
http://www.andrewsteinhome.com
http://www.tubequeue.com

*****************************
Version History
*****************************

v1.57 (01/08/2010)
-----

* Batch YouTube search function skips over videos in search that are private / removed / etc (major bug fix).
* Batch YouTube search function allows you to search a user's subscriptions, playlists, and favorites. You can also find all videos uploaded by a particular user (major new feature, beta / experimental)
* Program compiled for 32-bit / x86 platform. Flash player in internal YouTube web browser should work fine now (major bug fix)
* Vevo videos still do not download, sorry!

v1.56
-----

* Updated to fix the changes in the way YouTube hides the video in the source code.
* "Vevo" videos do not download correctly, as they are encrypted. No workaround yet, hopefully version 1.57 wil fix this.



v1.55
-----

* This version add an experimental feature -- letting the user select any type of video or music file for conversion with ffmpeg (you are not limited to FLV files or YouTube links anymore). This essentially makes the program a simple frontend GUI for ffmpeg
* There are now minimize and maximize buttons for the Youtube browser and internal Youtube search areas, so you can comfortably select / view videos or the YouTube webpage in a larger viewing area (they are at the bottom of the search panes)
* Entire app has been slightly scaled down in dimensions to fit on more monitors
* There is now a "Update Now" button in the top menu to check for critical updates
* There is alternative / recent ffempg binary included in the installation (ffmpeg-alternative.exe) in case the current binary stops working or does not work in a particular conversion


v1.54
-----

* Fixed problem when adding video with quotes to video conversion queue
* Fixed exception when you deleted a video from video conversion queue and tried adding/deleting another video
* Fixed iPod 5G conversion issue

v1.53
-----

* Added "Please wait" dialogs for time intensive operations (give some indication that the program is alive)
* Change some labels to make things clearer/less ambigious 
* Added a "must read" document specifying things that must be done for correct program operation
* Updated list of "known" bugs
* Added "Rename/Delete" feature to "Video Collection Queue" list
* Made entire line be selected in in-line search
* Fixed tabbed preview window so the previewed view is entirely visible

v1.52
-----

* Packaged into an installer

v1.51
-----

* Various important bugfixes to the local FLV file conversion feature


v1.5
-----

* First "real" release to public.


v1.0
-----

* First incarnation of program. Many bugs, few features.