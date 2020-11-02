---
title: "Disable auto adjustment of HTML for email providers (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to disable the out of box HTML adjustment for emails"
keywords: Email HTML;Email design;Outlook
ms.date: 02/10/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
ms.assetid: 1893c4c9-8bfa-4156-a823-1b836199ea00
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Disable Auto-Adjustment of HTML for all providers

When emails are created in Dynamics 365 Marketing, users can create beautiful emails by simply dragging and dropping design elements into the email canvas. When these emails are created, Dynamics 365 Marketing applies some changes to the email HTML (visible in the Output HTML tab) to ensure that the email renders correctly across email providers (including Outlook) and across devices. In certain cases, you may want to create your marketing emails using pre-created email templates, by simply pasting in the HTML in the HTML tab. Additionally, you may want to apply email provider-specific adjustments yourselves. In this case, you can enable a per-email level switch to prevent the out of box auto-adjustment of email HTML.

> [!NOTE]
> You will need your administrator to [turn on the feature switch](admin-feature-switches.md) for the "Post-processing switch" functionality before you are able to access it in the email designer.

On the HTML tab in any email in the Draft or Live Editable state, you will see a new switch on the HTML editor canvas header, labelled "Auto-Adjust HTML for all providers". By default, this functionality is switched on. 

<!--- Alex Please Add Screenshot Here -->

When creating or editing your email, you can toggle this switch to turn off this auto-adjustment. You will get a confirmation dialog - click the "Turn it off for this" button. This will turn off auto-adjustment for that email.

