---
title: Enable enhanced case forms for multisession apps | MicrosoftDocs 
description: Learn about enabling the enhanced case forms for multisession apps.
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 04/24/2023 
ms.custom: bap-template 
---

# Enable enhanced case forms for multisession apps

Enable the enhanced **Quick case form** and **Full case form**  options, if you want your agents to see the enhanced quick case form and full case form, while creating a new case in the Customer Service workspace app."

> [!NOTE]
> The enhanced case creation experience is available only in the Customer Service workspace app and not in other applications including Omnichannel for Customer service and Customer Service Hub.

## Enable enhanced case experience
To enable the enhanced case forms, perform the following steps:

1. In Customer Service admin center, go to **Case Settings**.
1. Select **Manage** for **Enhanced case experience**.
1. Switch the **Enhanced case experience** toggle to **Yes**.
   - To enable the enhanced full case form:
      1. Switch the **Full case form** toggle to **Yes**, for your agents to see the enhanced full case form. 
      1. Select **Configure** to [customize the form in Power Apps](/power-apps/maker/model-driven-apps/create-and-edit-forms). The Power Apps form page opens on a new tab. 
   - To enable the enhanced quick case form:
      1. Switch the **Quick case form** toggle to **Yes**.
      1. Select the option in the **Choose Form** dropdown. The selected main form appears as the side pane when the agent creates a new case. By default, this is set to **Enhanced quick case form**. 
      1. Select **Configure** to [customize the form in Power Apps](/power-apps/maker/model-driven-apps/create-and-edit-forms). The Power Apps form page opens on a new tab.

   :::image type="content" source="media/settings-enh-case-channel.png" alt-text="Default main case form" lightbox="media/settings-enh-case-channel.png":::

> [!NOTE]
> If the enhanced full case form has a higher form order than the default case form, agents might see the enhanced full case form even if you haven't enabled the enhanced case experience. If you'd like agents to see the default case experience, set the form order of the enhanced form lower than that of the default form. More information: [Set the form order](/power-apps/maker/model-driven-apps/control-access-forms#set-the-form-order)

## View and use default components available on enhanced full case form

The following components are available out-of-the box in the enhanced full case form. You can use these components to customize other forms. When you add the components to a form, the runtime experience is as follows:

 :::image type="content" source="media/runtime-exp-mini.png" alt-text="runtime experience for the " lightbox="media/runtime-exp.png":::

|Legend|Component   | Description   | Entity   |  Additional actions| 
|------ |----------|-----------|----------|-----------|
| 1 |**Associated Grid Control** | Displays the relevant records linked to the current record as subgrids. You can configure up to four subgrids using this component. More information: [Configure components to display case associations](add-associated-grid-control.md)| Available for all entities.| Not Applicable. |
| 2 | **Attachment Control** | Enables you to upload and display attachments. The source of the upload can be email, conversation, notes, or direct uploads.| You can use this control to upload and display attachments for case entities only.<br> For all other entities, use this component to display the uploaded attachments. | For a case entity, set the **Table Column** in the component to **Pre Create Entity Attachment Id**. |
| 3| **OptionSet Wrapper** | Displays the selected option set values as color-coded options on the form. For example, if you add **Priority** on a case, the application displays color-coded priority icons. If you add **Case Status**, color-coded status options are displayed.| Available for all entities. | Not Applicable. |
| 4 | **Queue Item Control** |  Displays the current queue a record belongs to and the **Worked by** field. You can edit the **WorkedBy** field and save the changes.| Available for queue enabled entities.| Not Applicable. |
|5 | **Due open activities control** |  Displays the activities that are due today or are overdue. You can select the link to view the activities in the specified tab. More information: [Specify tab to redirect users to view open activities](#specify-tab-to-redirect-users-to-view-open-activities)  | Available for all entities.| - Set **Table** to **Activity**.<br> - Select **Related records** to display only the activities related to the current record.|
| | **Notes Control** | Allows you to take notes on a form before saving a record. The rich text editor tool is enabled by default.| Available for case entities only.| - Set the **Table Column** in the component to **Pre Create Notes Id**. <br> - To configure advanced rich text configurations, specify the **Rich text editor configuration URL**. More information: [Create and use advanced configuration for the rich text editor control](/power-apps/maker/model-driven-apps/rich-text-editor-control#create-and-use-advanced-configuration-for-the-rich-text-editor-control)|


You can add these default components to other forms and customize them. More information: [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form).

## Specify tab to redirect users to view open activities

You can configure the tab agents must be redirected to when they select the open activities link from the **Due open activities control**. You can set this at an environment level or for a specific app.

1. In Power Apps, add the **Due open activities control** component to the required form. More information: More information: [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form).
1. In **Edit Due open activities control** set the **Static value** option to the required tab. To find the tab's name, perform the following steps:
   - Navigate to a form which has the required tab.
   - Select the tab, and then copy the value in **Name** in **Display options**.
1. Select **Publish All Customizations**.

   :::image type="content" source="media/set-open-activities.png" alt-text="Open activities in a new tab" lightbox="media/set-open-activities.png":::


### See also

[Case management in multisession apps](enh-casemgmt-csw.md)   
[Get started with Customer Service workspace](csw-overview.md)
