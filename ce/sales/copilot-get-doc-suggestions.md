---
title: Use Copilot to get content recommendations and answers from SharePoint
description: Discover how integrating SharePoint with Sales allows Copilot to recommend product-related documents and answer queries from stored files.
ms.date: 01/15/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:04/15/2024
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Use Copilot to get content recommendations and answers from SharePoint

Copilot can recommend documents related to the products and accounts in your sales records. You can also ask questions about the products and get answers from the documents stored in SharePoint.  

> [!NOTE]
> If your admin has [configured Copilot to use specific SharePoint folders](copilot-sharepoint-config.md), Copilot searches for documents only in those folders. If not, Copilot searches all the SharePoint folders that you have access to.

## Prerequisites

- You must have the SharePoint Online license.
- You must have at least read permission to access SharePoint documents. If you only have access to specific folders or sites, Copilot displays relevant documents from only those folders or sites.

<a name="copilot-content-recommendation"></a>

## Get content recommendations from SharePoint
 
As a salesperson, you need to be aware of the latest product and account-related information, such as product brochures, pricing, sales pitch, and specifications, which are typically stored in SharePoint. You can ask Copilot to provide you with the list of SharePoint documents related to your sales records.

To get content recommendations, use one of the following methods in the Copilot chat window:

- Select **View Prompts** above the Copilot chat box, select **Get info** > **Show files from SharePoint**. Type "/" to select a specific record or remove "related to" from the prompt and press **Enter** to view files related to the record that you've opened.  
- Use natural language chat. For example, you can ask Copilot, **Show me the product-related files** or **Get files related to this** or **Display documents for the *opportunity name***.  
- Select the follow-up prompt **Show related files from SharePoint** if available.  
    - The follow-up prompt is displayed depending on the type of record and whether products or accounts are associated with the record. For example, if you have associated products with an opportunity, you'll see the follow-up prompt **Show product-related files**.  
    - The follow-up prompt also appears after Copilot responds to the [prepare for a meeting](copilot-stay-ahead.md#prepare-for-upcoming-sales-appointments) prompt to help you gather relevant files for the meeting based on the account or product involved.  

The documents are listed in the ranking order of SharePoint search results. [Learn more about which files are listed](#which-files-are-listed)

:::image type="content" source="media/get-files-from-sharepoint.svg" alt-text="Screenshot of the list of files fetched from SharePoint.":::

### Which records are supported?

The SharePoint content recommendation capability is supported for the account, contact, lead, opportunity, quote, order, and invoice records.

### Which files are listed?

The **Show related files** prompt lists the files that meet the following criteria:

- The file must be of type Word, Excel, PowerPoint, or PDF. 
- The file must be related to the product or account associated with the record, or any other keywords provided in the prompt.  
    - For the records that have associated products, such as opportunity and quote, files related to the associated products are listed. If there are no product associations in the record or no product-related files in SharePoint, the files related to the account are listed.  
    - For the records that don't have associated products, such as accounts, contacts and leads, the files related to the account are listed.  
    - Apart from product and account-related files, you can also ask Copilot to get files related to any keyword. For example, you can ask **Show files related to Healthcare case studies**.

<a name="copilot-content-qa"></a>
## Get answers from SharePoint documents

As a seller, you might have to refer to documents such as contracts, technical documents, and marketing collateral to answer questions from your customers. If these documents are stored in SharePoint, Copilot can help you find answers from the documents and summarize them for you.

You can ask questions in your preferred language. Copilot searches for answers from all the SharePoint documents that you have access to, irrespective of the language of the documents and responds in your preferred language. For a list of supported languages, see [this report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

**To get answers from SharePoint documents**

1. [Open Copilot](use-sales-copilot.md#open-copilot) and select **View Prompts** above the Copilot chat box.  
1. Select **Get info** > **Get info from SharePoint** and then type in your question.  
   Alternatively, you can ask Copilot a question in natural language. To search in SharePoint directly, include the term **SharePoint** in your question. For example, you can ask, **Get me the recent case studies related to this opportunity from sharepoint**. Otherwise, Copilot searches for answers from the sales data stored in Dataverse first.  
   If the answer is available in SharePoint, Copilot summarizes the answer and provides links to the corresponding documents in SharePoint. If you're not getting the expected results, see the [tips for asking the right questions](#tips-for-asking-the-right-questions).

**To get answers from Dataverse and SharePoint**

1. [Open Copilot](use-sales-copilot.md#open-copilot) and type in your question in natural language, and select **Enter**.  
    You need not open a record to ask Copilot a question. For example, you can ask Copilot, **What is the warranty period for Contoso 3D printers?**  
    Copilot searches for answers from the sales data stored in Dataverse first. After the result is displayed, you'll see a follow-up prompt.  
1. Select the follow-up prompt **Search for the answer in SharePoint**.  
   If the answer is available in SharePoint, Copilot summarizes the answer and provides links to the corresponding documents in SharePoint.

### Tips for asking the right questions

To get accurate answers from SharePoint documents, follow these tips:

- Ask questions related to sales. The questions must contain words relevant to the configured SharePoint content and also related to sales. For example, a question like **Get info from SharePoint What are the sales figures for Contoso laptops in Q1?** (assuming relevant documents are available in SharePoint) will be answered. However, generic questions like **Get info from SharePoint What is the capital of France?** will not be answered, as the question is not related to sales.
- Use the right keywords. The whole question is broken down into keywords, which are then used to search all available SharePoint documents. So ensure the question contains proper keywords based on what you're looking for.
- Ask simple and clear questions. Avoid complex keywords such as GUIDs, technical terms, or jargon that might not be present in the documents.
- Don't include file names. Including a file name in the question, such as **Get me the recent case studies from sharepoint file case-studies.docx**, doesn't restrict the search to that file. Instead, Copilot interprets the file name as a keyword and searches across all documents for that keyword.
- Don't ask questions related to harmful content. Copilot doesn't provide answers to questions that are harmful or inappropriate. [Learn more about how Copilot blocks harmful content](/dynamics365/faqs-copilot-data-security-privacy#how-does-copilot-block-harmful-content).