---
title: FAQ about creating inspection templates with Copilot in Field Service (preview)
description: Get answers to common questions about the AI technology used to create inspection templates with Copilot, details about how the AI is used, how it was tested and evaluated, and any specific limitations.
ms.date: 11/13/2024
ms.topic: how-to
author: alvinv
ms.author: alvinv
ms.custom: 
  - responsible-ai-faqs
  - ignite-2024
ms.collection: bap-ai-copilot 
---

# FAQ about creating inspection templates with Copilot in Field Service (preview)

The feature to [create inspection templates with Copilot in Field Service (preview)](inspections-copilot.md) helps service managers that need to create inspection templates for technicians and operators.

## What is the Create Inspection Templates with Copilot (preview) feature?

Service organizations often have numerous procedures, forms and checklists stored in various formats like paper, and PDF files. With Copilot in Field Service, makers can quickly upload and digitize these documents to integrate them into Field Service work orders.
Copilot converts the uploaded documents into a draft of an inspection template that can be edited and published. Technicians can complete these inspection templates when completing work order tasks in the Field Service mobile app.

## What are the feature's capabilities?

Service managers can upload a PDF or an Image of a checklist or an inspection form and Copilot will convert it to a draft of a new inspection template in Field Service. They can review the accuracy of the conversion, discard it, preview it, and make any edits needed before saving it for future use by technicians and operators.

## What is the feature's intended use?

This feature is intended to simplify the creation of inspection templates based on information that currently exists in a paper format or as an electronic document.

## How was the feature tested and what metrics are used to measure its performance?

We tested the feature using a collection of sample inspection forms in English. We checked the accuracy and performance of the conversions, comparing them against a copy of the original inspection form.
This feature was evaluated using both conventional performance testing and methods specifically targeted to AI features to help ensure user safety and security. An extensive set of test cases was used to evaluate the risk of generating potentially sensitive or harmful content. Standardized internal tooling provided further testing to help ensure harm filters and security mitigations functioned as intended, including prevention of attacks such as jailbreak attempts. More evaluation takes place with each subsequent update throughout the feature's lifecycle. 

[Learn more about Microsoft Responsible AI principles.](https://www.microsoft.com/ai/responsible-ai)

## What are the limitations of the feature and how can I minimize their impact?

This feature is in preview, and we're working on improving it. Review the draft created by Copilot for accuracy and completeness and edit the inspection template before saving and publishing it. You can help us by submitting feedback about the draft created by Copilot, using the like/dislike buttons on the converted inspection templates. We use this data to evaluate and improve the quality of the conversion.

- The feature was tested in English. If you use it in other languages, you might not get good results.  
- The feature can't convert large forms with many pages of content. The conversion process will only create question types compatible with current Field Service inspection templates.
- Users cannot customize the prompt instructions used by Copilot to convert documents.
- Very complex forms or low-quality images of forms may make it difficult for Copilot to correctly convert the form to an inspection template.
- Copilot might convert content in a manner that is not optimal. For example, instead of a multiple-choice question as a drop-down type, Copilot might convert it as a radio group type. However, you can always refine the inspection template before saving it. 

## What operational factors and settings allow for effective and responsible use of the feature?

Administrators can enable or disable the feature for your environment by going to the Copilot in Field Service settings and toggling the Create Inspection Templates  (preview) option.

[Learn more about the data collection policy of this feature.](/dynamics365/faqs-copilot-data-security-privacy)

Converted forms are not put into use automatically but require several manual steps before they become available for technicians and operators to use.

## See also

- [Create inspections with Copilot (preview)](inspections-copilot.md)
- [Add inspections to work orders](inspections.md)
- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)
