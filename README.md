#Simple CyberCafe Server

Simple CyberCafe Server is an open source application for managing cyber cafe clients, written in VB.net. 

###Latest Update:
- 15-Apr-14 - The database file is included, named server.mdb. The database is using Jet 4.0 OLE DB and compatible with Open Office Base. https://wiki.openoffice.org/wiki/Connecting_to_Microsoft_Access

###Currently working:

- GUI - the graphical user interface (30%)
- Timekeeper module - to handle the open and prepaid session charges, calculate time left, time in, time out (90%)
- Services - Manage services like printing, foods, drinks etc (0%)
- Settings - Configure the settings from the GUI (eg adding, removing or editing clients) (Please review My.Settings. (10%)
- Members - Manage memberships (for discounts, special rates etc) (0%)
- Sales - Generate reports, save or print (0%)
- Logging - log errors and other events for troubleshooting (0%)
- Printing - Printing receipts, reports, POS functions (0%)
- Network - control the clients remotely. (0%)
- Database - the database contains username and password. also contains configurations, reports, members (15%)

###Modules in the project:

Modules used in the project. 

- module-authentication - this module provide functions like login, and password hashing
- module-charges - contain functions like calculating prepaid and open session charges. 
- module-msgbox - contains function to show message boxes, contains logging function (currently working)
- module-readsettings - Read settings (.cfg) files. Responsible to get all list of clients, reading .cfg files and getting the authentication settings (currently working)
- module-savesettings - Save settings
- module-timekeeper - contain functions to get timein, timeout, timeleft, adding time, login and logout features
- module-network - handles all functions like sending login, logout, reboot etc to the clients across the network. (currently working)
- module-database - contains functions for connecting to database, adding, deleting or modifying the database
