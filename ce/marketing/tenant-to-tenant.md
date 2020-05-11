---
title: "Move instances between tenants (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to prepare for and request to move an instance from one tenant to another"
keywords:
ms.date: 05/11/2020
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

Dynamics 365 Marketing supports tenant to tenant migration within the same geo, as [documented for the Dynamics 365 platform](https://docs.microsoft.com/dynamics365/admin/move-instance-tenant). There is no support for [geo to geo migrations](https://docs.microsoft.com/power-platform/admin/geo-to-geo-migrations).

>[!NOTE]
>Refer to the [International availability guide](https://docs.microsoft.com/dynamics365/get-started/availability) for Dynamics 365 Marketing geo availability.

When migrating a Marketing instance between tenants, specific pre-migration and post-migration steps must be followed (see below). These migration steps require assistance from our technical support team. To request tenant to tenant migration within the same geo, [contact technical support](https://docs.microsoft.com/dynamics365/admin/contact-technical-support) and submit a support request.

## Steps that are executed during migration

The following is a list of required steps for Marketing instance tenant to tenant migration:

- The Marketing app will need to be reinstalled on the destination tenant once migration is complete.
- You must go live again with any records that you want to use on the target instance.
- After any copy or restore operation, you must run the setup wizard on the target instance. This will create a new set of marketing services (including a new marketing-insights service) and link them to the target instance. If you don't run the wizard, all features that require services (such as insights and email sending) won't work and you'll still see information about images in the files library for which the source files aren't available.
- We strongly recommend that you upload all the images you need to the new instance and edit your emails and pages to use those images before going live with them again.
- Portal reset may be required, depending on how the Marketing app is configured on the source instance.
- If the Marketing app on your source instance used a Dynamics 365 Portal, you might choose to also set up a new portal on the target instance to host its marketing pages and event websites (requires an unconfigured Dynamics 365 Portals license to be available on your tenant). Portals are optional, so you can choose not to use a portal with the copied instance if you prefer, even if the source instance was using one.

## Post-migration tenant state

The following is a list of settings and component statuses that may require attention after tenant to tenant migration for Marketing instances:

- The Marketing app will be upgraded to the latest version that is available at the time of migration.
- All apps, settings, and customizations from your source instance will be present on the target instance.
- All records that were live on the source instance (such as customer journeys, emails, lead-scoring records, and more) will revert to the draft state on the target instance.
- Because a new set of marketing services is created on the target instance, interaction data from your source instance (such as email clicks or website visits) won't be available to the target instance. Most insights data will be initialized. You can freely generate new interaction data on the target instance without affecting your source instance.
- Because a new set of marketing services is created on the target instance, files uploaded to your source instance (such as images used in emails and landing pages) won't be available to the target instance. If you go live with an email or page that was previously published on the source instance, the published design will continue to use the previous image URLs from the source instance—these images will still appear in the republished designs provided they are still available on the source instance.

### See also

[Tenant to tenant migration](https://docs.microsoft.com/dynamics365/admin/move-instance-tenant)
[Manage your Marketing instances](manage-marketing-instances.md)  
[Transfer data between instances](transfer-data.md)  
[Transfer customizations between instances](transfer-solution.md)
[Administer Power Apps](https://docs.microsoft.com/power-platform/admin/admin-guide)  
[Manage instances](https://docs.microsoft.com/dynamics365/admin/new-instance-management)  
[Move configuration data across environments and organizations](https://docs.microsoft.com/power-platform/admin/manage-configuration-data)  
[Import, update, and export solutions](https://docs.microsoft.com/powerapps/maker/common-data-service/import-update-export-solutions)