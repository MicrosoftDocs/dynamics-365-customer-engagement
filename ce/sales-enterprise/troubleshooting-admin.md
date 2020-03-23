---
title: "Troubleshooting guide for administrators for Dynamics 365 Sales | MicrosoftDocs"
description: "Follow the instructions in this topic to troubleshoot the issues your users may face while working on Dynamics 365 Sales."
ms.date: 10/01/2019
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Dynamics 365 Sales troubleshooting guide for administrators

Use the following list of troubleshooting topics to quickly find information to solve your users' issues.

## Lead qualification issues and resolution

### Insufficient permissions or Access denied error when a user is trying to qualify a lead

How you resolve this error depends on the following ownership scenarios for the lead records. 
-  [The lead is owned by the user trying to qualify it](troubleshooting-admin.md#OwnedByUser)
-  [The lead that the user is trying to qualify is in their business unit](troubleshooting-admin.md#BusinessUnit)
-  [The lead that the user is trying to qualify is in their organization](troubleshooting-admin.md#Organization)

<a name="OwnedByUser"> </a>
**Scenario:** 
The lead is owned by the user trying to qualify it.

**Resolution:** 
1.    Go to **Settings** > **Security Role**.
2.    Open the security role of the user.
3.    On the **Core Records** tab, assign **Create**, **Read**, **Append**, and **Append To** permissions to the Security Role at User level on the following entities:
    -  Account 
    -  Lead
    -  Contact
    -  Opportunity 

    ![Security role with access at User level](media/security-role-sales-person.png "Security role with access at User level")

4.    On the **Custom Entities** tab, assign Read access to any custom entity.
5.    On the **Customizations** tab, assign **Read** access to **Attribute Map**, **Customizations**, **Entity** and **Entity Map**.

<a name="BusinessUnit"> </a>
**Scenario:**
The lead that the user is trying to qualify is in their business unit.

**Resolution:**
1.    Go to **Settings** > **Security Role**.
2.    Open the security role of the user.
3.    Assign **Create**, **Read**, **Append**, and **Append To** permissions to the user's Security Role at Business Unit level on the following entities:
    -  Account 
    -  Lead
    -  Contact
    -  Opportunity 

    ![Security role with access at Business Unit level](media/security-role-sales-person-bu-access.png "Security role with access at Business Unit level")

4.    Assign **Read** access to any custom entity.
5.    Assign **Read** access to **Attribute Map**, **Customizations**, **Entity** and **Entity Map**

<a name="Organization"> </a>
**Scenario:**
The lead that the user is trying to qualify is in their organization.

**Resolution:**
1.    Go to **Settings** > **Security Role**.
2.    Open the security role of the user.
3.    Assign **Create**, **Read**, **Append**, and **Append To** permissions to the user's Security Role at Organization level on the following entities:
    -  Account 
    -  Lead
    -  Contact
    -  Opportunity 
 
    ![Security role with access at Organization level](media/security-role-sales-person-org-access.png "Security role with access at Organization level")

4.    Assign Read access to any custom entity.
5.    Assign Read access to **Attribute Map**, **Customizations**, **Entity** and **Entity Map**.

