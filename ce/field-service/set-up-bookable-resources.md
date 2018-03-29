---
title: "Set up bookable resources (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "mduelae"
ms.assetid: 7ed1712e-acd6-433b-bb78-22f8d58c5c61
caps.latest.revision: 14
ms.author: "mkaur"
manager: "amyla"
---
# Set up bookable resources (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

A resource in Dynamics 365 for Field Service is anything that needs to be scheduled. This can be users, crews, service centers, company assets (equipment), accounts, or contacts.  
  
<a name="BKMK_CreateBookableResource"></a>   
## Create a bookable resource  
  
1.  From the main menu, click **Field Service** > **Administration**, and then choose **Bookable Resources**.  
  
2.  On the **Active Bookable Resources** screen, click **New**.  
  
3.  Choose a **Resource Type**:  
  
    - **Account** or **Contact**: Resources that aren't directly a part of your organization, but that you subcontract to.  
  
    - **User**: The resource is a member of your organization.  
  
    - **Company Asset**: Equipment.  
  
    - **Service Center**: Where shop repairs are made.  
  
    - **Crew**: Any collection of resources, for example, two or more workers, or a group.  
  
4.  Choose a **Time Zone**.  
  
5.  Type an **Hour Rate**.  This is the hourly pay that the resource should be paid by the company.  
  
6.  Choose the **Start Location** and the **End Location** to specify which location the resource will be at when starting and ending work.  
  
7.  Choose if the resource should be displayed on the schedule board and schedule assistant.  
  
8.  Set **Enable Drip Scheduling** to **Yes** or **No**.  This controls how many schedules will appear on the mobile app. If drip scheduling is disabled, all schedules will appear, based on your mobile settings.  
  
9. Choose if time off needs to be approved or not.  
  
10. Click **Save**.  
  
11. In the **Characteristics** section, click **+Add Bookable Resource Characteristics record** to add characteristics. More information: [Set up characteristics](../field-service/set-up-characteristics.md)  
  
<a name="BKMK_AddWorkHours"></a>   
## Add work hours  
  
1.  Once the resource has been created, at the top, click the arrow next to the resource name, and then click **Work Hours**.  
  
2.  Click the **Set-Up** drop-down list and choose one of the following:  
  
    - **New Weekly Schedule**: Set an ongoing weekly schedule for the resource.  
  
    - **Work Schedule for One Day**: Set the hours the resource can be scheduled for on a particular day.  
  
    - **Time Off**: Set the dates and times the resources can't work.  
  
<a name="BKMK_AddCharacteristics"></a>   
## Add characteristics  
  
1.  From the resource name submenu,  click **Bookable Resource Characteristics**.  
  
2.  Click **Add New Bookable Resource Characteristics**.  
  
3.  Use the tooltips to help fill in information, and then click **Save**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up characteristics](../field-service/set-up-characteristics.md)  
  
<a name="BKMK_AddResourceTerritories"></a>   
## Add resource territories  
  
1.  From the resource name submenu, click **Resource Territories**.  
  
2.  Click **Add New Resource Territory**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up territories](../field-service/set-up-territories.md)  
  
3.  Use the tooltips to help fill in your information, and then click **Save & Close**.  
  
### See also   
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Set up bookable resource categories](../field-service/set-up-bookable-resource-categories.md)   
 [Set up characteristics](../field-service/set-up-characteristics.md)   
 [Set up resource pay types](../field-service/set-up-resource-pay-types.md)<br>
 [User's Guide](../field-service/user-guide.md) 
