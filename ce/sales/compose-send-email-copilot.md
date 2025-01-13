---
title: Compose and send email messages using Copilot
description: Get suggestions on email messages through Copilot in Dynamics 365 Sales. 
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ms.topic: how-to 
ms.date: 01/08/2024
ms.custom: bap-template
---

# Compose and send email messages using Copilot (preview)

[!INCLUDE [preview-banner-section](~/../shared-content/shared/preview-includes/preview-banner.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

> [!NOTE]
> From the version 9.2.24124.0010, composing and sending email using Copilot side pane feature is not supported and is being removed in a phased manner. You can use the [Copilot email assist](enable-copilot-email-assist.md) feature to compose and [send emails through the rich text editor](/power-apps/maker/model-driven-apps/use-copilot-email-assist).  

Copilot for email suggests content while composing or replying to emails, saving you time and effort. It provides AI-generated drafts based on your input, recent emails, and related information. You can select from predefined response categories or input your own text, and the AI generates the suggested content. You can use it as-is or modify it as per your requirements.

> [!NOTE]
> - The AI-generated content is just a suggestion. It is your responsibility to review and edit the suggested content to make sure it’s accurate and appropriate before sending your email.
> - Copilot for email is supported only for lead and opportunity records through the Dynamics 365 email experience. 

## Prerequisites

Ensure that the Copilot feature is enabled for your Dynamics 365 Sales organization. More information: [Enable and set up copilot capabilities](enable-setup-copilot.md)

## View the Copilot email composer

Copilot is available for lead and opportunity records with the Dynamics 365 email experience.  
Sign in to your sales app and the Copilot (:::image type="content" source="media/copilot-icon.svg" alt-text="Image of the copilot icon.":::) icon appears on the upper-right corner of the page. The email composer is inactive until you open the email.  

Open an email from a record using the Up next widget, Timeline, or quick create email activity. The Copilot email composer becomes active.  

When opening an email from Timeline or quick create email activity, ensure that the **Regarding** field contains a lead or an opportunity.  

> [!NOTE]
> If you have opted in for the early access, you can see the Copilot email composer is active for account, contact, lead, and opportunity records and the Regarding field can contain any of the entity.

## Compose or reply to an email

When you're sending an email, you can provide the context for the email in the Copilot composer, and a draft is generated. You can review the draft, copy the content to the email, and send it to recipients.  

1.	Open a new or an existing email from a lead or an opportunity record.

1. On the **Copilot** pane, go to the **Email (preview)** tab.

1. Select **Describe the email you want**.  

    > [!NOTE]
    > When replying to an email, default options are available to generate a draft, including **Reply to an inquiry**, **Make a proposal**, and **Address a concern**. You can choose an option that suits your needs or draft a new email.

1.	In the **Draft with Copilot** section, enter the statement for which you want to generate the draft email. An example statement, Write an email to thank Kenny Smith for showing interest in Contoso 3D printers.

    A draft is generated for the statement. Review the suggested content.  

    Do the following according to your needs:  
    - If the content meets your needs, select **Add to email** to insert it directly into the email body. Also, you can select the copy icon to copy the content and paste it into the email body. If necessary, edit the content according to your requirements and send the email.  
    - If you want to fine-tune the suggested content, select the **Adjust draft** icon. Then, select your desired tone under the **Adjust tone** section and input your preferred statement into the **Add details** textbox. To refine the draft, see [Refine suggested content](#refine-suggested-content).  
    - If you’re not satisfied with the draft and generate new content based on the same statement, select **More options** > **Try again**. More information, see [Refine suggested content](#refine-suggested-content).  

## Refine suggested content

After you’ve generated the suggested content, you can refine the results further by providing a new prompt that builds upon the previous suggestion or generate new suggested content. This allows you to fine-tune your email replies according to the needs and preferences. 

**To refine the suggested content**:

1. Select the **Adjust draft** icon.  

1. Choose the tone type under **Adjust tone**.  

    The tone type is selected by default based on the statement you entered and it's grayed out. You can choose a different tone type if necessary. The following tone types are available: **Formal**, **Professional**, and **Friendly**.

1. Enter a statement to refine the suggested content in the **Add details** textbox. For example: Make it formal, make it shorter, or suggest a meeting next week. 

1. Select **Update**.

1. Review the suggested content and select **Add to email** or the copy icon to paste the content in the email body.

**To generate different suggestion based on the statement**:

1. Select **More options** > **Try again**.  
    New content is generated based on the statement.  
1. Review the suggested content and select  **Add to email** or the copy icon to paste the content in the email body.  

> [!NOTE]
> To restore the content to the previous version, select **More options** and then select **Restore last version**.  

**To start a fresh draft**:

1. Select **More options** > **Start over**.  

    The Copilot email composer is cleared and you can start a new draft.

## Related information

[Copilot overview](copilot-overview.md)  
