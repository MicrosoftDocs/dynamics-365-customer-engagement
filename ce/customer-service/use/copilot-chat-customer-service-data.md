---
title: Chat with Customer Service data in Microsoft 365 Copilot (preview)
description: Learn how to use Copilot for Microsoft 365 to chat with service data and ask questions in natural language.
ms.date: 04/12/2024
ms.custom:
  - bap-template
ms.topic: conceptual
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.collection: bap-ai-copilot
---

# Chat with Customer Service data in Copilot for Microsoft 365 (preview)

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note-d365.md)]

This article explains how to use Microsoft Copilot for Microsoft 365 to chat with Dynamics 365 Customer Service data by using the Customer Service plugin.

Copilot for Microsoft 365 works across Microsoft 365 apps to help you unlock business scenarios in your organization.

The Customer Service plugin works together with Copilot for Microsoft 365 to help you:

- Deliver a consistent customer experience in every conversation with your customers.
- Connect customer data and insights across the company.
- Provide a natural user experience, in your tools of choice.

## Prerequisites 

You must meet the following prerequisites to use the Customer Service plugin with Copilot for Microsoft 365.

- Your administrator must deploy the Dynamics 365 Service app. More information: [Build plugins using Microsoft business applications](/microsoft-365-copilot/extensibility/overview-business-applications#deploy-a-plugin)

- To engage in a natural-language conversation with Dynamics 365 service data, you need a Copilot for Microsoft 365 license. 

## Supported data types

Data that resides inside tables is referred to as *structured data*. Data that's present in static documents, such as Word and PDF files, is referred to as *unstructured data*. The Customer Service plugin mainly supports structured data for now.

## Available out-of-the-box scenarios

If you have access to Dynamics 365 Customer Service data, you can turn on the plugin in Copilot for Microsoft 365 and query the data without leaving the tool.

Some examples of prompts are as follows:

- Show me the high-priority support tickets for Contoso coffee in the past 30 days.
- Tell me if Contoso Coffee has active escalated cases in the past three months. If yes, show me the list.
- What are the cases that missed their SLA in the past seven days?
- Show me all my active cases.
- Show me my cases due tomorrow.
- Tell me about the details for case number CAS-01006-W8H5Q.
- What is the resolution for case #abc?
- Show me active high-priority support tickets for *AgentName* in the past 30 days.
- Show me active escalated support tickets for *AgentName* in past 30 days.

> [!IMPORTANT]
> The AI-generated content is a suggestion. It's your responsibility to review and edit the suggested content to make sure it's accurate and appropriate before sharing the responses.


### Related information

[Use Copilot to solve customer issues](use-copilot-features.md)  
[Understand Copilot language support](copilot-language-support.md)  
[Manage copilot features in Customer Service](../administer/configure-copilot-features.md)  
[Responsible AI FAQ for copilot features](../implement/faq-responsible-ai-copilot.md)   
[FAQ for Copilot in Customer Service](../administer/faq-copilot-features.md)  
