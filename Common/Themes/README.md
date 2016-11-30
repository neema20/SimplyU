#Themes

The following files and folders are for SimpliiU.
They contain audio and image files.

There is a .7z file containing all of the Themes. 

These files (audio) are from their original creators; I take no credit
whatsoever! 

They're as follows: 

* Ryuko Matoi Theme (Kill_la_Kill) 
* Satsuki Theme 
* Uzu Theme  - Not finsished 
* Aikuro Theme - Not finsished 
* Nonon Theme - Not finsished  
* Ragyo Theme - Not finsished 
* Sonic Theme - For testing 
* Material Brown Theme - For testing 
* Test theme - For testing 

**NOTE:** as of 0.8.0 Beta, the Theme parser is **NOT** finished! 
By at least 0.8.2 or 0.9.0, the theme parser will be completed; as well
as the Updater and RedNAND Setup.


##How to: 

You will need to create a folder, with two sub-folders; "audio" & "img." 
These folders will contain any and all resources. 
There should also be two .ini files; "color.ini" & "theme.ini," these files will contain
information about the theme.
There should be a color.ini on the root directory of the themes folder!  

###theme.ini: 

**[theme]

[info]
name=Your themes name

[icons]
icon=SimplyU_Full_Logo.png
splash=pnl_back.png

[audio]
background=audio_bck.mp3
task_completed=audio_complete.mp3
task_credits=

[author]
name=Your Username
author_notes=**

###color.ini: 

**Should only contain the color scheme. For example:** 

* Purple
* Pink
* Yellow
* Brown
* Blue 
* Red
* Grey 
* Green 
* Orange

IE(Without quotes): "blue"


Those are the colors that are available to you. But, you can modify the source-code
to add more colors.

The Theme-Compiler will handle all of this, but it is currently **not** finished, and is still
being worked on; sorry for any inconvienance.

If you haven't guessed, the theme manager finds themes based on the name you entered. For example: 
I enter "Test" in the Properties, and save; then it looks for the folder "Test" within "\\Common\\Themes."
If it finds it, It will then look for the sub-folders "img & audio." Once they're found, it'll then search
for the required resources, which are: "pnl_back.png, SimplyU_Full_Logo.png, audio_bck.mp3, audio_complete.mp3, and audio_credits.mp3."
The audio files are **NOT** required for the app to run, if they're **not** found, the app will ignore that they
don't exist within that folder.

If you have any concerns or questions, leave them on the GitHub repo; via "Issues."
Or contact me via GBATemp.net @Dr.Hacknik.  

##Credits:

* Studio Trigger: for their great work on Kill la Kill, thanks so much for a great Anime show.
If you haven't watched Kill la Kill, please do; It's such a great anime! 
* All my fellow Tempers: For supporting me this far, and with other projects! I'm so glad that 
people find my Projects so useful, and I hope to create other useful programs and homebrew in the future!
* Thanks to Nintendo: For creating the Wii U of course, and to all the hackers and homebrewers whom
make Wii U hacking possible!  

Developers (Are as follows): 

* Dr.Hacknik (All work) 

Note: Your name could be here, or below. 
Just ask me if you wish to help, in any way! 
I appreciate the extra hand. 

Artists/Image resources: 

* Me (Some art) 
* DeviantArt creators (Don't remember them x3) 
* And a few other resources via Google Images. 

