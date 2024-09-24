---
title: Configure fields for generating what's new with my sales records list
description: Learn how to configure fields for generating what's new with my sales records list in Copilot for leads, opportunities, and accounts.
ms.date: 08/02/2024
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom:
  - bap-template
---

# Configure fields for generating what's new with my sales records list

The **What's new with my sales records** prompt lists the sales records that were updated in the last seven days. The list is generated from the audit history of the lead, opportunity, and account tables. Depending on the record type, Copilot uses different fields to get the list of records updated: 

- For the lead and opportunity records, Copilot uses the fields in the primary table (lead or opportunity) that you had [configured for generating the recent changes list](copilot-configure-summary-fields.md). For example, if you had configured four fields from the lead table and six fields from related tables, Copilot monitors changes to only those four fields from the lead table to identify the lead records that are updated.

- For the account records, Copilot lists the following changes:
  - Contacts, leads, and opportunities created for the account in the last seven days.
  - Changes to the fields in the **Quick Find** view of the account table. If you'd like to see changes to other fields, add them to the **Quick Find** view of your account table. [Learn how to add fields to the Quick Find view](/power-apps/maker/model-driven-apps/create-edit-views#how-to-access-the-view-editor-to-create-or-edit-views).