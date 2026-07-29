---
title: Sales Opportunity Agent FAQs
description: Find answers to common questions about Sales Opportunity Agent data storage, deletion, and privacy compliance in Dynamics 365 Sales.
ms.date: 07/29/2026
ms.topic: faq
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Sales Opportunity Agent FAQs

## What personal data does Sales Opportunity Agent store?

Sales Opportunity Agent stores opportunity research insights and supporting metadata in Microsoft Dataverse. Depending on the enabled capabilities, stored data can include AI-generated opportunity insights, opportunity mapping information, competitor insights, and meeting metadata. The data is stored in Dataverse tables used by the Sales Opportunity Agent, such as `msdyn_opportunityrankermapping`. When analyzing meetings, the system captures attendee email addresses as personal data.

The `msdyn_opportunityrankermapping` table can contain a record similar to the following:

```json
{
  "msdyn_meetingoriginalsourceid": "22222b22-2b22-2222-2222-222bb22bb22b",
  "msdyn_generatedemailinsights": "...",
  "msdyn_bantdata": "...",
  "msdyn_detectedcompetitors": "[\"Contoso Competitor\"]",
  "msdyn_mappedopportunityid": "aa111a11-a11a-1111-a111-11a1a1aa11aa",
  "msdyn_meetingmetadata": {
    "calendarEventId": "sample-calendar-event-id",
    "attendees": [
      "buyer@contoso.com",
      "legal@contoso.com"
    ]
  }
}
```

Here, the attendee email addresses stored in the `msdyn_meetingmetadata` field are considered personal data under applicable privacy regulations. The `calendarEventId` might also be associated with customer communication records.

## How can I delete personal data?

Organizations use standard Microsoft Dataverse and Dynamics 365 Sales administrative capabilities to locate, export, update, and delete records stored by Sales Opportunity Agent. If your organization needs to respond to a data subject request (DSR) or comply with privacy regulations such as GDPR, administrators can identify and remove records containing personal data from the relevant Dataverse tables, including `msdyn_opportunityrankermapping`. Dynamics 365 Sales provides data management capabilities that help organizations meet their privacy and regulatory obligations. For more information, see [Dynamics 365 Sales and privacy laws and regulations](dynamics-365-sales-privacy.md).

To delete personal data, follow these steps:

1. Sign in to [Power Apps portal](https://make.powerapps.com) with an account that has the necessary permissions to manage Dataverse tables.
1. Search and select your organization's environment.
1. Select **Search** and then select **Select for rows in a table using advanced filters**.
1. In the **Look for** list, select the `msdyn_opportunityrankermapping` table.
1. Select **Edit columns**.
1. On the columns that you want to remove, select more options and then select **Remove**. For example, `msdyn_meetingmetadata`.
1. Select **Apply**.
    The application removes the selected columns from the table, and any personal data stored in those columns is deleted.  

### Related information

[Sales Opportunity Agent overview](sales-opportunity-agent.md)