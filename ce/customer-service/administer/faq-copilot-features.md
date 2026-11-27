---
title: FAQ for Copilot features
description: Learn about frequently asked questions for Microsoft 365 Copilot features in Dynamics 365 Customer Service.
ms.date: 11/26/2026
ms.update-cycle: 180-days
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - admin
ms.custom: 
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# FAQ for Copilot in Customer Service

Find answers to common questions about Microsoft 365 Copilot features in Customer Service.

## In which Customer Service apps is Copilot available?  

Copilot is available in Copilot Service workspace, Customer Service Hub, and [custom apps](../administer/copilot-powerapps-settings.md).

<a name="which-are-the-copilot-features-available-across-apps"></a>

## Which Copilot features are available across apps?

The following table describes the availability of Copilot features across apps.

| Feature name | Copilot Service workspace | Customer Service Hub | Custom apps |
| ------- | ----- | -------- | ----- | 
| Copilot knowledge chat| Yes | Yes<sup>1</sup> | Yes<sup>1</sup> |
| Copilot for drafting emails| Yes | Yes<sup>1</sup>  |Yes<sup>1</sup> |
| Case summarization| Yes  | Yes<sup>1</sup> | Yes<sup>1</sup> |
| Copilot analytics| Yes | Yes<sup>1</sup> | Yes<sup>1</sup> |
| Conversation summarization| Yes | No | No |

Yes<sup>1</sup>: Available, but configuration is required in Power Apps. 

Learn more in [Copilot feature availability across applications](/dynamics365/contact-center/use/copilot-feature-availability).

<a name="why-does-copilot-come-back-with-a-different-response-to-the-same-exact-input"></a>

## Why does Copilot give different responses to the same input?

Copilot uses generative AI language models, which can produce different answers to the same question. Although measures are in place to reduce variability, responses might still differ. In multiturn conversations, Copilot also considers the context of previous questions. Asking the same question at the start of a session and later in the session can therefore produce different responses.

## Can Copilot read tables and images in my knowledge articles?
Copilot can't currently read tables and images in knowledge articles.

## What are the limitations for webpages as sources? 

You can add up to five trusted domains as web sources, and the domains must be publicly indexed by Bing search. 

## Does Copilot support knowledge articles published in all languages? 

Yes. Copilot supports knowledge articles published in the supported languages. Learn more in [Language support for AI-based analytics and insights in Customer Service](cs-region-availability-service-limits.md#language-support-for-ai-based-analytics-and-insights-in-customer-service).

## What are the best practices for configuring Copilot?
 
- Use high-quality knowledge sources to generate responses.
- Review your knowledge sources before you enable Copilot.
- Restrict access to sources you don't want Copilot to use.

## Where can I access feedback for Copilot?

Feedback that customer service representatives provide on Copilot responses is stored in the `msdyn_copilotinteraction` and `msdyn_copilotevent` Dataverse tables. Learn more in [Retrieve verbatim feedback](../develop/download-copilot-transcript-data.md#retrieve-verbatim-feedback).

## Related information

[Responsible AI FAQ for Copilot in Customer Service](../implement/faq-responsible-ai-copilot.md)  
[FAQ for Copilot data security and privacy in Microsoft Power Platform](/power-platform/faqs-copilot-data-security-privacy)  
