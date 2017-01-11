@echo off
setlocal 
set PATH=C:\Windows\Microsoft.NET\Framework64\v4.0.30319;%PATH%
msbuild NET_FWK_MovilizerWindowsService.csproj /t:Build /p:Configuration="Release 4.5"
msbuild NET_FWK_MovilizerWindowsService.csproj /t:Build;Package /p:Configuration="Release" 
endlocal
