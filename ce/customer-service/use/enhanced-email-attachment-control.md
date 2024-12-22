---
title: Use enhanced experience to attach files to emails
description: View and manage attachments with ease using the enhanced email attachment experience for forms. 
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 01/12/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:12/01/2023
  - ai-gen-desc
---

# Use enhanced experience to attach files to emails

When you're composing an email, you can drag files and add them as attachments and copy attachments from one email to another.

## Prerequisites

Your administrator has enabled the enhanced attachment control.

## Use the enhanced experience to attach files
 
Perform the following actions using the enhanced email attachment control:

- Add files.
- Select the dropdown to add existing attachments from previous emails. In the **Select attachment** window, you can perform the following actions: 
  - Select the required attachments.  
  - Select the attachment link to preview it in the Attachment preview popup. 
  - Search for attachments by attachment name.  
- Drag files to the attachment control, email body, or rich text editor to be added as attachments. When you drag image files to rich text editor, they're added as inline images.
- Select **Flows** to create and select your existing flows. 
- Export attachments that you uploaded. The .csv file contains the name and size of the attachments. 
- View the size of the uploaded attachment in the nearest unit of its size.
- Hover over the attachment to download, delete, or select an attachment.
- Select the file to launch the preview. Preview is available only for image and pdf attachments.
- Switch between the grid and list views.
- Select all the attachments.
- Copy multiple attachments from various emails and paste them into a single email. When you copy multiple attachments, the application displays a notification with the following: 
   - The total number of attachments that you copied across multiple emails and pasted to the target email. 
   - **Clear All** option to remove all the copied attachments. 
   - **Undo** option to remove the most recently copied attachment. 

 ![Enhanced attachment control.](../media/cs-enh-email-attach.png "Screenshot of the enhanced email with the enhanced attachment control")


## Delete in-line attachments for completed emails

Perform the following steps within your Power Apps form to delete an inline attachment for a completed email.

- From the Customer Service hub site map, go to **My Work** > **Activities**.
- Select the completed email from the list of activities.
- Select the Attachment panel from within the email. The **Edit Attachments control** window shows.
- Change the **Static value** dropdown to **True** in **Make Delete visible to users**.
- Select **Done**.

## Next steps

[Enable enhanced experience for email attachments](../administer/add-enhanced-attachment-control.md)
