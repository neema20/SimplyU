#Themes

The following files and folders are for SimpliiU.
They contain audio and image files.

There is a .7z file containing all of the Themes. 

These files (audio/images) are from their original creators; I take no credit
whatsoever! 

They're as follows: 

* Ryuko Matoi Theme (Ryuko) - Finished
* Satsuki Theme (Satsuki) - Finished
* Uzu Theme  - Almost finished
* Aikuro Theme - Almost finished 
* Nonon Theme - Almost finished  
* Ragyo Theme - Almost finished
* Sonic Theme - Not finished
* RWBY Theme - Finished - Updated (12/10/16) w/New Bck Music & Images
* Rock Edition Theme - Finished
* Material Brown Theme - For testing 
* Test theme - For testing 

**NOTE:** as of 0.8.0 Beta, the Theme parser is **NOT** finished! 
By at least 0.8.2 or 0.9.0, the theme parser will be completed; as well
as the Updater and RedNAND Setup (Hopefully).

##Downloads: 

* ![Ryuko Matoi Theme - Ryuko](https://github.com/zoltx23/SimplyU/blob/master/Common/Themes/Packed/Ryuko.zip?raw=true) 
* ![Satsuki Theme - Satsuki](https://github.com/zoltx23/SimplyU/blob/master/Common/Themes/Packed/Satsuki.zip?raw=true)  
* ![Uzu Theme](https://github.com/zoltx23/SimplyU/blob/master/Common/Themes/Packed/Uzu.zip?raw=true)
* ![Aikuro Theme](https://github.com/zoltx23/SimplyU/blob/master/Common/Themes/Packed/Aikuro.zip?raw=true) 
* ![Nonon Theme](https://github.com/zoltx23/SimplyU/blob/master/Common/Themes/Packed/Nonon.zip?raw=true) 
* ![Ragyo Theme](https://github.com/zoltx23/SimplyU/blob/master/Common/Themes/Packed/Ragyo.zip?raw=true) 
* ![Sonic Theme](https://github.com/zoltx23/SimplyU/blob/master/Common/Themes/Packed/Sonic.zip?raw=true)
* ![RWBY Theme](https://github.com/zoltx23/SimplyU/blob/master/Common/Themes/Packed/RWBY.zip?raw=true) 
* ![Rock Edition Theme](https://github.com/zoltx23/SimplyU/blob/master/Common/Themes/Packed/Rock Edition.zip?raw=true)
* ![Material Brown Theme](https://github.com/zoltx23/SimplyU/blob/master/Common/Themes/Packed/Material Brown.zip?raw=true) 

##How to: 

You will need to create a folder, with two sub-folders: "audio" & "img." 
These folders will contain any and all resources. 
There should also be two .ini files; "color.ini" & "theme.ini," these files will contain
information about the theme.
There should be a color.ini on the root directory of the themes folder!  

###theme.ini: 

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
author_notes=


###color.ini: 

**Should only contain the color scheme; and are as follows:**

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
to add more colors. The color management can be found in "program.cs." 

The Theme-Compiler will handle all of this, but it is currently **not** finished, and is still
being worked on; sorry for any inconvienance.

If you haven't guessed, the theme manager finds themes based on the name you entered. For example: 
I enter "Test" in the Properties, and save; then it looks for the folder "Test" within "\\Common\\Themes." Do note
that the application is **not** case sensitive with theme names; meaning I could enter "test" and the folder could be "Test."
If it finds it, It will then look for the sub-folders "img & audio." Once they're found, it'll then search
for the required resources, which are: "pnl_back.png, SimplyU_Full_Logo.png, audio_bck.mp3, audio_complete.mp3, and audio_credits.mp3."
The audio files are **NOT** required for the app to run, if they're **not** found, the app will ignore that they
don't exist within that folder.

There are also .xcf files; you can edit these files, making it easier to create your own images. 
Do keep in Mind you will need Gimp 2.7 or higher. They also need to be the proper resolution; or they'll not appear properly.  

If you have any concerns or questions, leave them on the GitHub repo; via "Issues."
Or contact me via GBATemp.net @Dr.Hacknik.  

##Preview: 

![Themes Preview](https://github.com/zoltx23/SimplyU/blob/master/Common/Resources/Images/themes.png?raw=true) 


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

