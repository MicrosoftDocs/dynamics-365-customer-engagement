---
title: "Troubleshoot first time setup (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to solve common issues that can occur during the initial setup of Dynamics 365 for Marketing"
keywords: "troubleshooting;setup"
ms.date: 01/31/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 4c2bc52f-595c-4728-9ef5-5e3281ca0cc0
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Troubleshoot first time setup of Dynamics 365 for Marketing

Read this topic to find solutions to known issues that can sometimes occur during the initial setup of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

## Authorization fails due to unmanaged organization state

In some cases, when you sign up for a trial of [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] or [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)], you will receive an organization that is in an _unmanaged_ state, which means (among other things), that you can't get permission to install third-part solutions&mdash;including [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. As a result, you'll see the following error message when you run the setup wizard for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]:

![Unmanaged org error](media/setup-ts-unmanaged-aad.png "Unmanaged org error")

To fix this, you must convert your unmanaged org into a managed one and then run the setup wizard again. For instructions about how to do this, see [Take over an unmanaged directory as administrator in Azure Active Directory](https://go.microsoft.com/fwlink/?linkid=866753).