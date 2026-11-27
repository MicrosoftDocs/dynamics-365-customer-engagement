---
title: Enable enhanced case forms for multisession apps 
description: Learn how to enable enhanced case forms for multisession apps.
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 11/26/2026
ms.custom: bap-template 
ai-usage: ai-assisted
---

# Enable enhanced case forms for multisession apps

Enable the enhanced **Quick case form** and **Full case form** options to use these forms when customer service representatives (service representatives or representatives) create cases in Copilot Service workspace.

> [!NOTE]
> The enhanced case creation experience is available only in the Copilot Service workspace app.


Watch this video to learn about enhanced case forms and how to set them up.

> [!VIDEO https://www.youtube.com/embed/u9uLwhuv1SA]

## Enable enhanced case experience

1. In Copilot Service admin center, go to **Case Settings**.
1. Select **Manage** for **Enhanced case experience**.
1. Set the **Enhanced case experience** toggle to **Yes**.
   - To enable the enhanced full case form:
      1. Set the **Full case form** toggle to **Yes** to show the enhanced full case form when representatives create a case. To also show it when representatives open an existing case, set it as the [default form](/power-apps/maker/model-driven-apps/control-access-forms#set-the-form-order).
      1. Select **Configure** to [customize the form in Power Apps](/power-apps/maker/model-driven-apps/create-and-edit-forms). The form opens in a new tab.
   - To enable the enhanced quick case form:
      1. Set the **Quick case form** toggle to **Yes**.
      1. Select a form in the **Choose Form** dropdown list. The selected main form appears in a side pane when a representative creates a case. The default is **Enhanced quick case form**.
      1. Select **Configure** to [customize the form in Power Apps](/power-apps/maker/model-driven-apps/create-and-edit-forms). The form opens in a new tab.

   :::image type="content" source="../media/settings-enh-case-channel.png" alt-text="Default main case form" lightbox="../media/settings-enh-case-channel.png":::

> [!NOTE]
> - If the enhanced full case form has a higher form order than the default case form, representatives might see the enhanced full case form even if you haven't enabled the enhanced case experience. If you'd like representatives to see the default case experience, set the form order of the enhanced form lower than that of the default form. Learn more in [Set the form order](/power-apps/maker/model-driven-apps/control-access-forms#set-the-form-order).
> - The [enhanced case form](../use/enh-casemgmt-csw.md#view-an-existing-case-by-using-the-enhanced-full-case-form) displays customer details and recent cases in the customer details pane. If you switch to another form, the pane doesn't refresh or close automatically. Close it manually.

## View default components available on enhanced full case form

The following image shows the default components in the enhanced full case form at runtime. You can also use these components to customize other forms.

> [!NOTE]
> - In the **Case for multisession experience** form, which is the default case form for Copilot Service workspace, **OptionSet Wrapper**, **Queue Item Control**, **Due open activities control**, and **Attachment Control** components are enabled by default.
> - Learn how these components appear on the **Case for multisession experience** form in [Default main case form: Case](../use/enh-casemgmt-csw.md#create-a-case-from-the-main-case-form).



 :::image type="content" source="../media/runtime-exp-mini.png" alt-text="Screenshot of the enhanced full case form." lightbox="../media/runtime-exp.png":::

Legend:

| Number | Component | Description | Entity | Additional actions | Additional information |
| ------ | --------- | ----------- | ------ | ------------------ | ---------------------- |
| 1 |**Associated Grid Control** | Displays the relevant records linked to the current record as subgrids. You can configure up to four subgrids using this component.| Available for all entities.| Not Applicable. | [Configure components to display case associations](add-associated-grid-control.md)|
| 2 | **Attachment Control** | Enables you to upload and display attachments. | You can add this control on a case form to upload attachments to a case and to display attachments uploaded directly, through email, notes, and conversations.<br> For all other entities, add this component to display the attachments uploaded through email and notes. | For a case entity, set the **Table Column** in the component to **Pre Create Entity Attachment Id**. |[Use Attachment Control to customize forms](add-attachment-control.md)|
| 3 | **OptionSet Wrapper** | Displays selected option set values as color-coded options. For example, **Priority** displays color-coded priority icons, and **Case Status** displays color-coded status options. | Available for all entities. Add this component to choice or option set fields, but not to noneditable fields or fields that don't support option sets, such as single line of text. | Specify the required option set in **Table Column**. | |
| 4 | **Queue Item Control** | Displays the queue a record belongs to and the **Worked by** field. You can edit **Worked by** and save your changes. | Available for queue-enabled entities. | Specify a value in **Table Column**. | |
|5 | **Due open activities control** |  Displays the activities that are due today or are overdue. | Available for all entities.| **Table** must be set to **Activities**.|[Use the Due open activities control to customize forms](add-due-open-activities.md) |
| | **Notes Control** | Allows you to take notes on a form before saving a record. The rich text editor tool is enabled by default.| Available for case entity only.| - Set the **Table Column** in the component to **Pre Create Notes Id**. <br> - To configure advanced rich text configurations, specify the **Rich text editor configuration URL**. Learn more in [Create and use advanced configuration for the rich text editor control](/power-apps/maker/model-driven-apps/rich-text-editor-control#create-and-use-advanced-configuration-for-the-rich-text-editor-control)| |


You can add these default components to other forms and customize them. Learn more in [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form).


## Related information

[Case management in multisession apps](../use/enh-casemgmt-csw.md)<br>
[Get started with Copilot Service workspace](../implement/csw-overview.md)
