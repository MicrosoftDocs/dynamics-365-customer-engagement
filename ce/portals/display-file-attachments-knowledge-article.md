---
title: "Display file attachments with knowledge articles on a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 07/02/2017
ms.service: crm-online
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

[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] allows Knowledge Manager to author knowledge articles. Notes attachment can be added to knowledge articles which can be used by users. These attachments are not displayed automatically on portals, thereby limiting the effectiveness of self-service.

To display knowledge articles with downloadable file attachments, you must create the site setting KnowledgeManagement/DisplayNotes and set the value to true. When you set the site setting to true, knowledge articles are displayed along with their attachments and allow Portal users to search for these attachments.

By default, only notes with the \*WEB\* prefix will be published to the portal. Just add the prefix in front of the body of the note text as you are creating the Note in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)], and it will be published on the portal. If you want a note with a different prefix to be published to the portal, you must modify the value of the site setting KnowledgeManagement/NotesFilter to the desired prefix. The value entered for this site setting is used to filter which notes with attachment are displayed on the portal. Notes without attachment are not displayed even if they match the filter. If you do not specify anything for the site setting, all attachments are displayed on the portal and will be searchable.

> [!Note]
> - The Notes title is not exposed on the Portal. Only the note description and file attachment name are exposed and are searchable.
> - Notes are grouped under a knowledge article. A maximum of three notes matching the search result for a knowledge article are displayed.
> - If the search term matches with a knowledge article and an attachment, all the notes text and the file attachment name are highlighted.
> - If the search term matches only with an attachment, the corresponding article is also displayed.
