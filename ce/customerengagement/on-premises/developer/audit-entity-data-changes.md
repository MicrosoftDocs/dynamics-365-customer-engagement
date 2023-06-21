---
title: "Audit entity data changes (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Supports auditing of entity and attribute data changes on a per organization basis."
ms.custom: audit
ms.date: 05/27/2022
ms.reviewer: jdaly
ms.suite:
ms.tgt_pltfrm:
ms.topic: article
applies_to:
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords:
  - auditing entity data changes in Microsoft Dynamics CRM, introduction
author: Bluebear7
ms.author: munzinge
search.audienceType:
  - developer
---

# Audit entity data changes

Organizations need to track changes made to business data for maintaining security, examining the history of a particular data record,
documenting modifications for future analysis and record keeping, and being in compliance with regulations.
Dynamics 365 Customer Engagement (on-premises) support auditing of entity and attribute data changes on a per organization basis.

## Overview

Organizations often need to be in compliance with various regulations to ensure availability of customer interaction history, audit logs, access reports, and security incident tracking reports. Organizations may want to track changes in Dynamics 365 Customer Engagement (on-premises) data for security and analytical purpose. To learn more, see [Auditing Feature Overview](/powerapps/developer/common-data-service/auditing-overview) in the Dataverse documentation.

## Configure entities and attributes for auditing

There are three levels where auditing can be configured: organization, entity, and attribute. The organization level is the highest level, followed by the entity level, and finally the attribute level. For attribute auditing to take place, auditing must be enabled at the attribute, entity, and organization levels. For entity auditing to take place, auditing must be enabled at the entity and organization levels. To learn more, see [Configure Entities and Attributes for Auditing](/powerapps/developer/common-data-service/configure-entities-attributes-auditing) in the Dataverse documentation.

## Retrieve and delete history of audited data changes

After auditing is enabled and data changes are made to those entities and attributes being audited, you can proceed to obtain the data change history. Optionally, you can delete the audit records after you review the change history. To learn more, see [Retrieve and Delete the History of Audited Data Changes](/powerapps/developer/common-data-service/retrieve-and-delete-the-history-of-audited-data-changes) in the Dataverse documentation.

### Behavior of DeleteAuditData message depends on SQL Server edition

When using Dynamics 365 Customer Engagement (on-premises) the behavior of the `DeleteAuditData` message depends on the which edition of SQL Server is used.

When using SQL Server Enterprise edition, the `DeleteAuditData` message will delete all audit data in those partitions where the end date is before the date specified in the `EndDate` property. Any empty partitions are also deleted. However, neither the current (active) partition nor the `audit` records in that active partition can be deleted by using this request or any other request.

SQL Server Standard edition doesn't support the database partitioning feature. In this case the `DeleteAuditData` message deletes all audit records created up to the end date specified in the `EndDate` property.

## Audit user logons

Dynamics 365 Customer Engagement (on-premises) support the ability to audit user access. The information that is recorded includes when the user started accessing Dynamics 365 Customer Engagement (on-premises) and if access originated from the Dynamics 365 Customer Engagement (on-premises) web application, Dynamics 365 for Outlook, or SDK calls to the web services. To learn more, see [Audit User Logons](/powerapps/developer/common-data-service/audit-user-access) in the Dataverse documentation.

## Sample: Audit entity data changes

This sample demonstrates how to enable and disable auditing on an entity and its attributes, retrieve the data change history of the audited entity, and delete the audit records. To learn more, see [Sample: Audit Entity Data Changes](https://github.com/microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/C%23/AuditEntityData) in the Dataverse documentation.

## Sample: Audit user access

This sample demonstrates how to audit user access to Dynamics 365 Customer Engagement (on-premises). To learn more, see [Sample: Audit User Access](https://github.com/microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/C%23/AuditUserAccess) in the Dataverse documentation.

## Related Sections

[Data Management in Dynamics 365 Customer Engagement (on-premises)](manage-data.md)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
