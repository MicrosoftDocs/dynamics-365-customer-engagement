---
title: "Get started with Marketing app setup (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to get up and running quickly with outbound and real-time marketing features in Dynamics 365 Marketing."
ms.date: 03/01/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Get started with Marketing app setup

This article provides a checklist to get your Dynamics 365 Marketing implementation up and running quickly.

For in-depth information on getting started with the Dynamics 365 platform, see the [Microsoft Dynamics 365 implementation guide](/dynamics365/fasttrack/implementation-guide/overview).

## Dynamics 365 Marketing basic setup

Follow these steps to expedite the Dynamics 365 Marketing setup process.

| Timeline | Task | Details |
|---|---|---|
| Pre-provisioning | Gather and document use cases and marketing requirements | Determine your business requirements for bulk mailings, automation, surveys, event management, etc. |
| Pre-provisioning | Determine licensing requirements | Licensing is done on a tenant level.<br> Learn more: [Dynamics 365 Marketing licensing options](purchase-setup.md#dynamics-365-marketing-licensing-options). |
| Pre-provisioning | Determine company geographical address | Visible on all emails (regulatory requirement).<br> Learn more about entering your organization's postal address: [Use content settings to set up repositories of standard and required values for email messages](dynamic-email-content.md#use-content-settings-to-set-up-repositories-of-standard-and-required-values-for-email-messages). |
| Pre-provisioning | Determine if Power Apps portals are needed | Learn more: [Integrate Marketing with a CMS system, Dynamics 365 Portals, or Power Apps portals](portal-optional.md). |
| Provisioning | Provision Dynamics 365 Marketing app on all Dynamics 365 organizations (dev and production) | Update Dynamics 365 tenants first.<br> Learn more: [Purchase and set up Dynamics 365 Marketing](purchase-setup.md). |
| Post-provisioning | Grant access to superusers for Dynamics 365 Marketing training | Later, give access to all users.<br> Learn more: [Manage user accounts, user licenses, and security roles](admin-users-licenses-roles.md). |
| Post-provisioning | Customize your Dynamics 365 Sales app if needed (merge new tabs, attributes) | Example: [View and edit which lists each contact subscribes to](set-up-subscription-center.md#view-and-edit-which-lists-each-contact-subscribes-to). |
| Post-provisioning | Authenticate your company domains on the production environment | Learn more: [Authenticate your domains](mkt-settings-authenticate-domains.md). |
| Post-provisioning | Configure insights sync settings | Learn more: [Sync entities and track insights using Dataset configuration](mkt-settings-sync.md). |
| Post-provisioning | Configure content settings. If there are multiple subsidiaries or legal entities with different brands, create multiple settings. | Learn more: [Use content settings to set up repositories of standard and required values for email messages](dynamic-email-content.md#use-content-settings-to-set-up-repositories-of-standard-and-required-values-for-email-messages),<br> [Configure your social media accounts](mkt-settings-social-media.md),<br> [Configure landing pages](mkt-settings-landing-pages.md). |
| Post-provisioning | Configure default marketing settings. If there are multiple subsidiaries or legal entities with different brands, create multiple settings. | Learn more: [Settings overview](marketing-settings.md),<br> [Set up global double opt-in for new subscriptions and consent changes](double-opt-in.md),<br> [Set up subscription lists and subscription centers](set-up-subscription-center.md). |

## Next steps

After the Marketing app is set up, you can start setting up features such as [email](email-get-started.md) and [text messages](real-time-marketing-outbound-text-messaging.md) to reach out to your customers.
