---
title: FAQ for copilot features
description: FAQ for copilot features in Dynamics 365 Customer Service.
ms.date: 12/24/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - admin
ms.custom: 
ms.collection: bap-ai-copilot
---

# FAQ for Copilot in Customer Service

This FAQ article helps answer the questions around the Copilot features in Customer Service.

## In which Customer Service apps is Copilot available?  

Copilot is available in Customer Service workspace, Customer Service Hub, and [custom apps](../administer/copilot-powerapps-settings.md). 

## Which are the copilot features available across apps?

The following table describes the availability of Copilot features across apps.

| Feature name | Customer Service workspace | Customer Service Hub | Custom apps |
| ------- | ----- | -------- | ----- | 
| Copilot knowledge chat| Yes | Yes<sup>1</sup> | Yes<sup>1</sup> |
| Copilot for drafting emails| Yes | Yes<sup>1</sup>  |Yes<sup>1</sup> |
| Case summarization| Yes  | Yes<sup>1</sup> | Yes<sup>1</sup> |
| Copilot analytics| Yes | Yes<sup>1</sup> | Yes<sup>1</sup> |
| Conversation summarization| Yes | No | No |

Yes<sup>1</sup>: Available, but configuration is required in Power Apps 


## Why does Copilot come back with a different response to the same exact input? 

Copilot's response to the same question can vary due to multiple factors. Copilot is built on a generative AI language models. While measures are in place to minimize response variability, there's a possibility that Copilot might generate slightly different answers. Additionally, in multiturn questions, Copilot considers the previous question's context as input. Therefore, asking Copilot the same question at the start of the session versus in the middle can result in different responses.

## Can Copilot read tables and images in my knowledge articles?
 At this time, Copilot cannot read tables and images in knowledge articles. 

## What are the limitations for webpages as sources? 

You can add up to five trusted domains as web sources, and the domains must be publicly indexed by Bing search. 

## Does Copilot support knowledge articles published in all languages? 

Yes. Copilot supports knowledge articles published in the supported languages. See: 
[Language support for AI-based analytics and insights in Customer Service](cs-region-availability-service-limits.md#language-support-for-ai-based-analytics-and-insights-in-customer-service)

## What are the best practices for configuring copilot?
 
- Make sure that you use high-quality knowledge sources for copilot to generate responses from.
- Revisit your copilot knowledge sources before you enable Copilot.
- Restrict access to sources from which you don't want your copilot responses to be generated.

## Where can I access feedback for copilot?
When an agent interacts with Copilot, they can provide feedback on the responses that Copilot provides. The feedback is stored in the msdyn_copilotinteraction table in Dataverse. Learn more in [Retrieve verbatim feedback](../develop/download-copilot-transcript-data.md#retrieve-verbatim-feedback).

### Related information

[Responsible AI FAQ for Copilot in Customer Service](../implement/faq-responsible-ai-copilot.md)  
[FAQ for Copilot data security and privacy in Microsoft Power Platform](/power-platform/faqs-copilot-data-security-privacy)  