---
title: Connect the sales research agent to your data
description: Learn how to connect the sales research agent to your data.
manager:
ms.date: 03/17/2025
ms.topic: overview
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Connect the sales research agent to your data

You can connect the sales research agent to your Dynamics 365 Sales or Dataverse environment, and upload data files (CSV, Excel, PDF) for additional context. This allows you to create comprehensive research blueprints that combine data from multiple sources.

On the Sales Research Agent page in the Sales Hub app, select **Add data** to connect to your data.

:::image type="content" source="media/sales-research-agent-add-data.png" alt-text="Screenshot of the Add data option in the sales research agent.":::

## Use data from Dynamics 365 Sales

You can connect to your business data from Dynamics 365 Sales, which enables you to do rich analysis across your business data estate.

- If you have access to multiple environments, choose the environment that has the data you want to analyze.

- Based on the question you ask, the agent looks through the data source for the most relevant data to answer the question. The agent depends on the metadata available (for example, table and column descriptions) to help identify the relevant data. This connection has same limitations on number of tables and rows as the Dataverse connection. 
- Make sure that custom tables and fields added to Dynamics 365 Sales have proper descriptions. The agent uses these descriptions to understand the data and provide better insights.
- The blueprint generated depends on the data found. If no data is found, then the sales research agent shows an error and might ask if you can rephrase the question.  
- If you use the AI cursor to ask follow-up questions, the agent will consider the data source again to answer it unless you specify a different data source.  

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
