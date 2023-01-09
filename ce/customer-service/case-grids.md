---
title: "Manage cases with case grids | MicrosoftDocs"
description: "Learn how to work with case grids and increase agent productivity. "
ms.date: 01/09/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
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
  - intro-internal
---

# Manage cases with case grids

The modernized case grids help you increase your productivity by providing quick access to information, such as last customer interaction, case age, and the next SLA breach. You can perform inline edits and quick operations with minimal clicks, thereby managing cases quickly and efficiently. More information: [Key features](enable-case-grids.md#key-features)

## Columns on the Enhanced Active Cases view

To be able to view the modernized case grids, your administrator must enable the **Enhanced Active Cases** view. More information: [Enable case grids](enable-case-grids.md#enable-case-grids)

> [!NOTE]
> Enabling the **Enhanced Active Cases** view will alter the **modifiedon** and **modifiedby** fields on the case entity. We recommend that you avoid using these fields for reporting.

The following table explains the enhancements that you'll find in the **Enhanced Active Cases** view columns, when the **Power Apps grid control** is enabled, compared with other grids, such as the **Read Only Grid**.

|Column  |Experience with Power Apps grid control |Experience with other grids  |
|---------|---------|---------|
|Origin    |Shows the Origin Icon followed by the text for all the views on Case Grid. This column is editable on double-click. Sorting and filtering are supported. | Only the text appears, without any icons.      |
|Priority   | Shows the color-coded Priority Icon followed by the text for all the views on Case Grid. This column is editable on double-click. Sorting and filtering are supported. | Only the text appears, without any icons.     |
|Owner  | Shows the profile image of the Owner, if available; otherwise shows the initials followed by the Owner name as text. This column is editable on double-click. Sorting and filtering are supported.| Only the owner’s name  appears without any profile image or initials.    |
|Last Interaction    | Shows the last activity and the action performed on that activity&mdash;for example, **Note Added** for standard activities. For custom activities, only the created or updated status is shown. Selecting this will open the corresponding activity’s form. This is read-only. Sorting and filtering aren’t supported. Additionally, if the activity has an attachment, it's indicated by an attachment icon, next to the activity. Displaying the Last Interaction column doesn’t impact the **modifiedon** and **modifiedby** fields.|  No text will appear. |
|Next SLA   | Searches through all active (that is, non canceled) SLA KPI instances attached to the given case, filters, and then picks the SLA KPI instance that's in an unresolved state and has the earliest expiry time. If the expiry time is in the past, this denotes that there's an expired SLA instance associated with the case. The SLA KPI instance name isn't shown along with the timer control. The properties of the SLA timer control that aren't supported are negative timer, customized labels, upgrade frequency, and auto-refresh. This column is read-only. Sorting is supported but filtering isn't. Calculating Next SLA for cases results in updates to the **modifiedon** and **modifiedby** fields on the case entity. If you want to disable Next SLA, you must contact Microsoft Support.| The SLA timer won't appear. Only the value assigned to **Next SLA** field in the back end will appear, which includes details such as name of SLA instance and expiry/warning time.|
|Subject   | Shows the subject associated with the case. You can edit this column by double-clicking it. All the available options that can be selected are listed. A hierarchical view isn't supported. Sorting and filtering are supported. | The subject associated with the case will appear as a text. |
|Is Escalated   | Shows a toggle button reflecting whether the case has been escalated. This column is editable. Sorting and filtering are supported. | Escalation information in the form of **Yes/No** appears as text. |
|Case Age| Shows the static text with the duration for which the case has been active for active and resolved cases in the format {xx}d {yy}h or {xx}h {yy}m. For canceled cases, the column shows **Canceled**. For cases which were in **Resolved** state before enabling modernized case grids, the column will show as **Resolved**. Calculated Case Age is refreshed every minute, but you must refresh the view to see the updated case age on the grid. The column will show **0h 0m** when a case is created, after which the column will show either **{xx}h {yy}m** or **{xx}d {yy}h**. This column is read-only. Sorting and filtering aren't supported. To calculate case age for cases that get resolved after enabling modernized case grids, the **deactivatedon** attribute captures the date and time, when a case is resolved. Case age for resolved cases depends on the values of the **createdon** and **deactivatedon** attributes. Calculating case age for active or resolved cases won't have any impact on **modifiedon** and **modifiedby** fields. | Duration in minutes (whole number) for active and resolved cases will appear. For canceled cases, **Canceled** will appear. |

## Customize the Case grid

Depending on the information that you want to view, you can choose to add columns to the case grid and you can change the existing case grid views.

### Add columns to the Case grid

 Adding columns to the new **Enhanced Active Cases** view directly isn't supported. However, you can create a copy of the existing view and customize it.

To create a copy of the **Enhanced Active Cases** view and customize it to add a new column:

1. In the Customer Service workspace site map, open a new tab, and then select **Cases**.

1. From the dropdown list, select **Enhanced Active Cases** .
1. Select **Switch to classic**.
1. Enter a new name for the view. This saves it as a copy of the **Enhanced Active Cases** view.
1. From the list of views available for **Cases**, select the new view that you just created.
1. Select **Column Options**.
1. In the **Edit columns** dialog, select **Add columns**. The Add columns dialog appears.
1. In the **Add columns** dialog, within **Case**, search for the column that you want to add.
1. Select the column, and then select **Close**. The new column that you have just added appears in the **Edit columns** dialog.
1. Select **Apply**. If you want to change the sequence of the columns, select **Move up**, and then select **Apply**.

### Make changes to existing case grid views

You can also add columns to your existing views. For example, if you want to add **Last Interaction** or any of the other new key data columns, perform the following steps:

1. In the Customer Service workspace site map, open a new tab, and then select **Cases**.

1.	From the dropdown list, select any of the existing views.
1.	Select **Column Options**.
1.	In the **Edit columns** dialog, select **Add columns**. The **Add columns** dialog appears.
1.	In the **Add columns** dialog, within Case, select **Custom** from the dropdown list. 
1.	Select **Last Interaction**, and then select **Close**. **Last Interaction** appears in the **Edit columns** dialog.
1.	Select **Apply**. If you want to change the sequence of the columns, select **Move up**, and then select **Apply**.

### See also

[Enable case grids](enable-case-grids.md#enable-case-grids)
[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
