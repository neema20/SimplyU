echo off

:top
cls
mode con cols=85 lines=54
color 1f
title SimpliiU: Server Script 
echo ==========================
echo Script by Dr.Hacknik (C) 2016
echo --------------------------
echo Script Version: 0.4b 
echo ==========================
echo This Script was made for SimpliiU;
echo SimpliiU and/or its Components are Licensed
echo under the Open GPL GNU Open-Source License. 
echo You may Modify this or the Software, as long
echo as you include a copy of the License, and give 
echo credit to the Original Creator (Me).
echo ==========================
echo NOTE: The console color is by default, blue. When the server starts 
echo successfully, it will turn green. If it fails, it will turn red. 
echo ===========================
pause
goto :agreement 

:start_server
cls
color 1e
echo If you're running Skype or any other Program running on Port 80; please close it now!
pause 
ipconfig
color 2f
echo Your IP Address is above. 
echo ======================================================
cd Common\hosting\
Java -jar HaxServer.jar 
IF ERRORLEVEL 1 (goto :error) 

:error
cls
color 4f
echo There has been an error! 
echo ===========================
echo It seems that we couldn't start the server properly.
echo Please make sure that all the server's files are within the folder \Common\hosting.
pause
goto :top 

:agreement 

cls
::SET FILENAME=%~nx0 //this returns the name of the batch file running (doesn't work when packaged in an exe)
::SET PATHNAME=%0 //this returns the filename but also with absolute path

set warning=
echo                                     SimpliiU Script
echo                                      by Dr.Hacknik
echo.
echo.
echo.
echo			            THIS SOFTWARE IS NOT FOR SALE.
echo.
echo          IF YOU PAID FOR THIS SOFTWARE OR RECEIVED IT AS PART OF A "BUNDLE"
echo       YOU HAVE BEEN SCAMMED AND YOU SHOULD DEMAND YOUR MONEY BACK IMMEDIATELY
echo.
echo.
echo                              USE THIS AT YOUR OWN RISK!
echo.
echo       THIS PACKAGE COMES WITH ABSOLUTELY NO WARRANTY, NEITHER STATED NOR IMPLIED.
echo       NO ONE BUT YOURSELF IS TO BE HELD RESPONSIBLE FOR ANY DAMAGE THIS MAY CAUSE
echo                             TO YOUR NINTENDO WII U CONSOLE!
echo.

echo.

echo.
echo                 Please type the word "I" followed by the word "Agree"
echo                      with a space between those two words and
echo                           then press "Enter" to continue.
echo.

echo                     If you can't follow those instructions,
echo                    then you have no business modding anything.
echo.	              This includes performing Hacks, such as: 
echo.		        Haxchi, ColdBootHax, Mocha, etc. 
echo.
echo.
echo.
echo.
echo.

set /p warning=     Enter Selection Here: 

if /i "%warning%" EQU "I Agree" goto:skip
echo.
echo                                Exiting the Script...
Exit
:skip

::Save version agreed to
if exist Common\hosting\settings.bat support\sfk filter -quiet Common\hosting\settings.bat -ls!"set AGREEDVERSION=" -write -yes
echo set AGREEDVERSION=%currentversion%>> Support\settings.bat
goto :start_server
