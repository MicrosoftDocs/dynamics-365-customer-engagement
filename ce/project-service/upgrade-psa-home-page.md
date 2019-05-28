---
title: Upgrade home page
description: This topic shows where to find important information about the new and changed features in PSA and the process for upgrading to the newest version.
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 11/15/2018
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
As of May 17th 2019, whenever a new Org is being provisioned, **PS v3.x will be the default PSA version** installed during the provisioning process. 

Also, as of May 17th 2019, if customers that have an instance with the legacy PS v2.x need to upgrade to PSA 3.x (UCI-based version of PSA), you will need to contact support with your instance details so support can enable your Org for upgrade to 3.x or UCI based Project Service application.
> [!NOTE]
>The release of Project Service Automation (PSA) version 3.x includes significant changes. This release is built on the Unified Interface framework for an improved user experience. The redesigned app delivers a consistent, uniform user interface, and follows responsive design principles for optimal viewing on any screen size or device. There have been other changes throughout the application including changes to pricing, booking and assigning resources, time, expenses, and approvals.  
> If the identified instance has both Field Service and Project Service installed, plan to upgrade both solutions before you resume normal use of the instance. 
> Before you begin your upgrade process, we recommend the following:
> Carefully review the “What’s new or changed in Project Service Automation version 3” and “Upgrade considerations” topics listed below. An awareness and understanding of the changes between versions will help you with the upgrade process.
The following topics provide information about the major changes in PSA, along with considerations and recommendations for planning your upgrade to version 3.x.

>- [What's new or changed in Project Service Automation version 3](whats-new-changed-v3.md)
>- [Upgrade considerations - Project Service Automation version 2.x or 1.x to version 3](upgrade-v3.md)
 
>- Upgrade your sandbox instance to evaluate the changes on your implementation before you upgrade your production instance.

Once you have reviewed all the materials above and are ready to upgrade to PSA 3.x or UCI-based version, please submit a request with MS support i.e log a support ticket with the details of your instance to make the upgrade available from Admin center.
 
**Getting legacy versions for FS and PS enabled on a UCI Org: 

As of May 17th, 2019, all new Orgs will have UCI as the default client. In line with that, the default PSA and FS version will be 3.x and 8.x respectiviely as these versions are designed to work with the UCI client. If you are creating a new Org and want it with the legacy version of FS and PS (FS v7.x or PS v2.x), please make sure that you do not select PSA or FS duirng the Org provisioning process. Instead, once the Org is provisioned, please log a support ticket that has your instance details so support can enable your org for  legacy versions of FS and PS. 
Note: For the best experience with legacy versions of FS and PS applications, you will also need to disable the UCI flag as these versions are not designed to load correctly in UCI. By disbaling the UCI flag, you can open and run these versions of FS and PS using the legacy web client. The instructions for turning off UCI client are located at this link.
https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/enable-unified-interface-only

