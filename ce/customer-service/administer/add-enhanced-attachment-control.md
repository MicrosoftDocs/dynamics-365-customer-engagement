---
title: Enable enhanced experience for email attachments
description: Enable enhanced email attachment control for agents to have a consistent experience across all forms. 
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection:
ms.date: 05/23/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:12/01/2023
  - ai-gen-desc
---

# Enable enhanced experience for email attachments

Enhanced email components enable you to streamline the email experience for agents. Use the information in this article to configure **Email Recipient control** and **Attachments control** to improve agent productivity.

## Enable enhanced experience for email attachments

You can enable the enhanced email attachment control for forms to provide a consistent email attachment experience to agents. Do the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**> **Email**> **Forms** and then select the required form.
1.  Add **Attachments control** to **Components** in the **Attachment** subgrid properties. Learn more at [add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form#add-components-for-a-column-on-the-form).
1. Save and publish the form.

## Enable drag and drop for attachments in the rich text editor

You can enable the drag and drop feature for files to be added as attachments for the rich text editor. Do the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**> **Email**> **Forms** and then select the required form.
1. Select **Email body** > **Components** > **Rich Text Editor Control** and then edit **Custom Configuration URL** to add the following configuration:
     
     ```
        "base64FileUploader":true,
        "attachmentEntity": {
        "tableName": "activitymimeattachments",
        "contentColumn": "body",
        "fileNameColumn": "filename",
        "mimeTypeColumn": "mimetype",
        "objectTypeCodeColumn": "objecttypecode",
        "relatedEntityName": "emails",
        "relatedFieldName": "objectid_email"
        }    

     ```
   Learn more at [customize the rich text editor control](/power-apps/maker/model-driven-apps/rich-text-editor-control#customize-the-rich-text-editor-control).<br>

1. Save and publish the form.

## Delete attachment for completed emails

You can enable representatives to delete attachments from sent emails by performing the following steps.

- In the [Power Apps home page](https://make.powerapps.com), select **Tables** > **Email**. 
- Select **Forms** and select the required form.
- Select the **Attachments control** component. In Properties, set the **Make Delete visible to users** value to **True**.
- Select **Done**.
- Save and publish the changes.

:::image type="Delete email attachment." source="../media/delete-email-attachments.png" alt-text="Delete email attachment for a completed email." lightbox="../media/delete-email-attachments.png":::

## Next steps

[Enhanced recipient handling](/power-apps/user/view-compose-email#enhanced-recipient-handling)

[Use the enhanced email attachment experience across email forms](../use/enhanced-email-attachment-control.md)
