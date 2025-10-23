---
title: Edit the Opportunity Research Agent settings
description: 
ms.date: 07/09/2025
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Edit the Opportunity Research Agent settings

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

After starting the agent, you can edit its settings to suit your business needs. You can change the knowledge sources that the agent uses to generate insights, the frequency of research updates, and the segment of opportunities that the agent works on. 

This article describes the impact of the edits to the Opportunity Research Agent settings.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## What happens when you edit the agent settings?


| Settings modified      | Completed opportunities | In progress opportunities |
|------------------------|------------------------|--------------------------|
| Knowledge sources      | Changes will be applied to all opportunities during the next refresh cycle. | Continue with previous sources until next refresh cycle. |
| Selection criteria     | If the completed opportunity doesn't match the new selection criteria, opportunity research page will be removed and a banner appears. The opportunity will be removed from future refreshes. | Continue with previous criteria until next refresh |
| Opportunity segment    | No change              | Continue with previous segment until next refresh |
| Opportunity assessment fields | Changes applied during the next refresh. | Continue with previous fields until next refresh. |
| Value proposition      | Changes applied during the next refresh. | Continue with previous value proposition until next refresh. |

