---
title: "Best practices for administration (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about best practices for Dynamics 365 Marketing administration and management."
ms.date: 12/02/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Best practices for administration

Dynamics 365 Marketing is a marketing-automation app that helps turn prospects into business relationships. The app is easy to use, works seamlessly with Dynamics 365 Sales, and has built-in business intelligence.

Marketing is built on top of the Dynamics 365 platform. Environment-management operations are a standard feature of model-driven Dynamics 365 apps (Sales, Customer Service, Field Service, Marketing, and Project Service Automation). Marketing, however, has additional considerations to keep in mind.

This document discusses some of the key elements for managing Marketing, focusing on the most common areas in which administrators have questions.

## Licensing model

Dynamics 365 Marketing has a different licensing model than other Dynamics 365
applications. You can find more details about the Marketing licensing model in
[How to Purchase](purchase-setup.md#how-to-purchase-dynamics-365-marketing)
and [Marketing Contacts Purchase](setup-troubleshooting.md#how-is-dynamics-365-marketing-licensed), as well as in the [Dynamics 365 Licensing guide](https://download.microsoft.com/download/9/6/7/96706B15-1CBE-47B7-AB9E-6BC31A377BBB/Dynamics%20365%20Licensing%20Guide%20-%20Feb%202020.pdf). Some important aspects of Marketing’s licensing model are:

- You do not purchase user licenses of Marketing. You purchase the Marketing app and bundles of marketing contacts.
- One Marketing app license permits deployment on only one Dynamics 365 environment. The environment could be a sandbox or production. Deploying on multiple Dynamics 365 environments requires multiple Marketing app licenses.
- Marketing is available in multiple variants with different pricing for prod and non-prod usage.

## Marketing quota limits

As documented in [Quota management](quota-management.md), there are multiple types of marketing quotas. Here are some issues customers encounter regarding quotas:

- **You see a sudden drop in the Marketing quota compared to the past or compared to what you have always paid for.** In such cases, validate that the Marketing app and the marketing contact add-on pack subscription has not expired. Normally, if a subscription expires, the related quota associated with it also decreases.
- **You purchased marketing contact packs, but you do not see the packs reflected in the Quota Limits monitoring.** There could be multiple causes, but some common reasons are:
    1. *There are multiple channels through which you can purchase the Marketing app and contact packs.* It might take time for the purchases to reflect in the quota limits. If the purchase does not reflect after 24 hours, you should open a support ticket to resolve the issue.
    1. *The offer used to purchase contact packs does not match the base offer of the Marketing app.* This mismatch is normally the case in a non-web direct purchase channel. Check with your Microsoft contact counterpart for the purchase to validate that there is not a purchase conflict. If no dependency issues are found and the purchase does not reflect after 24 hours, you should open a support ticket to resolve the issue.

## Environment strategy

The Dynamics 365 Marketing app is built on top of the Dynamics 365 platform. Follow the environment and development strategy recommended by the Dynamics 365 platform when adopting Marketing. You can find more details about
Dynamics 365 platform administration and environment strategy in this [Power
Platform Admin and Governance whitepaper](https://aka.ms/powerappsadminwhitepaper) [section: Platform architecture].

Marketing customers often maintain a development environment, a test
environment, and a prod environment. The various environments help to:

- Set up security boundaries and provide environments with flexibility for change management. For example, in a development environment, you might allow multiple customizations. But in prod, customizations are restricted to ensure a fully stable environment.
- Test upcoming features in a non-prod environment.
- Address DevOps issues without putting the prod environment at risk.

Depending on the environment and its usage, you might have different needs when
deploying the Marketing app. For information about deploying various environments, see the next section.

## Marketing app types

Dynamics 365 Marketing is composed of several components. Each Dynamics 365
environment requires a dedicated Marketing app. In other words, if you want
multiple Marketing environments, you need to purchase multiple Marketing app
licenses. Many times, you might not want to buy additional Marketing app
licenses but still want to follow the best practices of having a dev, test, and
prod setup. In such cases, there is another option.

Marketing offers a solution-only license. The solution-only license does not
support Marketing processes such as segmentation and email sending. It does
support, however, Marketing metadata such as marketing entities that you can use
for extensibility purposes. The solution-only license also allows you to enable ALM operations across your environments. Learn more about the
solution-only license in [Purchase and set up Dynamics 365 Marketing](purchase-setup.md#how-to-purchase-dynamics-365-marketing).

Here are some of the common pitfalls (from a management perspective) that you
might face when working with multiple Marketing apps/environments:

- **Encountering an error about missing components when importing a custom solution build from a source environment containing a Marketing app to a target environment that does not contain a Marketing app, such as transitioning from QA to UAT.** In this scenario, you might believe that the source environment Marketing solution is the cause of the problem. You might then try to remove or uninstall the Marketing app from the source environment. Instead, deploy the solution-only Marketing app on the target environment so that both the source and the target have the same level of solution level metadata.
- **Uninstalling and reinstalling the Marketing app from one environment to another, hoping to reuse one Marketing app for multiple Dynamics 365 environments.** This is incorrect and most of the time results in broken systems.
- **Not noting that when a Marketing environment is installed as solution-only, no Marketing processes (such as customer journey or segmentation) will execute.** The solution-only environment only supports Marketing entity availability and extensibility. If you require marketing process execution, the full Marketing app should be installed.
- **Not following defined guidance (such as pre-req) when doing ALM operations (such as copy) on environments with the Marketing app.** Refer to the next section for up-to-date guidance on ALM operations.

## ALM operations

Dynamics 365 Marketing supports most of the Dynamics 365 platform’s Application
Lifecycle Management (ALM) capabilities such as copy, backup, and restore. Learn more about ALM capabilities in [Manage Marketing environments](https://docs.microsoft.com/dynamics365/marketing/manage-marketing-environments).
There are specifics to these operations, however, which you should adhere to
when working with Marketing. Some of the common pitfalls include:

- **Incorrectly assuming that ALM operations will move with the Marketing apps from source to the target.**
- **Not preparing the source and target environments for the necessary ALM operation.**
- **Unnecessary uninstalling and reinstalling the Marketing app in the source or target environments against the recommendations in the documentation.**
- **Assuming that the Marketing trial can be converted to paid by converting the Dynamics 365 trial environment to paid in the Power Platform admin center.** For more information, see the Trials section below.

## Uninstallation

You can remove the Marketing app from any Dynamics 365 environment where it's
installed. While there are good reasons to uninstall the Marketing app (such as
dismantling a sandbox environment), there are situations where this operation is
used incorrectly. The following scenarios outline some
common situations where the uninstall operation is incorrectly used:

- **Trying to use one Marketing license for multi-use on multiple environments instead of doing a fresh install.** For information about installing Marketing on more than one environment, refer to the Environment Strategy and Marketing app type sections for additional guidance and options. The Marketing uninstall process has [particular requirements and implications](uninstall-marketing.md).
- **Once the Marketing app is uninstalled, trying to also remove the Marketing solutions from the environment.** The Marketing app installs [many solutions on an environment](developer/marketing-solutions.md). You [do not need to remove the solutions](uninstall-marketing.md#uninstall-dynamics-365-marketing-services)
when uninstalling the Marketing app. Removing the solutions requires special
care and sequencing. Incorrect sequential removal of the solutions brings the
environment into an undesired state. If you need to remove the solutions for valid
business reasons (such as also removing the Marketing metadata from the
environment), you should open a support ticket to resolve the issue.

## Microsoft Dataverse vs CE deployment

Currently, Dynamics 365 Marketing, like other Dynamics 365 model apps (Sales,
Service, etc.), can only be deployed on CE environments (also known as orgs).

- [This documentation](https://docs.microsoft.com/power-platform/admin/create-environment) describes how to add CE environments via purchase into a tenant on which Marketing can be deployed.

- A CE environment could also be [provisioned via the Power Platform Admin Center with a CE DB](https://docs.microsoft.com/power-platform/admin/create-environment). If you need to create a Marketing template-based CE environment, you should open a support ticket to resolve the issue.

## Trials

Dynamics 365 Marketing trial apps have special behavior. Marketing trial apps
can only be installed on Dynamics 365 trial environments, which are automatically provided as part of the Marketing Trial sign-up process. Unlike paid environments, these environments cannot be created manually. Similarly, paid Marketing apps (sandbox or prod) cannot be deployed on trial environments.

Marketing does not support converting from a trial to a paid subscription. If
you convert a Dynamics 365 environment from trial to paid, the Marketing app will not convert. In such a scenario, you must uninstall the trial Marketing app from the converted system and deploy a paid Marketing app. In this scenario, the standard rules of [uninstalling a Marketing app](uninstall-marketing.md) apply. All interaction and behavioral data will be deleted.

## Data transfer

You can replicate Dynamics 365 Marketing configurations and data across
environments using the standard tools provided for Dynamics 365. More information is available in [Transfer data](transfer-data.md) and in [Transfer customizations](transfer-solution.md). The following are some of the common pitfalls when transferring data:

- **Using ALM operations instead of Import/Export when transferring selective data.**
- **Not following the transfer guidelines mentioned in the documentation such as having similar source and target versions of the Marketing app.**

## Migrations

- **Tenant to tenant**:* Dynamics 365 Marketing supports [tenant to tenant migration within the same geo](https://docs.microsoft.com/power-platform/admin/move-environment-tenant). There are, however, specific conditions to such migration that you must follow when provided as part of the support request.
- **Geo to geo**: Marketing does not currently support geo to geo migration.

## Geos (commercial clouds)

Dynamics 365 Marketing is only available in certain geos. Refer to [the International availability guide](https://docs.microsoft.com/dynamics365/get-started/availability) for Marketing geo availability.

If your tenant is in a non-supported geo, you cannot deploy Marketing in that
geo. The tenant must be enabled for multi-geo before deploying Marketing in a
supported geo. In this scenario, open a support request to check for
feasibility.

[!INCLUDE[footer-include](../includes/footer-banner.md)]