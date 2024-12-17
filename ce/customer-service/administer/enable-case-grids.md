---
title: Enable case grids
description: Learn how you can enable case grids and increase service representative productivity.
ms.date: 12/05/2024
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
ms.collection: get-started
---

# Enable case grids

Increase your customer service representative's (service representative or representative) productivity by providing quick access to information, such as the last customer interaction, case age, and the next SLA breach, with modernized case grids. The modern UI presents data in an intuitive manner that helps you and your representatives perform inline edits and quick operations with minimal clicks, facilitating decision-making.

## Key features

The following are some of the key features of the modernized case grids:

- The **Enhanced Active Cases** view is available for the **Case** entity with a predefined set of columns that enable representatives to:
    - View icons for **Priority**, **Case status**, and the **Origin** channel.
    -	View avatars for the assigned **Owner**.
    - View key data, such as **Case Age**, **Next SLA**, **Is escalated** and **Last Interaction**, by default.
    - Perform inline edits and update data for columns. For example, representatives can double-click the **Priority** column to change the priority of the case or set the toggle to **Yes** or **No** in the **Is Escalated** column. The updated data is automatically saved only when representatives move to the next row. However, edit actions aren't enabled by default. To allow representatives to perform inline edits and update data for columns in the view, turn on **Configure property Enable Editing** in Power Apps. Inline editing for the **Status reason** column isn't supported.
- Color coded icons for **Priority**, **Case status**, and the **Origin** channels, avatars for **Owner** appear in all the case views. 
- Colors that you've set for custom columns of type **OptionSet** are also automatically displayed on the case grid.
  > [!NOTE]
  > Any changes made by Microsoft to the default color palette won't be available automatically if you've customized the colors that appear on the case status field.
- The ability to use quick navigation to respond to the latest interaction.

## Enable inline edits 

To enable inline edits on columns, do the following:

1. Go to the application and select **Settings** > **Advanced settings**.
1. Select **Solutions**. The **Solutions** page appears.
1. On the **Solutions** page, select **Default Solution**.
1. Select **Switch to classic**.
1. Select **Entities** > **Case**.
1. On the **Case** page, in the **Controls** section, select **Power Apps grid control**.
1. In the **Property** section in **Enable editing**, select **Edit**. The **Configure property Enable Editing** dialog appears.
1. In the **Configure property Enable Editing** dialog, select **Bind to static options**, select **Yes** from the dropdown list, and then select **OK**.

1. Select **Save**, and then select **Publish**.

### Manage option set colors

We recommend that you choose colors that keep the text readable if you are customizing the color of option set values. When the application is in the dark mode, the text color for option sets is white. Make sure that the background color you choose displays the text, in either mode.

Colors that you've set for custom columns of type OptionSet are also automatically displayed on the case grid. If you don't want the option sets to display colors on the case grid, set the **Enable OptionSet colors** property of the **Power Apps grid control** to **No (Enum)**.


## Add columns to the case grid

1. Go to the https://make.powerapps.com portal.

1. Select **Solutions**. The **Solutions** page appears.
1. On the **Solutions** page, select **Default Solution**.
1. On the left pane of the **Default Solution** page, select **Tables**, and then select **Case**.
1. On the **Case** page, select **Views**.
1. Select the case type that you want to update, for example, **All Cases**.
1. On the **View** page, select **+ View** column.
1. In the **View column** dialog, search for the column that you want to add, for example, the **Last Interaction** column. The **Last Interaction** column now appears on the **View** page.
1. Select **Save**, and then select **Publish**.

## Add new icons for Origin and Priority Columns

In the following example, you add a new **Option Set Value** for the **Priority** and **Origin** column.

1. Go to https://make.powerapps.com portal.
1. Select **Solutions**.
1. Select the solution in which you want to add the web resource. 
1. Select **New** > **More** > **Web resource**.
1. In the **New web resource** dialog, enter the following:

   1. Upload your file by selecting the **Upload file** option.
   1. In the **Display name** field, enter a display name.
   1. In the **Name** field, enter the name in the format: **Incident/Priority/{Option Set Value}PriorityIcon.{File Extension}** or **Incident/Origin/{Option Set Value}OriginIcon.{File Extension}**. For example, **Incident/Priority/100000000PriorityIcon.png**.
1. Select **Save**.

## Revert to legacy grids

If you want to revert to the legacy grids, perform the following steps:

1. Go to the application and select **Settings** > **Advanced settings**.
1. Select **Solutions**. The **Solutions** page appears.
1. On the **Solutions** page, select **Default Solution**.
1. Select **Switch to classic**.
1. Select **Entities** > **Case**.
1. On the **Case** page, in the **Controls** section, select **Web**,**Phone**, or **Tablet** for **Read-only Grid (default)** or delete **Power Apps grid control**.
1. Select **Save and Publish**.

### Related information

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)
  
[Troubleshoot issues in SLAs](../troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
