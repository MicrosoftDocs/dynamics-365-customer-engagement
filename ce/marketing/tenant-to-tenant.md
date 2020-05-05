---
title: "Move instances between tenants (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to prepare for and request to move an instance from one tenant to another"
keywords:
ms.date: 05/04/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
ms.assetid: 361dea50-9093-4668-910c-50f715fdd572
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status:
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Tenant to tenant migration for Dynamics 365 Marketing

>[!IMPORTANT]
>The following notes apply when you use tenant to tenant migration to move data from one Dynamics 365 Marketing instance to another:
>- All records exported with a status of "live" will be imported with a status of "draft" on the destination instance.
>- Interaction data can't be exported or transferred to a new instance. It will never be included in the export file.
>- There is no support for [geo to geo migrations](https://docs.microsoft.com/power-platform/admin/geo-to-geo-migrations). Please refer to the [International availability guide](https://docs.microsoft.com/dynamics365/get-started/availability) for Dynamics 365 Marketing geo availability.

Dynamics 365 Marketing supports tenant to tenant migration within the same geo, as [documented for the Dynamics 365 platform](https://docs.microsoft.com/dynamics365/admin/move-instance-tenant). There are, however, specific conditions to such migration. Pre-requisites must be followed when provided as part of the support request. Tenant to tenant migration, therefore, requires assistance from our technical support team to complete.

In tenant to tenant migration, [the same stipulations](manage-marketing-instances.d#content-of-the-target-instance-after-a-copy-or-restore) apply to a target instance as when an instance is copied or restored.

To request tenant to tenant migration within the same geo, [contact technical support](https://docs.microsoft.com/dynamics365/admin/contact-technical-support) and submit a support request.

### See also

[Tenant to tenant migration](https://docs.microsoft.com/dynamics365/admin/move-instance-tenant)
[Manage your Marketing instances](manage-marketing-instances.md)  
[Transfer data between instances](transfer-data.md)  
[Transfer customizations between instances](transfer-solution.md)
[Administer Power Apps](https://docs.microsoft.com/power-platform/admin/admin-guide)  
[Manage instances](https://docs.microsoft.com/dynamics365/admin/new-instance-management)  
[Move configuration data across environments and organizations](https://docs.microsoft.com/power-platform/admin/manage-configuration-data)  
[Import, update, and export solutions](https://docs.microsoft.com/powerapps/maker/common-data-service/import-update-export-solutions)