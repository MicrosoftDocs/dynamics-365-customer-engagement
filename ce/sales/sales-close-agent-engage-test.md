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

After you set up and configure the Sales Close Agent - Engage, you can test its functionality to ensure it operates as expected before going live. Testing helps identify any issues and allows you to make necessary adjustments to optimize performance.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

You can test the agent only when you set up the following configurations to ensure the required information is available for testing.  

- [Agent profile](configure-sales-close-agent-profile.md) for agent such as profile, company info, and email signature.  
- [Product details](configure-sales-close-agent-product-details.md) that the agent uses to recommend products during customer interactions.  
- [Target customers](configure-sales-close-agent-target-customers.md) for the agent to process the records.  
- [Email content](configure-sales-close-agent-email-content.md) that the agent uses for outreach and follow-up emails.  
- [Knowledge sources](configure-sales-close-agent-knowledge-sources.md) that the agent uses to enrich customer interactions. 

## Test the agent

You can simulate interactions between the Sales Close Agent and a customer. This allows you to evaluate how the agent performs in real-world scenarios without impacting your actual data.  

1. Choose one of the following ways to open the test chat pane:  

    - From the **Sales Close Agent - Engage** settings page, select **Test**.  
        :::image type="content" source="media/sca-engage-settings-test-option.png" alt-text="Sales Close Agent - Engage settings page showing the option to test the agent.":::
    - From the **Setup assistant**, after completing the configurations, select **Test**.  
        :::image type="content" source="media/sca-engage-assisted-setup-test-option.png" alt-text="Assisted setup page showing the option to test the agent.":::  

1. In the test chat pane, you can see the sample outreach email that the agent would send to a potential customer. The email includes personalized content based on the configurations you set up earlier.  
    :::image type="content" source="media/sca-engage-test-chat-pane.png" alt-text="Sales Close Agent - Engage test chat pane showing a sample outreach email.":::

    Review the email content and ensure it aligns with your expectations. If required, make necessary chages in the agent configuration settings to improve the email content and rerun the test until you are satisfied with the results.  

1. (Optional) Select **Restart** to clear the chat pane and start a new test.  
1. To stop testing, select **Stop**.  
    The agent testing is stopped, and you are returned to the agent settings page or the Setup Assistant depending on your testing selection.  

## Next step

[Start the Sales Close Agent - Engage](start-sales-close-agent.md)  


## Related information

[Set up and configure the Sales Close Agent - Engage](configure-sales-close-agent.md)  
[Set up Sales Close Agent (Engage) through the Setup Assistant](sales-close-agent-engage-setup-assistant.md)  
[How the Sales Close Agent - Engage works](how-sales-close-agent-engage-mode-works.md)