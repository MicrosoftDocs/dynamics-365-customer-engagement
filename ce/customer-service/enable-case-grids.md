---
title: "Enable case grids for agents| MicrosoftDocs"
description: "Learn how you can enable case grids and increase agent productivity."
ms.date: 06/21/2022
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

# Enable case grids (Preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

The modernized Case grids help you increase agent productivity by providing quick access to information, such as last customer interaction, case age, and the next SLA breach. The modern UI presents data in an intuitive manner that helps you and your agents perform inline edits and quick operations with minimal clicks, thereby facilitating decision-making.

## Key features

The following are some of the key features of the modernized case grids:

- View called **Enhanced Active Cases** with a set of pre-defined columns:
    - View icons for **Priority** and the **Origin** channel.
    -	View avatars for the assigned **Owner**.
    - View key data, such as **Case Age**, **Next SLA Breach**, and **Last Interaction** with attachments.
- Perform inline edits and update data for columns. For example, you can double-click on the **Status Reason** column to change the status of the case or set the toggle to **Yes** or **No** in the **Is Escalated** column. The data update is auto saved only when you move to the next row.
- Use quick navigation to respond to the latest interaction.

## Enable the (Preview) Power Apps grid control for the Case entity

To make the **Enhanced Active Cases** view accessible to agents you must enable the **(Preview) Power Apps grid control**:

1. Go to the https://powerautomate.microsoft.com portal.
1. Select **Solutions**. The **Solutions** page appears.
1. On the **Solutions** page, select **Default Solution**.
1. On the **Default Solution** page, select **Tables** from the left panel and then select the **Case** entity.
1. Select **Switch to classic** view.
1. On the **Case** page, in the **Controls** section, select **Add Control**.
1. On the **Add Control** dialog, select **(Preview) Power Apps grid control**> **Add**.
1. On the **Controls** tab, do the following:

    1. **Controls** section: For **(Preview) Power Apps grid control**, select **Web**, **Phone**, and **Tablet** radio button/options.
    1. **Property** section: In **Customizer Control** field, select **Edit**. The **Configure property “Customizer Control Name”** dialog appears.
    1. Select the **Bind to a static value option**, and for **Singleline.Text**, select **MscrmControls.CustomCellControl.CustomCellControl** and then select **OK**.
     1. To enable inline editing, in the **Property** section, in **Enable editing**, select **Edit**. The Configure property **Enable Editing** dialog appears. 
     1. Select **Bind to static options** and select **Yes** from the dropdown list, and then select **OK**.
1. Select **Save** and then select **Publish**.

> [!NOTE]
> New columns introduced as part of a solution will be available in the environment, after the solution is installed. Experience of these columns will depend on enabling the modernized grids.


## Enable the Enhanced Active Cases View in Customer Service workspace

To make the **Enhanced Active Cases** view accessible to agents in Customer Service workspace:

 1. Navigate to your environment using your organization link.
 
 1. From the list of apps, select **More Options** in Customer Service Workspace Model Driven App and then select **Open in App Designer**.
  1. From **Components > Entity Assets > Views**, select the **Case** entity. 
  1. In the Components tab, search for **Enhanced Active Cases** view and select the checkbox. 
  1. Select **Save** and then select **Publish**.

## Customize the Case grid

### Add columns to the Case grid

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

### Add new icons for Origin and Priority Columns

You can also add new icons for the Origin and Priority Columns. Here's an example that explains how you can add a new **Option Set Value** for the **Priority** column with the label **Custom**.

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
