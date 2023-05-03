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

## Upload and view attachments on case forms

If you've enabled the enhanced full case form or added the **Attachment Control** component to other case forms , the following actions are applicable:

   ### [Create workflow: Case](#tab/createacase)

   When agents create a new case, and before the case is saved, they can upload attachments to the case.
    
   :::image type="content" source="media/enh-case-attach-mini.png" alt-text="Enhanced quick case form create" lightbox="media/enh-case-attach.png":::

   ### [Edit workflow: Case](#tab/quickcreateform)

   After agents save a new case or if they open an existing case, the attachments grid is displayed. For more information on the actions agents can perform on this tab in runtime, see: [View an existing case using enhanced Full case form](enh-casemgmt-csw.md#view-an-existing-case-using-enhanced-full-case-form).

   :::image type="content" source="media/case-enh-save-mini.png" alt-text="Enhanced quick case form edit" lightbox="media/case-enh-save.png":::

---

> [!NOTE]
> If agents have to add attachments, ensure that you grant the required privileges to the security roles as applicable, for the **Entity attachment** custom entity. More information: [Create or edit a security role to manage access](/power-platform/admin/create-edit-security-role#create-a-security-role).

## View attachments on other entity forms

When you add the **Attachment Control** component to other entity forms such as Account or Customer, agents can only view and download attachments. The following actions are applicable:

   ### [Create workflow: other entities](#tab/createacase)

   Agents can only view attachments for an entity record that's saved. When agents create a new entity record, before they save the record, attachments aren't displayed or can't be uploaded directly to the record.
    
   :::image type="content" source="media/new-entity-create-mini.png" alt-text=" create record for an entity form" lightbox="media/new-entity-create.png":::

   ### [Edit workflow: other entities](#tab/quickcreateform)

   After agents save a new record or open an existing record, the attachments grid is displayed. Agents can only view and download the attachments uploaded through notes and email related to that entity.

   :::image type="content" source="media/entity-rec-save.png" alt-text=" edit record for an entity form" lightbox="media/entity-rec-save-mini.png":::

---

## Customize forms with Attachment Control

On the required form, add the **Attachment Control** component.  More information: [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form). If you add the component to a case form, the following properties are available for further customization:


|Property | Description | 
|------ |----------|
| Table Column | The column the component is bound to.<br> For case forms, set this field to **Pre Create Entity Attachments Id**, for agents to be able to upload attachments when a new case is created and before it's saved.<br> For other entity forms, this field can be set to any column, as attachments can't be uploaded to an entity record. |
| Show Control Title | Displays or hides the **Attachments** label on the Case page when a new case is created.|
| Show attachments from Conversation | Set this value to **Yes** or **No** to display or hide the attachments that were shared through conversations, for an existing case or a new case that's been saved.|
| Show attachments directly uploaded to entity |  Set this value to **Yes** or **No** to display or hide the attachments that were directly uploaded when the case was created, for an existing case or a new case that's been saved.|  
| Show attachments from email | Set this value to **Yes** or **No** to display or hide the attachments sent through email, for any entity.|  
| Show attachments from notes | Set this value to **Yes** or **No** to display or hide the attachments that were added to notes on the timeline, for any entity.|  

### See also

[Case management in multisession apps](enh-casemgmt-csw.md)   
[Get started with Customer Service workspace](csw-overview.md) 
