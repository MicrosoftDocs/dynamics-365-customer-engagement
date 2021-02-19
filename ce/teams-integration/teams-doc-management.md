---
title: "Document management in Microsoft Teams integration| MicrosoftDocs"
ms.custom: 
description: "How file and document works with Microsoft Teams integration and SharePoint "
ms.date: 02/18/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps
ms.assetid: 8097c9ec-023b-407d-ac0e-074b5e1964a5
caps.latest.revision: 1
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser
search.app: 
  - D365CE
  - Powerplatform
---
# Document management in Microsoft Teams integration

There is no automatic relationship between SharePoint permissions and Dynamics permissions. It means even if a user has Sales manager permissions in the D365 org, but doesn’t have permissions on the SharePoint site, they will not be able to use document management capabilities. Permissions have to be granted explicitly from Dynamics as well as from the SharePoint side to make SharePoint integration work for all the users.

## Access to files

A user’s access to files in Microsoft Teams or Dynamics 365 apps depends on their access to the SharePoint site the file is stored in.
 
| Member of organization      | Member of Teams channel | View record in Teams | View record in Dynamics 365  | Access document in  Dynamics 365  | Access document in Teams | Access document in SharePoin|    
| ----------- | ----------- | ----------- | ----------- | ----------- | ----------- | -----------
| Yes      | Yes       | Yes       | Yes       | Yes (read, write, delete)       |Yes (read, write, delete)       |Yes       |
| No   | Yes        | Yes (read only)       | Yes       | Yes (read, write, delete)       |Yes (read, write, delete)       |Yes       |
| No      | No       | No       | Yes (read only)       | No       | No       | No       |
| Yes   | No        | No       | Yes       | No       |No       | No       |

> [!NOTE]
> - A guest user in Microsoft Teams will get error message when they try to access a pinned Dynamics 365 app record. You need a Mic
> - A user who is part of Microsoft Teams channel or team that does have access to Dynamics 365 apps won't be able to see the record in Microsoft Teams
