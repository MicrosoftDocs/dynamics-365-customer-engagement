---
title: "Set up territories (Dynamics 365 for Field Service) | MicrosoftDocs"
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
ms.assetid: 5b22bdbc-4c52-4889-bf29-df0023d504f6
caps.latest.revision: 17
ms.author: "mkaur"
manager: "amyla"
---
# Set up territories to divide service areas (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Territories are used to divide large service areas. If a service territory is assigned to a service account record, and a work order is generated for that service account, then the work order will inherit the service territory from the service account. When you are scheduling a work order using the scheduling assistant, the suggested available resources can be filtered based on the resources that are assigned to the same territory as the work order. Using territories also helps dispatchers manage the schedules more efficiently when managing the schedule board.  
  
> [!NOTE]
>  To assign a territory to a resource, you will need to add the resource to a territory. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up bookable resources](../field-service/set-up-bookable-resources.md)  
  
<a name="BKMK_CreateATerritory"></a>   
## Create a territory  
  
1.  From the main menu, click **Field Services** > **Administration**, and then choose **Territories**.  
  
2.  On the **All Territories** screen, click **+New** in the upper left corner.  
  
3.  Fill in your information:  
  
    - **Name**: Enter the geographical name for the territory, such as the name of a city, country/region, or a state.  
  
    - **Manager**: Enter the name of the user who manages this territory. This person typically assigns leads to salespeople.  
  
    - **Important**: You can't allocate the same user to multiple territories. If you need to assign a user to a large area (more than one existing territory), create a new territory that includes the existing territories, and then assign the user to that new territory.  
  
    - **Description**: Enter any details that you'd like to include for this territory; for example, "Sales territory created for education and training".  
  
4.  When you're done, on the command bar, click **Save** or **Save & Close**.  
  
<a name="BKMK_AssignMemberstoTerritories"></a>   
## Assign members to territories  
  
1.  To assign members to a sales territory, open the territory and then, in the left pane, under **Common**, choose **Members**.  
  
2.  At the top of **Users**, click **Add Members**.  
  
3.  In the **Look Up Records** dialog box, select a user, and then click **Add**.  
  
### See also    
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Set up postal codes](../field-service/set-up-postal-codes.md)   
 [Set up booking rules](../field-service/set-up-booking-rules.md)   
 [Set up booking statuses](../field-service/set-up-booking-statuses.md)<br>
 [User's Guide](../field-service/user-guide.md)
