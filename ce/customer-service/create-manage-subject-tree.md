---
title: Create and manage subject tree (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to create and manage subject tree in Dynamics 365 for Customer Service 
keywords: Create subject in a subject tree; Manage subject in a subject tree; Remove a subject; Dynamics 365 for Customer Engagement; Customer Service
author: anjgupta
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.author: anjgup
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 680117bf-42f8-4663-a4e2-8ef39fb6b14e
ms.custom: dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Create and manage subjects in a subject tree

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] includes a subject organizational structure that lets you mark and categorize service cases, knowledge base articles, and products. By using the subject hierarchy, you can classify service cases to quickly provide service to your customer.

> [!NOTE]
> With the Customer Engagement apps version 9.1 release, subjects in service management is available in the Customer Service Hub. You are recommended to create and manage subjects using the new experience.
  
## Create or edit a subject  

1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)] 
  
1. In the Customer Service Hub sitemap, go to **Service Management** > **Subjects**.  
  
2.  To add a subject, select **Add Subject**.  
  
     -OR-  
  
     To edit a subject, in the subject tree, select a subject, and then  select **Edit Subject**.  
  
3.  In the **Subject** dialog box, enter the required information:  
  
    - **Title**: Type a name for the subject. This is a required field.  
  
    - **Parent Subject**: To search for and select a parent subject for the new subject, select the **Lookup** button.  
  
         -OR-  
  
         To make the new subject a parent subject, select the **Parent Subject** box.  
  
    - **Description**: Type a descriptive statement about the subject.  
  
4.  Select **Save**.  

> [!NOTE]
> If you select a subject in the subject tree and select **Add Subject**, select the **Parent Subject** box to make it a parent subject. If you do not select the box, the new subject will be added as a child of that subject.
  
## Remove a subject  

To remove a subject from the subject tree, select the subject and select **Remove Subject**.

### See also

[Service Manager Guide (Customer Service Hub and Customer Service app)](service-manager-guide.md)