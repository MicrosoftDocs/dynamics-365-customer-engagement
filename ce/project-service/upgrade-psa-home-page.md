---
title: Upgrade home page
description: This topic shows where to find important information about the new and changed features in PSA and the process for upgrading to the newest version.
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 05/28/2019
ms.topic: article
ms.prod: 
ms.service: business-applications
ms.technology: Dynamics 365 for Project Service 3.x
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
  
---

# Upgrade home page
[!INCLUDE[cc-applies-to-psa-app-1x-2x](../includes/cc-applies-to-psa-app-1x-2x.md)]

## Upgrade from Project Service Automation version 2.x or 1.x to version 3.x
**New Orgs**

As of May 17th 2019, when a new Org is provisioned, Project Service Automation (PSA) v3.x is installed by default. 

**Existing Orgs**

As of May 17th 2019, customers with an instance of PSA version 2.x must upgrade version 3.x, the UCI-based version of PSA. You will need to contact support with the details of your instance so that support can enable your Org for upgrade to 3.x.

> [!NOTE]
> The release of Project Service Automation (PSA) version 3.x includes significant changes. This release is built on the Unified Interface framework for an improved user experience. The redesigned app delivers a consistent, uniform user-interface, and follows responsive design principles for optimal viewing on any screen size or device. There have been other changes throughout the application including changes to pricing, booking and assigning resources, time, expenses, and approvals.  


Before you begin your upgrade process, we recommend the following:

- Verify that the identified instance has both **Field Service** and **Project Service Automation** installed. If they are, plan to upgrade both solutions before you resume normal use of the instance.  
- Carefully review the following topics topics listed below. An awareness and understanding of the changes between versions will help you with the upgrade process. These topics provide information about the major changes in PSA, along with considerations and recommendations for planning your upgrade to version 3.x.

  - [What's new or changed in Project Service Automation version 3](whats-new-changed-v3.md)
  - [Upgrade considerations - Project Service Automation version 2.x or 1.x to version 3](upgrade-v3.md)

- Upgrade your sandbox instance to evaluate the changes on your implementation before you upgrade your production instance.

After you have reviewed the materials above and are ready to upgrade to PSA 3.x or UCI-based version, submit a request with Microsoft support detailing your instance, to make the upgrade available from Admin center.
 
## Legacy versions of PSA (PSA v2.x) on a newly created Org
As of May 17th, 2019, all new Orgs will have UCI as the default client. To align with that, the default PSA and Field Service (FS) versions that will be provisioned are 3.x and 8.x respectiviely as these versions are designed to work with the UCI client. 
If you are creating a new Org and want it with the legacy version of FS and PSA (FS v7.x or PSA v2.x), make sure that you do not select PSA or FS during the Org provisioning process. Instead, after the Org is provisioned, log a support ticket that includes your instance details so that support can enable your org for legacy versions of FS and PSA. 

> [!NOTE]
> For the best experience with legacy versions of FS and PSA applications, you will also need to disable the UCI flag as these versions are not designed to load correctly in UCI. By disbaling the UCI flag, you can open and run these versions of FS and PSA using the legacy web client. See the topic, [Enable unified interfaceonly](../admin/enable-unified-interface-only.md) for instructions about how to turn off the UCI client.
