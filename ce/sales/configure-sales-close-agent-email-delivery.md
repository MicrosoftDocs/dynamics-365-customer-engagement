---
title: Configure email delivery settings for Sales Close Agent
description: Configure the compliance profile that the Sales Close Agent uses to send outreach and follow-up emails to customers.  
ms.date: 03/30/2026
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure email delivery settings for Sales Close Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Configure the compliance profile that the Sales Close Agent should use to send outreach and follow-up emails to customers. The compliance profile ensures that all email communications adhere to organizational policies and regulatory requirements.  
To understand more about the compliance profile, read the [Stay compliant with privacy regulations](consent-management-overview.md) article.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Follow these steps**:

1. [Open the Sales Close Agent settings page](open-sales-close-agent-settings.md).  
1. In the **Guidance** section, select **Email delivery**.  
    :::image type="content" source="media/sca-guidance-email-delivery-settings-page.png" alt-text="Screenshot of the Sales Close Agent email delivery settings page.":::  
1. In the Email delivery settings page, select the compliance profile, purpose, and topic that the agent should use to ensure that the email adheres to your organization's compliance requirements. Learn more about settings up compliance profiles in [Stay compliant with privacy regulations](consent-management-overview.md).  
    The compliance profile defines the email policies and consent management settings that the agent adheres to when communicating with customers.
    By default, [a default](consent-management-overview.md#understand-the-default-consent-setup) compliance profile is created for your organization. You can use the default profile or create a new compliance profile.  
    To create a new compliance profile, select **Manage compliance settings** and follow the instructions specified in the [Set up a compliance profile](consent-management-overview.md#set-up-consent-management-for-your-organization) article.  

## Next step

[Configure email content](configure-sales-close-agent-email-content.md)

## Related information

[Set up and configure the Sales Close Agent (preview)](configure-sales-close-agent.md)  
