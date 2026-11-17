---
title: Use the canvas experience in email (preview)
description: Review email conversations, prepare replies, and use templates, Copilot, and attachments in the modern email experience in Copilot Service workspace.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.date: 11/17/2026
ai-usage: ai-assisted
ms.custom: bap-template
search.audienceType:
  - enduser
---

# Use the canvas experience in email (preview)

[!INCLUDE[public-preview-banner](../../includes/public-preview-banner.md)]


Use the email canvas in Copilot Service workspace to review earlier messages and respond to customers without leaving the email record.

[!INCLUDE[public-preview-note](../../includes/public-preview-note.md)]


## Prerequisites

- Your administrator enabled the email canvas in Copilot Service admin center. Learn more in [Manage canvases in CRM Canvas Designer](../../canvas-designer/manage-canvases.md) to publish the email canvas.
- Your administrator configured your mailbox and send permissions. See [Configure email](../administer/customer-service-hub-user-guide-email-admin.md).
- Your administrator enabled email drafting to use Copilot. See [Enable Copilot to draft emails](/dynamics365/contact-center/administer/copilot-email-enable). 

## Open an email

1. Open Copilot Service workspace.
2. From **Activities**, open an existing email, or open a case and create a new email. When the administrator enables the email canvas experience for you in the app, the email opens in the modern form.

To switch to the classic email form, select **Open classic view** on the command bar. To return, select **Open canvas view** on the classic form.

:::image type="content" source="../media/email-canvas-mini.png" alt-text="Screenshot of the email canvas showing the sender, related case, message editor, and earlier email." lightbox="../media/email-canvas.png":::

## Explore the form

| Action | Where to find it | Related instructions |
|---|---|---|
| Reply, reply to all, or forward. | **Reply** or **More response options** on the current message. | [View, compose, and respond to email](/power-apps/user/view-compose-email). |
| Review earlier messages. | Expand linked messages below the current email or draft. Only the parent-email chain appears, not every email for the customer or case. | - |
| Choose a sender or related record. | **From** or **Set regarding** in the compose command bar. | [Anatomy of an email form](/power-apps/user/view-compose-email#anatomy-of-an-email-form). |
| Add or resolve recipients. | **To**, **Cc**, and **Bcc**; **Review** for unresolved addresses. | [Enhanced recipient handling](/power-apps/user/view-compose-email#enhanced-recipient-handling). |
| Format a response. | Formatting toolbar in the message editor. | [Use the rich text editor toolbar in email](/power-apps/user/email-rich-text-editor). |
| Insert a template. | **Insert template**, then **Recently used** or **Browse all templates**. | [Insert an email template](/power-apps/user/insert-email-template). |
| Insert a signature. | **Insert signature** in the compose command bar. | [Use an email signature](/power-apps/user/email-signature). |
| Draft or refine a response with Copilot. | **Draft with Copilot** in the message body. A recommended template remains a preview until you select **Keep it**. | [Draft emails with Copilot](/dynamics365/contact-center/use/use-copilot-email#use-copilot-to-draft-an-email). Follow the rich text editor guidance, not the help-pane navigation. |
| Add or review attachments. | **Attach file** or drag files into the compose area. Preview supported images and PDFs on the current email; download files from earlier messages. | [Attach a file to email](/power-apps/user/attach-email). |
| Apply a sensitivity label. | Sensitivity label control, when enabled. | [Use sensitivity labels in emails](use-sensitivity-labels.md). |
| Send a response. | **Send** in the compose command bar. **Pending Send** confirms submission, not delivery. | [Compose an email](/power-apps/user/view-compose-email#compose-an-email). |
| Delete a draft. | **Discard draft** in the compose command bar. Discarding a response returns you to its parent email. | - |
| Share, check access, or refresh. | **More email actions**. Copying a link doesn't grant record access. | - |


## Related information

[Use the canvas experience for cases](use-case-canvas.md)  
[Get started with Copilot Service workspace](../implement/csw-overview.md)
