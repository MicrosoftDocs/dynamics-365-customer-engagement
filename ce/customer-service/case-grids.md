---
title: "Manage cases with case grids | MicrosoftDocs"
description: "Learn how to work with case grids and increase agent productivity. "
ms.date: 03/06/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
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

## Columns on the Enhanced Active Cases view

To be able to view the modernized case grids, your administrator must enable the **Enhanced Active Cases** view. More information: [Enable case grids (preview)](enable-case-grids.md#enable-case-grids-preview)

> [!NOTE]
> Enabling the **Enhanced Active Cases** view will alter the **modifiedon** and **modifiedby** fields on the case entity. We recommend that you avoid using these fields for reporting.

The following table explains the enhancements to the **Enhanced Active Cases** view columns when you enable the **Power Apps grid control**, compared with other grids, such as the **Read Only Grid**.

|Column  |Experience with Power Apps grid control |Experience with other grids  |
|---------|---------|---------|
|Origin    |Shows the Origin Icon followed by the text for all the views on Case Grid. The Origin column is editable on double-click. You can sort and filter the data. | Only the text appears, without any icons.| 
|Priority   | Shows the color-coded Priority icon followed by the text for all the views on Case Grid. The Priority column is editable on double-click. You can sort and filter the data.<br> **Note**: The colors displayed for the **Priority** and **Case status** fields have changed as an early access feature.|Only the text appears, without any icons.|
|Owner  | Shows the profile image of the Owner, if available; otherwise shows the initials followed by the Owner name as text. The Owner column is editable on double-click. You can sort and filter the data.| Only the owner’s name appears without any profile image or initials.    |
|Last Interaction    | Shows the last activity and the action performed on that activity&mdash;for example, **Note Added** for standard activities. For custom activities, only the created or updated status is shown. Selecting it opens the corresponding activity’s form. This data is read-only. You can't sort or filter the data. Additionally, if the activity has an attachment, you can see an attachment icon next to the activity. Displaying the Last Interaction column doesn’t affect the **modifiedon** and **modifiedby** fields.|  No text appears. |
|Next SLA   | Searches through all active, that is, non-canceled SLA KPI instances attached to the given case, filters, and then picks the SLA KPI instance that's in an unresolved state and has the earliest expiry time. If the expiry time is in the past, it indicates that there's an expired SLA instance associated with the case. The SLA KPI instance name isn't shown along with the timer control. The unsupported properties of the SLA timer control are negative timer, customized labels, upgrade frequency, and auto-refresh. The Next SLA column is read-only. You can sort the data but can't filter it. Calculating Next SLA for cases results in updates to the **modifiedon** and **modifiedby** fields on the case entity. If you want to disable Next SLA, you must contact Microsoft Support.| The SLA timer doesn't appear. Only the value assigned to **Next SLA** field in the back end appears, which includes details such as name of SLA instance and expiry/warning time.|
|Subject   | Shows the subject associated with the case. You can edit the Subject column by double-clicking it. All the available options that you can select are listed. A hierarchical view isn't available. You can sort and filter the data. | The subject associated with the case appears as a text. |
|Is Escalated   | Shows a toggle button reflecting whether the case has been escalated. The Is Escalated column is editable. You can sort and filter the data. | Escalation information in the form of **Yes/No** appears as text. |
|Case Age| Shows the static text with the duration for which the case has been active for active and resolved cases in the format {xx}d {yy}h or {xx}h {yy}m. For canceled cases, the column shows **Canceled**. For cases that were in the **Resolved** state before enabling modernized case grids, the column shows as **Resolved**. Calculated Case Age is refreshed every minute, but you must refresh the view to see the updated case age on the grid. The column shows **0h 0m** when a case is created, after which the column shows either **{xx}h {yy}m** or **{xx}d {yy}h**. This column is read-only. You can't sort or filter the data. To calculate case age for cases that are resolved after enabling modernized case grids, the **deactivatedon** attribute captures the date and time, when a case is resolved. Case age for resolved cases depends on the values of the **createdon** and **deactivatedon** attributes. Calculating case age for active or resolved cases won't affect the **modifiedon** and **modifiedby** fields. | Duration in minutes (whole number) for active and resolved cases appears. For canceled cases, **Canceled** appears. |

## Customize the Case grid

Depending on the information that you want to view, you can choose to add columns to the case grid and you can change the existing case grid views.

### Add columns to the Case grid

Adding columns to the new **Enhanced Active Cases** view directly isn't supported. However, you can create a copy of the existing view and customize it.

To create a copy of the **Enhanced Active Cases** view and customize it to add a new column:

1. In the Customer Service workspace site map, open a new tab, and then select **Cases**.

1. From the dropdown list, select **Enhanced Active Cases** .
1. Select **Switch to classic**.
1. Enter a new name for the view. This saves it as a copy of the **Enhanced Active Cases** view.
1. From the list of views available for **Cases**, select the new view that you created.
1. Select **Column Options**.
1. In the **Edit columns** dialog, select **Add columns**. The Add columns dialog appears.
1. In the **Add columns** dialog, within **Case**, search for the column that you want to add.
1. Select the column, and then select **Close**. The new column that you have added appears in the **Edit columns** dialog.
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

[Enable case grids (preview)](enable-case-grids.md#enable-case-grids-preview)
[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
