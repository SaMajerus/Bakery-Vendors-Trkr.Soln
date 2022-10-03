# Pierre's Vendor Tracker

#### By Sam Majerus

#### A web application that Pierre can use to track what orders he has, and for/from which Vendor(s).  (Features that allow for other uses -- i.e. basic financial tracking for an order -- are possible to implement, but aren't included with this bare-bones MVP iteration.)  
<br>

## Technologies Used

* C# (C-sharp)
* .NET 5 
* Markdown
* ASP.NET Core
* ASP.NET Core - MVC 
* Razor
* RESTful Routing coventions
* Layout files 
* HTML 5(?); CSHTML 
* Git Bash (Used in: Local Cmd-line Terminal, navigation of local directories)
* GitHub (Remote repositories)
* GitHub template repository (MSTest)
<br><br>


## Description

The program starts by printing out a greeting to the User on the Splash page. Then the user can navigate to the page where the Vendors are listed. The blue text strings are indeed hyperlinks, but they function more like buttons in this context. Thus, the user clicks on those to navigate to the desired pages. 
The Vendors list will start off blank, so the user has to create a new vendor before they can proceed further. Once that is done, they can add a New Order for that Vendor.   (Please note that order information is only accessible via the given Vendor's page, on which their List of Orders is displayed. The user can navigate back there from the page that comes up after adding the Order as follows: First, click the button to go back to the List of Vendors. Then, click the Vendor that the Order was added for. Lastly, click on the desired Order from those Listed.) 

Note that this application is the Minimum-Viable-Product iteration, and so features are minimal. 



## Setup/Installation Requirements

* All that's required to run this application -- at minimum -- is: a decently-performing laptop, and a reliable Internet connection. (The latter is really only required for 'Cloning from GitHub' this time around, however.) 

* To Clone the program from the GitHub repo to your local machine:

  * 1.) Click the green button labelled 'Code'. Under the 'HTTPS' tab, there are 3 Options. This program will only work at the moment if you choose Option 1, so move on to Step 2.<br>

  * 2.) Copy the link. Then, in Git BASH, navigate to the folder you want to put the files in. This can be your Desktop directory, or a different subfolder, whatever you prefer. Next, still in the Git BASH console, type the following (with the copied-link in place of 'HTTPS') and hit ENTER: 'git clone HTTPS' Several lines of text will come up in the console -- that's the files being copied into whichever directory/folder you're in currently. Then, do the following once your prompt line reappears: While still in the console window, type 'pwd' and press ENTER. This will display your current file path. Copy that by highlighting it and pressing 'Ctrl-C', and then pasting it in an easily-accessible word processor like Notepad for reference. Next, open File Explorer, and navigate to through your files according to that File Path you just copy-pasted for reference. Once you've done this, move on to Step 3.<br>

  * 3.) Before opening the HTML file, do the following: right-click the containing folder (in which the newly-copied files are stored) and select the option that says 'Pin to Quick Access'. This is to ensure that you can find this folder again in the steps that follow. Move on to Step 4.<br>

  * 4.) Open VS Code. Then, click on the page icon at the top of the left-hand toolbar. Then click 'Open Folder'. When the Windows File Explorer window appears, navigate to and select the containing folder you pinned in the previous step. Once you've selected the folder and clicked the button to open the folder in VS Code, move on to Step 5.<br>

  * 5.) Open a New Terminal (shortcut is Ctrl+Shift+`). Then, in the command line, navigate to the "Bakery" subdirectory by typing  'cd Bakery'  then pressing ENTER.   
  Next, type  'dotnet restore'  and press ENTER. This ensures that everything required to run the program is updated and ready to go.   (Your command prompt will show up again once the operation is complete; DO NOT kill the terminal or close VS Code.) <br>
  Once that's done, move on to the next Section.     (DO NOT Navigate to any other directories between now and then!!  Otherwise, the Program will not run.) <br>


* Running the Program <br>
  <!-- IMPORTANT: If your current directory location is not the same as it was for the most recent Step, the instructions that follow WILL NOT WORK.  -->
  
  * In your GIT BASH command line, enter this command:  'dotnet run' .   The files will be compiled and then the application will be started. 
  In the terminal, once the last line of prompts says something like    ''Ctrl-C to end the Application'',  'Ctrl + Left-click' the 'localhost:5000' link. A new tab will open in your browser -- and the rest should be self-explanitory. 

  To run the program again after a given session ends, simply reenter   dotnet run   as before.
<br><br><br>


* If you get an error, here are Troubleshooting steps to try (In Order): 
  * 9 times out of 10, an error message will appear if you try to run the program whilst being in the wrong directory location.  
  To make sure you're in the right place, do the following. 
    * In your Git Bash command line, enter the command  'pwd'.  The Path leading to your current Folder (a.k.a. Directory) location will be printed out.   
    If the last 2 Directories in that Path DO NOT match the following snippet, then you're located in the wrong place. ('CONTAINER' represents your Containing Folder, which is what Contains the Program's Parent/Root folder):          .../CONTAINER/BkyVendors/Bakery 

  * If you're in the Right Place:  try entering the command  'dotnet restore'.  Once its process is completed, try entering  'dotnet run' again. 

  * Still not working?  Save a copy of this document, then move the Program's folder to the Recycle bin and Delete it. Then, try installing it from GitHub again using the above steps. 

  * If it STILL won't work:  Please don't hesitate to reach out via Email.  In addition to uncropped screenshots of the issue (send them as Attachments), please also include your Contact Info (along which method is best for contacting you).   This allows me to better assist you with Troubleshooting.  
<br><br><br>


## Known Bugs
* May throw an error under certain conditions if the user hits the back arrow after resubmitting a form (i.e. on the 'New Order' page). 
<br>


## License

Email me at ladolego@gmail.com for questions, ideas, concerns, or even any issues that you run into. You may also clone or Fork the content in this Repo to fiddle around with it, if you like.

Licensed through MIT. Copyright (c) 10/03/2022, Samuel Majerus.