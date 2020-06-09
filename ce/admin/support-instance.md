---
title: "Manage Support instances | MicrosoftDocs"
ms.custom: 
ms.date: 06/09/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
ms.assetid: 2e4db92a-515b-4976-875a-d97d88af081f
caps.latest.revision: 4
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Manage Support instances

[!INCLUDE[applies-to](../includes/cc_applies_to_ce.md)]

A Support instance is any non-Production instance of Common Data Service used by Microsoft Support to reproduce and resolve customer issues. When there is an issue affecting the operation of your online service, Microsoft can create a Support instance in your tenant to troubleshoot and repair the issue.  It is isolated from your Production instance so it does not impact your business operations. System admins have full control of managing and providing organization data by [copying it](copy-instance.md) to a Support instance. 

**What is a Support instance?**

-  It is an instance created in your tenant by Microsoft under your direct instructions, for purposes of preventing, detecting, or repairing problems affecting the operation of your online service.
-  It does not require any additional non-Production instance to be purchased.
-  The database size of a Support instance does not count towards your storage limit.
-  It resides in the same regional datacenter as your source instance. 
- Support instances are protected by the same administrative and technical measures implemented by Microsoft to protect your production instance. 

**What data is in a Support instance?**

- When a Support instance is initially created by Microsoft, it contains no customer data or customizations.
- System admins [manage Support instances](manage-online-instances.md) in the [!INCLUDE[pn_dyn_365_admin_center](../includes/pn-dyn-365-admin-center.md)].
- System admins can [copy an instance](copy-instance.md) to a Support instance, and then choose whether to provide a minimal or full copy of their instance.
- Prior to provisioning, system admins must consent to providing a copy of their data to Microsoft.

**Who has access to a Support instance?**

Minimal copy:

-  Microsoft staff who are members of a support security group

Full copy:

-  Microsoft staff who are members of an elevated support security group

**What kind of data access does Microsoft have?**

Online (via the application):

-  System admin privileges

Database (via SQL query tools):

-  Read/Write access to all tables
-  Access to the database requires additional approval by Microsoft and it is managed, controlled, and granted as needed.
-  Access to the database is subject to our standard access controls (i.e. Just-in-time); for instance, access is time limited (for example, 30 minutes) and expires automatically.

**How long does a Support instance stay in your tenant?**

1. Seven days or upon resolution of the problem.
2. System admins can [delete](delete-instance.md) the Support instance at any time.

**Is access and usage of Support instance audited?** 

Yes.

**What is the consent form in the New support request page?** 

To assist with diagnosing and resolving a support issue, you must consent to the creation of a Minimal or a Full copy of the instance with the issue. The consent form displayed records your instructions to Microsoft for the creation of a support instance. 
