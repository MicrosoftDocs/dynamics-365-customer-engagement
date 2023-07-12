---
title: Use Sales Copilot capabilities
description: 
ms.date: 07/07/2023
ms.custom: bap-template
ms.topic: how-to
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
---

# Use Sales copilot capabilities

Copilot is an AI assistant that helps you be more productive and efficient in your daily work. Sales Copilot can summarize records, help you catch up on updates, prepare for meetings, respond to emails, and so on.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## Prerequisites

To use Sales Copilot, your administrator must have [enabled and set it up](enable-setup-copilot.md). 

## Launch Sales Copilot

Sales Copilot launches automatically when you access the Sales Hub app. If it's closed, launch it from the Sales Hub app by selecting the Sales Copilot icon (:::image type="icon" source="media/copilot-icon.png" border="false":::) in the right most bar.

## Use Sales Copilot

In the Sales Copilot (preview) pane, type / to get the list of suggested requests. 
:::image type="content" source="media/sales-copilot-pane.png" alt-text="Screenshot of the Sales Copilot pane along with the list of suggested requests":::

The following table lists the requests you can make to Sales Copilot.


|Request  |Response  |
|---------|---------|
|Summarize opportunity     | Summarizes the given opportunity based on the fields configured by your administrator.          |
|Summarize lead     | Summarizes the given lead based on the fields configured by your administrator. Copilot can also suggest possible contacts for a lead.        |
|Catchup with opportunity      | Summarizes the changes to the given opportunity since the last seven days, based on fields configured by your administrator.        |
|Catchup with lead     | Summarizes the changes to the given lead since the last seven days, based on fields configured by your administrator.        |
|Prepare for upcoming meetings     | Lists your upcoming meetings scheduled in Dynamics 365. After you select the meeting that you'd like to prepare for, Copilot generates a summary based on the last 3 interactions from the Notes content of the related record. The summary is only generated from the notes recorded in the last 3 months.
|Show latest news for account     | Displays the latest news about a given account, curated from Bing.         |

You can use the Sales Copilot pane from any page in the Sales Hub app. Type the record name after the @ symbol to view the summary or catch up of the record.  


## Provide feedback

Rate the usefulness of the response by selecting the thumbs up or thumbs down icon. <<Author's note: Who gets the response and how does it improve?>>

## See also

[Copilot overview](copilot-overview.md)
[Configure copilot capabilities](configure-sales-copilot.md)
