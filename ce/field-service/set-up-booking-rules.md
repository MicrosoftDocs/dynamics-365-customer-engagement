---
title: "Set up booking rules (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/12/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: krbjoran
ms.assetid: 87e2cafc-ead7-43b2-b62a-db3a2fc05380
caps.latest.revision: 13
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---
# Set up booking rules (Field Service)

Booking rules in [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] allow a System Administrator to create warning or error messages that users see when creating or editing a resource booking record, based on custom conditions. For example, a booking rule could be created to warn a user when they attempt to book a work order to a resource on the schedule board that doesn't have the skills required for the job.  

Booking rules are custom JavaScript methods that will be executed prior to the Bookable Resource Booking record being created or edited.  The JavaScript method can accept a parameter that will contain information for the Bookable Resource Booking record being created and must return a JavaScript object with the required properties.
  
 Set up booking rules to validate a booking when it is created or modified.  

## Create a solution

The first step to setting up your booking rule is to create a custom Jscript web resource.  It is recommended that you create a solution in CRM to add your custom Jscript web resource or use an existing solution you may have for customizations.

Create CRM Solution

1.	From the Settings -> Solutions area create a new solution for your booking rule Jscript web resources.
The following screen shot shows a new solution that has been created.  It is recommended that your solution use a unique publisher rather than the default publisher.

scheduling-booking-rules-solution

2.	After creating the solution click on the Web Resources component and create a new Web Resource.
3.	On the new Web Resource form enter the following information
  a.	Name
  b.	Display Name.
  c.	Select “Script (Jscript)” as the Type.
4.	Click on the Text Editor button to enter your JavaScript code for the booking rule.
5.	Click the SAVE button to save your web resource.
6.	Click the PUBLISH button to ensure your booking rule web resource has been published.

scheduling-booking-rules-JS


## Set up a booking rule

1.  From the main menu, click **Field Service** > **Resources**, and then choose **Booking Rules** under **Booking Settings**.  

scheduling-booking-rules-navigation

2.	Click +NEW to create a new Booking Rule.
3.	From the Booking Rule form enter the following information
a.	Name
b.	Web Resource -> Select the web resource that you created above.
c.	Enter the Method Name that you defined in your JavaScript.
 
scheduling-booking-rules-new

4.	Save your booking rule.  Once you save the booking rule it will be used by the Schedule Board and Schedule Assistant.  You can deactivate your booking rule record to keep the Schedule Board and Schedule Assistant from executing the rule.



## Create a CRM action

The following is an example showing how you can use a custom CRM Action to perform the validation(s) as part of a booking rule.

When using a CRM Action for the booking rule validation you will still need to create a custom web resource as defined above.  The JavaScript that you will define in your custom web resource will call the custom CRM Action and evaluate the results from the custom CRM Action.  See Attachment A at the end of this document for sample code that you can use to call a custom CRM Action.

A custom CRM Action will need to be created in CRM.  It is recommended that you use the CRM Solution you have defined for your custom web resource to add your custom CRM Action.
The custom CRM Action should have the following input and output parameters.  You can add additional input and output parameters as your scenario requires.  You will need to ensure the JavaScript that you define to call your custom CRM Action is updated to support your additional input / output parameters.

Input Parameters:
•	originalScheduleStart – DateTime
•	originalScheduleEnd – DateTime
•	originalBookableResource – EntityReference
•	originalScheduleSource – Picklist
•	newScheduleStart – DateTime
•	newScheduleEnd – DateTime
•	isCreate – Boolean
•	isUpdate – Boolean
Output Parameters:
•	isError – Boolean
•	isWarning – Boolean
•	errorMessage – String
•	warningMessage - String
 
The screenshot below shows an example custom CRM Action.  This sample is checking if the newBookableResource matches the Preferred Resource on the work order and if the newScheduleStart is inside of the Time From Promised and Time To Promised.  It is assumed the dates of the promised window are for a single date. Example: Time From Promised: 01/01/2016 8:00AM / Time To Promised: 01/01/2016 12:00PM.

scheduling-booking-rules-worflow
## Sample code


1.  From the main menu, click **Field Service** > **Resources**, and then choose **Booking Rules** under **Booking Settings**.  
  
2.  On the **Active Booking Rules** screen, click **+New** in the upper left corner.  
  
3.  Type a **Name** for the new booking rule.  
  
4.  Select a **Web Resource** that has been previously created by the System Administrator to contain the validation logic and warning text.  
  
5.  Enter the **Method Name**.  
  
6.  Click **Save**.  
  
### See also    
 [Schedule within time constraints](../field-service/schedule-time-constraints.md)   
 [Set up booking statuses](../field-service/set-up-booking-statuses.md)   
 [Create and edit web resources](../customize/create-edit-web-resources.md)
