---
title: Start the Sales Close Agent - Engage
description: Learn how to start the Sales Close Agent - Engage in Dynamics 365 Sales.
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

# Start the Sales Close Agent - Engage

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

> [!IMPORTANT]
> Ensure that the agent is properly configured to avoid editing configurations after starting. Editing the agent changes how records are processed before and after the change, giving different results.

The **Start agent** option is enabled only after all the configuration sections are completed and marked with a green check mark as shown in the following image.

:::image type="content" source="media/sca-settings-start-agent.png" alt-text="Screenshot of selecting start agent option on the Sales Close Agent - Engage settings page.":::

Select **Start agent** to start the agent. The agent might take a few seconds to start, and you can continue working while the agent is being started. Upon successful activation, the agent is listed under the AI agents home page with status as **On**. As soon as the agent is started, the agent starts processing the records that match the [configured target customers](configure-sales-close-agent-target-customers.md).  
When you start the agent, [the email engagement feature](email-engagement.md) is enabled by default. It gathers information about email interactions with customers, such as email opens and link clicks, and displays them when you open the email summary from the activities page.

>[!NOTE]
>
>- When the agent is activated for the first time, it might take up to 20 minutes to start sending outreach emails.  
>- If agent fails to start due to unknown issues, contact Microsoft support for assistance.  

## Related information

[Set up and configure the Sales Close Agent - Engage (preview)](configure-sales-close-agent.md)  
[Sales Close Agent overview](sales-close-agent.md)
