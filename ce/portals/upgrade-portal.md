---
title: "Upgrade a Dynamics 365 portals | MicrosoftDocs"
description: "Learn how to upgrade a portal."
ms.date: 05/30/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 68A7E45F-8583-495B-AC29-F944DBE9D388
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Upgrade a portal

This section helps you understand the Portals release process to prepare for any new release properly and to reduce any impact on your customers. It also talks about various components which are part of your portal.

A Dynamics 365 Portal consists of the following components:

|Component|Description|Update process|
|---------|-----------|--------------|
|Portal solutions|Solutions which are Installed in Dynamics 365 organization and contains the metadata entities for any Dynamics 365 Portal.|Updated by customers themselves from the Dynamics 365 Administration Center.|
|Portal website host|Portal website host is the Portal code which forms the actual website.|Portal website host is updated automatically for all portals.<br>**Note**: A new version of Portal website host is backwards compatible with all supported versions of Portal solutions. However, once a solution version becomes unsupported, it is not certified to run with the new version of Portal website host.|
|||

## Impact of new releases on a Portal solution

As part of any Portal release, Portal website hosts are updated automatically to the latest versions while Portal solutions are updated by customers. It is important to understand the impact of each component update on your live Portal, so you can plan accordingly.

### Portal website host update

If you are running a production version of Portal (you can see it on Portal Admin center), there will not be any downtime to your live Portal when your Portal is updated. However, if you are running a trial version of Portal, there will be around 6-10 minutes of downtime and you will not be able to access your Portal.

### Portal solution update

While installing or updating any solution in your Dynamics 365 instance, you can see some instability in your Dynamics 365 instance. Portal solution update process updates solutions available in your Dynamics 365 instance and will impact your Dynamics 365 instance which will in turn have an impact of your Portal as well. Hence, it is always advised to do solution updates in your Dynamics 365 instance during dark hours.

## Get notified about new releases

Every customer is notified about new Portal release through Office 365 message center (in Office 365 Admin center). Ensure that you either have access to Office 365 message center (Global administrator and Dynamics 365 service administrator have access) or have discussed with your global administrator or Dynamics 365 service administrator to inform you about any new Portal release.

Notifications are sent around 2-5 business days ahead of the release. Notifications are sent to only those customers whose portals are planned to be updated. Each notification provides details of the type of update and the date/time it will be rolled out along with the link to release notes.

## Enable a portal for new release

You can enable development or test portal to receive an early upgrade ahead of all customers, so you can test all core scenarios on your test portal before upgrades are rolled out to your live portal. Early upgrades are rolled out at least one week before the global rollout of any release. Also, notifications for early upgrades are sent as described in the [Get notified about new releases](#get-notified-about-new-releases) section.

To enable a portal for early upgrade:

1.	Go to the Dynamics 365 Administration Center, and then select the **Applications** tab.

2.	Select the application row for your portal, and then select **Manage**.

3.	Under **Portal Details**, select **Enable portal for early upgrade**.

    ![Enable a portal for early upgrade](media/upgrade-portal.png "Enable a portal for early upgrade")

> [!NOTE]
> You can enable or disable a portal for early upgrade anytime. However, a snapshot is taken for all portals marked for early access two days before any release, and any portal marked for early access after that is not guaranteed to get an early upgrade.

If you encounter any issue during the early upgrade phase, you can report it through Microsoft support.


