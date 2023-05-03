---
title: Use the attachment control to customize forms | MicrosoftDocs 
description: Learn about adding attachment control to forms
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 05/04/2023 
ms.custom: bap-template 
---

# Customize forms to view and upload attachments

You can add the **Attachment Control** component to case forms so that agents can view and upload attachments. You can also add the component to other entity forms, such as Account or Contact, so that agents can view attachments uploaded through notes or emails.

> [!NOTE]
> Agents can upload attachments directly only for cases and not on other entities. 

## Upload and view attachments on case forms

If you've enabled the enhanced full case form or added the **Attachment Control** component to other case forms, the following actions are applicable:

- When agents create a new case, and before the case is saved, they can upload attachments to the case. 
    
   :::image type="content" source="media/enh-case-attach-mini.png" alt-text="Enhanced quick case form create" lightbox="media/enh-case-attach.png":::

- After agents save a new case or if they open an existing case, the attachments grid is displayed. For more information on the actions agents can perform, see: [View an existing case using enhanced Full case form](enh-casemgmt-csw.md#view-an-existing-case-using-enhanced-full-case-form).

   :::image type="content" source="media/case-enh-save-mini.png" alt-text="Enhanced quick case form edit" lightbox="media/case-enh-save.png":::

If agents need to upload attachments, follow the steps in [Create or edit a security role to manage access](/power-platform/admin/security-roles-privileges#security-roles-and-the-new-modern-ui-preview) to
grant permissions on the **Entity attachment** custom table to the applicable security role that's assigned to the agent. 

## View attachments on other entity forms

When you add the **Attachment Control** component to other entity forms such as Account or Contact, agents can only view and download attachments that are uploaded through notes or email. They can't upload attachments directly to other entity records. The following actions are applicable:

- Agents can only view attachments for an entity record that's saved. When agents create a new entity record, before they save the record, attachments aren't displayed. The application displays the following message when agents create a new entity record, and haven't saved the record.
    
   :::image type="content" source="media/new-entity-create-mini.png" alt-text=" create record for an entity form" lightbox="media/new-entity-create.png":::

 - After agents save a new record or open an existing record, the attachments grid is displayed as follows:

   :::image type="content" source="media/entity-rec-save.png" alt-text=" edit record for an entity form" lightbox="media/entity-rec-save-mini.png":::

## Customize forms with Attachment Control

On the required form, add the **Attachment Control** component.  More information: [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form). If you add the component to a case form, the following properties are available for further customization:


|Property | Description | 
|------ |----------|
| Table Column | For case forms, set this field to **Pre Create Entity Attachments Id**, for agents to be able to upload attachments to a new case, before they've saved it.<br> For other entity forms this field can be set to any column, as attachments can't be uploaded directly to an entity record. |
| Show Control Title | Displays or hides the **Attachments** label, when a new case is created.|
| Show attachments from Conversation | Set this value to **Yes** or **No** to display or hide the attachments that were shared through conversations such as live chat and asynchronous messaging conversations.|
| Show attachments directly uploaded to entity |  Set this value to **Yes** or **No** to display or hide the attachments that were directly uploaded when the case was created.|  
| Show attachments from email | Set this value to **Yes** or **No** to display or hide the attachments sent through email, for any entity.|  
| Show attachments from notes | Set this value to **Yes** or **No** to display or hide the attachments that were added to notes on the timeline, for any entity.|  

### See also

[Case management in multisession apps](enh-casemgmt-csw.md)   
[Get started with Customer Service workspace](csw-overview.md) 
