---
title: Use the attachment control to customize forms | MicrosoftDocs 
description: Learn about adding attachment control to forms
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 04/28/2023 
ms.custom: bap-template 
---

# Use Attachment Control to customize forms

You can add the **Attachment Control** component to case forms and other entity forms. Agents can either upload and view attachments, or only view attachments based on the entity form you add this component to.

### Upload and view attachments on case forms

If you add the **Attachment Control** component to a case form, the following actions are applicable:

- When an agent creates a new case, before the case is saved, the **Attachments** grid is displayed. Agents can upload attachments on this grid.
- When agents save a new case, the **Attachments** tab is displayed. For more information on the runtime experience, see: [View an existing case using enhanced Full case form](enh-casemgmt-csw.md#view-an-existing-case-using-enhanced-full-case-form).

> [!NOTE]
> If agents have to add attachments, ensure that you grant the required privileges to the security roles as applicable, for the **Entity attachment** custom entity. More information: [Create or edit a security role to manage access](/power-platform/admin/create-edit-security-role#create-a-security-role).

### View attachments on other entity forms

When you add the **Attachment Control** component to other entity forms such as Account or Customer,for an existing record, agents can view and download the attachments uploaded through notes and email on the **Attachments** tab.

## Customize forms with Attachment Control

On the required form, add the **Attachment Control** component.  More information: [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form). If you add the component to a case form, the following properties are available for further customization:


|Property | Description | 
|------ |----------|
| Table Column | The column the component is bound to.<br> For case forms, set this field to **Pre Create Entity Attachments Id**<br> For other entity forms, this field can be set to any column. |
| Show Control Title | Displays or hides the **Attachments** label on the Case page when a new case is created.|
| Show attachments from Conversation | Set this value to **Yes** or **No** to display or hide the attachments that were shared through conversations, for an existing case or a new case that's been saved.|
| Show attachments directly uploaded to entity |  Set this value to **Yes** or **No** to display or hide the attachments that were directly uploaded when the case was created, for an existing case or a new case that's been saved.|  
| Show attachments from email | Set this value to **Yes** or **No** to display or hide the attachments sent through email, for any entity.|  
| Show attachments from notes | Set this value to **Yes** or **No** to display or hide the attachments that were added to notes on the timeline, for any entity.|  

### See also

[Case management in multisession apps](enh-casemgmt-csw.md)   
[Get started with Customer Service workspace](csw-overview.md) 
