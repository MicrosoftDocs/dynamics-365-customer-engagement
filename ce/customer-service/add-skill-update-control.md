---
title: "Skill update control for routed records| Microsoft Docs"
description: "Learn how to add a skill update control on forms to view skills on any routed record"
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
# Add a skill update control to view skills on any routed record

Dynamics 365 provides an out-of-the box control that you can embed in any of your forms to view the skills of any routed record. 
> [!NOTE]
   > Make sure that you have the System Administrator or System Customizer security role or equivalent permissions. To know more about your security role, see [View your user profile](../../view-your-user-profile.md)
Say you have a case form where you want to add a **Skills** control, here are the steps to add the skill update control on the case form:

1. In Dynamics 365, go to **Advanced Settings** > **Customizations** > **Customize the System**.

2. In the navigation pane, under **Components**, select **Entities** > **Case** > **Forms**. 

3. From the **Forms** list that appears on the grid, select the form where you want to add the skill update control. In this example, we have selected the **Case for Interactive experience** form.

4. On the **Insert** tab, select **Section** > **One Column**. Drag and drop the section on the form.
 
5. From the **Field Explorer**, select an appropriate field (such as **Case Title**) to add onto the section you just created, and save the form.

6. Select the field you just added and click **Change Properties**.  In the **Field Properties** dialog box that appears, select the **Display** tab and enter a label name for the field, such as **Skills**.
    > ![Set Field Properties in the Display tab](media/field-properties-display-tab.png)

7. On the **Controls** tab, select **Add Controls**. 
    > ![Select Add Controls in the Controls tab](media/field-properties-controls-tab.png)

  In the **Add Control** dialog box that appears, select the **CC_OCRoutedEtnRelatedRecordsControl** custom control from the drop-down list and click **OK**.
    > ![Select the Skill Update Control from the drop-down list](media/add-skill-update-control.png)

9. Save and publish the form.
   
> [!NOTE]
> To be able to add the skill update form in Customer Service workspace or Omnichannel admin center, you can add the skill update control to the Case for Multisession experience form.

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Routing and assignment rules](routing-workstream-queues.md)  
[Set up record routing](set-up-record-routing.md)  
[Set up unified routing](set-up-routing-process.md)  