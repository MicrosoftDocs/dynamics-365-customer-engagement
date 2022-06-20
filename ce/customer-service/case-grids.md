---
title: "Manage cases with case grids | MicrosoftDocs"
description: "Learn how to work with case grids and increase agent productivity. "
ms.date: 06/20/2022
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

# Manage cases with case grids (Preview)

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
- View key data, such as **Case Age**, **Next SLA Breach**, and **Last Interaction** with attachments.
- Perform inline edits and update data for columns. For example, you can double-click on the **Status Reason** column to change the status of the case or set the toggle to **Yes** or **No** in the **Is Escalated** column. The data update is auto saved only when you move to the next row.
- Use quick navigation to respond to the latest interaction.

## Columns on the Enhanced Active Cases View

|Column  |Experience with (Preview) Power Apps grid control |Experience with other grids  |
|---------|---------|---------|
|Origin    |Shows the Origin Icon followed by the text for all the views on Case Grid. It is editable on double-click. Sorting and filtering are supported. | Only the text will appear without any icons.      |
|Priority   | Shows the color-coded Priority Icon followed by the text for all the views on Case Grid. It is editable on double-click. Sorting and filtering are supported. | Only the text will appear without any icons.     |
|Owner  | Shows the profile image of the Owner if available, else shows the initials followed by the Owner name as text. It is editable on double-click. Sorting and filtering are supported.| Only the Owner’s name will appear without any Profile image or the Initials.    |
|Last Interaction    | Shows the last activity and the action performed on that activity for that case. For example, **Note Added** for standard activities. For custom activities, only the created or updated status is shown. Selecting this will open the corresponding activity’s form. It is read-only. Sorting and filtering aren’t supported.            Additionally, if the activity has an attachment, it is displayed by an attachment icon, next to the activity.|  Only empty text will appear. |
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
1. On the **Controls** tab, do the following:

    1. **Controls** section: For **(Preview) Power Apps grid control**, select **Web**, **Phone**, and **Tablet** radio button/options.
    1. **Property** section: In **Customizer Control** field, select **Edit**. The **Configure property “Customizer Control Name”** dialog appears.
    1. Select the **Bind to a static value option**, and for **Singleline.Text**, select **MscrmControls.CustomCellControl.CustomCellControl** and then select **OK**.
     1. To enable inline editing, in the **Property** section, in **Enable editing**, select **Edit**. The Configure property **Enable Editing** dialog appears. 
     1. Select **Bind to static options** and select **Yes** from the dropdown list, and then select **OK**.
1. Select **Save** and then select **Publish**.

> [!NOTE]
> New columns introduced as part of a solution will be available in the environment, after the solution is installed. Experience of these columns will depend on enabling the modernized grids.

## Enable Enhanced Active Cases View in Customer Service workspace app

 1. Navigate to your environment using your organization link.
 
 1. From the list of apps, select **More Options** in Customer Service Workspace Model Driven App and then select **Open in App Designer**.
  1. From **Components > Entity Assets > Views**, select the **Case** entity. 
  1. In the Components tab, search for **Enhanced Active Cases** view and select the checkbox. 
  1. Select **Save** and then select **Publish**. 

## Add columns to the Case grid on the client side

Depending on the information that you want to view, you can choose to add columns to the Case grid. Adding columns to the new **Enhanced Active Cases** view is not supported. However, you can create a copy of the existing view and customize it. You can also add columns to your existing views.

To create a copy of the **Enhanced Active Cases** view and customize it to add a new column:

1. In the Customer Service workspace site map, open a new tab and select Cases.

1. Select **Enhanced Active Cases** from the dropdown list.
1. Select **Switch to classic** view.
1. Enter a new name for the view to save it as a copy of the **Enhanced Active Cases**view.
1. Select the new view that you just created from the list of views available for Cases.
1. Select **Column Options**.
1. On the **Edit columns** dialog, select **Add columns**. The Add columns dialog appears.
1. On the **Add columns** dialog, within **Case**, search for the column that you want to add. 
1. Select the column and then select **Close**. The new column that you have just added shows up on the **Edit columns** dialog.
1. Select **Apply**. If you want to change the sequence of the columns, select **Move up**and then **Apply**.

You can also make changes to existing case grid views. For example, if you want to add **Last Interaction** or any of the other new key data columns, you must perform the following steps:
1.	In the Customer Service workspace site map, open a new tab and select **Cases**. 

1.	Select any of the existing views from the dropdown list.
1.	Select **Column Options**.
1.	On the **Edit columns** dialog, select **Add columns**. The **Add columns** dialog appears.
1.	On the **Add columns** dialog, within Case, select **Custom** from the dropdown list. 
1.	Select **Last Interaction** and then select **Close**. **Last Interaction** shows up on the **Edit columns** dialog.
1.	Select **Apply**. If you want to change the sequence of the columns, select **Move up** and then **Apply**.

## Add columns to the Case grid on the server side

To add columns in the Case grid:

1. Go to the https://powerautomate.microsoft.com portal.

1. Select **Solutions**. The **Solutions** page appears.
1. On the **Solutions** page, select **Default Solution**.
1. On the **Default Solution** page, select **Tables** from the left panel and then select the **Case** entity.
1. On the **Case** page, select **Views**.
1. Select the Case type that you want to update, for example, **All Cases**.
1. On the **View** page, select **+ View** column.
1. On the **View column** dialog, search for the column that you want to add, for example, **Last Interaction** column. The **Last Interaction**column now appears on the View page.
1. Select **Save** and **Publish**.

## Add new icons for Origin and Priority Columns

The following section takes the example of adding a new Option Set Value for the Priority column with the label Custom.

1. Go to the https://powerautomate.microsoft.com portal.
1. Select **Solutions**.
1. Select the Solution in which you want to add the web resource. 
1. Select **New > More > Web resource**.
1. In the **New web resource** dialog, enter the following:

   1. Upload your file by selecting the Upload file option.
   1. In the **Display name** field, provide a display name.
   1. In the **Name** field, provide the name in the format: **Incident/Priority/{Option Set Value Label}PriorityIcon or Incident/Origin/{Option Set Value Label}OriginIcon**. For the given example, the name would be **Incident/Priority/CustomPriorityIcon**.
1. Select **Save**.


### See also

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
