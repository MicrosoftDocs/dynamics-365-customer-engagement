---
title: "Display file attachments with knowledge articles on a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to display file attachments with knowledge articles on a portal in Dynamics 365."
ms.custom:
  - dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 4D1B4F5A-43C8-4229-9984-A5065462DED4
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---

# Display file attachments with knowledge articles

Knowledge articles help you achieve self-service. As a Knowledge Manager, you might want to share some downloadable files along with your articles to provide detailed information or a case study. [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] allows you to author knowledge articles and add them as notes attachments that can be used by users. These attachments are not displayed automatically on portals, thereby limiting the effectiveness of self-service.

To display knowledge articles with downloadable file attachments, you must [create the site setting](configure-site-settings.md) KnowledgeManagement/DisplayNotes and set the value to true. When you set the site setting to true, knowledge articles are displayed along with their attachments, so portal users can search for these attachments.

You can continue to use the legacy behavior of prefixing the notes description with \*WEB\* to publish it on the portal. If you want a note with a different prefix to be published to the portal, you must [modify the value of the site setting](configure-site-settings.md) KnowledgeManagement/NotesFilter to the prefix you want. The value entered for this site setting is used to filter which notes with attachments are displayed on the portal. Notes without attachments are not displayed even if they match the filter. If you do not specify anything for the site setting, all attachments are displayed on the portal and will be searchable.

> [!Note]
> - The Notes title is not exposed on the portal. Only the note description and file attachment name are exposed and are searchable.
> - Notes are grouped under a knowledge article. A maximum of three notes matching the search result for a knowledge article are displayed as part of the search results.
> - If the search term matches with a knowledge article and an attachment, all the text from the note and the file attachment name are highlighted.
> - If the search term matches only with an attachment, the corresponding article is also displayed.
