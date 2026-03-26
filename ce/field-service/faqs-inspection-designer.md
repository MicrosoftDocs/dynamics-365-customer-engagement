---
title: FAQ about creating inspection templates with Copilot in Field Service (preview)
description: Get answers to common questions about the AI technology used to create inspection templates with Copilot, details about how the AI is used, how it was tested and evaluated, and any specific limitations.
ms.date: 10/23/2025
ms.update-cycle: 180-days
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
ms.custom: 
  - responsible-ai-faqs
ms.collection: bap-ai-copilot 
---

# FAQ about creating inspection templates with Copilot in Field Service (preview)

The feature to [create inspection templates with Copilot in Field Service (preview)](inspections-copilot.md) helps service managers who need to create inspection templates for technicians and operators.

## What is the create inspection templates with Copilot (preview) feature?

Service organizations often have numerous procedures, forms, and checklists stored in various formats like paper and PDF files. With Copilot in Field Service, makers quickly upload and digitize these documents to integrate them into Field Service work orders.
Copilot converts the uploaded documents into a draft inspection template that is editable and publishable. Technicians complete these inspection templates while finishing work order tasks in the Field Service mobile app.

## What are the feature's capabilities?

Service managers upload a PDF or an image of a checklist or an inspection form, and Copilot converts it to a draft of a new inspection template in Field Service. They review the accuracy of the conversion, discard it, preview it, and make any edits needed before saving it for future use by technicians and operators.

## What is the feature's intended use?

This feature simplifies creating inspection templates using information that exists in paper format or as an electronic document.

## How the feature is tested and what metrics measure its performance

The feature is tested using a collection of sample inspection forms in English. The accuracy and performance of the conversions are checked by comparing them against a copy of the original inspection form.
This feature is evaluated using both conventional performance testing and methods specifically targeted to AI features to ensure user safety and security. An extensive set of test cases is used to evaluate the risk of generating sensitive or harmful content. Standardized internal tooling provides further testing to ensure harm filters and security mitigations function as intended, including preventing attacks such as jailbreak attempts. Evaluation continues with each update throughout the feature's lifecycle. 

Learn more about [Microsoft Responsible AI principles](https://www.microsoft.com/ai/responsible-ai).

## What are the limitations of the feature and how can you minimize their impact?

This feature is in preview, and we're working on improving it. Review the draft created by Copilot for accuracy and completeness, and edit the inspection template before saving and publishing it. Help improve the feature by submitting feedback about the draft created by Copilot using the like/dislike buttons on the converted inspection templates. This data is used to evaluate and improve the quality of the conversion. For more information about release plans, see [Use inspection builder to create inspections from existing files](/dynamics365/release-plan/2024wave2/service/dynamics365-field-service/planned-features).

- The feature is tested in English. Using it in other languages might not produce good results.  
- The feature can't convert large forms with many pages of content. The conversion process only creates question types compatible with current Field Service inspection templates.
- You can't customize the prompt instructions used by Copilot to convert documents.
- Complex forms or low-quality images of forms might make it difficult for Copilot to correctly convert the form to an inspection template.
- Copilot might convert content in a way that isn't optimal. For example, instead of converting a multiple-choice question as a drop-down type, Copilot might convert it as a radio group type. You can refine the inspection template before saving it. 

## What operational factors and settings allow effective and responsible use of the feature?

Admins can enable or disable the feature for your environment by going to the Copilot in Field Service settings and toggling the **Create Inspection Templates (preview)** option.

[Learn more about the data collection policy of this feature.](/dynamics365/faqs-copilot-data-security-privacy)

Converted forms don't go into use automatically. They require several manual steps before they are available for technicians and operators.

## See also

- [Create inspections with Copilot (preview)](inspections-copilot.md)
- [Add inspections to work orders](inspections.md)
- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)
