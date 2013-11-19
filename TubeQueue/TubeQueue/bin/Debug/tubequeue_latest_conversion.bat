@echo off
C:
CD "C:\Users\as1348\Dropbox\0DOC\Misc. Programming Projects\WindowsFormsApplication9\WindowsFormsApplication9\bin\Debug"
START ffmpeg.exe -i "C:\Users\as1348\Dropbox\0DOC\Misc. Programming Projects\WindowsFormsApplication9\WindowsFormsApplication9\bin\Debug\temp\\Jack Taylor Scores 109 Points.flv" -vcodec msmpeg4 -vtag MP43 "C:\Users\as1348\Dropbox\0DOC\Misc. Programming Projects\WindowsFormsApplication9\WindowsFormsApplication9\bin\Debug\processed_videos\\Jack Taylor Scores 109 Points".avi
