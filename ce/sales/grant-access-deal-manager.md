---
title: "Grant or restrict access to deal manager - Sales Enterprise | MicrosoftDocs"
description: "As an administrator, grant deal manager access to specific security roles or to all security roles."
ms.date: 11/29/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Preview: Grant access to deal manager

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

By default, deal manager is enabled only for administrators. As an administrator, you can grant access to specific security roles or to all security roles in your organization.  

## License and role requirements

| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Grant access to security roles

1. Access the [deal manager settings page](enable-deal-manager-preview.md#access-deal-manager-settings).

1. Under **Define team access**, select one of the following:
    - Select **All security roles** to grant access to all users.
    - Select **Specific security roles**, and then add the security roles that you want to grant access to.
1. Select **Publish**.


> [!IMPORTANT]
> - If you're using a custom app, ensure to set the **Read** privilege for the Deal manager site map entry. This will ensure that the site map entry is only visible to users who are part of the selected security roles. More information: [Add deal manager settings and deal manager workspace in custom app](enable-deal-manager-preview.md#add-deal-manager-settings-and-deal-manager-workspace-in-custom-app)
> - By default, the settings selected on this page is only applicable to the current BU. If your organization has multiple BUs, set the "Read" access for **Deal manager settings** and **dealmanageraccess** under the **Custom entities** tab to organization-level access.
    > :::image type="content" source="media/deal-manager-access-global.png" alt-text="Security role settings page with deal manager settings highlighted":::

The deal manager workspace is now available to the selected roles. More information: [Access the deal manager workspace](access-deal-manager.md)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also
[Edit security privileges for a role](/power-platform/admin/create-edit-security-role#edit-a-security-role)