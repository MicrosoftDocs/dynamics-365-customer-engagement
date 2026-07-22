---
title: Configure connection references
description: Learn how to configure connection references for AI Agent flow in Dynamics 365 Customer Service and Contact Center, with Microsoft Dataverse and Copilot Studio.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection:
ms.date: 05/07/2026
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:02/26/2025
---

# Configure connection references 

This article explains how to configure connection references for AI agents that help enable seamless integration with Microsoft services. These connections link flows to essential data sources such as Microsoft Dataverse and Copilot Studio, ensuring smooth operation and enhanced functionality.


## Set up connection references for Customer Knowledge Management Agent

[!INCLUDE[cc-connection-reference](../../includes/qea/cc-connection-reference.md)] 
3. Search for the following connection references. 
   - **Microsoft Dataverse CustomerServiceKnowledgeHarvest**   
   - **Microsoft Copilot Studio CustomerServiceKnowledgeHarvest**     
4. To create a connection for **Microsoft Dataverse CustomerServiceKnowledgeHarvest**:
    1. In the **Edit** dialog, select **Connection** > **New connection**. 
    1. Search for **Microsoft Dataverse** and select **Create**. You might need to sign in using the OAuth connection type to create a Dataverse connection.
    1. Go back to the **Edit** dialog of **Microsoft Dataverse CustomerServiceKnowledgeHarvest**, search for the new connection and save it.
    1. Repeat step a and b, to create a connection with **Microsoft Copilot Studio**.    
5. [!INCLUDE[cc-flow-enable](../../includes/qea/cc-flow-enable.md)]
     - **Knowledge Harvest Trigger Flow V2**  
6. [!INCLUDE[cc-publish-agent](../../includes/qea/cc-publish-agent.md)]. For Customer Knowledge Management Agent flow, the agent in Copilot Studio is **CustomerServiceKnowledgeHarvest**.

## Set up connection references for Quality Evaluation Agent

[!INCLUDE[cc-connection-reference](../../includes/qea/cc-connection-reference.md)]
3. Search for the following connection references. Authenticate the connection references using an administrator account to enable the AI agent to access data sources. 
   - **Microsoft Dataverse Connection Reference for QEA**
   - **Microsoft Copilot Studio Connection Reference for QEA**
   - **QMA.Incident.DVPluginConnection** (applicable to evaluations on case and email only) 
   - **QMA.UnifiedAgent.DVPluginConnection**
 4. [!INCLUDE[cc-flow-enable](../../includes/qea/cc-flow-enable.md)]
      - **Expire evaluations** 
      - **QEA On Demand Evaluation Case** (applicable to evaluations on case and email only) 
      - **AI Evaluation Flow for Conversation** (applicable to evaluations on conversations only) 
      - **QEA Simulation**

5. [!INCLUDE[cc-publish-agent](../../includes/qea/cc-publish-agent.md)]. For Quality Evaluation Agent flow, the agent in Copilot Studio is **Quality Evaluation Agent**.


 
## Related information

[Overview of cloud flows](/power-automate/overview-cloud)  
[Manage Customer Knowledge Management Agent](admin-km-agent.md)  
[Manage Quality Evaluation Agent](/dynamics365/contact-center/administer/manage-quality-evaluation-agent)
