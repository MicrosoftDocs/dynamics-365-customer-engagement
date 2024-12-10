---
title: Add Power Apps components to case management forms 
description: Learn how to add the right Power Apps components to case management forms.
author: gandhamm 
ms.author: v-slaik
ms.reviewer: neeranelli 
ms.topic: conceptual 
ms.date: 12/05/2024
ms.custom: bap-template 
---

# Add Power Apps components to case forms

You can customize case forms in the Customer Service workspace using the default Power Apps components. Learn more at [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form)


The following tables lists the components that can be added to case forms and the behavior in real-time.

|Number |Component |Description |Entity |Additional actions |Additional information|
|-------|----------|------------|-------|-------------------|----------------------|
|1 |**Status reason transitions** |This component allows you to define what the status reason value can be changed to, for each status reason. | Available for all entities. | Applicable. |[Define status reason transitions for case management](define-status-reason-transitions-case-management.md)|
|2 |**Customer 360** |The Customer 360 component enables agents to view customer details for a case as a card on the form. | Available for all entities. | Applicable. | [Configure components to display customer details and recent records](add-display-components-to-case-form.md)| 
|3 |**Recent records** |This component allows agents to view and access related customer records for a case as a card on the form. |Available for all entities. |Not applicable |[Configure components to display customer details and recent records](add-display-components-to-case-form.md)|
|4 |**Case handling time widget** |Agents can see the case handling time widget on the form. |Available for all entities. |Not applicable. |[Configure case handling time widget to case forms](add-case-handling-time.md)|  
|5 |**Redirect user to the specified tab to close open activities** |Allows to redirect agents to a custom tab for closing open activities related to a case. |Available for all entities. |Applicable. |[Customize the case resolution experience](add-enhanced-case-management.md)|    
|6 |**Enable minimal case resolution dialog** |This component allows to display the legacy case resolution dialog box. |Available for all entities. |Applicable. |[Customize the case resolution experience](add-enhanced-case-management.md)|   
|7 |**Power Apps grid control** |This component allows multiple customization options, such as inline edits, to manage option set colors, and to revert to legacy grids. |Available for all entities. |Applicable |[Enable case grids](enable-case-grids.md)|
|8 |**Configure property Enable Editing** |Allows agents to perform inline edits and update data for columns in the view. Inline editing for the **Status reason** column isn't supported. |Available for all entities. |Applicable |[Enable case grids](enable-case-grids.md)|
|9 |**Enable OptionSet colors** |Allows to customize and choose the color of the text values to make them readable. |Available for all entities. |Applicable |[Enable case grids](enable-case-grids.md)|


## Default components available on enhanced full case form

You can use the following components that are available by default on the [Enhanced full case form](case-enh-config.md#view-default-components-available-on-enhanced-full-case-form) to customize other forms.

|Number | Component | Description | Entity | Additional actions | Additional information|
|------ | --------- | ----------- | ------ | ------------------ | ----------------------|
|1 | **Associated Grid Control** | Displays the relevant records linked to the current record as subgrids. You can configure up to four subgrids using this component. | Available for all entities | Not applicable | [Configure components to display case associations](add-associated-grid-control.md)|
|2 | **Attachment Control** | Enables you to upload and display attachments. | You can add this control on a case form to upload attachments to a case and to display attachments uploaded directly, through email, notes, and conversations.<br> For all other entities, add this component to display the attachments uploaded through email and notes. | For a case entity, set the **Table Column** in the component to **Pre Create Entity Attachment Id**. | [Use Attachment Control to customize forms](add-attachment-control.md)|
|3| **OptionSet Wrapper** | Displays the selected option set values as color-coded options on the form. For example, if you add **Priority** on a case, the application displays color-coded priority icons. If you add **Case Status**, color-coded status options are displayed. | Available for all entities. You can add this component to choices or option set field types but not to non editable fields or fields that don't support option set type, such as single line of text. | Specify the required option set in **Table Column**.| Not applicable|
|4 | **Queue Item Control** |  Displays the current queue a record belongs to and the **Worked by** field. You can edit the **Worked by** and save the changes. | Available for queue enabled entities. | Specify a value in **Table Column**.| Not applicable |
|5 | **Due open activities control** |  Displays the activities that are due today or are overdue. | Available for all entities. | **Table** must be set to **Activities**. | [Use the Due open activities control to customize forms](add-due-open-activities.md) |
|6 | **Notes Control** | Allows you to take notes on a form before saving a record. The rich text editor tool is enabled by default.| Available for case entity only. | - Set the **Table Column** in the component to **Pre Create Notes Id**. <br> - To configure advanced rich text configurations, specify the **Rich text editor configuration URL**. Learn more in [Create and use advanced configuration for the rich text editor control](/power-apps/maker/model-driven-apps/rich-text-editor-control#create-and-use-advanced-configuration-for-the-rich-text-editor-control) |


### Related information

[Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form)

[Enable enhanced case forms for multisession apps](case-enh-config.md)