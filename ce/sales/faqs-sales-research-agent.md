---
title: FAQ about Sales Research Agent
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

# FAQs about Sales Research Agent


## Why can't I access the Sales Research Agent?

You might not be able to access the Sales Research Agent in the following scenarios:

- Your tenant is in a region where the Sales Research Agent is not available. For a list of supported regions, go to the [International availability report](https://releaseplans.microsoft.com/en-US/availability-reports/?report=featuregeoreport). If you're in one of these geographies or regions but still see a notification that the agent isn't available, your tenant's data residency may be outside these regions.
- You don't have the required permissions to access the Sales Research Agent. You need the **Sales Research Agent Reader** role to access the agent. 
- You don't have enough credits in Copilot Studio to use the Sales Research Agent.

Reach out to your administrator to help resolve these issues.

## How can I refine a single block instead of the entire blueprint?

If you're using the AI Cursor and you pressed **Enter** after typing your prompt, your prompt will automatically create a new blueprint. To update only a single block on a blueprint, select **Generate** and then select **Update block**.

## Can I connect to other data sources?

Yes, you can connect to other Dynamics 365 and Dataverse environments, and Fabric Lakehouse if you have access to those. Additionally, you can upload data files to enrich your research further. Learn more in [Connect the Sales Research Agent to a different data source](sales-research-agent-connect-data.md).

## Why do I get an error when trying to upload a file?

You can upload a PDF (.pdf), CSV (.csv), and Excel (.xlsx) file. Learn more in [Supported data files](sales-research-agent-connect-data.md#supported-data-files).

## Which languages are supported by the Sales Research Agent?

For a list of supported languages, go to the [International availability report](https://releaseplans.microsoft.com/en-US/availability-reports/?report=featurelangreport).

## How does the Sales Research Agent handle currency? 

The Sales Research Agent uses the base currency of the Dynamics 365 Sales environment that it is connected to. For analysis using Fabric Lakehouse or uploaded files, the agent infers the currency based on the information available to it through the Lakehouse environment, or based on instructions in general context or any business function applied to the prompt. 

## Does the agent use Bing to search for information?

Yes, the Sales Research Agent uses Microsoft Bing if no data sources are provided. The agent only uses the prompt provided by the user to write the query that goes to Bing Search. The use of Bing is subject to the Bing section of the [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

## Where can I find the terms of use? 

The use of the Sales Research Agent is subject to the terms outlined in [Microsoft Product Terms](https://www.microsoft.com/en-us/licensing/product-licensing/products).