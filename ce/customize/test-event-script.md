---
title: "Test an event script in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 6fa38bb3-d114-4eee-add1-b29bb3b75bf2
caps.latest.revision: 11
ms.author: "rdubois"
manager: "brycho"
---
# Test an event script
Before you publish any customizations, you should thoroughly test your scripts. You can perform customization tasks only while you’re online.  
  
1. [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)]  
  
    ###### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)].  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3.  Choose **Customize the System**.  
  
4.  Choose **Components** > **Entities**, and then expand the entity you want.  
  
5.  Choose **Forms**. In the list, choose a form to edit if it has a form type of Main.  
  
6.  On the **Home** tab, choose **Preview**, and then select **Create Form**, **Update Form**, or **Read-Only Form**.  
  
    -   If you have added an **OnLoad** event for the form, open the form in each mode, and verify that your event executed as expected.  
  
    -   If your code depends on data existing in the form when it loads, test your script in an **OnChange** or **OnSave** event to enter sample data into the form. The **Update Form** will open with no data.  
  
        -   If you have added an **OnChange** event for a field, for create and update modes, enter the data in the field and verify that your event executed as expected.  
  
        -   If you have added an **OnSave** event for a field, for create and update modes, choose **Simulate Form Save** and verify that your event executed as expected.  
  
7.  Choose **File** > **Close**.
