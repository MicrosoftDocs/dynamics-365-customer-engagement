---
title: "Distribute a managed app with Dynamics 365 Customer Engagement (on-premises)"
description: "Learn how to package one or more apps in a solution and import them into other environments. You can also delete a managed app that you no longer need."
ms.custom: 
ms.date: 04/01/2022
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: e82e7f64-37ad-41e5-acd7-16309881c6a2
caps.latest.revision: 9
ms.author: matp
search.audienceType: 
  - customizer
---
# Distribute a managed app

An app can be distributed to other Dynamics 365 Customer Engagement organizations. To do this, you create a solution and then add one or more apps and components to the solution. Then, export the solution as managed. This creates a .zip package file that can be imported into other Dynamics 365 Customer Engagement organizations.  
  
## Add an app to a solution

Before you can import an app to another organization, you must first add it to a solution. To do this, create a solution and add the app you want. When you are adding the app to the solution, select the **Yes, include required components** option in the **Missing Required Components** dialog box. More information: [Create a solution](create-solution.md)

Once you have the app and all components in the solution, export it as a managed solution.
  
> [!NOTE]
>  When you export an app using a solution, the app URL is not exported.
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a managed solution](../developer/create-install-update-managed-solution.md#create-a-managed-solution), [Create an unmanaged solution](../developer/create-export-import-unmanaged-solution.md#create-an-unmanaged-solution) 
  
## Import the solution

In the organization where you need the app, import the solution that contains the app.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Install a managed solution](../developer/create-install-update-managed-solution.md#install-a-managed-solution)
  
## App access

 System administrators and customizers have access to these apps by default, and can grant app access to specific security roles. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage access to apps with security roles](../customize/manage-access-apps-security-roles.md)  
  
## Delete (uninstall) a managed app  

To delete a managed app, you must delete the managed solution that contains the app.

1. Go to **Settings** > **Solutions**.  
  
   > [!IMPORTANT]
   > - Deleting a solution deletes all data that is associated with the components in the solution, such as entities and all entity records.
   > - Deleting a solution might impact Dynamics 365 Customer Engagement apps performance. We recommend that you perform this task during hours when there's less user activity.

1. Select the managed solution that contains the app you want to delete, and then, on the command bar, select **Delete**.
  
### See also

 [Design custom business apps by using the app designer](design-custom-business-apps-using-app-designer.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
