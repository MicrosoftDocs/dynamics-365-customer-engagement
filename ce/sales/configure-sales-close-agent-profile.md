---
title: Configure the agent profile for Sales Close Agent - Engage (preview)
description: Define the agent information, email signature, disclaimer, and other terms to set the context for the Sales Close Agent - Engage.
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

# Configure the agent profile for Sales Close Agent - Engage (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Define the agent information, email signature, disclaimer, and other terms to set the context for the Sales Close Agent - Engage.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Follow these steps**:

1. [Open the Sales Close Agent - Engage settings page](open-sales-close-agent-settings.md).  
1. Under the **General** settings section, select **Agent profile**.  
    :::image type="content" source="media/sca-general-agent-profile-settings-page.png" alt-text="Screenshot of the Sales Close Agent - Engage profile settings page.":::  
1. In the **Agent profile** page, enter the following information:  

    | Field name | Description |
    |------------|-------------|
    | **Agent name** | Specify a meaningful name for the agent. |
    | **Agent description** | Specify a brief description of the agent's purpose and the deals it will handle. |
    | **Agent user** | Select the [agent app user you created for the agent](configure-requirements-for-sales-close-agent.md#create-an-app-user-in-dataverse-and-assign-aisalesperson-role). This user account is used to perform all the agent tasks such as owning records, sending emails, and accessing data. |
    | **Email signature** | Enter the email signature that the agent will use when sending emails to customers. This signature will be appended to the end of each email sent by the agent. Select **Modify signature** to open the Email signature editor, where you can format the signature text and add links or images. Ensure that the name used to configure the mailbox is the same as the agent name in the signature because the agent sends emails using this mailbox. |
    | **AI disclaimer** | Enter a disclaimer that will be included in the emails sent by the agent. This disclaimer informs recipients that the email is sent by an AI agent and not a human. Work with your legal team to ensure the disclaimer meets your organization's requirements. |
    | **Other terms** | Enter any other terms that the agent should include in its communications with opportunity’s contact. This could include terms of service, privacy policy links, or any other relevant information. |

## Next step

[Configure product details](configure-sales-close-agent-product-details.md)

## Related information

[Set up and configure the Sales Close Agent - Engage (preview)](configure-sales-close-agent.md)