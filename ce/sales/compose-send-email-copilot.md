---
title: Compose and send email messages using Copilot
description: Get suggestions on email messages through Copilot in Dynamics 365 Sales. 
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 07/18/2023
ms.custom: bap-template
---

# Compose and send email messages using Copilot (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Copilot for email suggests content while composing or replying to emails, saving your time  and effort. It provides AI-generated suggested drafts based on your input, recent emails, and related information. You can select from predefined response categories or input your own text, and the AI generates the suggested content. You can use it as-is or modify it as per your requirements.

> [!NOTE]
> - The AI-generated content is just a suggestion. It is your responsibility to review and edit the suggested content to make sure it’s accurate and appropriate before sending your email.
> - Copilot for email is supported only for lead and opportunity records through the Dynamics 365 email experience. 

## Prerequisites

Ensure that the Copilot feature is enabled in your organization. More information: [Enable and set up copilot capabilities](enable-setup-copilot.md)

## View the Copilot composer

Copilot is available for lead and opportunity records with the Dynamics 365 email experience.  
Sign in to your sales app and the Copilot (:::image type="content" source="media/copilot-icon.png" alt-text="Image of the copilot icon.":::) icon appears on the upper-right corner of the page. The composer is inactive until you open the email.  
Open an email from a record using the Up next widget, Timeline, or quick create email activity. The Copilot composer becomes active.  
When opening an email from Timeline or quick create email activity, ensure that the Regarding field contains a lead or an opportunity.  

## Compose or replay an email

When you're sending an email, you can provide the context for the email in the Copilot composer, and a draft is generated. You can review the draft, copy the content to the email, and send it to recipients.  

1.	On the **Copilot** pane, go to the **Compose** tab.

1. Select **Describe the email you want**.  

    > [!NOTE]
    > When replying to an email, default options are available to generate a draft, including **Reply to an inquiry**, **Make a proposal**, and **Address a concern**. You can choose an option that suits your needs or draft a new email.

1.	In the **Draft with Copilot** section, enter the statement for which you want to generate the draft email. An example statement, Write an email to thank Kenny Smith for showing interest in Contoso 3D printers.

    A draft is generated for the statement. Review the suggested content. 

    :::image type="content" source="media/copilot-draft-email-suggestion.png" alt-text="Screen shot of copilot pane with draft email suggestion.":::

    Do the following according to your needs:  
    -	If you’re fine with the content, select Copy to email to paste the content in the email body. Edit the content according to your requirements and send the email.  
    -	If you want to fine-tune the suggested content, enter the suggested statement in the **Describe the changes you want** textbox. To refine the draft, see [Refine suggested content](#refine-suggested-content).  
    -	If you’re not satisfied with the draft and generate new content based on the same statement, select **Try again**. More information, see [Refine suggested content](#refine-suggested-content).  

## Refine suggested content

After you’ve generated the suggested content, you can refine the results further by providing a new prompt that builds upon the previous suggestion or generate new suggested content. This allows you to fine-tune your email replies according to the needs and preferences. 

**To refine the content**:

1.	Enter a statement to refine the suggested content in the **Describe the changes you want** textbox. For example: Make it formal, make it shorter, or suggest a meeting next week. 
1.	Press **Enter**.
1.	Review the suggested content and select **Copy to email** to past the content in the email body.

**To generate different suggestion based on the statement**:

1.	Select **Try again**.  
    New content is generated based on the statement. 
1.	Review the suggested content and select **Copy to email** to past the content in the email body.  

> [!NOTE]
> To restore the content to the previous version, select the undo (:::image type="content" source="media/undo-icon.png" alt-text="Image of the undo icon.":::) icon beside **Try again**. 

### See also

[Copilot overview](copilot-overview.md)  
[Use Copilot in rich text editor for email](/power-apps/maker/model-driven-apps/use-copilot-email-assist?context=/dynamics365/context/sales-context)
