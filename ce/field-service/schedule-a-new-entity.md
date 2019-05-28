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


In this article we will show how to enable an entity for scheduling and utilize the entity on the schedule board. 

**Scenario:** A solar panel company must perform consultations over the phone and on site at their customers' homes before installing solar panels because details regarding the home's structure, location, and local laws need to be discussed as part of the qualification process before a solar panel installation can take place. The solar panel company would like to use the schedule board and other scheduling tools to assign leads to appropriate sales resources to perform the consultation and qualification process with potential customers. 

To configure this scenario, we will show how to enable the **Lead** entity for scheduling and add a new requirement view to the schedule board that specifically relates to Lead resource requirements. 

## Prerequisites
- Field Service v6.1+
- Logged in as a user with Field Service - Administrator or System Administrator security roles.

> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Enable an entity for scheduling 

## Add a requirement view to the schedule board

## Configuration considerations
- schedule onsite leads and custom entities 
- 
## Additional Notes
- If the entity that you want to enable for scheduling is not displayed, you have to check the Managed Properties settings for that entity. If by chance the "Can be customized" setting is set to False, then that's the reason why the entity is not being displayed. This is true even if the entity is in unmanaged state (development environment). Another strange issue I've faced (and thanks to MS support I'd been able to fix) is changing that flag to False. The steps to solve this issue is creating a solution patch (using Clone as patch feature) from the solution that contains the custom entity. Then add that entity to the patch, update the Can be customized flag to True and publish entity. Then you can delete the patch.


