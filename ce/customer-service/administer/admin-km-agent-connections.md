---
title: Configure connection references for Customer Knowledge Management Agent flow
description: Learn how to configure connection references for Customer Knowledge Management Agent flow with Microsoft Dataverse and Copilot Studio.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection:
ms.date: 10/24/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:02/26/2025
---

# Configure connection references for Customer Knowledge Management Agent flow

This article provides instructions to configure connection references for the Customer Knowledge Management Agent flow. You need to set the following connection references for the **Knowledge Harvest Trigger Flow V2** flow.

- **Microsoft Dataverse CustomerServiceKnowledgeHarvest**
- **Microsoft Copilot Studio CustomerServiceKnowledgeHarvest**

Learn more in [Add connection references to a solution](/power-apps/maker/data-platform/create-connection-reference#add-connection-references-to-a-solution).

## Set connection references for Customer Knowledge Management Agent flow

1. Sign in to [make.powerapps.com](https://make.powerapps.com) and select your environment.
1. Go to **Solutions** > **Default Solution** > **Objects** > **Connection References**.
1. Search for the following connection references:
    - **Microsoft Dataverse CustomerServiceKnowledgeHarvest**
    - **Microsoft Copilot Studio CustomerServiceKnowledgeHarvest**
1. To create a connection for **Microsoft Dataverse CustomerServiceKnowledgeHarvest**:
    1. In the **Edit** dialog, select **Connection** > **New connection**. 
    1. Search for **Microsoft Dataverse** and select **Create**.
    1. Go back to the **Edit** dialog of **Microsoft Dataverse CustomerServiceKnowledgeHarvest**, search for the new connection and save it.
1. Perform the same steps to create a connection for **Microsoft Copilot Studio CustomerServiceKnowledgeHarvest**, with **Microsoft Copilot Studio (Preview)**.
 
## Turn on the Power Automate flow

In [Power Automate](https://powerautomate.microsoft.com), search for **Knowledge Harvest Trigger Flow V2** flow in **Cloud flows**, and turn it on. Learn more in [Power Automate](/power-automate/overview-cloud#find-your-flows-easily).

## Publish the Microsoft Copilot Studio agent

1. In [Microsoft Copilot Studio](https://copilotstudio.microsoft.com), select your environment, and then search for the **CustomerServiceKnowledgeHarvest** agent. 
1. [Publish the agent](/microsoft-copilot-studio/publication-fundamentals-publish-channels?tabs=web).

Once done, go to the Copilot Service admin center and [enable Customer Knowledge Management Agent](admin-km-agent.md#enable-customer-knowledge-management-agent).
 
## Related information

[Overview of cloud flows](/power-automate/overview-cloud)