---
title: "Skill control for routed records| Microsoft Docs"
description: "Learn how to add a skill control on forms to view skills on any routed record"
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/20/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
ms.reviewer: nenellim
---
# Add a skill control to view skills on any routed record

Dynamics 365 provides an out-of-the box control that you can embed in any of your forms to view the skills of any routed record. To be able to add the skill control, you must have the System Administrator or System Customizer security role or equivalent permissions. To know more about your security role, see [View your user profile](../basics/view-your-user-profile.md).

Say you want to add the skill control named **Skills** to a case form, then:

1. In Dynamics 365, go to **Advanced Settings**, select **Customizations**, and then select **Customize the System**. 
On the page that appears, in the site map, under **Components**, expand **Entities**, select **Case**, and then select **Forms**. 

2. In the **Active Forms** list that appears on the grid, select the form where you want to add the skill control. In this example, we have selected the **Case for Interactive experience** form.

3. On the **Insert** tab, select **Section** > **One Column**. Drag and drop the section on the form.
 
4. From the **Field Explorer**, select an appropriate field (such as **Case Title**) to add onto the section you just created, and save the form.

5. Select the field you just added and select **Change Properties**.  In the **Field Properties** dialog box that appears, select the **Display** tab and enter a label name for the field, such as **Skills**.

6. On the **Controls** tab, select **Add Control**. 
    In the **Add Control** dialog box that appears, select the **CC_OCRoutedEtnRelatedRecordsControl** custom control from the dropdown list and select **OK**.

7. Save and publish the form.
   The skill control is now added to the **Case Interactive experience** form.
<!-- need an image here -->
   
> [!NOTE]
> To customize a form to add the skill control in **Customer Service workspace** or the **Omnichannel admin center**, you can add the control to the **Case for Multisession experience** form.

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Routing and assignment rules](routing-workstream-queues.md)  
[Set up record routing](set-up-record-routing.md)  
[Set up unified routing](set-up-routing-process.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]