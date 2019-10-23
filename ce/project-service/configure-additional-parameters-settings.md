---
title: Configure additional parameter settings
description: How to configure additional parameter settings in Project Service
author: JohnPBurrows
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 8/03/2018
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: jburrows
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Configure additional parameter settings (Project Service)

[!INCLUDE[cc-applies-to-psa-app-1x-2x](../includes/cc-applies-to-psa-app-1x-2x.md)]

Once you’ve configured the items in previous topics, you need to set additional project parameters to use for your projects. When you first installed [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)], you created a parameters setting to first create all the records required for [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] to work. Now it’s time to go back and configure additional fields for these settings.  
  
 You’ll need to have configured the following settings:  
  
-   Organizational unit  
  
-   Invoice frequency  
  
-   Work hours template  
  
-   Price list  
 
In this step, you’ll also indicate what type of resource allocation you want:  
  
- **Central**. Only resource managers can allocate resources to projects.  
  
- **Hybrid**. Resource managers, project managers, and account managers can allocate resources to projects.  
  
 
To set project parameters:  
  
1. Go to **Project Service > Parameters**.  
  
2. Click the parameters setting you want to configure (the one you created when you first installed [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)]), or click **New** to create a new one.  
  
3. In the **General** area, set all the options for your project parameters.  
  
4. In the **Price List** area, click **+** to add a price list, select a price list in the **Project Parameter Price List** drop-down list, and then click **Save**.  
  
5. Click the **Save** button in the bottom right corner of the screen.  

> [!NOTE]
> The project parameter record must be maintained for Project Service to function correcly. This record should not be deleted.

### See Also  
 [Set up resources](../project-service/set-up-resources.md)
