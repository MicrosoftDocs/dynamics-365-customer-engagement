---
title: Configure email content for Sales Close Agent - Engage
description: Configure the email content that the Sales Close Agent - Engage uses for outreach and follow-up emails to customers.   
ms.date: 12/17/2025
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

Configure the agent to send personalized outreach emails to customers. You can select templates that the agent should use to personalize emails based on customer data and predefined variables. This ensures relevant and engaging communication and sets the tone for interactions by providing prompts that guide agents' language. Also, you can customize the formatting and style in email communications by defining specific prompts.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Follow these steps**:

1. [Open the Sales Close Agent - Engage settings page](open-sales-close-agent-settings.md).  
1. In the **Guidance** section, select **Email content**.  
    :::image type="content" source="media/sca-guidance-email-content-settings-page.png" alt-text="Screenshot of the Sales Close Agent - Engage email content settings page.":::  
1. In the **Email content** page, configure the following settings:  

    - **Outreach email templates**: Select a template that the agent should use for sending outreach emails to customers. Select **Choose template** and then pick a template from the list of available email templates.
    To create a template, select **Create template** and then design a new template that suits your outreach needs. You can use variables that the agent can use to personalize the email content. These variables can include customer names, company names, product details, and other relevant information that makes the emails more personalized and effective. To know more about creating email templates, read the [Create templates for email](/power-platform/admin/create-templates-email?tabs=new) article.  
    By default, up to 10,000 emails are sent daily according to the [Exchange Online sending limits](/office365/servicedescriptions/exchange-online-service-description/exchange-online-limits#sending-limits-1). If your agent is set to send more than this amount, the extra emails are placed in a queue and sent the following day. Outreach emails are only sent to leads or contacts who have given their consent. Therefore, not all outreach emails are delivered on the same day. You can track the number of emails successfully sent through [the insights dashboard](view-sales-close-agent-engage-insights-metrics.md).  

        >[!NOTE]
        >When the agent is activated or reactivated, the outreach flow identifies records with the same email. If an outreach email is sent to one record, others with that email are skipped, unless the email was sent in a previous activation cycle, in which case outreach is sent again.  

    - **Tone for emails**: Provide specific prompts that guide the agent's tone and style in email communications. This helps maintain consistency with your organization's brand voice and ensures that the emails resonate with the target audience.  
    For example, the prompt *Keep the tone friendly and confident* keeps the tone of the email friendly and confident which is important for building rapport with customers. You can add multiple prompts to cover different aspects of the email tone and style.  

## Next step

[Configure knowledge sources](configure-sales-close-agent-knowledge-sources.md)

## Related information

[Set up and configure the Sales Close Agent - Engage (preview)](configure-sales-close-agent.md)
