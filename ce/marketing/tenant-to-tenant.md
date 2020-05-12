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

Migrating a Marketing instance between tenants requires assistance from our technical support team. To request tenant to tenant migration within the same Azure geographic location (geo), [contact technical support](https://docs.microsoft.com/dynamics365/admin/contact-technical-support) and submit a support request.

> [!NOTE]
> When migrating a Marketing instance between tenants, the support team will advise you about pre-migration and post-migration steps (see below). Familiarize yourself with the [post migration state](#Marketing-app-post-migration-state) to determine if migration will be a good fit for your instance.

## Post-migration state of the Marketing app

After tenant to tenant migration, the Marketing instance will be in the following state:

- The Marketing app will be upgraded to the latest version that is available at the time of migration.
- All Marketing-related settings and customizations from your source instance will be present on the migrated instance.
- All records that were live on the source instance (such as customer journeys, emails, lead-scoring records, and more) will revert to the draft state on the migrated instance.
- Interaction data from your source instance (such as email clicks or website visits) won't be available to the migrated instance. Most insights data will be initialized. You can freely generate new interaction data on the migrated instance without affecting your source instance.
- Content assets uploaded to your source instance (such as images used in emails and landing pages) won't be available on the migrated instance. If you go live on the migrated instance with an email or page that was previously published on the source instance, the published design will show defunct links.
- Other aspects of the org state not specific to Marketing will align with the [general tenant to tenant migration norms](https://docs.microsoft.com/dynamics365/admin/move-instance-tenant).

## Steps that are executed during migration

You may need to execute the following steps when migrating a Marketing instance between tenants:

- After any copy or restore operation, you must [run the setup wizard](purchase-setup.md#run-the-marketing-setup-wizard) on the target instance. The setup wizard will create a new set of marketing services (including a new marketing-insights service) and link them to the target instance. If you don't run the wizard, all features that require services (such as insights and email sending) won't work.
- You must go live again with any records that you want to use on the target instance.
- Upload all the images you need to the migrated instance and edit your emails and pages to use those images before going live with them again.
- Portal reset may be required, depending on how the Marketing app is configured on the source instance.
- If the Marketing app on your source instance used a Dynamics 365 Portal, you will need to also set up a new portal on the target instance to host marketing pages and event websites (requires an unconfigured Dynamics 365 Portals license to be available on your tenant).
- Portals are optional, so you can choose not to use a portal with the migrated instance if you prefer, even if the source instance used one.

### See also

[Tenant to tenant migration](https://docs.microsoft.com/dynamics365/admin/move-instance-tenant)
[Manage your Marketing instances](manage-marketing-instances.md)  
[Transfer data between instances](transfer-data.md)  
[Transfer customizations between instances](transfer-solution.md)
[Administer Power Apps](https://docs.microsoft.com/power-platform/admin/admin-guide)  
[Manage instances](https://docs.microsoft.com/dynamics365/admin/new-instance-management)  
[Move configuration data across environments and organizations](https://docs.microsoft.com/power-platform/admin/manage-configuration-data)  
[Import, update, and export solutions](https://docs.microsoft.com/powerapps/maker/common-data-service/import-update-export-solutions)