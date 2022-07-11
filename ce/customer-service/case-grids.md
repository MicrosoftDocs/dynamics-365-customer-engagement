---
title: "Manage cases with case grids | MicrosoftDocs"
description: "Learn how to work with case grids and increase agent productivity. "
ms.date: 07/11/2022
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

# Manage cases with case grids (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

The modernized case grids help you increase your productivity by providing quick access to information, such as last customer interaction, case age, and the next SLA breach. You can perform inline edits and quick operations with minimal clicks, thereby managing cases quickly and efficiently. More information: [Key features](enable-case-grids.md#key-features)

## Columns on the Enhanced Active Cases View

To be able to view the modernized case grids, your administrator must enable the **Enhanced Active Cases** View. More information: [Enable case grids (Preview)](enable-case-grids.md#enable-case-grids-preview)

The following table explains the enhancements that you would find in the **Enhanced Active Cases** View columns, when the **(Preview) Power Apps grid control** is enabled, as against other grids, such as **Read Only Grid**.

|Column  |Experience with (Preview) Power Apps grid control |Experience with other grids  |
|---------|---------|---------|
|Origin    |Shows the Origin Icon followed by the text for all the views on Case Grid. It is editable on double-click. Sorting and filtering are supported. | Only the text will appear without any icons.      |
|Priority   | Shows the color-coded Priority Icon followed by the text for all the views on Case Grid. It is editable on double-click. Sorting and filtering are supported. | Only the text will appear without any icons.     |
|Owner  | Shows the profile image of the Owner if available, else shows the initials followed by the Owner name as text. It is editable on double-click. Sorting and filtering are supported.| Only the Owner’s name will appear without any Profile image or the Initials.    |
|Last Interaction    | Shows the last activity and the action performed on that activity for that case. For example, **Note Added** for standard activities. For custom activities, only the created or updated status is shown. Selecting this will open the corresponding activity’s form. It is read-only. Sorting and filtering aren’t supported.            Additionally, if the activity has an attachment, it is displayed by an attachment icon, next to the activity.|  Only empty text will appear. |
|Next SLA   | Searches through all active (Non cancelled) SLA KPI instances attached to the given case, filters, and picks the SLA KPI instance which is in unresolved state and with the earliest expiry time. If the expiry time is in the past, it will denote that there is an expired SLA instance associated with the case. SLA KPI instance name isn't shown along with the timer control. Properties of the SLA Timer Control which are not supported are: Negative timer, Customized Labels, Upgrade Frequency, and auto-refresh. It is read-only. Sorting is supported but not filtering. | SLA Timer won't appear. Only the value assigned to Next SLA field in the backend will appear. It has details such as name of sla instance, expiry/warning time, and so on.|
|Subject   | Shows a subject associated with the case. It is editable on double-click. All the available options are listed to be selected. A hierarchical view isn't supported. Sorting and filtering are supported. | Subject associated with the case will appear as a text. |
|Is Escalated   | Shows a toggle button reflecting whether the case is escalated or not. It is editable. Sorting and filtering are supported. | Escalated information as Yes/No will appear as a text. |
|Case Age| Shows the static text with the duration for which the case is active for active and resolved cases in the format: {xx}d {yy}h or {xx}h {yy}m. For cancelled cases, the column shows Cancelled. The time gets refreshed every minute. The column will show 0h 0m when a case is created, after which the column will show either {xx}h {yy}m or {xx}d {yy}h. It is read-only. Sorting and filtering are not supported. | Duration in minutes (whole number) for active and resolved cases will appear. For cancelled cases, Cancelled will appear. |

## Customize the Case grid

Depending on the information that you want to view, you can choose to add columns to the Case grid.

### Add columns to the Case grid

 Adding columns to the new **Enhanced Active Cases** view directly isn't supported. However, you can create a copy of the existing view and customize it.

To create a copy of the **Enhanced Active Cases** view and customize it to add a new column:

1. In the Customer Service workspace site map, open a new tab and select **Cases**.

1. Select **Enhanced Active Cases** from the dropdown list.
1. Select **Switch to classic** view.
1. Enter a new name for the view to save it as a copy of the **Enhanced Active Cases**view.
1. Select the new view that you just created from the list of views available for Cases.
1. Select **Column Options**.
1. On the **Edit columns** dialog, select **Add columns**. The Add columns dialog appears.
1. On the **Add columns** dialog, within **Case**, search for the column that you want to add. 
1. Select the column and then select **Close**. The new column that you have just added shows up on the **Edit columns** dialog.
1. Select **Apply**. If you want to change the sequence of the columns, select **Move up**and then **Apply**.

### Make changes to existing case grid views

You can also add columns to your existing views. For example, if you want to add **Last Interaction** or any of the other new key data columns, you must perform the following steps:

1.	In the Customer Service workspace site map, open a new tab and select **Cases**.

1.	Select any of the existing views from the dropdown list.
1.	Select **Column Options**.
1.	On the **Edit columns** dialog, select **Add columns**. The **Add columns** dialog appears.
1.	On the **Add columns** dialog, within Case, select **Custom** from the dropdown list. 
1.	Select **Last Interaction** and then select **Close**. **Last Interaction** shows up on the **Edit columns** dialog.
1.	Select **Apply**. If you want to change the sequence of the columns, select **Move up** and then **Apply**.

### See also

[Enable case grids (Preview)](enable-case-grids.md#enable-case-grids-preview)
[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
