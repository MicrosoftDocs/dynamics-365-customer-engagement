---
title: Configure email content for Sales Close Agent - Engage
description: Configure the email content that the Sales Close Agent - Engage uses for outreach and follow-up emails to customers.   
ms.date: 11/07/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure email content for Sales Close Agent - Engage

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Configure the email content to send outreach emails and personalize email content tone for emails sent by the agent to customers. The email content includes selecting templates that agents personalize based on customer data and predefined variables. This ensures relevant, engaging communication and sets the tone for interactions by providing prompts that guide agents' language. Also, you can customize the formatting and style in email communications by defining specific prompts.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Follow these steps**:

1. [Open the Sales Close Agent - Engage settings page](open-sales-close-agent-settings.md).  
1. In the **Guidance** section, select **Email content**.  
    :::image type="content" source="media/sca-guidance-email-content-settings-page.png" alt-text="Screenshot of the Sales Close Agent - Engage email content settings page.":::  
1. In the **Email content** page, configure the following settings:  

    - **Outreach email templates**: Select a template that agent uses for sending outreach emails to customers. Select **Choose template** and then pick a template from the list of available email templates.
    To create a template, select **Create template** and then design the new template that suits your outreach needs. You can use variables that agent uses to personalize the email content. These variables can include customer names, company names, product details, and other relevant information that makes the emails more personalized and effective.  
    To know more about creating email templates, read the [Create templates for email](/power-platform/admin/create-templates-email?tabs=new) article.  
    - **Tone for emails**: Provide specific prompts that guide the agent's tone and style in email communications. This helps maintain consistency with your organization's brand voice and ensures that the emails resonate with the target audience.  
    For example, the prompt *Keep the tone friendly and confident* keeps the tone of the email friendly and confident which is important for building rapport with customers. You can add multiple prompts to cover different aspects of the email tone and style.  

## Next step

[Configure knowledge sources](configure-sales-close-agent-knowledge-sources.md)

## Related information

[Set up and configure the Sales Close Agent - Engage (preview)](configure-sales-close-agent.md)
