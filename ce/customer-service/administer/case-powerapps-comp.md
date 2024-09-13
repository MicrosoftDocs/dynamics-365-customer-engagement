---
title: Adding PowerApps components in Customer Service workspace 
description: Learn about adding the applicable PowerApps components to Case Management forms.
author: gandhamm 
ms.author: v-slaik
ms.reviewer: neeranelli 
ms.topic: how-to 
ms.date: 09/12/2024
ms.custom: bap-template 
---

# Adding PowerApp components to Case Management forms

You can use the collection of PowerApp components to customize your case management forms and add the additional functionalities that agents can use when handling cases in Customer Service workspace.

> [!NOTE]
> The functionality of a PowerApps component is applicable to the availability of that feature in your Customer Service workspace app.

To view and use the default components available on the enhanced full case form, see [Enable enhanced case forms for multisession apps](case-enh-config.md).

The table below shows all the PowerApps components, along with other details, which are available for customizing your forms in the Customer Service workspace.

|Number|Component   | Description   | Entity   |  Additional actions| Additional information|
|------ |----------|-----------|----------|-----------|
| 1 |**status reason transitions** | Allows agents to enter and update case status.| Available for all entities.| Not Applicable. | [Define status reason transitions for case management](define-status-reason-transitions-case-management.md)|
| 2 | **Attachment Control** | Enables you to upload and display attachments. | You can add this control on a case form to upload attachments to a case and to display attachments uploaded directly, through email, notes, and conversations.<br> For all other entities, add this component to display the attachments uploaded through email and notes. | For a case entity, set the **Table Column** in the component to **Pre Create Entity Attachment Id**. |[Use Attachment Control to customize forms](add-attachment-control.md)|
| 3| **OptionSet Wrapper** | Displays the selected option set values as color-coded options on the form. For example, if you add **Priority** on a case, the application displays color-coded priority icons. If you add **Case Status**, color-coded status options are displayed.| Available for all entities. You can add this component to choices or option set field types but not to non editable fields or fields that don't support option set type, such as single line of text. | Specify the required option set in **Table Column**.| 
| 4 | **Queue Item Control** |  Displays the current queue a record belongs to and the **Worked by** field. You can edit the **Worked by** and save the changes.| Available for queue enabled entities. | Specify a value in **Table Column**.| |
|5 | **Due open activities control** |  Displays the activities that are due today or are overdue. | Available for all entities.| **Table** must be set to **Activities**.|[Use the Due open activities control to customize forms](add-due-open-activities.md) |
| | **Notes Control** | Allows you to take notes on a form before saving a record. The rich text editor tool is enabled by default.| Available for case entity only.| - Set the **Table Column** in the component to **Pre Create Notes Id**. <br> - To configure advanced rich text configurations, specify the **Rich text editor configuration URL**. More information: [Create and use advanced configuration for the rich text editor control](/power-apps/maker/model-driven-apps/rich-text-editor-control#create-and-use-advanced-configuration-for-the-rich-text-editor-control)| |


You can add these default components to other forms and customize them. More information: [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form).


### Related information

