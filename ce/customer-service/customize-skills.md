---
title: "Customize skills on any form| Microsoft Docs"
description: "Learn how to customize skills on any form"
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/15/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - developer
  - customizer
search.app: 
  - D365CE
  - D365CS
ms.reviewer: nenellim
---
# How to customize skills on any form

Dynamics 365 ships a control that you can embed in any of your forms. 
Say you have a case form where you want to add a **Skills** control, here are the steps to add the skill update control on the case form:

1. In Dynamics 365, go to **Advanced Settings** > **Customizations** > **Customize the System**.

2. In the navigation pane, under **Components**, select **Entities** > **Case** > **Forms**. 

3. From the **Forms** list that appears on the grid, select the form where you want to add the skill update control.

4. On the **Insert** tab, select **Section** > **One Column**. Drag and drop the section on the form.
 
5. From the **Field Explorer**, select an appropriate field to add onto the section you just created, and save the form.

6. Select the field you just added and click **Change Properties**. 
   In the **Field Properties** dialog box, on the **Display** tab, enter a label name for the field.

7. Select the **Control** tab, click **Add Controls**, select the **CC_OCRoutedEtnRelatedRecordsControl** custom control from the drop-down list and select **OK**.

8. Save and publish the form.
    

### See also

[Overview of unified routing](overview-unified-routing.md)
[Routing and assignment rules](routing-workstream-queues.md)  
[Set up record routing](set-up-record-routing.md)  
[Set up unified routing](set-up-routing-process.md)  