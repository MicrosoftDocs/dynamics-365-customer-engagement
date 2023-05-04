---
title: FAQ about case management
description: Learn about the frequently asked questions (FAQ) on the different features in case management.
ms.date: 04/18/2023
ms.topic: concept
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
---

A few answers to common questions about the case management are listed here.

## An error occurs when agents try to resolve a case. What should I do?

If agents encounter the following error when they select **Resolve Case**, it indicates that the Dataverse search isn't configured. 

'Could not load type "Microsoft.crm.cdshttpContext" from assembly "Microsoft.Xrm.Kernal.Contacts.Internal.Version=9.0.0.0, Culture=neutral'

You need to make sure that your Dataverse search is configured. More information: [Configure Dataverse search for your environment](/power-platform/admin/configure-relevance-search-organization).

## I'm not able search using the required column values on the Case view.

 You need to make sure that your quick find search is configured for the required search parameters. More information: [Use quick find search](/power-apps/user/quick-find).

