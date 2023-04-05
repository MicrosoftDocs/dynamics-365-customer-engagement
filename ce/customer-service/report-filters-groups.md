---
title: Report filters and groups
description: Learn how reports are grouped and how filters affect report groups in Dynamics 365 Customer Service and Omnichannel for Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: nenellim
ms.topic: conceptual 
ms.date: 02/14/2023
ms.custom: bap-template
---

# Report filters and groups

In Dynamics 365 Customer Service and Omnichannel for Customer Service, historical analytics reports are grouped into categories.

Omnichannel historical analytics reports:

- **Summary** and **Bot** tabs
- **Conversation**, **Queue**, and **Agent** tabs
- **Topics** tab
- **Voice** tab
- **Unified routing** tab

Customer Service historical analytics reports:

- **Summary**, **Agent**, and **Topics** tabs

Knowledge analytics reports:

- **Search Term Insights** tab
- **Article Insights** tab

When you set one or more filters on a report, the filters are applied to the entire report group. Say, for example, that you've set the "channel" filter to display records related to the live chat channel in the **Conversation** tab of the Omnichannel historical report. This filter is automatically applied to other tabs of the report group&mdash;**Queue** and **Agent**&mdash;but not to the **Bot**, **Summary**, **Topics**, **Voice**, or **Unified routing** tabs.

## Next steps

[Manage report bookmarks](manage-bookmarks.md)

### See also

[Configure analytics and insights dashboards](configure-customer-service-analytics-insights-csh.md)
