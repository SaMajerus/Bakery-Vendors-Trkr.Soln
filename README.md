# "Pierre's Bakery"  (Console App)

#### By Sam Majerus

#### A Console application that allows the User to enter how many of each item they want at this hypothetical Bakery.  Based on their entry and the pre-defined pricing (the latter being shown in a Listing before the first text-prompt), they get a receipt printed out for them in return.  The receipt shows -- for each item -- the entered quantity, and the resultant USD price.   
(Disclaimer:  To the best of my knowledge, the Bakery name that Epicodus uses in this Independent Project's prompt is a hypothetical detail.  If there exists a bakery that is so-named, then I'm sure that the fact it's used in the prompt is purely coincidental.) 
<br>

## Technologies Used

* C# (C-sharp)
* .NET 5 
* Markdown
* Git Bash (Used in: Local Cmd-line Terminal, navigation of local directories)
* GitHub (Remote repositories)
* GitHub template repository (MSTest)
<br><br>


## Description

The program starts by printing out a greeting to the User in the Console.    Immediately following this is a Pricing section.  Note that the User can only choose between two different items to "buy":   Loaves of Bread  or  Pastries. 
The Baseline Prices -- the price for 1 item -- are printed first, followed by the 'Deals' section. Currently there's just a "Buy 2, Get 1 Free!" (B2G1) deal for each Item. 

If the User inputs a number for each item that is greater than 3 and -- when divided -- the whole-numbered quotient is 2 or more, then the B2G1 deal (for the Item type in question) gets applied once for each group of 3 items in that number. After that, the remaining items that are priced accordingly.  <br><br>
To help you -- the Reader -- understand a bit better, let me give an Example Case. <br> 
  Let's say a User wants to buy 8 Loaves of Bread and no Pastries.  (Now, I don't know Who would buy that many Loaves of Bread, nor Why, but I digress.)   The greatest number that is both less than 8  AND a Factor of 3  is '6'.   So, for that portion, the B2G1 deal gets applied (which amounts to $20 total for those six).   
  Now:  since the Baseline Price for  1 Loaf  is $5, and there are two remaining to be counted, the cost for them is $10.    
  Result:  the Total Price for 8 Loaves of Bread  =  $30.  And since no Pastries were bought, that is also the Grand Total. 
<br><br>

The if-else branching that conducts those calculations are laid out in the way described, by the way.  So, too, is the formatting of the User's outputted Receipt, which I've taken the liberty of describing below. <br> 

The Receipt's content is printed out in the following order: 
1)  For each item,  it prints  the Quantity entered by the user, followed by the resultant price in US Dollars (USD, $). 
2)  Next, the program sums the two price totals and prints that result for the User's 'Grand Total' price. 
<br><br>

The last piece of the program -- the farewell message -- is printed in the Console, with a couple lines of Whitespace to make the Receipt text easier to find. 
<br><br><br>


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
  
  * In your GIT BASH command line, enter this command:  'dotnet run' .   The files will be compiled and then the program will run. 
  Once the Welcome message and other text appears in your Console, the Program has started!  
  To run the program again after a given session ends, simply reenter   dotnet run   as before.
<br><br><br>
  
* If you get an error, here are Troubleshooting steps to try (In Order): 
  * 9 times out of 10, an error message will appear if you try to run the program whilst being in the wrong directory location.  
  To make sure you're in the right place, do the following. 
    * In your Git Bash command line, enter the command  'pwd'.  The Path leading to your current Folder (a.k.a. Directory) location will be printed out.   
    If the last 2 Directories in that Path DO NOT match the following snippet, then you're located in the wrong place. ('CONTAINER' represents your Containing Folder, which is what Contains the Program's Parent/Root folder):          .../CONTAINER/Bakery-csharp/Bakery 

  * If you're in the Right Place:  try entering the command  'dotnet restore'.  Once its process is completed, try entering  'dotnet run' again. 

  * Still not working?  Save a copy of this document, then move the Program's folder to the Recycle bin and Delete it. Then, try installing it from GitHub again using the above steps. 

  * If it STILL won't work:  Please don't hesitate to reach out via Email.  In addition to uncropped screenshots of the issue (send them as Attachments), please also include your Contact Info (along which method is best for contacting you).   This allows me to better assist you with Troubleshooting.  
<br><br><br>


## Known Bugs
* May not work properly if negative numbers, non-numbers (like Strings), etc. are input when prompted.  (No error checking implemented at the moment)
<br>


## License

Email me at ladolego@gmail.com for questions, ideas, concerns, or even any issues that you run into. You may also clone or Fork the content in this Repo to fiddle around with it, if you like.

Licensed through MIT. Copyright (c) 9/23/2022, Samuel Majerus.