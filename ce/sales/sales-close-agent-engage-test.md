---
title: Test the Sales Close Agent (Engage) (preview)
description: Learn how to test the Sales Close Agent (Engage) using the AI Setup Assistant in Dynamics 365 Sales.
ms.date: 01/09/2026
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

# Test the Sales Close Agent (Engage) (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

When you test the agent, you can check how the Sales Close Agent (SCA) interacts with a potential customer. You can review the outreach email content, tone, and structure. You can also see how the agent responds to customer replies. For example, you can test how the agent handles questions about product features, pricing, or availability through chat by providing sample customer replies.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

You can test the agent only when you set up the following configurations to ensure the required information is available for testing.  

- [Agent profile](configure-sales-close-agent-profile.md) for the agent such as profile, company info, and email signature.  
- [Product details](configure-sales-close-agent-product-details.md) that the agent uses to recommend products during customer interactions.  
- [Target customers](configure-sales-close-agent-target-customers.md) for the agent to process the records.  
- [Email content](configure-sales-close-agent-email-content.md) that the agent uses for outreach and follow-up emails.  
- [Knowledge sources](configure-sales-close-agent-knowledge-sources.md) that the agent uses to enrich customer interactions. 

## Test the agent

You can simulate interactions between the Sales Close Agent and a customer. This approach lets you evaluate how the agent performs in real-world scenarios without impacting your actual data.  

1. Choose one of the following ways to open the test chat pane:  

    - From the **Sales Close Agent - Engage** settings page, select **Test**.  
        :::image type="content" source="media/sca-engage-settings-test-option.png" alt-text="Sales Close Agent - Engage settings page showing the option to test the agent.":::
    - From the **Setup assistant**, after completing the configurations, select **Test**.  
        :::image type="content" source="media/sca-engage-assisted-setup-test-option.png" alt-text="Assisted setup page showing the option to test the agent.":::  

1. In the test chat pane, you see the sample outreach email that the agent sends to a potential customer. The email includes personalized content based on the configurations you set up earlier.  
    :::image type="content" source="media/sca-engage-test-chat-pane.png" alt-text="Sales Close Agent - Engage test chat pane showing a sample outreach email.":::

    Review the email content and ensure it aligns with your expectations. You can further interact with the agent by simulating customer replies to the outreach email with follow-up questions, express negative intent, and observe how the agent responds.  
    If the agent's response isn't satisfactory, there are typically a few underlying reasons:  
    - **Insufficient grounding**: If the agent isn't connected to [the right knowledge sources](configure-sales-close-agent-knowledge-sources.md), it might be unable to generate accurate or relevant responses.  
    - **Email quality issues**: If the email structure or tone isn't appropriate, the [configured email template](configure-sales-close-agent-email-content.md) might need to be refined.  
    Make necessary changes in the agent configuration settings to improve the email content and rerun the test until you're satisfied with the results.  
1. (Optional) Select **Restart** to clear the chat pane and start a new test.  
1. Select **Stop** to stop testing.  
    The agent testing stops, and you're returned to the agent settings page or the Setup Assistant depending on your testing selection.  

## Next step

[Start the Sales Close Agent - Engage](start-sales-close-agent.md)  

## Related information

[Set up and configure the Sales Close Agent - Engage](configure-sales-close-agent.md)  
[Set up Sales Close Agent (Engage) through the Setup Assistant](sales-close-agent-engage-setup-assistant.md)  
[How the Sales Close Agent - Engage works](how-sales-close-agent-engage-mode-works.md)