---
title: "Work with case grids | MicrosoftDocs"
description: "Learn how to work with case grids and increase agent productivity. "
ms.date: 06/03/2022
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

# Work with case grids (Preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

The modernized Case grid helps you increase agent productivity by providing quick access to information, such as last customer interaction, case age, and the next SLA breach. The modern UI presents data in an intuitive manner that helps supervisors and agents perform inline edits and quick operations with minimal clicks, thereby facilitating decision-making.

## Key features

The following are some of the key features:

- New view called **Enhanced Active Cases** with a set of pre-defined columns.
- View icons for **Priority** and the **Origin** channel.
-	View avatars for the assigned **Owner**. 
- View key data, such as **Case Age**, **Next SLA Breach**, and **Last Interaction**.
- Perform inline edits and update data for columns. For example, you can double-click on the **Status Reason** column to change the status of the case or set the toggle to **Yes** or **No**in the **Is Escalated** column. The data update is auto saved.
- Use quick navigation to respond to the latest interaction.

## Columns on the Enhanced Active Cases View

|Column  |Experience with (Preview) Power Apps grid control |Experience with other grids  |
|---------|---------|---------|
|Origin    |Shows the Origin Icon followed by the text for all the views on Case Grid. It is editable on double-click. Sorting and filtering are supported. | Only the text will appear without any icons.      |
|Priority   | Shows the color-coded Priority Icon followed by the text for all the views on Case Grid. It is editable on double-click. Sorting and filtering are supported. | Only the text will appear without any icons.     |
|Owner  | Shows the profile image of the Owner if available, else shows the initials followed by the Owner name as text. It is editable on double-click. Sorting and filtering are supported.| Only the Owner’s name will appear without any Profile image or the Initials.    |
|Last Interaction    | Shows the last activity and the action performed on that activity for that case. For example, Note added for standard activities. For custom activities, only the created or updated status is shown. Selecting this will open the corresponding activity’s form. It is read-only. Sorting and filtering aren’t supported|  Only empty text will appear. |
|Next SLA   | Searches through all active (Non cancelled) SLA KPI instances attached to the given case, filters, and picks the SLA KPI instance which is in unresolved state and with the earliest expiry time. If the expiry time is in the past, it will denote that there is an expired SLA instance associated with the case. SLA KPI instance name is not shown along with the timer control. Properties of the SLA Timer Control which are not supported are: Negative timer, Customized Labels, Upgrade Frequency, and auto-refresh. It is read-only. Sorting is supported but not filtering. | SLA Timer will not appear. Only the value assigned to Next SLA field in the backend will appear. It has details such as name of sla instance, expiry/warning time, and so on.|
|Subject   | Shows a subject associated with the case. It is editable on double-click. All the available options are listed to be selected. A hierarchical view is not supported. Sorting and filtering are supported. | Subject associated with the case will appear as a text. |
|Is Escalated   | Shows a toggle button reflecting whether the case is escalated or not. It is editable. Sorting and filtering are supported. | Escalated information as Yes/No will appear as a text. |
|Case Age| Shows the static text with the duration for which the case is active for active and resolved cases in the format: {xx}d {yy}h or {xx}h {yy}m. For cancelled cases, the column shows Cancelled. The time gets refreshed every minute. The column will show 0h 0m when a case is created, after which the column will show either {xx}h {yy}m or {xx}d {yy}h. It is read-only. Sorting and filtering are not supported. | Duration in minutes (whole number) for active and resolved cases will appear. For cancelled cases, Cancelled will appear. |

## Enable the modernized grids for Case entity

1. Go to the https://powerautomate.microsoft.com portal.
1. Select **Solutions**. The **Solutions** page appears.
1. On the **Solutions** page, select **Default Solution**.
1. On the **Default Solution** page, select **Tables** from the left panel and then select the **Case** entity.
1. Select **Switch to classic** view.
1. On the **Case** page, in the **Controls** section, select **Add Control**.
1. On the **Add Control** dialog, select (Preview) Power Apps grid control > Add.
1. On the Controls tab, do the following:

    1. Controls section: For (Preview) Power Apps grid control, select Web, Phone, and Tablet radio button/options.
    1.	Property section: In Customizer Control field, select Edit. The Configure property “Customizer Control Name” dialog appears.
    1. Select the Bind to a static value option, and for Singleline.Text, select MscrmControls.CustomCellControl.CustomCellControl and then select OK.
     1. To enable inline editing, in the Property section, in Enable editing, select Edit. The Configure property Enable Editing dialog appears. 
     1. Select Bind to static options and select Yes from the dropdown list, and then select **OK**.
1. Select **Save** and **Publish**.


### See also

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
