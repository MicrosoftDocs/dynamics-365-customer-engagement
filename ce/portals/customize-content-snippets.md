---
title: "Customize content by using content snippets on a portal in Dynamics 365 | MicrosoftDocs"
description: "Learn how to customize content by using content snippets."
keywords: ""
ms.date: 01/26/2018
ms.service: dynamics-365-customerservice
ms.custom: dyn365-portal
ms.topic: article
ms.assetid: 64f9ec14-c22a-4337-af29-fc8b512cea63
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Drafting
---

# Customize content by using content snippets
Content snippets are small chunks of editable content that can be placed by a developer on a page template, allowing for customizable content to populate any portion of a page's layout easily. Snippet controls, which are responsible for rendering the content of snippets on the web-facing portal, are placed on .aspx pages by developers.

## Edit snippets

Snippets can be edited either through the front-side or through the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] interface. The main power of the snippet is the fact that you can abstract a bit of content (other than the main copy of the page) and edit it separately, allowing essentially any static content on your site to be fully content-managed and front-side editable but still backed by [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)].

## Edit by using the front-side editing engine

To edit snippets by using the front side, users must be associated with a Web Role that is associated with a Website Access Permission record with the **Manage Content Snippets** permission set to true.

To edit through the front side, point to the snippet element and select **Edit**. You must have website access permissions to edit snippets. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Control webpage access for portals](webpage-access-control.md)  

When editing a snippet, either a simple text box will appear, allowing you to quickly edit the content, or the full editor appears, as it does when editing a page's copy. Which of these two interfaces appears is determined by the edit type of the snippet, which also determines the type of content the snippet can hold (full, stylized HTML content versus plain text). A snippet can be assigned an edit type of either text or HTML when a developer adds the Content Snippet control to the page template in the portal's [!INCLUDE[pn-visual-studio-short](../includes/pn-visual-studio-short.md)] project.

## Edit using Dynamics 365

1.  Go to **Portals** > **Content Snippets**.
2.  To create a new snippet: Select **New**.
3.  To edit an existing snippet: double-click to select an existing **Content Snippet** in the grid.

Enter values for the following fields:

| Name    | Description                                                                                                   |
|---------|---------------------------------------------------------------------------------------------------------------|
| Name    | The name can be used by a developer to place the snippet value into a page template within the portal's code. |
| Website | The website that is associated with the snippet.                                                              |
| Value   | The content of the snippet to be displayed in the portal. This can contain plain text or HTML markup.         |

### See also

[How to provision a portal](provision-portal.md)  
[Get started with the portal content editor](get-started-portal-content-editor.md)  
[Use the front-side editing engine to publish content](publish-content-editing-engine.md)  
[Add dynamic content and create custom templates](custom-templates-dynamic-content.md)  

