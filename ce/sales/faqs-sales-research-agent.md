---
title: FAQ about Sales Research Agent (preview)
description: Get answers to frequently asked questions about sales research agent in Dynamics 365 Sales.
ms.date: 03/27/2025
ms.custom:
 - responsible-ai-faqs
 - bap-template
ms.topic: faq
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# FAQs about Sales Research Agent (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note.md)]


## Why can't I access the Sales Research Agent?

You might not be able to access the Sales Research Agent in the following scenarios:

- Your tenant is in a region where the Sales Research Agent is not available. The Sales Research Agent is only available in the European Union (EU) and United States currently. If you're in the EU or United States but still see a notification that the agent isn't available, your tenant's data residency may be outside these regions.
- You don't have the required permissions to access the Sales Research Agent. You need the **Sales Research Agent Reader** role to access the agent. 
- You don't have enough credits in Copilot Studio to use the Sales Research Agent.

Reach out to your administrator to help resolve these issues.

## How can I refine a single block instead of the entire blueprint?

If you're using the AI Cursor and you pressed **Enter** after typing your prompt, your prompt will automatically create a new blueprint. To update only a single block on a blueprint, select **Generate** and then select **Update block**.

## Can I connect to other data sources?

Yes, you can connect to other Dynamics 365 and Dataverse environments if you have access to those. Additionally, you can upload data files to enrich your research further. Learn more in [Connect the Sales Research Agent to a different data source](sales-research-agent-connect-data.md).

## Why do I get an error when trying to upload a file?

You can upload a PDF (.pdf), CSV (.csv), and Excel (.xlsx) file. Learn more in [Supported data files](sales-research-agent-connect-data.md#supported-data-files).

## Which languages are supported by the Sales Research Agent?

Currently, the agent supports only English.

## Does the agent use Bing to search for information?

Yes, the Sales Research Agent uses Microsoft Bing when it can't find the information in the data sources you provided or if no data sources are provided. The use of Bing is subject to the Bing section of the [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

## What are the preview terms? Is Microsoft using my data to train their models? How do I know my data is safe?

The use of the Sales Research Agent is subject to the terms outlined in [Preview terms](https://go.microsoft.com/fwlink/?linkid=2189520).
