cd /d "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin"
msbuild -t:Restore "%~dp0\JMs_Pomodoro.sln"
msbuild "%~dp0\JMs_Pomodoro.sln"
pause