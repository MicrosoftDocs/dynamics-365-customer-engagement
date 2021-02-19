---
title: Create and manage subject tree (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to create and manage subject tree in Dynamics 365 Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Create and manage subjects in a subject tree

Dynamics 365 Customer Service includes a subject organizational structure that lets you mark and categorize service cases, knowledge base articles, and products. By using the subject hierarchy, you can classify service cases to quickly provide service to your customer.

> [!NOTE]
> With the latest release of Dynamics 365 Customer Service app, subjects in service management is available in the Customer Service Hub. You are recommended to create and manage subjects using the new experience.
  
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

[Configure Customer Service)](configure-cs.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]