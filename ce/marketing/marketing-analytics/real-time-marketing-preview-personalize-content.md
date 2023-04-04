---
title: " Preview personalized content (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to preview personalized content in Dynamics 365 Marketing."
ms.date: 04/04/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Preview personalized content

You can preview your personalized content in the Preview and test view – see details <link to “preview and test your email” section>. The following table details how different types of personalized content are shown in the preview:

• **Sample data**: You can enter values in the side pane to see how email content looks.

• **Existing record**: You can select an existing record in Dataverse. Preview uses data from this record for all dynamic text that uses this record type as the data source

| Personalization concept                          | How to preview                            |
|--------------------------------------------------|-------------------------------------------|
| Dynamic text                                     |                                           |
| ·       Using Audience                           | Select an audience record                 |
| ·       Using trigger                            | Manually provide test data                |
| ·       Using specific record                    | Select a record                           |
| Link, Button, and QR code that uses Dynamic text | (See relevant row above)                  |
| Brand profile                                    | Select a brand profile                    |
| Compliance                                       | Manually provide test data                |
| List                                             | Audience based: Select an audience record |
|                                                  | Specific record: Select a record          |
|                                                  | Others: Not supported                     |
| Inline condition                                 |                                           |
| ·       Using audience                           | Manually set True/False                   |
| ·       Using trigger                            | Manually set True/False                   |
| Conditional content                              | Select desired variation from the menu    |
| Customer Voice                                   | Uses selected CV Survey                   |
|                                                  | (Shown as anonymous link)                 |

> [!NOTE]
> 1. When an audience record is selected, any dynamic text and Lists that use audience as data source will be resolved using data from the selected record. User can enter sample values for remaining dynamic text, if any, that is not using audience as its source.
> 2. When dynamic text is defined using a specific record and a record is not actually selected, then preview uses default values. If a record is selected, preview will use data from that record.
