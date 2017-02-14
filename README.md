# A repro project for a VS update issue
The .vs folder is here because it's one of the things related to the issue

It's a VS2015 .vs folder that when the project is updated by VS2017 in some way is corresponsable of VS2017 UI freezing.
Deleting it and reopening the (now converted) project with VS2017 solve the issue.

In the same way, if the .vs folder is deleted prior to open the project with VS2017, the conversion completes without any issue.
