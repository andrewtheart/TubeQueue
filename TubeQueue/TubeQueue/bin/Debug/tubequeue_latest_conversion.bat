@echo off
C:
CD "C:\Users\Andrew\Documents\GitHub\TubeQueue\TubeQueue\TubeQueue\bin\Debug"
START ffmpeg.exe -i "C:\Users\Andrew\Desktop\Slavonic Dances 7 Op 46 B.mp3" -vcodec msmpeg4 -vtag MP43 "C:\Users\Andrew\Documents\GitHub\TubeQueue\TubeQueue\TubeQueue\bin\Debug\processed_videos\\Slavonic Dances 7 Op 46 B".avi
