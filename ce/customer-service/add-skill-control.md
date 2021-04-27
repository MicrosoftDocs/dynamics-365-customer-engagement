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

Dynamics 365 provides an out-of-the box custom control that you can embed in any of your forms to view the skills of any routed record. To be able to add the skill control, you must have the System Administrator or System Customizer security role, or equivalent permissions. For more information about your security role, go to [View your user profile](../basics/view-your-user-profile.md).

In the following example, you add a skill control named **Skills** to a case form:

1. In Dynamics 365, go to **Advanced Settings**, select **Customizations**, and then  select **Customize the System**. 

2. On the page that appears, on the site map under **Components**, expand **Entities**, select **Case**, and then select **Forms**. 

3. In the **Active Forms** list that appears on the grid, select the form where you want to add the skill control. In this example, we selected the **Case for Interactive experience** form.

4. On the **Insert** tab, select **Section**, and then select **One Column**. Drag the section to the form.
 
5. From the **Field Explorer**, select an appropriate field (such as **Case Title**) to add to the section you just created, and then save the form.

6. Select the field you just added, and then select **Change Properties**. 

   In the **Field Properties** dialog that appears, select the **Display** tab and enter a label name for the field, such as **Skills**.

7. On the **Controls** tab, select **Add Control**. 
  
   In the **Add Control** dialog that appears, select the **CC_OCRoutedEtnRelatedRecordsControl** custom control from the dropdown list, and then select **OK**.

8. Save and publish the solution.

The skill control is now added to the **Case Interactive experience** form.

> [!NOTE]
> To customize a form to add the skill control in Customer Service workspace or the Omnichannel admin center, you can add the control to the **Case for Multisession experience** form.

After the skill control has been added to a case form, an agent can view the newly added custom control on all routed records in Customer Service Hub. The agent can view or delete existing skills, and even add new skills from the existing skill set. To enable agents to update skills, go to [Allow agents to update skills](enable-skill-routing-create-rating-model.md).


### See also

[Overview of unified routing](overview-unified-routing.md)  
[Routing and assignment rules](routing-workstream-queues.md)  
[Set up record routing](set-up-record-routing.md)  
[Set up unified routing](set-up-routing-process.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]