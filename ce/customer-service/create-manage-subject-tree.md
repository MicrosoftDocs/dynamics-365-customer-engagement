---
title: Create and manage subject tree (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to create and manage subject tree in Dynamics 365 Customer Service
ms.date: 01/10/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Create and manage subjects in a subject tree

Dynamics 365 Customer Service includes a subject organizational structure that lets you group service cases and knowledge base articles. By using the subject hierarchy, you can classify service cases to quickly provide service to your customer.

  
## Create or edit a subject

[!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  

1. In the Customer Service Hub site map, go to **Service Management** > **Subjects**. The **Subject tree** page appears.
  
2. In the **Subject tree management** area, select **Add**.  
  
3. In the **Create a subject** dialog, enter the following information:  
  
    - **Title**: Type a name for the subject.
  
    - **Parent Subject**: Search for and select a parent subject. Leave it blank if you want the new subject to be a parent subject.
  
    - **Description**: Type a descriptive statement about the subject.
    
    - Set the toggle for **Visibility** to **Yes** if you want the subject to be available for the agent.
  
4. Select **Save and close**.

5. To edit a subject, select a subject, and then select **Edit**. You can also select **More commands** to display the actions, such as **Edit** or **Add**, that you can take for the selected subject.

> [!NOTE]
> If you select a subject in the subject tree and select **Add**, clear the selection in the **Parent subject** box to make it a parent subject. Otherwise, the new subject will be added as a child of selected subject.
  
## Remove a subject  

To remove a subject from the subject tree, select the subject and select **Remove Subject**.

### See also

[Configure Customer Service](configure-cs.md)  
[Overview of case management](overview-cases.md)  
[Enable search control for the subject entity](search-control-for-subjects.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
