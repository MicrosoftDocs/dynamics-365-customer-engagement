---
title: Enable enhanced case forms for multisession apps 
description: Learn about enabling the enhanced case forms for multisession apps.
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli 
ms.topic: how-to 
ms.date: 08/02/2024
ms.custom: bap-template 
---

# Enable enhanced case forms for multisession apps

Enable the enhanced **Quick case form** and **Full case form**  options so that the enhanced quick case form and full case form open when agents create a new case in Customer Service workspace.

> [!NOTE]
> The enhanced case creation experience is available only in the Customer Service workspace app.

Watch this video to understand enhanced case form and how to set it up.

> [!VIDEO https://www.youtube.com/embed/u9uLwhuv1SA]

## Enable enhanced case experience

To enable the enhanced case forms, follow these steps:

1. In Customer Service admin center, go to **Case Settings**.
1. Select **Manage** for **Enhanced case experience**.
1. Switch the **Enhanced case experience** toggle to **Yes**.
   - To enable the enhanced full case form:
      1. Set the **Full case form** toggle to **Yes**, for your agents to see the enhanced full case form when they create a new case. Additionally, if agents should see the enhanced case form when they access an existing case, set the enhanced case form as the [default form](/power-apps/maker/model-driven-apps/control-access-forms#set-the-form-order).
      1. Select **Configure** to [customize the form in Power Apps](/power-apps/maker/model-driven-apps/create-and-edit-forms). The Power Apps form page opens on a new tab. 
   - To enable the enhanced quick case form:
      1. Switch the **Quick case form** toggle to **Yes**.
      1. Select the option in the **Choose Form** dropdown. The selected main form appears as the side pane when the agent creates a new case. By default, this is set to **Enhanced quick case form**. 
      1. Select **Configure** to [customize the form in Power Apps](/power-apps/maker/model-driven-apps/create-and-edit-forms). The Power Apps form page opens on a new tab.

   :::image type="content" source="../media/settings-enh-case-channel.png" alt-text="Default main case form" lightbox="../media/settings-enh-case-channel.png":::

> [!NOTE]
> - If the enhanced full case form has a higher form order than the default case form, agents might see the enhanced full case form even if you haven't enabled the enhanced case experience. If you'd like agents to see the default case experience, set the form order of the enhanced form lower than that of the default form. More information: [Set the form order](/power-apps/maker/model-driven-apps/control-access-forms#set-the-form-order).
> -  The **Enhanced case form** option is available in the form selector by default as an early access feature. Use this option to navigate from the enhanced case form to any other form. You can opt in early to enable these features in your environment, which will allow you to test these features and then adopt them across your environments. For information about how to enable these features, see [Opt in to early access updates](/power-platform/admin/opt-in-early-access-updates). If you haven't opted in, ensure that the **ShowInFormSelector** is set to **True** through FormXML to see the **Enhanced case form** option.
>     - The [enhanced case form](../use/enh-casemgmt-csw.md#view-an-existing-case-by-using-the-enhanced-full-case-form) displays customer details and recent cases on the customer details pane. When you switch to any other form from the enhanced case form, the pane isn't automatically refreshed or closed. You need to close it manually. 

## Case for multisession experience

If you [opt in](/power-platform/admin/opt-in-early-access-updates) to the early access features, the **Case for multisession experience** form, which is the default case form for Customer Service workspace, has the following components enabled by default: 

   - **OptionSet Wrapper**
   - **Queue Item Control**
   - **Due open activities control**
   - **Notes Control**
   - **Attachment Control**: Displays the attachments that are linked to the case by default. If you want agents to upload attachments and do other actions, perform the steps in [Use attachment control](add-attachment-control.md)

You can learn more about how these components are displayed on the **Case for multisession experience** form realtime in [Default main case form: Case](../use/enh-casemgmt-csw.md#create-a-case-from-the-main-case-form) section.

## View and use default components available on enhanced full case form

The following components are available by default in the enhanced full case form. You can use these components to customize other forms. When you add the components to a form, the runtime experience is as follows:

 :::image type="content" source="../media/runtime-exp-mini.png" alt-text="screenshot for enhanced full case form " lightbox="../media/runtime-exp.png":::

Legend:

|Number|Component   | Description   | Entity   |  Additional actions| Additional information|
|------ |----------|-----------|----------|-----------|
| 1 |**Associated Grid Control** | Displays the relevant records linked to the current record as subgrids. You can configure up to four subgrids using this component.| Available for all entities.| Not Applicable. | [Configure components to display case associations](add-associated-grid-control.md)|
| 2 | **Attachment Control** | Enables you to upload and display attachments. | You can add this control on a case form to upload attachments to a case and to display attachments uploaded directly, through email, notes, and conversations.<br> For all other entities, add this component to display the attachments uploaded through email and notes. | For a case entity, set the **Table Column** in the component to **Pre Create Entity Attachment Id**. |[Use Attachment Control to customize forms](add-attachment-control.md)|
| 3| **OptionSet Wrapper** | Displays the selected option set values as color-coded options on the form. For example, if you add **Priority** on a case, the application displays color-coded priority icons. If you add **Case Status**, color-coded status options are displayed.| Available for all entities. You can add this component to choices or option set field types but not to non editable fields or fields that don't support option set type, such as single line of text. | Specify the required option set in **Table Column**.| 
| 4 | **Queue Item Control** |  Displays the current queue a record belongs to and the **Worked by** field. You can edit the **Worked by** and save the changes.| Available for queue enabled entities. | Specify a value in **Table Column**.| |
|5 | **Due open activities control** |  Displays the activities that are due today or are overdue. | Available for all entities.| **Table** must be set to **Activities**.|[Use the Due open activities control to customize forms](add-due-open-activities.md) |
| | **Notes Control** | Allows you to take notes on a form before saving a record. The rich text editor tool is enabled by default.| Available for case entity only.| - Set the **Table Column** in the component to **Pre Create Notes Id**. <br> - To configure advanced rich text configurations, specify the **Rich text editor configuration URL**. More information: [Create and use advanced configuration for the rich text editor control](/power-apps/maker/model-driven-apps/rich-text-editor-control#create-and-use-advanced-configuration-for-the-rich-text-editor-control)| |


You can add these default components to other forms and customize them. More information: [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form).


### Related information

[Case management in multisession apps](../use/enh-casemgmt-csw.md)<br>
[Get started with Customer Service workspace](../implement/csw-overview.md)
