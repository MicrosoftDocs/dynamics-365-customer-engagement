---
title: Provide permissions to access and share a forecast
description: Provide permissions to view, access, and share a forecast in Dynamics 365 Sales.
ms.date: 03/15/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
ms.custom: 
  - dyn365-sales
---

# Provide permissions to access and share a forecast  

After you've [selected general properties and scheduled your forecast](./define-general-properties-scheduling-forecast.md), define who can view, access, and share it.

Use the **Permissions** step to:

- [Define the owner of the forecast](#define-the-forecast-owner)
- [Provide access to users who have specific security roles to view the forecast](#provide-access-to-additional-roles)
- [Allow users to share their forecast records with other users](#enable-or-disable-forecast-sharing)

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Forecast Manager<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Define the forecast owner

A forecast owner can view, share, and adjust the forecast.  

In the **Owner lookup field (preview)**, select who owns the forecast. Each template starts with a default value:

| Template | Default owner |
| --- | --- |
| Org chart forecast | User |
| Product forecast | None |
| Territory forecast | Manager |

For example, when you select **Manager** as the **Owner lookup field (Preview)** for a territory forecast, the forecast is visible only to the managers of the territories in the selected hierarchy. The managers can edit forecast data that directly belongs to them and to their reporting territories.

If you select a value other than the default, a column is added to the forecast grid. For org chart forecasts, you can select **Business Unit** as the owner. In this case, the forecast is owned by all users in the business unit.

## Provide access to additional roles

In the **Additional security roles** section, select an option to give access to users who aren't part of the hierarchy:

- **No additional security roles**: This option gives access only to the selected hierarchy users. Users who have other security roles in the organization can't view the forecast. This option is selected by default.
- **All security roles can read this forecast**: This option gives read-only access to all the security roles in your organization.
- **Specific security roles**: Use this option to specify the security roles to receive either read-only access, or read-only and adjustment access.

A message under the security roles gives more information about how the forecast security is applied, based on your selections.

:::image type="content" source="./media/forecast-permissions.png" alt-text="A screenshot of the Permissions step of the Forecast configuration page, with additional security roles defined.":::

## Enable or disable forecast sharing

By default, forecasts can't be shared. If you turn on forecast sharing, users can share only the forecasts that they own. For more information, see [Who owns the forecast?](./faqs-sales.md#who-owns-the-forecast)

In the **Share forecast** section, select one of the following options:

- **None**: The forecast can't be shared with anyone. If it's already been shared, users it was shared with can no longer access it.
- **Read-only**: The forecast can be shared to view, but not to edit.
- **Read and adjust**: The forecast can be shared either to view, or to view and edit. Select this option to share the forecast to users with different levels of access.

When you've finished setting permissions, select **Next**.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

<table>
<tr><td>

> [!div class="nextstepaction"]
> [Previous step: Define general properties and scheduling](define-general-properties-scheduling-forecast.md)
</td><td>

> [!div class="nextstepaction"]
> [Next step: Choose layout and columns](choose-layout-and-columns-forecast.md)
</td></tr>
</table>

### See also

[Configure forecasts in your organization](configure-forecast.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
