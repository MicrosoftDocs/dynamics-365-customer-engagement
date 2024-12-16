---
title: Use the attachment control to customize forms 
description: Learn about adding attachment control to forms.
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 08/29/2024 
ms.custom: bap-template 
---

# Use the attachment control to customize forms

You can add the **Attachment Control** component to case forms so that customer service representatives (service representatives or representatives) can view and upload attachments. You can also add the component to other entity forms, such as Account or Contact, so that representatives can view attachments uploaded through notes or emails.

> [!NOTE]
> Representatives can upload attachments directly only for cases and not on other entities. 

## Upload and view attachments on case forms

If you've enabled the enhanced full case form or added the **Attachment Control** component to other case forms, the following actions are applicable:

- When representatives create a new case, and before the case is saved, they can upload attachments to the case. 
    
   :::image type="content" source="../media/enh-case-attach-mini.png" alt-text="Enhanced quick case form create" lightbox="../media/enh-case-attach.png":::

- After representatives save a new case or if they open an existing case, the attachments grid is displayed. Learn more about the actions representatives can perform at [View an existing case using enhanced Full case form](../use/enh-casemgmt-csw.md#view-an-existing-case-by-using-the-enhanced-full-case-form).

   :::image type="content" source="../media/case-enh-save-mini.png" alt-text="Enhanced quick case form edit" lightbox="../media/case-enh-save.png":::

If representatives need to upload attachments, follow the steps in [Create or edit a security role to manage access](/power-platform/admin/security-roles-privileges#security-roles-and-the-new-modern-ui-preview) to
grant permissions on the **Entity attachment** custom table to the applicable security role that's assigned to the representative. 

## View attachments on other entity forms

When you add the **Attachment Control** component to other entity forms such as Account or Contact, representatives can only view and download attachments that are uploaded through notes or email. They can't upload attachments directly to other entity records. The following actions are applicable:

- Representatives can only view attachments for an entity record that's saved. When representatives create a new entity record, before they save the record, attachments aren't displayed. The application displays the following message when representatives create a new entity record, and haven't saved the record.
    
   :::image type="content" source="../media/new-entity-create-mini.png" alt-text=" create record for an entity form" lightbox="../media/new-entity-create.png":::

 - After representatives save a new record or open an existing record, the attachments grid is displayed as follows:

   :::image type="content" source="../media/entity-rec-save.png" alt-text=" edit record for an entity form" lightbox="../media/entity-rec-save-mini.png":::

## Customize forms with Attachment Control

On the required form, add the **Attachment Control** component.  More information: [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form). If you add the component to a case form, the following properties are available for further customization:


|Property | Description | 
|------ |----------|
| Table Column | For case forms, set this field to **Pre Create Entity Attachments Id**, for representatives to be able to upload attachments to a new case, before they've saved it.<br> For other entity forms this field can be set to any column, as attachments can't be uploaded directly to an entity record. |
| Show Control Title | Displays or hides the **Attachments** label, when a new case is created.|
| Show attachments from Conversation | Set this value to **Yes** or **No** to display or hide the attachments that were shared through conversations such as live chat and asynchronous messaging conversations.|
| Show attachments directly uploaded to entity |  Set this value to **Yes** or **No** to display or hide the attachments that were directly uploaded when the case was created.|  
| Show attachments from email | Set this value to **Yes** or **No** to display or hide the attachments sent through email, for any entity.|  
| Show attachments from notes | Set this value to **Yes** or **No** to display or hide the attachments that were added to notes on the timeline, for any entity.|  

### Related information

[Case management in multisession apps](../use/enh-casemgmt-csw.md)   
[Get started with Customer Service workspace](../implement/csw-overview.md) 

