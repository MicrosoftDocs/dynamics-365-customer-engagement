---
title: Connect the Sales Research Agent to a different data source or upload data (preview)
description: Learn how to connect the Sales Research Agent to your data.
manager:
ms.date: 09/19/2025
ms.topic: overview
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Connect the Sales Research Agent to a different data source (preview) 

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Sales Research Agent is connected to your Dynamics 365 Sales environment by default. However, you can connect to other Dataverse environments or upload data files (CSV, Excel, PDF) as additional data sources with sales and business data. You can also choose to remove existing connection entirely and just use the uploaded files as basis for your research. This allows you to create comprehensive research blueprints with the Dynamics 365 data, uploaded data, or both combined.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note.md)]

Add the data source using *one* of the following options in the **Sales Research Agent** page:

- Select **Data** at the top-right corner of the page and choose **Add data**.
- Select **Add data** in the **Ask any business question** prompt box.

    :::image type="content" source="media/sales-research-agent-add-data.png" alt-text="Screenshot of the Add data option in the Sales Research Agent." lightbox="media/sales-research-agent-add-data.png":::

## Use data from other Dynamics 365 Sales environments

- If you have access to multiple environments, choose the environment that has the data you want to analyze.

- Based on the question you ask, the agent looks through the data source for the most relevant data to answer the question. The agent depends on the metadata available (for example, table and column headers and descriptions) to help identify the most relevant data. 
- Make sure that custom tables and fields added to Dynamics 365 Sales have proper descriptions. The agent uses these descriptions to understand the data and provide better insights.
- The blueprint generated depends on the data found. If no data is found, then the Sales Research Agent shows an error and might ask if you can rephrase the question.  
- If you use the AI cursor to ask follow-up questions, the agent considers the data source again to answer it unless you specify a different data source.  

## Supported data files

You can upload a PDF (.pdf), CSV (.csv), or Excel (.xls) file. The following limitations apply to file uploads:

- The maximum supported file size is 10 MB. 
- The maximum number of uploaded files is 5, and the maximum total size for all files is 30 MB. 
- Encrypted, password-protected, or copyright-managed files aren’t supported.
- CSV:
    - Data within the file needs to be separated by commas.
- Excel:
    - Column header in the first row only.
    - No more than 10 tables and a maximum of 50 columns for each table.
    - Can’t contain merged cells.
    - Elements such as images, charts, and macros can't be processed.
- PDF:
    - 150 maximum supported number of pages per file.
    - Must contain selectable text. You can test it by trying to highlight text within the PDF. If you can’t select or highlight the text, then it can't be processed.
    - Use original digital documents or PDFs that are converted directly from word processors or other digital sources. A scanned PDF doesn't work.
    - If the PDF contains tables, make sure the borders are clearly outlined. Avoid using any contrasting colors to differentiate between rows and columns.

## Related information

- [Analyze your sales performance using the Sales Research Agent (preview)](use-sales-research-agent.md)
- [Frequently asked questions about Sales Research Agent (preview)](faqs-sales-research-agent.md)
