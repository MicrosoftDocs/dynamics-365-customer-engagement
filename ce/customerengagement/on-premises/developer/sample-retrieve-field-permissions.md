---
title: "Sample: Retrieve field permissions (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to retrieve secured fields for a user according to the steps outlined in Field security entities."
ms.custom: 
ms.date: 01/08/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - field security entities sample, enabling
  - enabling field security, sample
ms.assetid: acb20fc8-4b62-4e92-b105-7d832c56d007
caps.latest.revision: 20
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Retrieve field permissions

This sample shows how to retrieve secured fields for a user according to the steps outlined in [Field security entities](/dynamics365/customer-engagement/developer/field-security-entities). You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/RetrieveFieldPermission).

This sample requires additional users that are not in your system. Create the required users manually in **Office 365** in order to run the sample without any errors. For this sample create a user profile **as is** shown below. Replace `yourorg` with the organization name.

**First Name**: Samantha <br/>
**Last Name**: Smith<br/>
**Security Role**: Marketing Manager<br/>
**UserName**: ssmith@yourorg.onmicrosoft.com<br/>

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `FieldPermission` class is intended to be used in a scenario where it contains the data that defines the possible field permission types.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. Gets the user information that you have created manually in **Office 365**.
1. The `QueryExpression` method retrieves the security role needed to assign to the user.
1. The `Team` method instantiate a team entity record and set its property values.

### Demonstrate

1. The `FieldSecurityProfile` method creates field security profile.
1. The `AssociateRequest` method adds team and user to the profile.
1. The `CreateEntityRequest` method creates a new custom activity entity for the sample.
1. The `RolePrivilege` method adds privileges for the new custom entity.
1. The `AddPrivilegeRoleRequest` method creates and execute the `RolePrivilege` method.
1. The `FieldPermission` method creates field permission object for identity.

### Clean up

Display an option to delete the records created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]