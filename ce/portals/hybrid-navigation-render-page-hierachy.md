---
title: "Use hybrid navigation to render page hierarchy for a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 39bad7b1-c4a0-458f-9a48-7d721d9a7cf1
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Render up to three levels of page hierarchy by using hybrid navigation
[comment]: <> (Need to regroup with other similar topics. This topic can be the landing topic.)
This example renders a type of hybrid navigation, based on the portal sitemap, that renders up to three levels of page hierarchy. The rules of this component are:

* The ancestor pages of the current page will be shown, back to the Home page (or to the maximum depth specified by the optional depth\_offset parameter). 
* If the current page has children, those child pages will be shown.
* If the current page has no children, the siblings of the current page will be shown.

### See Also

[Create advanced templates for portals](create-advanced-templates.md)  
[Create a custom page template by using Liquid and a web template page template](create-custom-template.md)  
[Create a custom page template to render an RSS feed](render-rss-custom-page-template.md)  
[Render the entity list associated with the current page](render-entity-list-current-page.md)  
[Render a website header and primary navigation bar](render-site-header-primary-navigation.md)  