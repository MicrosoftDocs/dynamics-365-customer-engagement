---
title: "Install or uninstall a model-driven app | MicrosoftDocs"
description: "Learn how to install or uninstall a model-driven app"
ms.custom: ""
ms.date: 04/10/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
  - "powerapps"
author: "Mattp123"
ms.assetid: e82e7f64-37ad-41e5-acd7-16309881c6a2
caps.latest.revision: 9
ms.author: "matp"
manager: "kvivek"
---
# Install or uninstall an app

[!INCLUDE [cc-applies-to-powerapps-and-update-9-0-0](../includes/cc-applies-to-powerapps-and-update-9-0-0.md)]

A model-driven app can be made available as a solution. This allows you to package one or more apps in a solution and import them in other environments.  
  
## Package an app in a solution  
 To import an app, you must first package it in a solution. To do this, create a solution, add the app you want to import, and then export it. When you are adding the app, select the **Yes, include required components** option in the **Missing Required Components** dialog box.  
  
> [!NOTE]
>  When you export an app using a solution, the app URL is not exported.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a managed solution](../developer/create-install-update-managed-solution.md#create-a-managed-solution), [Create an unmanaged solution](../developer/create-export-import-unmanaged-solution.md#create-an-unmanaged-solution) 
  
## Import the solution  
 In the organization where you need the app, import the solution that contains the app.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Install a managed solution](../developer/create-install-update-managed-solution.md#install-a-managed-solution), [Import an unmanaged solution](../developer/create-export-import-unmanaged-solution.md#import-an-unmanaged-solution) 
  
## App access  
 System administrators and customizers have access to these apps by default, and can give app access to specific security roles. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage access to apps with security roles](../customize/manage-access-apps-security-roles.md)  
  
## Delete (uninstall) an app  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2. Select **Solutions**.  
  
3. In the Solution window, under **Components**, select **Apps**.  
  
4. Select the app you want to delete, and on the command bar, select **Delete**.  
  
    You can delete unmanaged components or managed components that are customizable. If the component has dependencies such as relationships, you must remove the dependencies before you can delete the component. See **Show Dependencies**.  
  
### See also  
 [Design custom business apps by using the app designer](design-custom-business-apps-using-app-designer.md)
