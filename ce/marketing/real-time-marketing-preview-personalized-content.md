---
title: Preview personalized content
description: Learn how to preview personalized content in Dynamics 365 Marketing.
ms.date: 07/06/2023
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

> [!NOTE]
> When you test send an email and use a sample audience record, the sent email uses condition outcomes or variations you manually select during test send (it will not use audience data for conditions). Always send email through a test journey to fully test emails with conditions and conditional content.

You can preview your personalized content in the **Preview and test** view. Learn more: [Preview and test send your email](email-preview.md)

To preview personalized content, select the **Preview and test** tab, then select **Edit sample data**. On the right pane, enter sample data values to see how email content looks. Alternatively, you can select an existing record for personalization in Dataverse. Alternatively, you can enter sample data values. Preview uses data from this record for all dynamic text that uses this record type as the data source. Whether you use sample data or select a record depends on the kind of personalization you're using.

The following table details how to preview different types of personalized content:

| Personalization concept                          | How to preview                                                                                                 |
| ------------------------------------------------ | -------------------------------------------------------------------------------------------------------------- |
| Dynamic text                                     |
| ·       Using Audience                           | Select an audience record or enter test data manually                                                                                      |
| ·       Using trigger                            | Manually provide test data (or select a Dataverse record where appropriate) *Custom triggers are not supported at this time                                                                                     |
| ·       Using specific record                    | Select a record or enter test data manually                                                                                   |
| Link, Button, and QR code that uses Dynamic text | (See relevant row above)                                                                                       |
| Brand profile                                    | Select a brand profile                                                                                         |
| Compliance                                       | Manually provide test data                                                                                     |
| List                                             | Audience based: Select an audience record<br><br>Specific record: Select a record<br><br>Others: Not supported |
| Inline condition                                 |                                                                                                                |
| ·       Using audience                           | Manually set True/False                                                                                        |
| ·       Using trigger                            | Manually set True/False                                                                                        |
| Conditional content                              | Select desired variation from the menu                                                                         |
| Customer Voice                                   | Uses selected CV Survey<br>(Shown as anonymous link)                                                           |

> [!NOTE]
> 1. When an audience record is selected, any dynamic text and lists that use audience as data a source will be resolved using data from the selected record. You can enter sample values for the remaining dynamic text, if any, that is not using audience as its source.
> 1. When dynamic text is defined using a specific record and a record is not actually selected, preview uses default values. If a record is selected, preview uses data from that record.

[!INCLUDE[footer-include](../includes/footer-banner.md)]