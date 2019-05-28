---
title: "Enable an entity for scheduling | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave 
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: Holly.Chamberlain
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Enable an entity for scheduling

Universal Resource Scheduling can be used to schedule any entity.

In this article we will show how to enable an entity for scheduling and utilize the entity on the schedule board. 

**Scenario:** A solar panel company must perform consultations over the phone and on site at their customers' homes before installing solar panels because details regarding the home's structure, location, and local laws need to be discussed as part of the qualification process before a solar panel installation can take place. The solar panel company would like to use the schedule board and other scheduling tools to assign leads to appropriate sales resources to perform the consultation and qualification process with potential customers. 

To configure this scenario, we will show how to enable the **Lead** entity for scheduling and add a new requirement view to the schedule board that specifically relates to Lead resource requirements. 

## Prerequisites
- Field Service v6.1+
- Logged in as a user with Field Service - Administrator or System Administrator security roles.

> [!Note]
>


## Enable an entity for scheduling 

To enable an entity to be scheduled, navigate to the Administration section of Universal Resource Scheduling: Enable Resource Scheduling for Entities.
Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/enablescheduling.png)
 
 
When choosing to add a new Entity, pick the Entity with the Add Entity drop down.  Choose Create New Relationship for both Booking and Requirement Relationship.  This will create the necessary relationships to the Bookable Resource Booking entity and the Resource Requirement entity.  

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/enableleads.png)
 
Once selected, click Publish Customizations.  
 
To make changes to the settings for booking this entity, double-click on the Entity in the Enabled Entities section.  Defaults and scheduling options for the entity can be manipulated to assist with creating Resource Requirements.  

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/leadsetup.png)
  

Before scheduling a record, a Resource Requirement must be created.  These can be created manually or created by a custom workflow.  To create a Resource Requirement, navigate to the Related tab on the Entity and choose Resource Requirements.

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/leadscheduling.png)
 

Click the New button to create the new Resource Requirement.  

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/addresourcereq.png)
 
Populate the information that will provide details on what requirements are needed for a recourse to be scheduled including dates, duration, priority and territory. 

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/newreq.png)


Once you have the Requirement created, bookings can be created directly from the record or by using the Schedule Board.  To book using the Scheduling Assistant directly from the record, use the Book button.  If Quick Scheduling is enabled for the entity, the Quick Scheduler will be initiated, otherwise the Scheduling Assistant will be used.

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/bookfromrecord.png)
 
Quick Scheduler View

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quick.png)

If using Quick Scheduling, the Schedule Assistant can also be viewed by clicking on Open Schedule Assistant.  

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assistant.png)


Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedulingassistant.png)
 
Once the record is booked, a new record is created on the Booking Resource Bookings tab on the entity.  
Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/booked.png)
  

## Add a requirement view to the schedule board

To view the new entity on the Schedule board, new views will need to be created.  All views on the schedule board use the Resource Requirement Entity.  Navigate to Customizations, Entities and Resource Requirement Entity.  

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customizations.png)

Create a New View 

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/createview.png)
 
Add fields to the view that will provide details to what you are scheduling. Use the drop down to capture fields from the Entity (in this case Lead) 

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/addleadentity.png)
 
Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/createview.png)
 
Edit the Filter Criteria to display the appropriate records.  To ensure only the Lead Resource Requirements will be displayed, select the Lead entity and filter the records appropriately.  

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/editfiltercriteria.png)
 
Save and Close & Publish.  

 
The final step to view this on the Schedule Board, is to edit the Schedule Board that you will be using to Schedule the Entity.  In this case, start by creating a new tab.  

Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/newtab.png)


In the Requirement Panels section, add a Title and select the new View. Click + to add the view.  
Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/addviewtoboard.png)
 
Choose “Hide default requirement panels” if you don’t want to display the other tabs.  
 
NOTE: There will be no data until the Resource Requirements are created.  These will need to be manually created or setup a workflow to auto create upon creation of a Lead.  
Screenshot of
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


## Configuration considerations
- schedule onsite leads and custom entities 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduleboard.png)


## Additional Notes
- If the entity that you want to enable for scheduling is not displayed, you have to check the Managed Properties settings for that entity. If by chance the "Can be customized" setting is set to False, then that's the reason why the entity is not being displayed. This is true even if the entity is in unmanaged state (development environment). Another strange issue I've faced (and thanks to MS support I'd been able to fix) is changing that flag to False. The steps to solve this issue is creating a solution patch (using Clone as patch feature) from the solution that contains the custom entity. Then add that entity to the patch, update the Can be customized flag to True and publish entity. Then you can delete the patch.


