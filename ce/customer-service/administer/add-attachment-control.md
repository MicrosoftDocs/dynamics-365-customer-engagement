---
title: Use the attachment control to customize forms 
description: Learn how to add the attachment control to forms in Dynamics 365 Customer Service.
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 11/26/2026
ms.custom: bap-template 
ai-usage: ai-assisted
---

# Use the attachment control to customize forms

Add the **Attachment Control** component to case forms so customer service representatives (service representatives or representatives) can view and upload attachments. On other entity forms, such as Account or Contact, representatives can view attachments uploaded through notes or email.

> [!NOTE]
> Representatives can upload attachments directly to cases only, not to other entities.

## Upload and view attachments on case forms

When you enable the enhanced full case form or add the **Attachment Control** component to another case form:

- Representatives can upload attachments when they create a case, before saving it.
    
   :::image type="content" source="../media/enh-case-attach-mini.png" alt-text="Enhanced quick case form create" lightbox="../media/enh-case-attach.png":::

- The attachments grid appears after representatives save a new case or open an existing case. Learn more in [View an existing case using the enhanced full case form](../use/enh-casemgmt-csw.md#view-an-existing-case-by-using-the-enhanced-full-case-form).

   :::image type="content" source="../media/case-enh-save-mini.png" alt-text="Enhanced quick case form edit" lightbox="../media/case-enh-save.png":::

To let representatives upload attachments, grant their security role permissions on the **Entity attachment** custom table. Follow the steps in [Create or edit a security role to manage access](/power-platform/admin/security-roles-privileges#security-roles-and-the-new-modern-ui-preview).

## View attachments on other entity forms

On other entity forms, such as Account or Contact, representatives can view and download attachments uploaded through notes or email. They can't upload attachments directly to these records.

- Attachments appear only for saved records. For an unsaved record, the application displays the following message.
    
   :::image type="content" source="../media/new-entity-create-mini.png" alt-text=" create record for an entity form" lightbox="../media/new-entity-create.png":::

- After representatives save a new record or open an existing record, the attachments grid appears.

   :::image type="content" source="../media/entity-rec-save.png" alt-text=" edit record for an entity form" lightbox="../media/entity-rec-save-mini.png":::

## Customize forms with Attachment Control

Add the **Attachment Control** component to the form. Learn more in [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form). If you add the component to a case form, you can configure the following properties:


|Property | Description | 
|------ |----------|
| Table Column | For case forms, set this field to **Pre Create Entity Attachments Id** so representatives can upload attachments before saving a new case.<br>For other entity forms, select any column. Attachments can't be uploaded directly to these records. |
| Show Control Title | Displays or hides the **Attachments** label when a new case is created. |
| Show attachments from Conversation | Set to **Yes** or **No** to display or hide attachments shared through live chat and asynchronous messaging conversations. |
| Show attachments directly uploaded to entity | Set to **Yes** or **No** to display or hide attachments uploaded directly when the case was created. |
| Show attachments from email | Set to **Yes** or **No** to display or hide attachments sent through email for any entity. |
| Show attachments from notes | Set to **Yes** or **No** to display or hide attachments added to timeline notes for any entity. |

## Related information

[Case management in multisession apps](../use/enh-casemgmt-csw.md)   
[Get started with Copilot Service workspace](../implement/csw-overview.md) 

