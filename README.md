# MEDsys
Coding Challenge to create a small web application for appointments

Requirements:
Write a small web application that solves the following business needs:

-	Allows you to add an appointment to a data store of some kind.

  o	You do not need to include the creation of a database (unless you want to). It could be a simple in memory list/container.

-	An appointment has a client, a staff, and one or more service lines.

  o	A client has a first name, last name, and a birth date.
  
  o	A staff has a first name, last name, and a specialty value.
  
  o	A service line has a start time, end time, and a service (a simple string is fine, again it's about organization).

The following business rule/validations should exist:

-	If a service line crosses midnight, it should be broken into 2 separate service lines from the start time to midnight, and one from the midnight to the end time.

-	If a client is older than 70, then the staff must have a specialty of "Geriatrics".  Otherwise the schedule should not be created.
