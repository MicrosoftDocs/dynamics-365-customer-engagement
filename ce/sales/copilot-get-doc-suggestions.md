---
title: Use Copilot to get suggestions and answers from SharePoint
description: Discover how integrating SharePoint with Sales allows Copilot to recommend product-related documents and answer queries from stored files.
ms.date: 04/30/2024
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

# Use Copilot to get suggestions and answers from SharePoint

If you have integrated SharePoint with Dynamics 365 Sales, Copilot can recommend documents related to the products in the sales records. You can also ask questions about the products and get answers from the documents stored in SharePoint.

## Prerequisites

- Your organization must have integrated SharePoint with Dynamics 365 Sales.
- The SharePoint site must be associated with your tenant.
- You must have the required permissions to access SharePoint documents.


<a name="copilot-content-recommendation"></a>
## Get document recommendations from SharePoint
 
As a salesperson, you need to be aware of the latest product and account-related information, such as product brochures, pricing, sales pitch, and specifications, which are typically stored in SharePoint. You can ask Copilot to provide you with the list of SharePoint documents related to your sales records.

To get document recommendations, use one of the following methods in the Copilot chat window:

- Use natural language chat. For example, you can ask Copilot, **Show me the product-related files for Contoso opportunity** to get the list of documents related to the products associated with the opportunity. Or, you can ask **Show me the related files for Contoso** to get the list of documents related to the account.

- Select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) in the chat window, select **Get info** > **Show related files**, and enter the record name.

- Select the follow-up prompt **Show related files** if available. The follow-up prompt is displayed depending on the type of record and whether products or accounts are associated with the record. For example, if you have associated products with an opportunity, you'll see the follow-up prompt **Show related files**. The follow-up prompt is also displayed when you use Copilot to [prepare for a meeting](copilot-stay-ahead.md#prepare-for-upcoming-sales-appointments). 

The documents are listed in the ranking order of SharePoint search results. [Learn more about which files are listed](#which-files-are-listed)

:::image type="content" source="media/get-files-from-sharepoint.svg" alt-text="Screenshot of the list of files fetched from SharePoint.":::

### Which records are supported?

The **Show related files** prompt is supported for the account, contact, lead, opportunity, quote, order, and invoice records.

### Which files are listed?

The **Show related files** prompt lists the files that meet the following criteria:

- The file must be of type Word, Excel, PowerPoint, or PDF.

- The file must be related to a product or account. 

    - For the records that have associated products, such as opportunity and quote, files related to the associated products are listed. If there are no product associations in the record or no product-related files in SharePoint, the files related to the account are listed.

    - For the records that don't have associated products, such as accounts, contacts and leads, the files related to the account are listed.


<a name="copilot-content-qa"></a>
## Get answers from SharePoint documents

As a seller, you might have to refer to documents such as contracts, technical documents, and marketing collateral to answer questions from your customers. If these documents are stored in SharePoint, Copilot can help you find answers from the documents and summarize them for you.

**To get answers from SharePoint documents**

1. [Open Copilot](use-sales-copilot.md#open-copilot) and select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::).

1. Select **Get info** > **Get info from SharePoint about** and type in your question.
   If the answer is available in SharePoint, Copilot summarizes the answer and provides links to the corresponding documents in SharePoint.

**To get answers from Dataverse and SharePoint**

1. [Open Copilot](use-sales-copilot.md#open-copilot) and type in your question in natural language, and select **Enter**.
    You need not open a record to ask Copilot a question. For example, you can ask Copilot, **What is the warranty period for Contoso 3D printers?** or **What is the price of Contoso 3D printers?**.

    Copilot searches for answers from the sales data stored in Dataverse first. After the result is displayed, you'll see a follow-up prompt.

2. Select the follow-up prompt **Search for the answer in SharePoint**.  
   If the answer is available in SharePoint, Copilot summarizes the answer and provides links to the corresponding documents in SharePoint.