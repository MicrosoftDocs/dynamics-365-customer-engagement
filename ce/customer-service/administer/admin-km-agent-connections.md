---
title: Configure connection references
description: Learn how to configure connection references for AI Agent flow in Dynamics 365 Customer Service and Contact Center, with Microsoft Dataverse and Copilot Studio.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection:
ms.date: 11/04/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:02/26/2025
---

# Configure connection references 

This article explains how to configure connection references for AI agents that help enable seamless integration with Microsoft services. These connections link flows to essential data sources such as Microsoft Dataverse and Copilot Studio, ensuring smooth operation and enhanced functionality.


|AI agent |Flow  |
|---------|---------|
|Customer Knowledge Management Agent    |   **Knowledge Harvest Trigger Flow V2**   |
|Quality Evaluation Agent    |  - **QEA On Demand Evaluation Case** for cases. <br> - **AI Evaluation Flow for Conversation** for conversations.    |

Learn more in [Add connection references to a solution.](/power-apps/maker/data-platform/create-connection-reference#add-connection-references-to-a-solution).

## Set connection references for AI agent flow

|AI agent flow|Connection references  |
|---------|---------|
|**Knowledge Harvest Trigger Flow V2**   |    - **Microsoft Dataverse CustomerServiceKnowledgeHarvest** <br> - **Microsoft Copilot Studio CustomerServiceKnowledgeHarvest**     |
|- **QEA On Demand Evaluation Case** for cases. <br> - **AI Evaluation Flow for Conversation** for conversations.    |  **QMA.UnifiedAgent.DVPluginConnection, Microsoft Copilot Studio (Preview) CaseReviewerFlow** and **Microsoft Dataverse FlowRunTest-8625a**. |

1. Sign in to [make.powerapps.com](https://make.powerapps.com) and select your environment.
1. Go to **Solutions** > **Default Solution** > **Objects** > **Connection References**.
1. Search for the connection references that you want to add. For example, search for **Microsoft Dataverse CustomerServiceKnowledgeHarvest**.
1. To create a connection for **Microsoft Dataverse CustomerServiceKnowledgeHarvest**:
    1. In the **Edit** dialog, select **Connection** > **New connection**. 
    1. Search for **Microsoft Dataverse** and select **Create**. You might need to sign in using the OAuth connection type to create a Dataverse connection.
    1. Go back to the **Edit** dialog of **Microsoft Dataverse CustomerServiceKnowledgeHarvest**, search for the new connection and save it.
    1. Repeat step a and b, to create a connection with **Microsoft Copilot Studio (Preview)**.
    1. Go back to the **Edit** dialog of **Microsoft Dataverse CustomerServiceKnowledgeHarvest**, search for the new connection and save it.
1. Save your changes.

 
## Turn on the Power Automate flow

|AI agent  | AI Agent flow  |
|---------|---------|
|Customer Knowledge Management Agent |    **Knowledge Harvest Trigger Flow V2**    |
|Quality Evaluation Agent   |  - **QEA On Demand Evaluation Case** for cases. <br> - **AI Evaluation Flow for Conversation** for conversations.  <br> - **Expire evaluations** |

In [Power Automate](https://powerautomate.microsoft.com), search for your flow, for example, **Knowledge Harvest Trigger Flow V2** in **Cloud flows**, and turn it on. Learn more in [Power Automate](/power-automate/overview-cloud#find-your-flows-easily).

Alternatively, in [make.powerapps.com](https://make.powerapps.com) from **Solutions** > **Default Solution** > **Objects** > **Cloud flows**, select your flow, and then select **Turn on**.

## Publish the Microsoft Copilot Studio agent

|AI agent flow |  Microsoft Copilot Studio agent |
|---------|---------|
|Customer Knowledge Management Agent flow    |   **CustomerServiceKnowledgeHarvest** |
|Quality Evaluation Agent flow    |  **Quality Evaluation Agent** |

1. In [Microsoft Copilot Studio](https://copilotstudio.microsoft.com), select your environment, and then search for the agent, for example, **CustomerServiceKnowledgeHarvest** agent. 
1. [Publish the agent](/microsoft-copilot-studio/publication-fundamentals-publish-channels?tabs=web).

Once done, go to the Copilot Service admin center and enable your agent. 
 
## Related information

[Overview of cloud flows](/power-automate/overview-cloud)  
[Manage Customer Knowledge Management Agent](admin-km-agent.md)  
[Manage Quality Evaluation Agent](/dynamics365/contact-center/administer/manage-quality-evaluation-agent)
