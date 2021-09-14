---
title: "Grant or restrict access to deal manager - Sales Enterprise | MicrosoftDocs"
description: "As an administrator, grant deal manager access to specific security roles or to all security roles."
ms.date: 09/14/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Preview: Grant access to deal manager

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

By default, deal manager is enabled only for administrators. As an administrator, you can grant access to specific security roles or to all security roles in your organization.  

**To grant access**

1. Access the [deal manager settings page](enable-deal-manager-preview.md#access-deal-manager-settings).

1. Under **Define team access**, select one of the following:
    - Select **All security roles** to grant access to all users.
    - Select **Specific security roles**, and then add the security roles that you want to grant access to.
1. Select **Publish**.


> [!IMPORTANT]
> By default, the settings selected on this page is only applicable to the current BU. If your organization has multiple BUs, set the "Read" access for **Deal manager settings** and **dealmanageraccess** under the **Custom entities** tab to organization-level access.
> 
> :::image type="content" source="media/deal-manager-access-global.png" alt-text="Security role settings page with deal manager settings highlighted":::

The deal manager workspace is now available to the selected roles. More information: [Access the deal manager workspace](access-deal-manager.md)

### See also
[Edit security privileges for a role](/power-platform/admin/create-edit-security-role#edit-a-security-role)