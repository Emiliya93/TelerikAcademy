# Homework
## Incident Management

1.We have a painting program like Paint.NET and we have the following bugs
*	Set Priority and Severity

| Severity types			| Priority types	|
| ------------------------- | -----------:|
|1 – Blocking				|1 – Immediate|
|2 – Critical				|2 – Next Release|
|3 – High					|3 – On Occasion|
|4 – Medium					|4 – Open (not planned for now)|
|5 – Low||

| Bug description        | Severity           | Priority  |
| ------------- |:-------------:| -----:|
|Tool for selection doesn’t select exactly the same that it’s marking (crops 10 pixels to the left)      |  *Critical*| *Immediate* |
| When selecting a color with the color picker it replaces the first color from the palette, not the chosen one     |*High*   |*Next Release*  |
| Shortcut for “Create New Image” (Ctrl+N) doesn’t work |*Low*   |  *Next Release* |
| Spelling mistake in menu Select “Transperent selection” instead of “Transparent selection”|   *Low*|   *Immediate*|
| While holding Ctrl+Z and drawing with the pencil the second color is used instead of the first one, and that’s not a feature|  *Critical* | *Open*  |
| When using “Magic Wand” tool the tolerance value is changing on every mouse click|   *Low*| *Immediate*  |
| While clicking “Rotate 90 Clockwise” the image is rotating in counterclockwise direction|  *Critical* | *Open*  |
| The button for increasing the Brush size doesn’t work. It can be increased only from the drop down |  *High* | *Immediate*  |
| Program crash on clicking the OK button while resizing an image.| *Blocking*  | *Immediate* |

2.Imagine you have the following bug, mentioned by a customer and you have to describe it and log it in the bug tracking tool you use
*	Report the following bugs

|BUG REPORT |   #1   |
|------------- |:---------------|
|Description  |When there’s a page break in the page and you try to set dashed border on the page, the bottom border line doesn’t show|
|Steps to reproduce  |<ol><li>Open the application</li><li>Enter some text to fill the first page.</li><li>Make sure that second page is automatically added and page break is inserted.</li><li>Go to borders and shading.</li><li>Choose page border.</li><li>Set dashed style.</li></ol>Actual result: Bottom border is missing.<br/>Expected result: All borders of the page should be visible.|
|Acceptance criteria  |All borders should be visible|
|Priority |Next Release|
|Severity  |Medium|

|BUG REPORT |   #2   |
| ------------- |:--------------|
|Description  |Application crash on clicking the Save button while creating a new user, hence unable to create a new user in the application.|
|Steps to reproduce  |<ol><li>Open the application.</li><li>Click Create new user.</li><li>Enter valid information.</li><li>Click Save button.</li></ol>Actual result: Application crashes and the new user is not created.<br/>Expected result: New user is created and stored in application database.|
|Acceptance criteria  |The application is able to create new users.|
|Priority |Immediate|
|Severity  |Blocking|

* Prepare another bug report
	* for the bug shown in this [video] (http://www.youtube.com/watch?v=xJg7k8QOGtM&feature=related)

|BUG REPORT |   #3   |
| ------------- |:--------------|
|Description  |When pasting bulleted list in excel and removing bullets with find and replace, the letters change to Greek symbols.|
|Steps to reproduce  |<ol><li>Open word or another text editor allowing creating of bullet lists.</li><li>Create a bullet list with few rows random text.</li><li>Mark all text and copy it.</li><li>Open Excel 2010 and paste the text there.</li><li>Verify that the bullets are pasted.</li><li>Copy the symbol for bullet list.</li><li>Open Find and Replace.</li><li>Paste the symbol for the bullet list and leave empty for the replace symbol.</li><li>Click Replace All.</li></ol>Actual result: The bullets are deleted, but the letters in the text are no longer in English, they are replaced with Greek letters. <br/>Expected result: The bullets are deleted and the letters remain unchanged in English.|
|Acceptance criteria  |The bullet list symbols can be deleted and the text is unchanged.|
|Priority |Immediate|
|Severity  |Critical|

* Prepare another bug report
	* for this sample defect: After logging into Gmail, it navigates to Google.com

|BUG REPORT |   #4   |
| ------------- |:--------------|
|Description  |After logging into Gmail, it navigates to Google.com|
|Steps to reproduce  |<ol><li>Open any browser.</li><li>Go to gmail.com</li><li>Click log in.</li><li>Enter valid email and password.</li>
</ol>Actual result: Google.com has opened for you.<br/>Expected result: Gmail has opened for you.|
|Acceptance criteria  |Logging in Gmail navigates to Gmail home page.|
|Priority |Next Release|
|Severity  |Critical|