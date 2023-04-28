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

The **Attachment Control** is available out-of-the box on the enhanced full case form and helps agents perform the following actions:

- Upload and view attachments linked to the case on the Attachment tab. Agents can upload upto ten attachments at once.
- See the source of the attachment such as direct upload, attachments uploaded through notes or shared through conversation and the user who uploaded the attachments.
- Search for attachments
- Sort and filter attachments based on Name, Size, Uploaded on, Uploaded by, and Source.
- Select the attachment to preview the content of the attachment. This is only supported for pdf and image files.
- Download and delete multiple attachments at once. You can delete only those attachments that have Source set to Direct Upload.

When this component is added to other entity forms, agents can only view the attachments that're uploaded.

## Customize forms with Attachment Control

You can customize other forms to display the due or overdue activities by performing the following steps:

1. In Power Apps, add the **Attachment Control** component to the required form. More information: More information: [Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form).
1.  In **Properties** specify the following:
    - **Table column**: You must set this value to **Pre Create Entity Attachments Id**.
    - Select the **Show related records** to display only the activities related to the current record.
1. Save and publish the customizations.

### See also

[Case management in multisession apps](enh-casemgmt-csw.md)   
[Get started with Customer Service workspace](csw-overview.md) 
