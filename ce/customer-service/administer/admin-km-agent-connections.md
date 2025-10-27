---
title: Configure connection references for Customer Knowledge Management Agent flow
description: Learn how to configure connection references for Customer Knowledge Management Agent flow with Microsoft Dataverse and Copilot Studio.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection:
ms.date: 10/27/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:02/26/2025
---

# Configure connection references

This article explains how to configure connection references for AI agents that helps enable seamless integration with Microsoft services. These connections link flows to essential data sources such as Microsoft Dataverse and Copilot Studio, ensuring smooth operation and enhanced functionality.


|AI agent flow |Connection references  |
|---------|---------|
|Customer Knowledge Management Agent flow    |    - **Microsoft Dataverse CustomerServiceKnowledgeHarvest** <br> - **Microsoft Copilot Studio CustomerServiceKnowledgeHarvest**     |
|Quality Evaluation Agent flow    |  - **QEA On Demand Evaluation Case** for cases. <br> - **AI Evaluation Flow for Conversation** for conversations.    |

## Step 1: Set connection references

1. Sign in to [make.powerapps.com](https://make.powerapps.com) and select your environment.
1. Go to **Solutions** > **Default Solution** > **Objects** > **Connection References**.
1. Search for the connection references for your agent.
1. To create a connection for the connection reference:
    1. In the **Edit** dialog, select **Connection** > **New connection**. 
    1. Search for **Microsoft Dataverse** and select **Create**.
    1. Go back to the **Edit** dialog of the connection reference, search for the new connection and save it.
1. Perform the same steps to create a connection for all references, with **Microsoft Copilot Studio (Preview)**.
 
## Step 2:  Turn on the Power Automate flow

|AI agent flow |Connection references  |
|---------|---------|
|Customer Knowledge Management Agent flow    |    **Knowledge Harvest Trigger Flow V2**    |
|Quality Evaluation Agent flow    |  - **QEA On Demand Evaluation Case** for cases. <br> - **AI Evaluation Flow for Conversation** for conversations.    |

In [Power Automate](https://powerautomate.microsoft.com), search for your flow in **Cloud flows**, and turn it on. Learn more in [Power Automate](/power-automate/overview-cloud#find-your-flows-easily).

### Publish the Microsoft Copilot Studio agent

1. In [Microsoft Copilot Studio](https://copilotstudio.microsoft.com), select your environment, and then search for the **CustomerServiceKnowledgeHarvest** agent. 
1. [Publish the agent](/microsoft-copilot-studio/publication-fundamentals-publish-channels?tabs=web).


laternatively, in [make.powerapps.com](https://make.powerapps.com) from **Solutions** > **Default Solution** > **Objects** > **Cloud flows**, select your flows, and then select **Turn on**.

Once done, go to the Copilot Service admin center and enable your agent.
 
## Related information

[Overview of cloud flows](/power-automate/overview-cloud)
[Manage Customer Knowledge Management Agent](admin-km-agent.md#manage-customer-knowledge-management-agent)  
[Manage Quality Evalaution Agent](/dynamics365/contact-center/administer/manage-quality-evaluation-agent?toc=/dynamics365/customer-service/administer/toc.json&bc=../../breadcrumb/toc.ym)