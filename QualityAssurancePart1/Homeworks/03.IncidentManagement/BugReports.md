Incident Management
===================

| Description         | When there’s a page break in the page and you try to set dashed border on the page, the bottom border line doesn’t show |
|---------------------|-------------------------------------------------------------------------------------------------------------------------|
| Steps to reproduce  | 1. Open the application                                                                                                 
                                                                                                                                                
                       2. Enter some text to fill the first page.                                                                               
                                                                                                                                                
                       3. Make sure that second page is automatically added and page break is inserted.                                         
                                                                                                                                                
                       4. Go to borders and shading.                                                                                            
                                                                                                                                                
                       5. Choose page border.                                                                                                   
                                                                                                                                                
                       6. Set dashed style.                                                                                                     
                                                                                                                                                
                       Actual result: Bottom border is missing.                                                                                 
                                                                                                                                                
                       Expected result: All borders of the page should be visible.                                                              |
| Acceptance criteria | All borders should be visible.                                                                                          |
| Priority            | Next Release                                                                                                            |
| Severity            | Medium                                                                                                                  |

Bottom border on page doesn’t show 
-----------------------------------

### Description

When there’s a page break in the page and you try to set dashed border on the page, the bottom border line doesn’t show

### Steps to reproduce

1.  Open the application

2.  Enter some text to fill the first page.

3.  Make sure that second page is automatically added and page break is inserted.

4.  Go to borders and shading.

5.  Choose page border.

6.  Set dashed style.

> Actual result: Bottom border is missing.
>
> Expected result: All borders of the page should be visible.

### Acceptance criteria 

All borders should be visible.

### Priority

Next Release

### Severity

Medium

Application crash while creating a new user
-------------------------------------------

### Description

Application crash on clicking the Save button while creating a new user, hence unable to create a new user in the application.

### Steps to reproduce

1.  Open the application.

2.  Click Create new user.

3.  Enter valid information.

4.  Click Save button.

> Actual result: Application crashes and the new user is not created.
>
> Expected result: New user is created and stored in application database.

### Acceptance criteria

The application is able to create new users.

### Priority

Immediate

### Severity

Blocking
