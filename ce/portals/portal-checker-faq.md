---
title: "Mitigation steps to the issues logged by the portal checker tool in Dynamics 365 for Customer Engagement Portal | MicrosoftDocs"
description: "Learn the mitigation steps to the issues logged by the portal checker tool."
ms.custom: 
  - dyn365-portal
ms.date: 01/31/2019
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: F7807673-978E-4097-B4CC-767DDCC2447C
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---

# Common portal issues and best practices

This document outlines common issues which can occur in your portal and cause a variety of problems. This also contains the checks which the portal checker (self-service diagnostics) tool automates and warns customers about.

## Portal does not load and displays a generic error page (Server Error in "/" application) 

This issue can be caused by a variety of reasons like when a portal is not able to connect to the underlying [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization, [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization doesn't exist or its URL has changed, when request to [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization is timed out, and so on. When you run the portal checker tool, it will try to determine the exact reason and will point you to the correct mitigation. 

Below is a list of most common causes and their correspondng mitigation steps:

### URL of the connected Dynamics 365 for Customer Engagement organization has changed 

This happens when the URL of [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization is changed by a user after portal is provisioned against the organization. To fix this issue, update the Dynamics 365 URL:

1. Go to the Dynamics 365 Administration Center page and select the **Applications** tab.
2. Select the name of the portal that you want to reset, and then select **Manage**.
3. Go to **Portal Actions** > **Update Dynamics 365 URL**. Once this action is successfully executed, your Dynamics 365 org url would be updated and Portal will start working.

## Dynamics 365 organization connected to your portal is in administration mode

This issue occurs when the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization is put in administration mode either when changing organization from production to sandbox mode or manually by an organization administrator.

If this is the cause, you can disable administration mode by performing actions listed [here](../admin/manage-sandbox-instances#administration-mode). Once administration mode is disabled, portal will work fine.

## Authentication connection between Dynamics 365 for Customer Engagement organization and portal is broken





