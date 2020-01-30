---
title: "Provide viewing permissions to access a forecast (Dynamics 365 Sales) | MicrosoftDocs"
description: "Provide viewing permissions to access a forecast in Dynamics 365 Sales."
ms.date: 02/03/2020
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Provide viewing permissions

In the **Permissions** step, define which team members can view and adjust the forecast data at each level of the hierarchy. Also, you can provide access to users with specific security roles to view the forecast. 

To set permissions, follow these steps:

1.	Under the **User security field** section, choose the **User lookup field**. Choosing the field determines the owner of the forecast row that allows the user to view the forecast and forecast of those below in the forecast hierarchy. The following default system user value is selected based on the template:

    -	For **Org chart forecast**, the value is selected as **User**.

    -	For **Territory forecast**, the value is selected as **Manager**.

    If you select a different selection than the default, a new column is created in the forecast grid.

    For example, when you select **User lookup field** as **Manager** for territory forecast, the forecast is visible only to the managers of the territories in the selected hierarchy and can edit forecast data that directly belongs to them and to their reporting territories.

2.	Under the **Additional security roles** section, select an option as described in the following table to provide permissions to users who are not part of the hierarchy to view the forecast.

    | Additional security roles option | Description |
    |----------------------------------|-------------|
    | No additional security roles | This option provides access only to the selected hierarchy users. When you select this option, other security role users in the organization can't view the forecast. By default, this option is selected. |
    | All security roles (everyone can access the forecast) | This option provides access to all the security role users in your organization to view the forecast. |
	  | Specific security roles | This option allows you to specify security roles when you want a few external users to view the forecast. |

    > [!div class="mx-imgBorder"]
    > ![Forecast permissions step](media/forecast-permissions.png "Forecast permissions step")

3.	Select **Next**.


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

[Configure a forecast in your organization](configure-forecast.md)
