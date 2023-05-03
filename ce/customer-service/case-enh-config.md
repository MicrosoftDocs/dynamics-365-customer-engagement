---
title: Enable enhanced case forms for multisession apps | MicrosoftDocs 
description: Learn about enabling the enhanced case forms for multisession apps.
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 05/03/2023 
ms.custom: bap-template 
---

# Enable enhanced case forms for multisession apps

Enable the enhanced **Quick case form** and **Full case form**  options, so that your agents can see the enhanced quick case form and full case form, when they create a new case in Customer Service workspace.

> [!NOTE]
> The enhanced case creation experience is available only in the Customer Service workspace app only.

## Enable enhanced case experience
To enable the enhanced case forms, perform the following steps:

1. In Customer Service admin center, go to **Case Settings**.
1. Select **Manage** for **Enhanced case experience**.
1. Switch the **Enhanced case experience** toggle to **Yes**.
   - To enable the enhanced full case form:
      1. Set the **Full case form** toggle to **Yes**, for your agents to see the enhanced full case form. 
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
| 2 | **Attachment Control** | Enables you to upload and display attachments. More information: [Use Attachment Control to customize forms](add-attachment-control.md)| You can use this control to upload and display attachments for case entities only.<br> For all other entities, use this component to display the uploaded attachments. | For a case entity, set the **Table Column** in the component to **Pre Create Entity Attachment Id**. |
| 3| **OptionSet Wrapper** | Displays the selected option set values as color-coded options on the form. For example, if you add **Priority** on a case, the application displays color-coded priority icons. If you add **Case Status**, color-coded status options are displayed.| Available for all entities. | Specify the required optionset in **Table Column**.|
| 4 | **Queue Item Control** |  Displays the current queue a record belongs to and the **Worked by** field. You can edit the **Worked by** and save the changes.| Available for queue enabled entities.| Specify a value in **Table Column**.|
|5 | **Due open activities control** |  Displays the activities that are due today or are overdue. More information: [Use the Due open activities control to customize forms](add-due-open-activities.md)  | Available for all entities.| **Table** must be set to **Activities**.|
| | **Notes Control** | Allows you to take notes on a form before saving a record. The rich text editor tool is enabled by default.| Available for case entities only.| - Set the **Table Column** in the component to **Pre Create Notes Id**. <br> - To configure advanced rich text configurations, specify the **Rich text editor configuration URL**. More information: [Create and use advanced configuration for the rich text editor control](/power-apps/maker/model-driven-apps/rich-text-editor-control#create-and-use-advanced-configuration-for-the-rich-text-editor-control)|


You can add these default components to other forms and customize them. More information: [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form).


### See also

[Case management in multisession apps](enh-casemgmt-csw.md)   
[Get started with Customer Service workspace](csw-overview.md)
