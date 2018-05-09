---
title: "Prevent elevation of security role privilege (Dynamics 365 Customer Engagement)| MicrosoftDocs"
ms.custom: ""
ms.date: 05/08/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 85bb4fd5-da15-4fd6-b297-2b772fb3a5c3
caps.latest.revision: 5
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Prevent elevation of security role privilege

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

The copy security role method is a quick and easy way to create a new security role based on an existing set of privileges. However, security role privileges can change with product updates which could render the new security role out-of-date and not functioning as expected.

The following steps describe a method to create a new custom security role with privileges that will change dynamically with updates and therefore will retain expected privileges.

1. 