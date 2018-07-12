---
title: "Determine your version | MicrosoftDocs"
ms.custom: ""
ms.date: 07/06/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: c51639b3-9ca6-4d2b-81a7-1aa9f2d68785
caps.latest.revision: 6
author: "jimholtz"
ms.author: "jimholtz"
manager: "kvivek"
---
# Determine your version 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

https://blogs.msdn.microsoft.com/crm/2015/04/14/new-naming-conventions-for-microsoft-dynamics-crm-updates/

https://blogs.msdn.microsoft.com/crm/2018/06/19/de-mystifying-versioning-in-dynamics-365/

As updates are deployed to the Dynamics 365 service, there are two separate versions that are tracked:

App Version
Application version represents the binary version that is deployed to the Dynamics 365 servers. These updates contain product improvements and bug fixes that are delivered through application code changes.

DB Version
Database version represents the version of the organization’s database. These updates contain customization changes to support new features, product enhancements, and bug fixes.

Why does the App Version and DB Version sometimes differ?
There are two primary scenarios where the App Version and DB Version will not match.

App-only Update: As we continue to increase the frequency of updates to Dynamics 365, it is common for a release to only include application updates with no database updates required. In such a scenario, the application version will be incremented, but the DB version will remain the same.  On a subsequent release that involves both application and database changes, the versions will once again align.
Update Sequence: During the update sequence, application servers are updated first, followed by the update of the organizations themselves. Multiple organizations are batched together and updated concurrently to speed up the overall release. Depending on when an organization is picked up for processing, the versions may not match during this window of time.
What should I do when the versions do not match?

As described in the scenarios above, it's entirely normal for the App Version and DB Version to occasionally differ.  The application is built specifically to support compatibility with previous database releases, so mismatched versions are generally (except very rare scenarios) not a cause for concern.